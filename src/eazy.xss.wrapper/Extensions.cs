using eazy.xss.wrapper.AntiXss.Info;
using eazy.xss.wrapper.AntiXss.Option;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace eazy.xss.wrapper
{

    public static class Extensions
    {
        public static IApplicationBuilder UseEazyXssWrapper(this IApplicationBuilder builder,
            IConfiguration configuration)
        {
            var options = new XssOptions();
            configuration.GetSection(nameof(XssOptions)).Bind(options);

            var isEnabled = options.Enabled ? true : false;

            if (isEnabled) return builder.UseMiddleware<AntiXssMiddleware>();

            return builder;
        }
    }
}
