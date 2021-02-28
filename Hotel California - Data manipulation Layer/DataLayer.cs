using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;

namespace Hotel_California___Data_manipulation_Layer
{
    class DataLayer : IDataLayer
    {
        public DataLayer()
        {

        }

        void Add_Room(Entities_oui dc, int rid, int rpplcnt, string rqlt, string rsize)
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

        void Del_Room(Entities_oui dc, int delid)
        {
            Rooms rdel = dc.Rooms.Where(rm => rm.Rooms_ID == delid).FirstOrDefault();

            if (rdel != null)
            {
                dc.Rooms.Remove(rdel);
                dc.SaveChanges();
            }
        }

        void Add_Client(Entities_oui dc, string cname, string cpassword)
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

        int Login(Entities_oui dc, string cname, string cpassword)
        {
            int cid = 0;

            Clients getid = dc.Clients.Where(gid => gid.Name == cname).Where(gid => gid.Password == cpassword).FirstOrDefault();

            if (getid != null)
            {
                cid = getid.Clients_ID;
            }

            return (cid);
        }

        void Del_Client(Entities_oui dc, string cname, string cpassword)
        {
            int cid = 0;
            cid = Login(dc, cname, cpassword);

            Clients cdel = dc.Clients.Where(rm => rm.Clients_ID == cid).FirstOrDefault();

            if (cdel != null)
            {
                dc.Clients.Remove(cdel);
                dc.SaveChanges();
            }

        }

        void Add_Reservation(Entities_oui dc, int rid, string cname, string cpassword, DateTime begins, DateTime ends)
        {
            Booked_Rooms br = new Booked_Rooms();

            int cid = Login(dc, cname, cpassword);
            br.Clients_ID = cid;

            br.Rooms_ID = rid;
            br.Begins = begins;
            br.Ends = ends;

            dc.Booked_Rooms.Add(br);
            dc.SaveChanges();

        }

        void Del_Reservation(Entities_oui dc, int bid)
        {
            Booked_Rooms bdel = dc.Booked_Rooms.Where(rm => rm.Reservation_ID == bid).FirstOrDefault();

            if (bdel != null)
            {
                dc.Booked_Rooms.Remove(bdel);
                dc.SaveChanges();
            }
        }
        
        void Add_Task(Entities_oui dc, int tid, int rid)
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

        void Del_Task(Entities_oui dc, int rid, int tid)
        {
            Tasks tdel = dc.Tasks.Where(rm => rm.Task_ID == tid).Where(rm => rm.ID_ROOM == rid).FirstOrDefault();

            if (tdel != null)
            {
                dc.Tasks.Remove(tdel);
                dc.SaveChanges();
            }
        }

        void Disp_Rooms(Entities_oui dc)
        {
            DbSet<Rooms> Rooms = dc.Rooms;
            var RoomsList = Rooms.OrderBy(rooms => rooms.Rooms_ID);

            foreach (Rooms r0 in RoomsList)
                Console.WriteLine("{0} {1} {2} {3}", r0.Rooms_ID, r0.People_Count, r0.Quality, r0.Size);
            Console.WriteLine("=====================================");
            Console.ReadKey();
        }

        void Disp_Tasks(Entities_oui dc)
        {
            DbSet<Tasks> Tasks = dc.Tasks;
            var TaskList = Tasks.OrderBy(tasks => tasks.Task_ID);

            Console.WriteLine("id       type           status");
            foreach (Tasks t in Tasks)
                Console.WriteLine("{0}{1}{2}");
            Console.ReadKey();
        }

        void Disp_Clients(Entities_oui dc)
        {
            DbSet<Clients> Clients = dc.Clients;
            
            var ClientsList = Clients.OrderBy(cli => cli.Clients_ID);

            Console.WriteLine("id                name             password");
            foreach (Clients c0 in ClientsList)
                Console.WriteLine("{0} {1} {2}", c0.Clients_ID, c0.Name, c0.Password);
            Console.WriteLine("======================================");
            Console.ReadKey();
        }
        /*
        void Main(string[] args)
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


        }
        */

    }
}


