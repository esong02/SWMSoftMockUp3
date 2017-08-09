using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.ComponentModel;
using SWMSoftMockUp3.Models;

namespace SWMSoftMockUp3.ViewModels
{
    public class AssetLocationVM
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
                    postalCode = "L3Y 7V8",
                    assetList = new System.Collections.Generic.List<Asset>{
                        new Asset{
                            Id = 0,
                            Name = "Pondview 2",
                            MunicipalId = "Vaughan Municpality",
                            Comments = "N/A",
                            LocationDescription = "Somewhere",
                            NearestIntersection = "Somewhere as well",
                            Address = "500 Davis Drive",
                            YearBuilt = 1200,
                            type = "Facility"

                        },
                        new Asset{
							Id = 1,
							Name = "Concord Stormpond",
							MunicipalId = "Vaughan Municpality",
							Comments = "N/A",
							LocationDescription = "Somewhere",
							NearestIntersection = "Somewhere as well",
							Address = "500 Davis Drive",
							YearBuilt = 1200,
							type = "Facility"
                        },
						new Asset{
							Id = 2,
							Name = "Sample Bridge",
							MunicipalId = "Vaughan Municpality",
							Comments = "N/A",
							LocationDescription = "Somewhere",
							NearestIntersection = "Somewhere as well",
							Address = "500 Davis Drive",
							YearBuilt = 1200,
							type = "Structure"
						},
						new Asset{
							Id = 3,
							Name = "Sample LID 1",
							MunicipalId = "Vaughan Municpality",
							Comments = "N/A",
							LocationDescription = "Somewhere",
							NearestIntersection = "Somewhere as well",
							Address = "500 Davis Drive",
							YearBuilt = 1200,
							type = "LID"
						},
						new Asset{
							Id = 4,
							Name = "Sample LID 2",
							MunicipalId = "Vaughan Municpality",
							Comments = "N/A",
							LocationDescription = "Somewhere",
							NearestIntersection = "Somewhere as well",
							Address = "500 Davis Drive",
							YearBuilt = 1200,
							type = "LID"
						},
						new Asset{
							Id = 5,
							Name = "Sample LID 3",
							MunicipalId = "Vaughan Municpality",
							Comments = "N/A",
							LocationDescription = "Somewhere",
							NearestIntersection = "Somewhere as well",
							Address = "500 Davis Drive",
							YearBuilt = 1200,
							type = "LID"
						},
						new Asset{
							Id = 6,
							Name = "Sample LID 4",
							MunicipalId = "Vaughan Municpality",
							Comments = "N/A",
							LocationDescription = "Somewhere",
							NearestIntersection = "Somewhere as well",
							Address = "500 Davis Drive",
							YearBuilt = 1200,
							type = "LID"
						},
						new Asset{
							Id = 7,
							Name = "Sample LID 5",
							MunicipalId = "Vaughan Municpality",
							Comments = "N/A",
							LocationDescription = "Somewhere",
							NearestIntersection = "Somewhere as well",
							Address = "500 Davis Drive",
							YearBuilt = 1200,
							type = "LID"
						},
						new Asset{
							Id = 8,
							Name = "Sample LID 6",
							MunicipalId = "Vaughan Municpality",
							Comments = "N/A",
							LocationDescription = "Somewhere",
							NearestIntersection = "Somewhere as well",
							Address = "500 Davis Drive",
							YearBuilt = 1200,
							type = "LID"
						},
						new Asset{
							Id = 9,
							Name = "Sample LID 7",
							MunicipalId = "Vaughan Municpality",
							Comments = "N/A",
							LocationDescription = "Somewhere",
							NearestIntersection = "Somewhere as well",
							Address = "500 Davis Drive",
							YearBuilt = 1200,
							type = "LID"
						},
						new Asset{
							Id = 10,
							Name = "Sample LID 8",
							MunicipalId = "Vaughan Municpality",
							Comments = "N/A",
							LocationDescription = "Somewhere",
							NearestIntersection = "Somewhere as well",
							Address = "500 Davis Drive",
							YearBuilt = 1200,
							type = "LID"
						},
						new Asset{
							Id = 11,
							Name = "Sample LID 7",
							MunicipalId = "Vaughan Municpality",
							Comments = "N/A",
							LocationDescription = "Somewhere",
							NearestIntersection = "Somewhere as well",
							Address = "500 Davis Drive",
							YearBuilt = 1200,
							type = "LID"
						},
						new Asset{
							Id = 12,
							Name = "Sample LID 8",
							MunicipalId = "Vaughan Municpality",
							Comments = "N/A",
							LocationDescription = "Somewhere",
							NearestIntersection = "Somewhere as well",
							Address = "500 Davis Drive",
							YearBuilt = 1200,
							type = "LID"
						},
						new Asset{
							Id = 13,
							Name = "Sample LID 9",
							MunicipalId = "Vaughan Municpality",
							Comments = "N/A",
							LocationDescription = "Somewhere",
							NearestIntersection = "Somewhere as well",
							Address = "500 Davis Drive",
							YearBuilt = 1200,
							type = "LID"
						},
						new Asset{
							Id = 14,
							Name = "Sample LID 9",
							MunicipalId = "Vaughan Municpality",
							Comments = "N/A",
							LocationDescription = "Somewhere",
							NearestIntersection = "Somewhere as well",
							Address = "500 Davis Drive",
							YearBuilt = 1200,
							type = "LID"
						},
						new Asset{
							Id = 15,
							Name = "Sample LID 10",
							MunicipalId = "Vaughan Municpality",
							Comments = "N/A",
							LocationDescription = "Somewhere",
							NearestIntersection = "Somewhere as well",
							Address = "500 Davis Drive",
							YearBuilt = 1200,
							type = "LID"
						},
						new Asset{
							Id = 16,
							Name = "Sample LID 11",
							MunicipalId = "Vaughan Municpality",
							Comments = "N/A",
							LocationDescription = "Somewhere",
							NearestIntersection = "Somewhere as well",
							Address = "500 Davis Drive",
							YearBuilt = 1200,
							type = "LID"
						}

                    }
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


    }
}
