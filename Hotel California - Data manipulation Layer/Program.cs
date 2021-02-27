using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;

namespace Hotel_California___Data_manipulation_Layer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Database context
            Entities_oui dc = new Entities_oui();

            // Getting all of the tables "imported" to collections on the C# code
            DbSet<Rooms> Rooms = dc.Rooms;
            DbSet<Clients> Clients = dc.Clients;
            DbSet<Booked_Rooms> Booked_Rooms = dc.Booked_Rooms;
            DbSet<Tasks> Tasks = dc.Tasks;
            DbSet<Task_Type> Task_Type = dc.Task_Type;
            DbSet<Post_Type> Post_Type = dc.Post_Type;

            // -------------------------------------------------------------------------------------------------------

            Console.WriteLine("Enter the number corresponding to the action you want to perform : \n 1 - Add a new room to the list\n 2 - Display the list of the rooms");
            Console.WriteLine(" 3 - Delete a Room\n 4 - Register a new Client\n 5 - Book a room (Work in progress, not working yet)\n 6 - Display a list of the Clients");

            int caseswitch = 0;
            caseswitch = int.Parse(Console.ReadLine());

            switch (caseswitch)
            {
                case 1:

                    // Adding a new room to the Room's list
                    int id;
                    int pplcnt;
                    string qlt;
                    string size;

                    Console.WriteLine("Please input your Room_ID (>350) : ");
                    id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input the number of People that can fit in : ");
                    pplcnt = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input the Quality of the room (in stars ***) : ");
                    qlt = Console.ReadLine();
                    Console.WriteLine("Input the size of the room (S, M, L, XL...) : ");
                    size = Console.ReadLine();

                    Rooms r = new Rooms();
                    r.Rooms_ID = id;
                    r.People_Count = pplcnt;
                    r.Quality = qlt;
                    r.Size = size;

                    dc.Rooms.Add(r);
                    dc.SaveChanges();

                    break;

                // -------------------------------------------------------------------------------------------------------

                case 2:

                    // Displaying a list of the Rooms along with their properties
                    var RoomsList = Rooms.OrderBy(rooms => rooms.Rooms_ID);

                    foreach (Rooms r0 in RoomsList)
                        Console.WriteLine("{0} {1} {2} {3}", r0.Rooms_ID, r0.People_Count, r0.Quality, r0.Size);
                    Console.WriteLine("=====================================");
                    Console.ReadKey();

                    break;

                // -------------------------------------------------------------------------------------------------------

                case 3:

                    // Deleting a Room 
                    int id_del;
                    Console.WriteLine("What's the ID of the room you want to delete ? ");
                    id_del = int.Parse(Console.ReadLine());

                    Rooms rdel = dc.Rooms.Where(rm => rm.Rooms_ID == id_del).FirstOrDefault();

                    if (rdel != null)
                    {
                        dc.Rooms.Remove(rdel);
                        dc.SaveChanges();
                    }
                    break;

                // -------------------------------------------------------------------------------------------------------

                case 4:

                    // Register a new Client
                    Clients cl = new Clients();

                    string name;
                    string password;

                    Console.WriteLine("Type in your name : ");
                    name = Console.ReadLine();
                    Console.WriteLine("Type in your password : ");
                    password = Console.ReadLine();

                    var rand = new Random();

                    cl.Clients_ID = rand.Next();
                    cl.Name = name;
                    cl.Password = password;

                    dc.Clients.Add(cl);
                    dc.SaveChanges();

                    break;

                // -------------------------------------------------------------------------------------------------------

                case 5:

                    // Book a room
                    Booked_Rooms br = new Booked_Rooms();


                    // "Login"
                    string name1;
                    string password1;
                    int id_c;

                    Console.WriteLine("Enter your name and password : ");
                    name1 = Console.ReadLine();
                    password1 = Console.ReadLine();

                    var client = Clients.OrderBy(cl14 => cl14.Clients_ID);


                    foreach (Clients c in Clients)
                        if (c.Name == name1)
                            foreach (Clients c1 in Clients)
                                if (c1.Password == password1)
                                    id_c = c.Clients_ID;


                    // Choose the room
                    Console.WriteLine("Type the ID of the Room you want to book : ");
                    int id_book = int.Parse(Console.ReadLine());

                    foreach (Rooms r13 in Rooms)
                        if (id_book == r13.Rooms_ID)
                            br.Rooms_ID = id_book;

                    // Choose the dates


                    dc.Booked_Rooms.Add(br);
                    dc.SaveChanges();

                    break;

                // -------------------------------------------------------------------------------------------------------

                case 6:

                    // Displaying a list of the Clients                  
                    var ClientsList = Clients.OrderBy(cli => cli.Clients_ID);

                    foreach (Clients c0 in ClientsList)
                        Console.WriteLine("id {0} name {1} passw {2}", c0.Clients_ID, c0.Name, c0.Password);
                    Console.WriteLine("======================================");
                    Console.ReadKey();

                    break;
           
            }

        }

    }
}


