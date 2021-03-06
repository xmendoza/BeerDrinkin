﻿using System;
using System.Runtime.Serialization;

#if !CLIENT
using Microsoft.WindowsAzure.Mobile.Service;
#endif
namespace BeerDrinkin.Service.DataObjects
{
    public class CheckInItem:EntityData
    {
        public int BeerId { get; set; }
        public int CheckedInBy { get; set; }
        public string Comment { get; set; }
        public double Rating { get; set; }
        public int FourSquareId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
#if CLIENT
        [IgnoreDataMember]
        public string[] Images {get;set;}
        [IgnoreDataMember]
        public BeerItem Beer{get;set;}
#endif
    }
}
