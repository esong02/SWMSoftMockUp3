﻿using System;
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

            MapIcon.ObjReference = location;

            int maxRowCount = 3;
            int maxColumnCount = getColumntCount(maxRowCount);

            populateGridView(maxRowCount, maxColumnCount);

        }

		/*
        async void OnCallTaskItem(Asset asset){
            await Navigation.PushAsync();
        }
        */

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
						var assetCell = new StackLayout();
						assetCell.HorizontalOptions = LayoutOptions.CenterAndExpand;
						assetCell.VerticalOptions = LayoutOptions.StartAndExpand;
						assetCell.Margin = new Thickness(5, 5, 5, 5);
						assetCell.Orientation = StackOrientation.Vertical;

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

						assetCell.Children.Add(iconBtn);
						assetCell.Children.Add(new Label
						{
							Text = _assetList[assetCount].Name,
							FontSize = 12,
							VerticalOptions = LayoutOptions.StartAndExpand,
							HorizontalOptions = LayoutOptions.CenterAndExpand,
							HorizontalTextAlignment = TextAlignment.Center,
							LineBreakMode = LineBreakMode.WordWrap,
							TextColor = Color.White,

						});

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
