using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthentificationN 
{
    class User : IComparable // à serialiser
    {
        public string login { get; set; }
        public string password { get; set; }


        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public int CompareTo(object obj)
        {
            if( obj is User)
            {
                return login.CompareTo(((User)obj).login);
            }
            return login.CompareTo(obj);
        }

        public override bool Equals(Object obj)
        {
            return (CompareTo(obj) == 0) ? true : false;
        }
    }
}
