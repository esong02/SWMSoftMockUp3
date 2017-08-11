﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

using SWMSoftMockUp3.CustomControls;
using SWMSoftMockUp3.Models;
using SWMSoftMockUp3.ViewModels;
using SWMSoftMockUp3.DataLists;

namespace SWMSoftMockUp3.Views
{
    public partial class ComponentListPage : ContentPage
    {
        ComponentListVM _cLVM;
        ObservableCollection<Component> _cList;
        Component selectedComponent;

        public ComponentListPage(Asset asset)
        {
            InitializeComponent();
            Title = asset.Name;
            _cLVM = new ComponentListVM();

            _cList = _cLVM._cList;
			int maxRowCount = 3;
			int maxColumnCount = getColumntCount(maxRowCount);

			populateGridView(maxRowCount, maxColumnCount);

		}

		async void OnCallLocationMapPage()
		{
			AssetLocation location = new AssetLocation
			{
				TaskId = 5,
				address = "Sample"
			};
			await Navigation.PushAsync(new LocationMapPage(location));
		}

        async void OnCallInfoPage()
		{
		
			await Navigation.PushAsync(new PhotoPage(selectedComponent));
		}

		void MapView_Tapped(object sender, System.EventArgs e)
		{
			OnCallLocationMapPage();
		}

		void OpenOptionWheelDialog()
		{
            OptionWheelDialog.IsVisible = true;
		}

		
		int getColumntCount(int maxRowCount)
		{
			int listSize;
			int maxColumnCount = 0;

			if (_cList == null)
			{
				listSize = 0;
			}
			else
			{
				listSize = _cList.Count;
			}

			if (listSize % maxRowCount == 0)
			{
				maxColumnCount = (listSize / maxRowCount);
			}
			else
			{
				maxColumnCount = (listSize / maxRowCount) + 1;
			}
			return maxColumnCount;
		}

        void OptionWheelBlackScreen_Tapped(object sender, System.EventArgs e)
        {
            CloseOptionWheelDialog();
        }

        void CloseOptionWheelDialog()
        {
            OptionWheelDialog.IsVisible = false;
        }

        async void OnCallTaskPage()
		{
			await Navigation.PushAsync(new TaskPage(selectedComponent));
		}


		void Inspection_Tapped(object sender, System.EventArgs e)
		//-------------------------------------------------------------
		{
			var item = sender as ImageButton;
            OnCallTaskPage();

		}

		void Maintenance_Tapped(object sender, System.EventArgs e)
		//-------------------------------------------------------------
		{
			var item = sender as ImageButton;
			DisplayAlert(selectedComponent.Name, "Maintenance", "Ok");

		}

        void Information_Tapped(object sender, System.EventArgs e)
		//-------------------------------------------------------------
		{
            DisplayAlert("Information Button","Tapped!","Ok");
			OnCallInfoPage();

		}

		void Archive_Tapped(object sender, System.EventArgs e)
		//-------------------------------------------------------------
		{
			var item = sender as ImageButton;
			DisplayAlert(selectedComponent.Name, "Archive", "Ok");

		}


		void populateGridView(int maxRowCount, int maxColumnCount)
		{
			int componentCount = 0;
			int maxComponentCount;

			if (_cList == null)
			{
				maxComponentCount = 0;
			}
			else
			{
				maxComponentCount = _cList.Count;
			}

			for (int columnPosition = 0; columnPosition < maxColumnCount; columnPosition++)
			{
				//Potential Bug, the function will still print out 3 empty cells
				for (int rowPosition = 0; rowPosition < maxRowCount; rowPosition++)
				{
					//If not at the end of the asset list or empty
					if (componentCount < maxComponentCount)
					{
						var componentCell = new StackLayout();
						componentCell.HorizontalOptions = LayoutOptions.CenterAndExpand;
						componentCell.VerticalOptions = LayoutOptions.StartAndExpand;
						componentCell.Margin = new Thickness(5, 5, 5, 5);
						componentCell.Orientation = StackOrientation.Vertical;

						ImageButton iconBtn = new ImageButton
						{
							Source = _cList[componentCount].IconImageURL,
							Aspect = Aspect.AspectFit,
							HorizontalOptions = LayoutOptions.CenterAndExpand,
							VerticalOptions = LayoutOptions.StartAndExpand,
							ObjReference = _cList[componentCount]
						};

						var tapGestureRecognizer = new TapGestureRecognizer();
						tapGestureRecognizer.Tapped += (s, e) =>
						{
							var item = s as ImageButton;
							selectedComponent = item.ObjReference as Component;
                            OpenOptionWheelDialog();
						};

						iconBtn.GestureRecognizers.Add(tapGestureRecognizer);

						componentCell.Children.Add(iconBtn);
						componentCell.Children.Add(new Label
						{
							Text = _cList[componentCount].Name,
							FontSize = 12,
							VerticalOptions = LayoutOptions.StartAndExpand,
							HorizontalOptions = LayoutOptions.CenterAndExpand,
							HorizontalTextAlignment = TextAlignment.Center,
							LineBreakMode = LineBreakMode.WordWrap,
							TextColor = Color.White,

						});

						AssetGrid.Children.Add(componentCell, rowPosition, columnPosition);
						componentCount++;

					}
					else
					{
						break;
					}

				}
			}
		}
    }
}
