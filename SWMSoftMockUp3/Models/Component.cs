using System;
namespace SWMSoftMockUp3.Models
{
    public class Component
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public string IconImageURL { get; set; }
        public bool IsIncomplete { get; set; }
        public string Comments { get; set; }
        public ProgressStatus.Status Status { get; set; }
        public string PhotoURL { get; set; }
        public bool HasPhoto { get; set; }
        public string Icon { get; set; }
    }
}
