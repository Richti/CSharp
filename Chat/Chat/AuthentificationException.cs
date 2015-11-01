using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthentificationN
{
    abstract class AuthentificationException : Exception
    {
        public string login { get; set; }
        public AuthentificationException(string login)
        {
            this.login = login;
        } 
    }

    class UserUnknownException : AuthentificationException
    {
       public UserUnknownException(string login) : base(login)
        {
        }
    }

    class UserExistsException : AuthentificationException
    {
        public UserExistsException(string login) : base(login)
        {
        }
    }

    class WrongPasswordException : AuthentificationException
    {
        public WrongPasswordException (string login) : base(login)
        {
        }
    }
}
