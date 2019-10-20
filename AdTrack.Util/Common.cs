using System.Collections.Generic;

namespace AdTrack.Util
{
    public static class Common
    {
        public static List<int> GetYears()
        {
            return new List<int> { 2019, 2018, 2017, 2016 };
        }
    }

    public enum PageType
    {
        Kapak = 1,
        KapakIci,
        ArkaKapak,
        IkiSayfa,
        TekSayfa
    }
}