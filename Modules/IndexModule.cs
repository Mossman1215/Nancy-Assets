using Nancy;
using NancyAspNetHostWithRazor1.Models;

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
			/*alternative syntax
			Get["/route"] = methodname;
				public View methodname (Object parameters){
					return View["viewname"];
				}
			*/
        }
    }
}