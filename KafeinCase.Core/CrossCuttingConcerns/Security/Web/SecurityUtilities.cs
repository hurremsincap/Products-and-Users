using System;
using System.Web.Security;

namespace KafeinCase.Core.CrossCuttingConcerns.Security.Web
{
    public class SecurityUtilities
    {
        public Identity FormsAuthTicketToIdentity(FormsAuthenticationTicket ticket)
        {
            var identity = new Identity
            {
                Id = SetId(ticket),
                Name = SetName(ticket),
                Email = SetEmail(ticket),
                Roles = SetRoles(ticket),
                UserId = SetKullaniciID(ticket),
                UserName = SetKullaniciAdi(ticket),
                UserSurname = SetKullaniciSoyadi(ticket),
                AuthenticationType = SetAuthType(),
                IsAuthenticated = SetIsAuthenticated()

            };
            return identity;
        }


        private bool SetIsAuthenticated()
        {
            return true;
        }

        private string SetAuthType()
        {
            return "Forms";
        }

        private string SetKullaniciSoyadi(FormsAuthenticationTicket ticket)
        {
            string[] data = ticket.UserData.Split('|');
            return data[3];
        }

        private string SetKullaniciAdi(FormsAuthenticationTicket ticket)
        {
            string[] data = ticket.UserData.Split('|');
            return data[2];
        }

        private string[] SetRoles(FormsAuthenticationTicket ticket)
        {
            string[] data = ticket.UserData.Split('|');
            string[] roles = data[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            return roles;
        }

        private string SetName(FormsAuthenticationTicket ticket)
        {
            return ticket.Name;
        }

        private string SetEmail(FormsAuthenticationTicket ticket)
        {
            string[] data = ticket.UserData.Split('|');
            return data[0];
        }

        private Guid SetId(FormsAuthenticationTicket ticket)
        {
            string[] data = ticket.UserData.Split('|');
            return new Guid(data[3]);
        }
        private int SetKullaniciID(FormsAuthenticationTicket ticket)
        {
            string[] data = ticket.UserData.Split('|');
            return Convert.ToInt32(data[4]);
        }

    }
}
