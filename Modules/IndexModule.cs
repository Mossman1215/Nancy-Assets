using Nancy;
using NancyAspNetHostWithRazor1.Models;
using System;
namespace NancyAspNetHostWithRazor1.Modules {
    public class IndexModule : NancyModule {
        public IndexModule() {
            Get["/billy"] = parameters => {
                var billy = new billy { name="billy" };
                return View["names",billy];
            };
            Get["/"] = parameters => {
                var goods = new tableofgoods();
                return View["assets", goods];
            };
			Post ["/"] = newItem;
			/*alternative syntax
			Get["/route"] = methodname;
				public View methodname (Object parameters){
					return View["viewname"];
				}
			*/
        }
		public ViewRenderer newItem(object parameters){
			string[] arr = Array.Empty<string> (5);
			return View["/"];
		}
    }
}