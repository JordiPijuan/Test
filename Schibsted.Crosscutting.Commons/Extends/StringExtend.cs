namespace Schibsted.Infrastructure.Commons.Extends
{
    using System;
    using System.Text;

    public static class StringExtend
    {

        public static string Encode(this string text)
        {
            var plainBytes = Encoding.UTF8.GetBytes(text);

            return Convert.ToBase64String(plainBytes);
        }

        public static string Decode(this string encoded)
        {
            var base64Bytes = Convert.FromBase64String(encoded);

            return Encoding.UTF8.GetString(base64Bytes);
        }

    }

}
