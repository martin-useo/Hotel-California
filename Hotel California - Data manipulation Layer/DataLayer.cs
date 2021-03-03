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
        Entities_oui3 dc;

        DbSet<Rooms> Rooms;
        DbSet<Clients> Clients;
        DbSet<Booked_Rooms> Booked_Rooms;
        DbSet<Tasks> Tasks;
        int taskID, postID;

        public DataLayer()
        {
            dc = new Entities_oui3();
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

            List<Rooms> rooms = Get_All_Rooms();
            bool pkTaken = false;
            foreach (Rooms r in rooms)
            {
                if (r.Rooms_ID == nr.Rooms_ID)
                {
                    pkTaken = true;
                }
            }

            if (!pkTaken)
            {
                dc.Rooms.Add(nr);
                dc.SaveChanges();
            }
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
            var roomSet = dc.Rooms.OrderBy(rooms => rooms.Rooms_ID);

            foreach (Rooms r in roomSet)
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
            br.Clients_ID = Login(cname, cpassword);
            br.Rooms_ID = rid;
            br.Begins = begins;
            br.Ends = ends;

            int reservationId = 0;
            List<Booked_Rooms> reservations = Get_All_Reservations();
            bool pkTaken = false;
            foreach (Booked_Rooms r in reservations)
            {
                if (r.Reservation_ID == br.Reservation_ID)
                {
                    pkTaken = true;
                }
                if (r.Reservation_ID > br.Reservation_ID)
                {
                    reservationId = r.Reservation_ID + 1;
                }
            }
            br.Reservation_ID = reservationId;


            List<Rooms> rooms = Get_All_Rooms();
            bool roomExists = false;
            foreach (Rooms r in rooms)
            {
                if (r.Rooms_ID == br.Rooms_ID)
                {
                    roomExists = true;
                }
            }

            if (!pkTaken && roomExists)
            {
                dc.Booked_Rooms.Add(br);
                dc.SaveChanges();
            }
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

            Clients clientHighestId = dc.Clients.OrderBy(x => x.Clients_ID).FirstOrDefault();
            ncl.Clients_ID = clientHighestId.Clients_ID + 1;
            ncl.Name = cname;
            ncl.Password = cpassword;

            // TODO check if client already exists before adding
            Clients client = dc.Clients.Where(gid => gid.Name == cname).Where(gid => gid.Password == cpassword).FirstOrDefault();
            if (client == null)
            {
            dc.Clients.Add(ncl);
            dc.SaveChanges();
            }
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
        
        public void Add_Task( String taskType, int rid)
        {
            Tasks nt = new Tasks();
            List<Tasks> tasks = Get_All_Tasks();
            int newTaskID = 0;
            bool pkTaken = false;

            foreach (Tasks t in tasks)
            {
                if (t.Task_ID > newTaskID)
                {
                    newTaskID = t.Task_ID + 1;
                }
                if (t.Task_ID == nt.Task_ID)
                {
                    pkTaken = true;
                }
            }
            
            nt.Task_ID = newTaskID;
            nt.ID_ROOM = rid;
            nt.Status = "new";
            nt.Task_Type = taskType;
            nt.Task_Note = "";

            if (!pkTaken)
            {
                dc.Tasks.Add(nt);
                dc.SaveChanges();
            }
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
        public List<Tasks> Get_All_Tasks()
        {
            List<Tasks> taskList = new List<Tasks>();
            var taskSet = dc.Tasks.OrderBy(tasks => tasks.Task_ID);

            foreach (Tasks t in taskSet)
                taskList.Add(t);

            return taskList;
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

            Clients client = dc.Clients.Where(gid => gid.Name == cname).Where(gid => gid.Password == cpassword).FirstOrDefault();

            if (client != null)
            {
                cid = client.Clients_ID;
            }
            else
            {
                Add_Client(cname, cpassword);
                client = dc.Clients.Where(gid => gid.Name == cname).Where(gid => gid.Password == cpassword).FirstOrDefault();
                cid = client.Clients_ID;
            }

            return (cid);
        }

        static void Main()
        {
            /*
            DataLayer dl = new DataLayer();

            //  /!\TESTING ZONE/!\

            // Getting the var to create a room
            int rid = 669;
            int rpplcnt = 314159276;
            string rqlt = "******************";
            string rsize = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXL";

            // Getting the var to create a client
            string cname = "JEANPIERRETREBERT";
            string cpassword = "LIFYVEGZ76873IRU";

            dl.Add_Room(rid, rpplcnt, rqlt, rsize);
            dl.Add_Client(cname, cpassword);

            dl.Disp_Rooms();
            dl.Disp_Clients();

            int lol = dl.Login(cname, cpassword);
            Console.WriteLine(lol);
            Console.ReadKey();

            dl.Del_Room(666);
            dl.Del_Client(cname, cpassword);
            */
            Console.ReadKey();
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

                             
        */
        
    }
}


