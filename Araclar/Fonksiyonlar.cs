using System;
namespace MyCoreApp.Araclar
{
    public static class Fonksiyonlar
    {
        

        public static string UrlAynimi(string url, string controller, string action)
        {
            if (controller + "/" + action == url)
                return "active";
            else
                return "";
        }
    }
}
