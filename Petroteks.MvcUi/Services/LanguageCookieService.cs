using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Petroteks.Entities.Concreate;
using Petroteks.MvcUi.ExtensionMethods;

namespace Petroteks.MvcUi.Services
{
    public class LanguageCookieService : ILanguageCookieService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LanguageCookieService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Language Get(string key)
        {
            return _httpContextAccessor.HttpContext.Session.GetObj<Language>(key);
        }


        public void Set(string key, object value, int? expireTime)
        {
            _httpContextAccessor.HttpContext.Session.SetObj(key, value);
        }

        public void Remove(string key)
        {
            _httpContextAccessor.HttpContext.Session.Remove(key);
        }
    }
}
