﻿namespace CloudFoundry.Doppler.Client
{
    using SuperSocket.ClientEngine.Proxy;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using WebSocket4Net;

    internal class DopplerWebSocket : IDisposable
    {
        private const int MagicWebSocketReceiveBufferSize = 64;

        private ProtobufSerializer protobufSerializer = new ProtobufSerializer();
        private WebSocket webSocket = null;
        private bool disposed;

        ~DopplerWebSocket()
        {
            this.Dispose(false);
        }

        public event EventHandler<ErrorEventArgs> ErrorReceived;

        public event EventHandler<DataEventArgs> DataReceived;

        public event EventHandler<EventArgs> StreamClosed;

        public event EventHandler<EventArgs> StreamOpened;

        public ConnectionState State
        {
            get
            {
                if (this.webSocket != null)
                {
                    switch (this.webSocket.State)
                    {
                        case WebSocketState.Closed:
                            {
                                return ConnectionState.Closed;
                            }

                        case WebSocketState.Closing:
                            {
                                return ConnectionState.Closing;
                            }

                        case WebSocketState.Connecting:
                            {
                                return ConnectionState.Connecting;
                            }

                        case WebSocketState.Open:
                            {
                                return ConnectionState.Open;
                            }

                        default:
                            {
                                return ConnectionState.None;
                            }
                    }
                }
                else
                {
                    return ConnectionState.None;
                }
            }
        }

        public void Open(Uri dopplerEndpoint, string authenticationToken, Uri httpProxy, bool skipCertificateValidation)
        {
            if (dopplerEndpoint == null)
            {
                throw new ArgumentNullException("dopplerEndpoint");
            }

            if (httpProxy != null)
            {
                if (httpProxy.Scheme != "http")
                {
                    throw new ArgumentException("httpProxy supports only 'http' for the scheme", "httpProxy");
                }

                if (httpProxy.AbsolutePath != "/")
                {
                    throw new ArgumentException("httpProxy supports only '/' for the absolute path", "httpProxy");
                }
            }

            List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
            if (authenticationToken != null)
            {
                headers.Add(new KeyValuePair<string, string>("AUTHORIZATION", authenticationToken));
            }

            this.webSocket = new WebSocket(dopplerEndpoint.ToString(), string.Empty, null, headers);

            this.webSocket.Security.AllowNameMismatchCertificate = skipCertificateValidation;
            this.webSocket.Security.AllowUnstrustedCertificate = skipCertificateValidation;

            this.webSocket.DataReceived += (sender, e) =>
                {
                    if (DataReceived != null)
                    {
                        DataReceived(sender, new DataEventArgs() { Data = this.protobufSerializer.DeserializeEnvelope(e.Data) });
                    }
                };

            this.webSocket.Error += (sender, e) =>
            {
                if (ErrorReceived != null)
                {
                    ErrorReceived(sender, new ErrorEventArgs() { Error = e.Exception });
                }
            };

            this.webSocket.Opened += (sender, e) =>
            {
                if (StreamOpened != null)
                {
                    StreamOpened(sender, e);
                }
            };

            this.webSocket.Closed += (sender, e) =>
            {
                if (StreamClosed != null)
                {
                    StreamClosed(sender, e);
                }
            };

            if (httpProxy != null)
            {
                this.webSocket.Proxy = new HttpConnectProxy(new DnsEndPoint(httpProxy.Host, httpProxy.Port));
            }

            this.webSocket.Open();
        }

        public void Close()
        {
            if (this.webSocket.State != (WebSocketState.Closed | WebSocketState.Closing | WebSocketState.None))
            {
                this.webSocket.Close();
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                return;
            }

            if (this.webSocket != null)
            {
                this.webSocket.Dispose();
            }

            this.disposed = true;
        }
    }
}
