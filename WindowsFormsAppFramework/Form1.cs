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
                    int taskId = (int)taskCell.Value;
                    int roomId = (int)roomCell.Value;
                    idl.Del_Task(taskId, roomId);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateTask_Click(object sender, EventArgs e)
        {
            int roomId = int.Parse(textBoxRoomNumberWork.Text);
            String taskType = comboBoxWorkType.Text;
            idl.Add_Task(taskType, roomId);
        }

        private void buttonReservationCreate_Click(object sender, EventArgs e)
        {
            bool correctFormat = true;
            String roomId = textBoxReservationRoomNumber.Text;
            String name = textBoxReservationName.Text;
            DateTime startDate = calendarStart.SelectionRange.Start;
            DateTime endDate = calendarStart.SelectionRange.End;

            if(roomId is null)
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
        }

        private void buttonReservationDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridViewReservations.SelectedRows;
            System.Collections.IEnumerator en = selectedRows.GetEnumerator();

            while (en.MoveNext())
            {
                DataGridViewRow current = (DataGridViewRow)en.Current;
                DataGridViewCellCollection cells = current.Cells;
                DataGridViewCell viewCell = cells[0];

                if (!(viewCell is null))
                {
                    int roomId = (int)viewCell.Value;
                    idl.Del_Reservation(roomId);
                }
            }
        }
        private void buttonGetTasks_Click(object sender, EventArgs e)
        {
            List<Tasks> tasklist = idl.Get_All_Tasks();

            foreach (Tasks task in tasklist) {
                String[] row = { task.Task_ID.ToString(), task.ID_ROOM.ToString(), "", task.Status, "" };
                dataGridViewTasks.Rows.Add(row);
            }
        }
        private void comboBoxViewRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            String selected = cb.SelectedItem.ToString();
            ComboBox.ObjectCollection items = cb.Items;

            if (selected == items[0].ToString())        // View rooms in available date range
            {
                DateTime startDate = calendarStart.SelectionRange.Start;
                DateTime endDate = calendarStart.SelectionRange.End;
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
            List<Booked_Rooms> b = idl.Get_All_Reservations();
            if  (!(b == null))
            {
                foreach (Booked_Rooms book in b)
                        dataGridViewReservations.Rows.Add(book);
            }
        }

        private void buttonReservationSearch_Click(object sender, EventArgs e)
        {
            string searchBox = textBoxReservationSearch.Text;

            if  (searchbox == ) { 
            
            }
        }
    }
}
