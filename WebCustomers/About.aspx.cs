using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCustomers
{
    public partial class About : Page
    {
        Entities dx = new Entities();
        //private DbSet<Rooms> Rooms;
        //private DbSet<Clients> Clients;
        //private DbSet<Booked_Rooms> Booked_Rooms;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        static Clients cl = new Clients();
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            cl.Name = NameText.Text;
            cl.Password = PasswordText.Text;

            int count = 0;
            foreach (Clients s in dx.Clients)
            {
                count++;
            }
            cl.Clients_ID = count;

            dx.Clients.Add(cl);
            dx.SaveChanges();
            NameText.Text = PasswordText.Text = "";
            MultiView1.ActiveViewIndex = 0;
        }

        protected void RegisteredButton_Click(object sender, EventArgs e)//show the reserves of the customer
        {

        }
        static DateTime First = new DateTime();
        static DateTime Last = new DateTime();
        protected void ButtonDisponibity_Click(object sender, EventArgs e)
        {
            dx.Rooms.Load();
            First = CalendarFirst.SelectedDate;
            Last = CalendarLast.SelectedDate;

            GridViewRooms.DataSource = dx.Rooms.Local.Where(rm => rm.People_Count == int.Parse(TextPeople.Text));
            GridViewRooms.DataBind();

            MultiView1.ActiveViewIndex = 2;
        }
        static Rooms ro = new Rooms();

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)   //
        {
            dx.Booked_Rooms.Load();
            string id = GridViewRooms.SelectedRow.Cells[1].Text;
            Booked_Rooms br = new Booked_Rooms();
            br.Rooms_ID = int.Parse(id);
            br.Clients_ID = cl.Clients_ID;
            br.Begins = First;
            br.Ends = Last;
            dx.Booked_Rooms.Add(br);
            dx.SaveChanges();
            MultiView1.ActiveViewIndex = 1;

        }
    }
}