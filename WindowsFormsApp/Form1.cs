using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerNS;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        IController IController;

        public Form1(IController _controller)
        {
            IController = _controller;
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String roomId = textBoxRoomNumber.Text;
            String work = comboBoxWorkType.Text;
            IController.RegisterRoomService(roomId, work);
        }
    }
}
