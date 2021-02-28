using System;
using System.Collections.Generic;
using System.Text;

namespace ControllerNS
{
    public interface IController
    {
        void GetAllRooms();
        void GetAvailableRooms(String startDate, String endDate);

        void GetAllReservations();
        bool RoomIsAvailable(String startDate, String endDate);
        void CreateReservation(String roomId, String name, String startDate, String endDate);
        void GetPersonsReservation(String name);
        void DeleteReservation(String roomNr);
        void DeletePersonsReservation(String name);

        void RegisterRoomService(String roomId, String workerType);
        void GetWorkerRequests();





    }
}
