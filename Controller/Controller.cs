using System;
using Hotel_California___Data_manipulation_Layer;

namespace ControllerNS
{
    public class Controller : IController
    {
        //Commented out until the System.Data.Sqlclient error is resolved
        IDataLayer IDataLayer;
        public Controller() { IDataLayer = new DataLayer(); }

        //public Controller() {}

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

        public void DeleteTask(string rid, string tid)
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
            /* Commented out until database errors are sorted out
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
            */
        }
        public bool RoomIsAvailable(string startDate, string endDate)
        {
            throw new NotImplementedException();
        }
    }
}
