using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace AuthentificationN
{
    [Serializable]
    class Authentification : AuthentificationManager ,ISerializable
    {
        public List<User> users { get; set; }

        public Authentification()
        {
            users = new List<User>();
        }
        public Authentification(SerializationInfo info, StreamingContext ctxt)
        {
            users = (List<User>)info.GetValue("k_head", typeof(List<User>));
        }

        public void addUser(string login, string password) 
        { 
            lock(users)
            {
                if (users.Contains(new User(login, password)))
                {
                    throw new UserExistsException(login);
                }
                users.Add(new User(login, password));
            }       
        }
        
        public void removeUser(string login) 
        {
            lock (users)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Equals(login))
                    {
                        users.RemoveAt(i);
                        return;
                    }
                }
                throw new UserUnknownException(login);
            }   
        }

        public void authentify(string login, string password)
        {
            lock(users)
            {
                foreach (User user in users)
                {
                    if (user.Equals(login))
                    {
                        if (!user.password.Equals(password))
                        {
                            throw new WrongPasswordException(login);
                        }
                        return;
                    }
                }
                throw new UserUnknownException(login);
            }                
        }

        public void load(string path)
        {
            lock(users)
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream flux = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    if (flux.CanRead)
                    {
                       users = (List<User>) bf.Deserialize(flux);
                    }
                }
            }
        }

        public void save(string path)
        {
            lock(users)
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream flux = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    if (flux.CanWrite)
                    {
                        bf.Serialize(flux, users);
                    }
                }
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("k_users", users);
        }
    }
}
