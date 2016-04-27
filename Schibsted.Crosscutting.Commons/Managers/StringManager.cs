namespace Schibsted.Infrastructure.Commons.Managers
{
    using System.Web;

    public class StringManager
    {

        public static string GetModel(HttpContext context, string model)
        {
            return FileManager.ReadFileToString(context.Server.MapPath(string.Format("~/Data/{0}Model.js", model)));
        }

    }

}
