using System;
using System.Collections.Generic;

namespace SWMSoftMockUp3.ViewModels
{
    public class User
    {
        public int Id { get; set; }
        public string UserLogon { get; set; }
        public string UserName { get; set; }
        public string UserInitials { get; set; }
        public bool IsAdministrator { get; set; }
        public bool IsReadOnly { get; set; }
        public bool Deleted { get; set; }
    }
}
