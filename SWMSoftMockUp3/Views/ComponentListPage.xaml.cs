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
		{
			var item = sender as ImageButton;
            OnCallTaskPage();

		}

        async void OnCallMaintenancePage()
        {
            await Navigation.PushAsync(new MaintenancePage());
        }

        void Maintenance_Tapped(object sender, System.EventArgs e)
		{
            OnCallMaintenancePage();

		}

        async void OnCallInfoPage()
        {

            await Navigation.PushAsync(new InfoPage());
        }

        void Information_Tapped(object sender, System.EventArgs e)
		{
			OnCallInfoPage();

		}

        async void OnCallArchivePage()
        {
            await Navigation.PushAsync(new ArchiveFrontPage());
        }

        void Archive_Tapped(object sender, System.EventArgs e)
		{
            OnCallArchivePage();

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
                        var componentCell = new AbsoluteLayout()
                        {
                            Margin = new Thickness(5, 5, 5, 5),
                        };

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

                        AbsoluteLayout.SetLayoutBounds(iconBtn, new Rectangle(0.0, 0.0, 1.0, 0.75));
                        AbsoluteLayout.SetLayoutFlags(iconBtn, AbsoluteLayoutFlags.All);
                        componentCell.Children.Add(iconBtn);

                        Label iconLabel = new Label
                        {
                            Text = _cList[componentCount].Name,
                            FontSize = 12,
                            VerticalOptions = LayoutOptions.StartAndExpand,
                            HorizontalOptions = LayoutOptions.CenterAndExpand,
                            HorizontalTextAlignment = TextAlignment.Center,
                            LineBreakMode = LineBreakMode.WordWrap,
                            TextColor = Color.White,

                        };

                        AbsoluteLayout.SetLayoutBounds(iconLabel, new Rectangle(0.0, 1.0, 1.0, 0.25));
                        AbsoluteLayout.SetLayoutFlags(iconLabel, AbsoluteLayoutFlags.All);
                        componentCell.Children.Add(iconLabel);

                        string progressIconLink = "";

                        if (_cList[componentCount].Status == ProgressStatus.Status.Complete)
                        {
                            progressIconLink = "Complete.png";
                        }
                        else if (_cList[componentCount].Status == ProgressStatus.Status.Pending)
                        {
                            progressIconLink = "Pending.png";
                        }
                        else if (_cList[componentCount].Status == ProgressStatus.Status.Incomplete)
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

                        componentCell.Children.Add(progressIcon);

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
