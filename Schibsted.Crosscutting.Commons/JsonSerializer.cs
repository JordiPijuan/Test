namespace Schibsted.Crosscutting.Commons
{
    using System.Web.Script.Serialization;

    public class JsonSerializer
    {

        public static string ToJson<T>(T instance)
        {
            var serializer = new JavaScriptSerializer();

            return serializer.Serialize(instance);
        }

        public static T FromJson<T>(string json)
        {
            var serializer = new JavaScriptSerializer();

            return serializer.Deserialize<T>(json);
        }

    }

}
