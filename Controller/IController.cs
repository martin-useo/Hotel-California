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
        void CreateReservation(String roomId, String name, String startDate, String endDate);
        void GetPersonsReservations(String name);
        void DeleteReservation(String roomNr);
        void DeletePersonsReservations(String name);

        void RegisterRoomService(String roomId, String workerType);
        void GetWorkerRequests();



        bool RoomIsAvailable(String startDate, String endDate);



    }
}
