using System;
using Hotel_California___Data_manipulation_Layer;

namespace ControllerNS
{
    public class Controller : IController
    {
        IDataLayer IDataLayer;

        public Controller() { IDataLayer = new DataLayer(); }

        public void CreateReservation(string roomId, string name, string startDate, string endDate)
        {
            throw new NotImplementedException();
        }
        public void DeletePersonsReservations(string name)
        {
            throw new NotImplementedException();
        }
        public void DeleteReservation(string roomNr)
        {
            throw new NotImplementedException();
        }
        public void GetAllReservations()
        {
            throw new NotImplementedException();
        }
        public void GetAllRooms()
        {
            throw new NotImplementedException();
        }
        public void GetAvailableRooms(string startDate, string endDate)
        {
            throw new NotImplementedException();
        }
        public void GetPersonsReservations(string name)
        {
            throw new NotImplementedException();
        }
        public void GetWorkerRequests()
        {
            throw new NotImplementedException();
        }
        public void RegisterRoomService(string roomId, string workerType)
        {
            switch (workerType)
                {
                case "Service":
                    {
                        IDataLayer.Add_Task(1, int.Parse(roomId));
                    }
                    break;
                case "Cleaner":
                    {
                        IDataLayer.Add_Task(2, int.Parse(roomId));
                    }
                    break;
                case "Maintenence":
                    {
                        IDataLayer.Add_Task( 3, int.Parse(roomId));
                    }
                    break;
                default:
                    {

                    }
                    break;
            }
        }
        public bool RoomIsAvailable(string startDate, string endDate)
        {
            throw new NotImplementedException();
        }
    }
}
