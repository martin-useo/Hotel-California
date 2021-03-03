﻿using System;
using System.Collections.Generic;

namespace Hotel_California___Data_manipulation_Layer
{
    public interface IDataLayer
    {
        // Rooms  ///////////////////////////////////////////////////////////
        void Add_Room(int rid, int rpplcnt, string rqlt, string rsize);
        void Del_Room(int delid);
        List<Rooms> Get_All_Rooms();
        List<Rooms> Get_All_Available_Rooms(DateTime begins, DateTime ends);
        //Rooms Get_Room(int rid);
        // Reservations  ////////////////////////////////////////////////////
        void Add_Reservation(int rid, string cname, string cpassword, DateTime begins, DateTime ends);
        void Del_Reservation(int bid);
        List<Booked_Rooms> Get_All_Reservations();
        // Clients  /////////////////////////////////////////////////////////
        void Add_Client(string cname, string cpassword);
        void Del_Client(string cname, string cpassword);
        //Clients Get_All_Clients();
        // Tasks  ///////////////////////////////////////////////////////////
        void Add_Task(String taskType, int rid);
        void Del_Task(int tid);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="roomid"> Id of the room of the tasks you want to delete</param>
        /// <param name="taskType"> Task type in String format: One of the following: "Cleaner", "Maintenence" or "Room Service"</param>
        void Del_Task(int roomid, String taskType);
        List<Tasks> Get_All_Tasks();
        // Other ////////////////////////////////////////////////////////////
        int Login(string cname, string cpassword);
    }
}