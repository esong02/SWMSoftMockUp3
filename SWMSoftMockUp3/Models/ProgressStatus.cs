using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMSoftMockUp3.Models
{
    public class ProgressStatus
    {

        public enum Status { Pending, Incomplete, Complete}

        public Status status { get; set; }

    }
}
