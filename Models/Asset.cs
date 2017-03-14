using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NancyAspNetHostWithRazor1.Models {
    public class Asset{
        public DateTime PurchaseDate { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string ProductNumber { get; set; }
		public long PurchasePrice { get; set; }
		//userid (guid)
    }
}