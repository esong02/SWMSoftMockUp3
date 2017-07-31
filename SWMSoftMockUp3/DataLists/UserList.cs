using System;
using System.ComponentModel;
using SWMSoftMockUp3.Models;
using System.Collections.ObjectModel;

namespace SWMSoftMockUp3.DataLists
{
    public class UserList //: INotifyPropertyChanged
    {
        
        public ObservableCollection<User> _userList { get; set; }

        public UserList()
        {

            _userList = new ObservableCollection<User>
            {
                new User{
                    Id = 1,
                    UserName = "Alex",
                    UserLogon = "123456"
                },
                new User{
                    Id = 2,
                    UserName = "aaa",
                    UserLogon = "bbb"
                }
            };
        }


        //public event PropertyChangedEventHandler PropertyChanged;
    }
}
