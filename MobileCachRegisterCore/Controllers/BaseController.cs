using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using NLog;
using Platform.MobileCachRegisterCore.Filter;

namespace Platform.MobileCachRegisterCore.Controllers;

[Culture]
[Authorize]
public abstract class BaseController : ControllerBase
{
    Logger _logger = LogManager.GetCurrentClassLogger();
    protected static readonly Logger Logger = LogManager.GetCurrentClassLogger();
    private static readonly object TokenLock = new();
    private static string refreshedToken = string.Empty;
    private static object __refreshTokenLock = new object();

    public string GetLanguageCookie()
    {
        var cookie = Request.Cookies[CookieRequestCultureProvider.DefaultCookieName];
        if (cookie == null)
            return "ru";
        else
        {
            List<string> cultures = new List<string>() { "en", "ro", "ru" };
            if (cultures.Contains(cookie.ToLower()))
                return cookie.ToLower();
            else
            {
                var c_uic = cookie.Split('|');
                var culture = c_uic[0].Split("=");

                return culture[1];
            }
        }
    }

    public string? GetToken()
    {
        lock (TokenLock)
        {
            return User?.Claims?.FirstOrDefault(c => c.Type == ".AspNetCore.MobileCash")?.Value;
        }
    }
}
