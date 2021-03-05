using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Diagnostics;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MaintenanceApp
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        String connectionString =
            "data source=hotel-california.database.windows.net;" +
            "initial catalog=Hotel-California;" +
            "persist security info=True;" +
            "user id=eagle;" +
            "password=Kv!gSci4KsrXp6D;";
        public static List<Task>  tasks = new List<Task>();

        public MainPage()
        {
            this.InitializeComponent();
        }
        private void MaintainerButton_Click(object sender, RoutedEventArgs e)
        {
            GetTasks(connectionString);

            while (TaskList.Items.Count != 0)
            {
                TaskList.Items.RemoveAt(0);
                ServiceList.Items.RemoveAt(0);
            }

            foreach (Task t in tasks)
            {
                if (t.Task_Type == "Maintenance")
                {
                    TaskList.Items.Add(t.Room_ID);
                    ServiceList.Items.Add(t.Status);
                }
            }
        }
        private void ServiceButton_Click(object sender, RoutedEventArgs e)
        {

            GetTasks(connectionString);

            while (TaskList.Items.Count != 0)
            {
                TaskList.Items.RemoveAt(0);
                ServiceList.Items.RemoveAt(0);
            }

            foreach (Task t in tasks)
            {
                if (t.Task_Type == "Service")
                {
                    TaskList.Items.Add(t.Room_ID);
                    ServiceList.Items.Add(t.Status);
                }
            }
        }
        private void CleanerButton_Click(object sender, RoutedEventArgs e)
        {
            GetTasks(connectionString);

            while (TaskList.Items.Count != 0)
            {
                TaskList.Items.RemoveAt(0);
                ServiceList.Items.RemoveAt(0);
            }

            foreach (Task t in tasks)
            {
                if (t.Task_Type == "Cleaning")
                {
                    TaskList.Items.Add(t.Room_ID);
                    ServiceList.Items.Add(t.Status);
                }
            }
        }
        private void Okey_Click(object sender, RoutedEventArgs e)
        {            
            switch (popUpList.SelectedIndex) {
                case 0:
                    ServiceList.Items[ServiceList.SelectedIndex] = selectedItem0.Text;
                    break;
                case 1:
                    ServiceList.Items[ServiceList.SelectedIndex] = selectedItem1.Text;
                    break;
                case 2:
                    ServiceList.Items[ServiceList.SelectedIndex] = selectedItem2.Text;
                    break;
            }
            POPup.IsOpen = false;
        }
        private void ServiceList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            POPup.IsOpen = true;
        }
        private void DeleteFinishedButtom_Click(object sender, RoutedEventArgs e)
        {
            /*
            int i = 0;
            while (i < TaskList.Items.Count)
            {
                object s = ServiceList.Items[0];
                if (s.value == "Finished")
                {
                    TaskList.Items.RemoveAt(i);
                    ServiceList.Items.RemoveAt(i);
                }
                i++;
            }
            */
        }
        public static ObservableCollection<Task> GetTasks(string connectionString)
{
            const string GetProductsQuery = "select Task_ID, ID_ROOM, Task_Type," +
               " Task_Note, Status" +
               " from Tasks";

            var products = new ObservableCollection<Task>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = GetProductsQuery;
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                tasks.Clear();
                                while (reader.Read())
                                {
                                    Task task = new Task();
                                    task.Task_ID = reader.GetInt32(0);
                                    task.Room_ID = reader.GetInt32(1);
                                    task.Task_Type = reader.GetString(2);
                                    task.Task_Note = reader.GetString(3);
                                    task.Status = reader.GetString(4);
                                    tasks.Add(task);
                                }
                            }
                        }
                    }
                }
                return products;
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
            }
            return null;
        }
    }
    }

