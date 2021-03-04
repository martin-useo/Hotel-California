using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_California___Data_manipulation_Layer;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        IDataLayer idl;
        String clientPassword = "hunter8";

        public Form1(IDataLayer _dataLayer)
        {
            idl = _dataLayer;
            InitializeComponent();
        }

     
        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridViewTasks.SelectedRows;
            System.Collections.IEnumerator en = selectedRows.GetEnumerator();

            while (en.MoveNext())
            {
                DataGridViewRow current = (DataGridViewRow)en.Current;
                DataGridViewCellCollection cells = current.Cells;
                DataGridViewCell taskCell = cells[0];
                DataGridViewCell roomCell = cells[1];

                if (!(taskCell is null) && !(roomCell is null))
                {
                    int taskId = int.Parse((string)taskCell.Value);
                    idl.Del_Task(taskId);
                }
            }
            buttonGetTasks_Click(sender, e);
        }
        private void buttonCreateTask_Click(object sender, EventArgs e)
        {
            int roomId = int.Parse(textBoxRoomNumberWork.Text);
            String taskType = comboBoxWorkType.Text;
            idl.Add_Task(taskType, roomId);
            textBoxRoomNumberWork.Text = "";
            buttonGetTasks_Click(sender, e);


        }

        private void buttonReservationCreate_Click(object sender, EventArgs e)
        {
            bool correctFormat = true;
            String roomId = textBoxReservationRoomNumber.Text;
            String name = textBoxReservationName.Text;
            DateTime startDate = DateTime.Parse(textBoxReservationStartDate.Text);
            DateTime endDate = DateTime.Parse(textBoxReservationEndDate.Text);

            if (roomId is null)
            {
                textBoxReservationRoomNumber.Text = "Please enter room number";
                correctFormat = false;
            }
            if (name is null)
            {
                textBoxReservationName.Text = "Please enter name";
                correctFormat = false;
            }
            if (correctFormat)
            {
                idl.Add_Reservation(Int32.Parse(roomId), name, clientPassword, startDate, endDate);
            }
            textBoxReservationEndDate.Text=textBoxReservationStartDate.Text=textBoxReservationName.Text = textBoxReservationRoomNumber.Text = "";
            buttonReservationShowAll_Click(sender,  e);
        }

        private void buttonReservationDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridViewReservations.SelectedRows;          

            //DataGridView
             System.Collections.IEnumerator en = selectedRows.GetEnumerator();

             while (en.MoveNext())
             {
                 DataGridViewRow current = (DataGridViewRow)en.Current;
                 DataGridViewCellCollection cells = current.Cells;
                 DataGridViewCell viewRoomId = cells[0];
                DataGridViewCell viewPerson = cells[1];
                DataGridViewCell beginDate = cells[2];
                DataGridViewCell endDate = cells[3];
                
                if (!(viewRoomId is null))
                 {
                    int roomId = (int)viewRoomId.Value;
                    int person = (int)viewPerson.Value;
                    DateTime begin = (DateTime)beginDate.Value;
                    DateTime end = (DateTime)endDate.Value;

                    List<Booked_Rooms> b = idl.Get_All_Reservations();
                    foreach (Booked_Rooms book in b)
                    { 
                        if((book.Rooms_ID == roomId) && (book.Clients_ID == person) && (book.Begins == begin) && (book.Ends == end)){
                            idl.Del_Reservation(book.Reservation_ID);
                        }
                    }                       

                    
                 }
             }
            buttonReservationShowAll_Click(sender, e);
        }
        private void buttonGetTasks_Click(object sender, EventArgs e)
        {
            if (!(dataGridViewTasks.Rows == null))
            {
                dataGridViewTasks.Rows.Clear();
            }

            List<Tasks> tasklist = idl.Get_All_Tasks();

            foreach (Tasks task in tasklist) {
                String[] row = { task.Task_ID.ToString(), task.ID_ROOM.ToString(), task.Task_Type, task.Status,task.Task_Note };
                dataGridViewTasks.Rows.Add(row);
            }
            
        }
        private void comboBoxViewRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewRooms.Rows.Clear();
            ComboBox cb = (ComboBox)sender;
            String selected = cb.SelectedItem.ToString();
            ComboBox.ObjectCollection items = cb.Items;

            if (selected == items[0].ToString())        // View rooms in available date range
            {
                DateTime startDate = calendarStart.SelectionRange.Start;
                DateTime endDate = calendarEnd.SelectionRange.End;
                List<Rooms> rooms = idl.Get_All_Available_Rooms(startDate, endDate);

                foreach (Rooms r in rooms)
                {
                    String[] row = { r.Rooms_ID.ToString(), r.People_Count.ToString(), r.Size, r.Quality };
                    dataGridViewRooms.Rows.Add(row);
                }
            }
            else if (selected == items[1].ToString())   // View all rooms
            {
                List<Rooms> rooms = idl.Get_All_Rooms();

                foreach (Rooms r in rooms)
                {
                    String[] row = {r.Rooms_ID.ToString(), r.People_Count.ToString(), r.Size, r.Quality};
                    dataGridViewRooms.Rows.Add(row);
                }
            }
            else
            {
                throw new InvalidOperationException("Something went wrong");
            }
        }

        private void buttonReservationShowAll_Click(object sender, EventArgs e)
        {

            if (!(dataGridViewReservations.Rows == null))
            {
                dataGridViewReservations.Rows.Clear();
            }
            

            List<Booked_Rooms> b = idl.Get_All_Reservations();
            if  (!(b == null))
            {
                foreach (Booked_Rooms book in b)
                    dataGridViewReservations.Rows.Add(book.Rooms_ID, book.Clients_ID, book.Begins, book.Ends);
            }
        }

        private void FirstDateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxReservationStartDate.Text = calendarStart.SelectionRange.Start.ToString();
       


        }

        private void LastDateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxReservationEndDate.Text = calendarEnd.SelectionRange.Start.ToString();
        }
    }
}
