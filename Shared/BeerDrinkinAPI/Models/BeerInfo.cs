﻿using BeerDrinkin.Service.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerDrinkin.Service.DataObjects
{
    public class BeerInfo
    {
        public string Name { get; set; }
        public int BreweryDbId { get; set; }
        public double AverageRating { get; set; }
        public IEnumerable<ReviewItem> Reviews { get; set; }
        public IEnumerable<string> ImagesURLs { get; set; }
        public IEnumerable<CheckInItem> CheckIns { get; set; }
    }
}