using System;

namespace ExpressMVC
{
    public static class BoolenExtensions
    {
        public static String ToHtmlString(this Boolean boolen)
        {
            return boolen.ToString().ToLower();
        }
    }
}