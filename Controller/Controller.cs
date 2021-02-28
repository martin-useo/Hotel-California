using System;

namespace ControllerNS
{
    public class Controller : IController
    {
        public Controller() { }
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
            throw new NotImplementedException();
        }
        public bool RoomIsAvailable(string startDate, string endDate)
        {
            throw new NotImplementedException();
        }
    }
}
