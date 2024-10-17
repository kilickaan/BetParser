using static BetParser.Common.Enum;

namespace BetParser.Helper
{
    public class LangHelper
    {
        public static Lang ParseLanguage(string language)
        {
            switch (language.ToLower())
            {
                case "tr":
                    return Lang.Tr;

                case "en":
                    return Lang.En;

                default:
                    return Lang.Invalid;
            }
        }
    }
}