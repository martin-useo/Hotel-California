using System;

namespace Hotel_California___Data_manipulation_Layer
{
    public interface IDataLayer
    {
        void Add_Room(int rid, int rpplcnt, string rqlt, string rsize);

        void Del_Room(int delid);

        void Add_Client(string cname, string cpassword);

        int Login(string cname, string cpassword);

        void Del_Client(string cname, string cpassword);

        void Add_Reservation(int rid, string cname, string cpassword, DateTime begins, DateTime ends);

        void Del_Reservation(int bid);

        void Add_Task(int tid, int rid);

        void Del_Task(int rid, int tid);

        void Disp_Rooms();

        void Disp_Tasks();

        void Disp_Clients();
    }
}