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
            Entities_oui dc = new Entities_oui();

            DbSet<Rooms> Rooms = dc.Rooms;

            var orderRooms = Rooms.OrderBy(rooms => rooms.Rooms_ID);

            foreach (Rooms r in orderRooms)
                Console.WriteLine("Room {0} is size {1}", r.Rooms_ID, r.Size);
            Console.ReadKey();
            Console.WriteLine("========================================");

            orderRooms = from rooms in Rooms
                         orderby rooms.Rooms_ID
                         select rooms;

            foreach (Rooms r in orderRooms)
                Console.WriteLine("Room {0} is a {1} room", r.Rooms_ID, r.Quality);

            Console.ReadKey();
        }
    }
}


