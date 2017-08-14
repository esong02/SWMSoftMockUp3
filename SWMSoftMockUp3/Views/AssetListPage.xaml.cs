﻿﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

using SWMSoftMockUp3.Models;
using SWMSoftMockUp3.ViewModels;
using SWMSoftMockUp3.CustomControls;

namespace SWMSoftMockUp3.Views
{
    public partial class AssetListPage : ContentPage
    {

        AssetLocationVM _aLVM;
        List<Asset> _assetList;

        public AssetListPage(AssetLocationVM aLVM,AssetLocation location)
        {
            InitializeComponent();
            Title = "Task " + location.TaskId;

            _aLVM = aLVM;
            _assetList = location.assetList;

            //MapIcon.ObjReference = location;

            int maxRowCount = 3;
            int maxColumnCount = getColumntCount(maxRowCount);

            populateGridView(maxRowCount, maxColumnCount);

        }

		/*
        async void OnCallTaskItem(Asset asset){
            await Navigation.PushAsync();
        }
        */
        async void OnCallLocationMapPage(){
            AssetLocation location = new AssetLocation
            {
                TaskId = 10,
                address = "Sample"
            };
            await Navigation.PushAsync(new LocationMapPage(location));
        }

		void MapView_Tapped(object sender, System.EventArgs e)
		{

			OnCallLocationMapPage();
		}

		async void OnCallComponentItem(Asset asset)
		{
			await Navigation.PushAsync(new ComponentListPage(asset));
		}

        int getColumntCount(int maxRowCount){

            int listSize;
            int maxColumnCount = 0;

            if (_assetList == null){
                listSize = 0;
            }else{
                listSize = _assetList.Count;
            }

            if (listSize % maxRowCount == 0){
                maxColumnCount = (listSize / maxRowCount);
            }else{
                maxColumnCount = (listSize / maxRowCount) + 1;
            }
            return maxColumnCount;
        }

        string getImageLink(string type){
            if (type.ToLower().Equals("facility")){
                return "BLUEicon.png";
            }else if (type.ToLower().Equals("structure")){
                return "REDicon.png";
            }else if (type.ToLower().Equals("lid")){
                return "GREENicon.png";
            }else{
                return "";
            }
        }

        void populateGridView(int maxRowCount, int maxColumnCount){
            int assetCount = 0;
            int maxAssetCount;

            if (_assetList == null){
                maxAssetCount = 0;
            }else{
                maxAssetCount = _assetList.Count;
            }

            for (int columnPosition = 0; columnPosition < maxColumnCount; columnPosition++){
                //Potential Bug, the function will still print out 3 empty cells
				for (int rowPosition = 0; rowPosition < maxRowCount; rowPosition++)
				{

                    //If not at the end of the asset list or empty
                    if (assetCount < maxAssetCount){
                        var assetCell = new AbsoluteLayout()
                        {
                            //HorizontalOptions = LayoutOptions.CenterAndExpand,
                            //VerticalOptions = LayoutOptions.StartAndExpand,
                            Margin = new Thickness(5, 5, 5, 5)
                        };
                        //assetCell.Orientation = StackOrientation.Vertical;

                        ImageButton iconBtn = new ImageButton
						{
							Source = getImageLink(_assetList[assetCount].type),
							Aspect = Aspect.AspectFit,
							HorizontalOptions = LayoutOptions.CenterAndExpand,
							VerticalOptions = LayoutOptions.StartAndExpand,
							ObjReference = _assetList[assetCount]
						};

						var tapGestureRecognizer = new TapGestureRecognizer();
						tapGestureRecognizer.Tapped += (s, e) =>
						{
							var item = s as ImageButton;
							Asset asset = item.ObjReference as Asset;
							//DisplayAlert("Test", asset.Name, "Ok");
                            OnCallComponentItem(asset);
						};

						iconBtn.GestureRecognizers.Add(tapGestureRecognizer);

                        AbsoluteLayout.SetLayoutBounds(iconBtn, new Rectangle(0.0,0.0,1.0,0.75));
                        AbsoluteLayout.SetLayoutFlags(iconBtn, AbsoluteLayoutFlags.All);

                        assetCell.Children.Add(iconBtn);

                        Label iconLabel = new Label
                        {
                            Text = _assetList[assetCount].Name,
                            FontSize = 12,
                            VerticalOptions = LayoutOptions.StartAndExpand,
                            HorizontalOptions = LayoutOptions.CenterAndExpand,
                            HorizontalTextAlignment = TextAlignment.Center,
                            LineBreakMode = LineBreakMode.WordWrap,
                            TextColor = Color.White,

                        };

                        AbsoluteLayout.SetLayoutBounds(iconLabel, new Rectangle(0.0, 1.0, 1.0, 0.25));
                        AbsoluteLayout.SetLayoutFlags(iconLabel, AbsoluteLayoutFlags.All);

                        assetCell.Children.Add(iconLabel);


                        string progressIconLink = "";

                        if (_assetList[assetCount].Status == ProgressStatus.Status.Complete)
                        {
                            progressIconLink = "Complete.png";
                        }
                        else if (_assetList[assetCount].Status == ProgressStatus.Status.Pending)
                        {
                            progressIconLink = "Pending.png";
                        }
                        else if (_assetList[assetCount].Status == ProgressStatus.Status.Incomplete)
                        {
                            progressIconLink = "Incomplete.png";
                        }
                        else
                        {
                            progressIconLink = "Pending.png";
                        }

                        Image progressIcon = new Image
                        {
                            Source = progressIconLink,
                            Aspect = Aspect.AspectFit
                        };

                        AbsoluteLayout.SetLayoutBounds(progressIcon, new Rectangle(1.0, 0.0, 0.4, 1.0));
                        AbsoluteLayout.SetLayoutFlags(progressIcon, AbsoluteLayoutFlags.All);

                        assetCell.Children.Add(progressIcon);

                        AssetGrid.Children.Add(assetCell, rowPosition, columnPosition);
						assetCount++;

                    }else{
                        //Otherwise exit row
                        break;
                    }

                   
				}
            }
        }
    }
}
