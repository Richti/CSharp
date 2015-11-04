using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AuthentificationN
{
    class Authentification : AuthentificationManager
    {
        public List<User> users { get; set; }
        public Authentification()
        {
            users = new List<User>();
        }
        

        public void addUser(string login, string password) 
        {
            foreach(User user in users)
            {
                if(user.Equals(login))
                {
                    throw new UserExistsException(login);       
                }
            }
                users.Add(new User(login, password));
                 
        }
        
        public void removeUser(string login) 
        {
            for(int i = 0; i < users.Count; i++)
            {
                if (users[i].Equals(login))
                {
                    users.RemoveAt(i);
                    return;
                }
            }
            throw new UserUnknownException(login);
           
        }

        public void authentify(string login, string password)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Equals(login))
                {
                    if(!users[i].password.Equals(password)) {
                        throw new WrongPasswordException(login);
                    }
                    return;
                }
            }
            throw new UserUnknownException(login);     
        }

        public void load(string path)
        {
           StreamReader sr = new StreamReader(path);
           string line;
           while ((line = sr.ReadLine()) != null)
           {
               string[] loginPassword = line.Split(';');
               addUser(loginPassword[0], loginPassword[1]);
           }
           sr.Close();
        }

        public void save(string path)
        {
           StreamWriter sw = new StreamWriter(path);
           foreach(User user in users)
           {
               sw.WriteLine(user.login + ";" + user.password);
           }
           sw.Close();
        }

    }
}
