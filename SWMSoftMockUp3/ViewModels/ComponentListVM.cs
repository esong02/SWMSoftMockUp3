using System;
using System.Collections.ObjectModel;

using SWMSoftMockUp3.Models;

namespace SWMSoftMockUp3.ViewModels
{
    public class ComponentListVM
    {
        public ObservableCollection<Component> _cList { get; set; }

        public ComponentListVM(){
            
            _cList = new ObservableCollection<Component>{
				new Component{
					Name = "Bench Mark",
					Description = "Make sure to record any offset from the actual bench mark",
					HasPhoto = false,
					IconImageURL = "icon1.png",
					IsIncomplete = false
				},
				new Component{
					Name = "Emergency Spillway",
					Description = "Check for structural condition (crackling, flaking, broken seperating learning), obstructions",
					HasPhoto = false,
					IconImageURL = "icon2.png",
					IsIncomplete = false
				},
				new Component{
					Name = "Emergency Spillway: Grating",
					Description = "Check grate bars for rust, bent, broken, open/closed,and lock",
					HasPhoto = false,
					IconImageURL = "icon3.png",
					IsIncomplete = false
				}
				,
				new Component{
					Name = "Facility",
					Description = "Check for garbage, erosion, proper function",
					HasPhoto = false,
					IconImageURL = "icon4.png",
					IsIncomplete = false
				}
				,
				new Component{
					Name = "Facility",
					Description = "Check for garbage, erosion, proper function",
					HasPhoto = false,
					IconImageURL = "icon4.png",
					IsIncomplete = false
				}
				,
				new Component{
					Name = "Facility",
					Description = "Check for garbage, erosion, proper function",
					HasPhoto = false,
					IconImageURL = "icon4.png",
					IsIncomplete = false
				}
				,
				new Component{
					Name = "Facility",
					Description = "Check for garbage, erosion, proper function",
					HasPhoto = false,
					IconImageURL = "icon4.png",
					IsIncomplete = false
				}
				,
				new Component{
					Name = "Facility",
					Description = "Check for garbage, erosion, proper function",
					HasPhoto = false,
					IconImageURL = "icon4.png",
					IsIncomplete = false
				}
				,
				new Component{
					Name = "Facility",
					Description = "Check for garbage, erosion, proper function",
					HasPhoto = false,
					IconImageURL = "icon4.png",
					IsIncomplete = false
				}
				,
				new Component{
					Name = "Facility",
					Description = "Check for garbage, erosion, proper function",
					HasPhoto = false,
					IconImageURL = "icon4.png",
					IsIncomplete = false
				}
				,
				new Component{
					Name = "Facility",
					Description = "Check for garbage, erosion, proper function",
					HasPhoto = false,
					IconImageURL = "icon4.png",
					IsIncomplete = false
				}
				,
				new Component{
					Name = "Facility",
					Description = "Check for garbage, erosion, proper function",
					HasPhoto = false,
					IconImageURL = "icon4.png",
					IsIncomplete = false
				}
            };

        }

    }
}
