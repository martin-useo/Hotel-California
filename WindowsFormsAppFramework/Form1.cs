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
        IDataLayer IDataLayer;

        public Form1(IDataLayer _controller)
        {
            IDataLayer = _controller;
            InitializeComponent();
        }

        public void CreateReservation() {
        
            // Check if room is already reserved
            // If room is already reserved, then cannot create reservation

        
        }

        public String ReadReservation() { 
            
            // If reservation exists, get it

            // Else reservation doesn't exists


            return ""; }

        public String getReservations()
        {
            return "";
        }

        public void UpdateReservation() { }

        public void DeleteReservation() { }

        public void RegisterRoomService() { }

        public void RegisterMaintenanceRequest() { }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void calendarEnd_DateChanged(object sender, DateRangeEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void calendarStart_DateChanged(object sender, DateRangeEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

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
                    IDataLayer.Del_Task(taskId, roomId);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int roomId = int.Parse(textBoxRoomNumberWork.Text);
            int work = int.Parse(comboBoxWorkType.Text);
            IDataLayer.Add_Task(roomId, work);
        }

        private void buttonReservationCreate_Click(object sender, EventArgs e)
        {
            bool correctFormat = true;
            String roomId = textBoxReservationRoomNumber.Text;
            String name = textBoxReservationName.Text;
            String startDate = textBoxReservationStartDate.Text;
            String endDate = textBoxReservationEndDate.Text;

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
            if (startDate is null)
            {
                textBoxReservationStartDate.Text = "Please enter date";
                correctFormat = false;
            }
            if (roomId is null)
            {
                textBoxReservationEndDate.Text = "Please enter date";
                correctFormat = false;
            }



            if (correctFormat)
            {
                // TODO
                // IDataLayer want int reservation id. Surely it should be the database that creates the id?
                //IDataLayer.Add_Reservation(roomId, name, startDate, endDate);
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
                    IDataLayer.Del_Reservation(roomId);
                }
            }
        }
    }
}
