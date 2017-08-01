using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.ComponentModel;
using SWMSoftMockUp3.Models;

namespace SWMSoftMockUp3.ViewModels
{
    public class AssetLocationVM : INotifyPropertyChanged
    {

        public ObservableCollection<AssetLocation> _assetLocations { get; set; }

        public AssetLocationVM()
        {

            _assetLocations = new ObservableCollection<AssetLocation>
            {
                new AssetLocation{
                    TaskId = 1,
                    address = "Golf & Country Club, 500 Davis Drive",
                    inspectionType = "Assumption Inspection",
                    city = "Newmarket Ont.",
                    postalCode = "L3Y 7V8"
                },
                new AssetLocation{
                    TaskId = 2,
                    address = "Halton Conservation Authority, 2340 Platoon Street",
                    inspectionType = "Performance Verification",
                    city = "Halton Ont.",
                    postalCode = "R4N 6T8"
				},
				new AssetLocation{
					TaskId = 3,
					address = "Wycreast Subdivision, 60 Willis Drive",
					inspectionType = "Routine Maintenance",
					city = "Bowmanville Ont.",
					postalCode = "J4K 8H3"
				}
            };

        }

        void Update(AssetLocation aLocation){
            int index = _assetLocations.IndexOf(aLocation);
            _assetLocations.Remove(aLocation);
            _assetLocations.Insert(index,aLocation);
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
