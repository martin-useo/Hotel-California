using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;

namespace Hotel_California___Data_manipulation_Layer
{
    public class DataLayer : IDataLayer
    {
        Entities_oui dc;

        DbSet<Rooms> Rooms;
        DbSet<Clients> Clients;
        DbSet<Booked_Rooms> Booked_Rooms;
        DbSet<Tasks> Tasks;
        DbSet<Task_Type> Task_Type;
        DbSet<Post_Type> Post_Type;

        public DataLayer()
        {
            dc = new Entities_oui();

            /*
            Rooms = dc.Rooms;
            Clients = dc.Clients;
            Booked_Rooms = dc.Booked_Rooms;
            Tasks = dc.Tasks;
            Task_Type = dc.Task_Type;
            Post_Type = dc.Post_Type;
            */
        }
        public void Add_Room(int rid, int rpplcnt, string rqlt, string rsize)
        {
            Rooms nr = new Rooms
            {
                Rooms_ID = rid,
                People_Count = rpplcnt,
                Quality = rqlt,
                Size = rsize
            };

            dc.Rooms.Add(nr);
            dc.SaveChanges();
        }
        public void Del_Room(int delid)
        {
            Rooms rdel = dc.Rooms.Where(rm => rm.Rooms_ID == delid).FirstOrDefault();

            if (rdel != null)
            {
                dc.Rooms.Remove(rdel);
                dc.SaveChanges();
            }
        }
        public List<Rooms> Get_All_Rooms()
        {
            List<Rooms> roomList = new List<Rooms>();

            var RoomsList = dc.Rooms.OrderBy(rooms => rooms.Rooms_ID);

            foreach (Rooms r in RoomsList)
                roomList.Add(r);

            return roomList;
        }
        // TODO
        public List<Rooms> Get_All_Available_Rooms(DateTime beings, DateTime ends)
        {
            List<Rooms> rooms = new List<Rooms>();


            return rooms;
        }
         
        public void Add_Reservation( int rid, string cname, string cpassword, DateTime begins, DateTime ends)
        {
            Booked_Rooms br = new Booked_Rooms();

            int cid = Login(cname, cpassword);
            br.Clients_ID = cid;

            br.Rooms_ID = rid;
            br.Begins = begins;
            br.Ends = ends;

            dc.Booked_Rooms.Add(br);
            dc.SaveChanges();

        }
        public void Del_Reservation( int bid)
        {
            Booked_Rooms bdel = dc.Booked_Rooms.Where(rm => rm.Reservation_ID == bid).FirstOrDefault();

            if (bdel != null)
            {
                dc.Booked_Rooms.Remove(bdel);
                dc.SaveChanges();
            }
        }
        // TODO
        public List<Booked_Rooms> Get_All_Reservations()
        {
            List<Booked_Rooms> rooms = new List<Booked_Rooms>();


            return rooms;
        }

        public void Add_Client( string cname, string cpassword)
        {
            Clients ncl = new Clients();

            var rand = new Random();

            // Need to implement a way of checking if the combination of name/password already exists
            // Also need a way of checking if the ID isn't already taken

            ncl.Clients_ID = rand.Next();
            ncl.Name = cname;
            ncl.Password = cpassword;

            dc.Clients.Add(ncl);
            dc.SaveChanges();
        }
        public void Del_Client( string cname, string cpassword)
        {
            int cid = 0;
            cid = Login(cname, cpassword);

            Clients cdel = dc.Clients.Where(rm => rm.Clients_ID == cid).FirstOrDefault();

            if (cdel != null)
            {
                dc.Clients.Remove(cdel);
                dc.SaveChanges();
            }

        }
        
        public void Add_Task( int tid, int rid)
        {
            string tstatus = "new";
            Tasks nt = new Tasks
            {
                Task_ID = tid,
                ID_ROOM = rid,
                Status = tstatus
            };

            dc.Tasks.Add(nt);
            dc.SaveChanges();
        }
        public void Del_Task( int rid, int tid)
        {
            Tasks tdel = dc.Tasks.Where(rm => rm.Task_ID == tid).Where(rm => rm.ID_ROOM == rid).FirstOrDefault();
            
            if (tdel != null)
            {
                dc.Tasks.Remove(tdel);
                dc.SaveChanges();
            }
        }
        // TODO
        public List<Tasks> Get_All_Tasks()
        {
            List<Tasks> tasks = new List<Tasks>();


            return tasks;
        }


        public void Disp_Rooms()
        {
            DbSet<Rooms> Rooms = dc.Rooms;
            var RoomsList = Rooms.OrderBy(rooms => rooms.Rooms_ID);

            foreach (Rooms r0 in RoomsList)
                Console.WriteLine("{0} {1} {2} {3}", r0.Rooms_ID, r0.People_Count, r0.Quality, r0.Size);
            Console.WriteLine("=====================================");
            Console.ReadKey();
        }
        public void Disp_Tasks()
        {
            DbSet<Tasks> Tasks = dc.Tasks;
            var TaskList = Tasks.OrderBy(tasks => tasks.Task_ID);

            Console.WriteLine("id       type           status");
            foreach (Tasks t in Tasks)
                Console.WriteLine("{0}{1}{2}");
            Console.ReadKey();
        }
        public void Disp_Clients()
        {
            DbSet<Clients> Clients = dc.Clients;
            
            var ClientsList = Clients.OrderBy(cli => cli.Clients_ID);

            Console.WriteLine("id                name             password");
            foreach (Clients c0 in ClientsList)
                Console.WriteLine("{0} {1} {2}", c0.Clients_ID, c0.Name, c0.Password);
            Console.WriteLine("======================================");
            Console.ReadKey();
        }


        public int Login( string cname, string cpassword)
        {
            int cid = 0;

            Clients getid = dc.Clients.Where(gid => gid.Name == cname).Where(gid => gid.Password == cpassword).FirstOrDefault();

            if (getid != null)
            {
                cid = getid.Clients_ID;
            }

            return (cid);
        }

        static void Main()
        {

        }
        /*
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

            //  /!\TESTING ZONE/!\
            
            // Getting the var to create a room
            int rid = 666;
            int rpplcnt = 314159276;
            string rqlt = "******************";
            string rsize = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXL";

            // Getting the var to create a client
            string cname = "JEANPIERRETREBERT";
            string cpassword = "LIFYVEGZ76873IRU";

            Add_Room(dc, rid, rpplcnt, rqlt, rsize);
            Add_Client(dc, cname, cpassword);

            Disp_Rooms(dc);
            Disp_Clients(dc);

            int lol = Login(dc, cname, cpassword);
            Console.WriteLine(lol);
            Console.ReadKey();

            Del_Room(dc, 666);
            Del_Client(dc, cname, cpassword);                    
        */

    }
}


