using Microsoft.Extensions.Localization;

namespace GlobalizationAndLocalization.API
{
    public class SharedLocalizationService(IStringLocalizer<SharedLocalizationService> localizer)
    {
        private readonly IStringLocalizer _localizer = localizer;

        public string GetLocalizedString(string key)
        {
            return _localizer[key];
        }
    }
}
