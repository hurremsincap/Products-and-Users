using System;
using System.Text;
using System.Web;
using System.Web.Security;

namespace KafeinCase.Core.CrossCuttingConcerns.Security.Web
{
    public class AuthenticationHelper
    {
        //public static void CreateAuthCookie(Guid id, string user, string email, DateTime endOfTime, string roles, bool rememberMe, string nameSurname, string userID, string factories, string photoId)
        //{
        //    var authTicket = new FormsAuthenticationTicket(1, user, DateTime.Now, endOfTime, rememberMe,
        //        CreateAuthTags(email, roles, nameSurname, id, userID, factories, photoId));
        //    string encTicket = FormsAuthentication.Encrypt(authTicket);
        //    HttpContext.Current.Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));
        //}

        public static void CreateAuthCookie(Guid id, string user, string email, DateTime endOfTime, string roles, bool rememberMe, string nameSurname, string userID)
        {
            var authTicket = new FormsAuthenticationTicket(1, user, DateTime.Now, endOfTime, rememberMe,
                CreateAuthTags(email, roles, nameSurname, id, userID));
            string encTicket = FormsAuthentication.Encrypt(authTicket);
            HttpContext.Current.Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));
        }

        //private static string CreateAuthTags(string email, string yetki, string kullaniciAdSoyad, Guid id, string kullaniciID, string factories, string photoId)
        //{
        //    var stringBuilder = new StringBuilder();
        //    stringBuilder.Append(email);
        //    stringBuilder.Append("|");
        //    for (int i = 0; i < yetki.Length; i++)
        //    {
        //        stringBuilder.Append(yetki[i]);
        //        if (i < yetki.Length - 1)
        //        {
        //            stringBuilder.Append(",");
        //        }
        //    }
        //    //stringBuilder.Append(yetki);
        //    stringBuilder.Append("|");
        //    stringBuilder.Append(kullaniciAdSoyad);
        //    stringBuilder.Append("|");
        //    stringBuilder.Append(id);
        //    stringBuilder.Append("|");
        //    stringBuilder.Append(kullaniciID);
        //    stringBuilder.Append("|");
        //    stringBuilder.Append(factories);
        //    stringBuilder.Append("|");
        //    stringBuilder.Append(photoId);
        //    return stringBuilder.ToString();
        //}

        private static string CreateAuthTags(string email, string yetki, string kullaniciAdSoyad, Guid id, string kullaniciID)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(email);

            stringBuilder.Append("|");
            for (int i = 0; i < yetki.Length; i++)
            {
                stringBuilder.Append(yetki[i]);
                if (i < yetki.Length - 1)
                {
                    stringBuilder.Append(",");
                }
            }

            //stringBuilder.Append(yetki);
            stringBuilder.Append("|");
            stringBuilder.Append(kullaniciAdSoyad);
            stringBuilder.Append("|");
            stringBuilder.Append(id);
            stringBuilder.Append("|");
            stringBuilder.Append(kullaniciID);
            //stringBuilder.Append("|");
            //stringBuilder.Append(factories);
            //stringBuilder.Append("|");
            //stringBuilder.Append(photoId);
            return stringBuilder.ToString();
        }
    }
}
