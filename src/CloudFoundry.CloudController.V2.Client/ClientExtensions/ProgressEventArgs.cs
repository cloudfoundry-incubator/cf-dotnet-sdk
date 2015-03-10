namespace CloudFoundry.CloudController.V2.Client.ClientExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ProgressEventArgs : EventArgs
    {
        public string Message { get; set; }

        public int Percent { get; set; }
    }
}
