using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NancyAspNetHostWithRazor1.Models {
    public class tableofgoods {
        public tableofgoods(){
            rows = new List<Asset>();
            //make up some data
            rows.Add(new Asset {
                PurchaseDate = new DateTime(2017, 01, 02),
                Name = "Xbox",
                ProductNumber = "12345",
				SerialNumber = "AE33333",
					PurchasePrice = 1000
            }  );
            rows.Add(new Asset {
                PurchaseDate = new DateTime(2017, 02, 03),
                Name = "PS4",
                ProductNumber = "3478",
                SerialNumber = "FQ3444",
				PurchasePrice = 20000
            });
            rows.Add(new Asset {
                PurchaseDate = new DateTime(2017, 03, 04),
                Name = "Intel i7 6800k",
                ProductNumber = "56784",
                SerialNumber = "PH234R",
				PurchasePrice = 40000
            });
        }
        public IList<Asset> rows { get; }
		public Guid userid;
    }
}