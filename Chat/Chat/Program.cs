using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Chat;
using AuthentificationN;
using Net;
using System.Net;
using Server;
using Client;

class Program
{
    public static void Main()
    {
       
        


        
        
    
    
        IPAddress Ip = IPAddress.Parse("127.0.0.1");
        int port = 55555;
        ServerGestTopics server = new ServerGestTopics(Ip);
        ParameterizedThreadStart ts = new ParameterizedThreadStart(server.startServer);
        Thread t = new Thread(ts);
        t.Start(port);

        ClientGestTopics client1 = new ClientGestTopics(Ip, port);
        Thread test1 = new Thread(new ThreadStart(client1.connect));
        test1.Start();

        ClientGestTopics client2 = new ClientGestTopics(Ip, port);
        Thread test2 = new Thread(new ThreadStart(client2.connect));
        test2.Start();
        
        try
        {
            client1.addUser("bob", "123");
            //client1.addUser("bob", "125"); //test la UserExistsException
            Console.WriteLine("Bob has been added !");
            client1.removeUser("bob");
            Console.WriteLine("Bob has been removed !");
            // client1.removeUser("bob");
            // Console.WriteLine("Bob has been removes twice !");
        }
        catch (UserUnknownException e)
        {
            Console.WriteLine(e.login + " : user unknown (enable to remove)!");
        }
        catch (UserExistsException e)
        {
            Console.WriteLine(e.login + " has already been added !");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message + " : user unknown (enable to remove)!");
        }



        // authentification 
        /*
        try
        {
            client1.addUser("bobi", "123");
            Console.WriteLine("Bob has been added !");
            client1.authentify("bobi", "123");
            Console.WriteLine("Authentification OK !");
           // client1.authentify("bob", "456");
           // Console.WriteLine("Invalid password !");
        }
        catch (WrongPasswordException e)
        {
            Console.WriteLine(e.login + " has provided an invalid password !");
        }
        catch (UserExistsException e)
        {
            Console.WriteLine(e.login + " has already been added !");
        }
        catch (UserUnknownException e)
        {
            Console.WriteLine(e.login + " : user unknown (enable to remove)!");
        }
        /*
        /*
        // persistance 
        try
        {
            server.stopServer();
            AuthentificationManager am1 = new Authentification();
            am1.load("users.txt");
            am1.authentify("bobi", "123");
            Console.WriteLine("Loading complete !");
        }
        catch (UserUnknownException e)
        {
            Console.WriteLine(e.login + " is unknown ! error during the saving/loading.");
        }
        catch (WrongPasswordException e)
        {
            Console.WriteLine(e.login + " has provided an invalid password !error during the saving/loading.");
        }
        catch (UserExistsException e)
        {
            Console.WriteLine(e.login + " has already been added !error during the saving/loading.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        */

        /*
        client1.createTopic("Ruby"); client1.createTopic("Java"); client2.createTopic("PHP");
        Console.WriteLine("Topics list : " + server.listTopics());

        IChatroom cr2 = client2.joinTopic("PHP");
        IChatroom cr1 = client1.joinTopic("PHP");

        IChatter bob = new TextChatter("Bob");
        IChatter joe = new TextChatter("Joe");

        cr1.join(bob);
        cr1.post("Je suis seul ou quoi ?", bob);
        cr2.join(joe);
        cr1.post("Tiens, salut Bob !", bob);
        cr2.post("Yop", joe);
        cr1.quit(bob);
        cr2.post("Toi aussi tu chat sur les forums de jeux pendant les TP,Bob ?", joe);
        */

        Console.ReadKey(true);
    }
}

