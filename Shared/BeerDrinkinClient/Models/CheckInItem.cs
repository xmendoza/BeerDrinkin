﻿using System;
using System.Runtime.Serialization;

namespace BeerDrinkin.Models
{
    public class CheckInItem:EntityData
    {
        public string BeerId { get; set; }
        public string CheckedInBy { get; set; }
        public string Comment { get; set; }
        public double Rating { get; set; }
        public string FourSquareId { get; set; }
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
