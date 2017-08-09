﻿using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Generic;

using SWMSoftMockUp3.Models;

namespace SWMSoftMockUp3.ViewModels
{
    public class AssetListVM 
    {

        public ObservableCollection<Asset> _assetList { get; set; }

        public AssetListVM(){
            _assetList = new ObservableCollection<Asset>();
        }

        public AssetListVM(AssetLocation location)
        {
            _assetList = new ObservableCollection<Asset>();
            convertToViewModel(location);
        }

        public void convertToViewModel(AssetLocation location){
			foreach (Asset asset in location.assetList)
			{
				_assetList.Add(asset);
                UpdateTasks(asset);
			}
        }

        void UpdateTasks(Asset asset)
        {
            int index = _assetList.IndexOf(asset);
            _assetList.Remove(asset);
            _assetList.Insert(index,asset);
        }

    }
}
