﻿namespace CloudFoundry.Doppler.Client
{
    using System;

    /// <summary>
    /// An EventArgs class for error events.
    /// </summary>
    public class ErrorEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the error that occured while trying to communicate with the Doppler service.
        /// </summary>
        /// <value>
        /// An exception that describes the error.
        /// </value>
        public Exception Error
        {
            get;
            internal set;
        }
    }
}