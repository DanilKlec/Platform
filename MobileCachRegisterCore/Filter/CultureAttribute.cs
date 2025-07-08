using Microsoft.AspNetCore.Mvc.Filters;
using Platform.MobileCachRegisterCore.Controllers;
using System.Globalization;

namespace Platform.MobileCachRegisterCore.Filter
{
	public class CultureAttribute : System.Web.Mvc.FilterAttribute
	{
		public void OnActionExecuted(ActionExecutedContext filterContext)
		{
			string cultureName = null;
			var controller = filterContext.Controller as BaseController;

			var cultureCookie = controller.GetLanguageCookie();

			if (cultureCookie != null)
				cultureName = cultureCookie.ToLower();
			else
			{
				cultureName = "ru";
			}

			// Список культур
			List<string> cultures = new List<string>() { "en", "ro", "ru" };
			if (!cultures.Contains(cultureName))
			{
				cultureName = "ru";
			}
			Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureName);
			Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(cultureName);
		}
	}
}
