namespace CloudFoundry.CloudController.V2.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ProgressInfo
    {
        public ProgressInfo()
        {
            this.Message = string.Empty;
            this.Percent = 0;
        }

        public string Message { get; set; }

        public int Percent { get; set; }
    }
}
