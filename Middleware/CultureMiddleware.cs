using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;

namespace net.Middleware
{
    public class CultureMiddleware
    {
        private static readonly List<CultureInfo> _supportedCultures = new List<CultureInfo>{
            new CultureInfo ("zh-TW"),
            new CultureInfo ("en")
        };
        private static readonly RequestLocalizationOptions _localizationOptions = new RequestLocalizationOptions{
            DefaultRequestCulture = new RequestCulture (_supportedCultures.First()),
            SupportedCultures = _supportedCultures,
            SupportedUICultures = _supportedCultures,
            RequestCultureProviders = new IRequestCultureProvider []
            {
                new QueryStringRequestCultureProvider {Options = _localizationOptions}
            }
        };
        public void Configure (IApplicationBuilder app){
            app.UseRequestLocalization(_localizationOptions);
        }
    
    }
}