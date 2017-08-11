﻿using System;
using System.Collections.Generic;


namespace SWMSoftMockUp3.Models
{
    public class AssetLocation
    {
		public int TaskId { get; set; }
        public string address { get; set; }
        public string postalCode { get; set; }
        public string city { get; set; }
        public string progressIcon { get; set; }
        public ProgressStatus.Status status { get; set; }
        public string inspectionType { get; set; }
        public List<Asset> assetList { get; set; }
    }
}
