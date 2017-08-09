using System;
namespace SWMSoftMockUp3.Models
{
    public class OptionWheel
    {
        public enum Options { Inspection, Mainteneance, Archive, Information}

        public Options action { get; set; }

    }
}
