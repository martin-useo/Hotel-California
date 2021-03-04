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
            /*
            List<Task> Tasks = new List<Task>();
            Tasks.Add(new Task() { Room_ID = 200, Task_ID = 1, Status = "new" });
            Tasks.Add(new Task() { Room_ID = 201, Task_ID = 2, Status = "In process" });
            Tasks.Add(new Task() { Room_ID = 202, Task_ID = 3, Status = "In process" });
            Tasks.Add(new Task() { Room_ID = 203, Task_ID = 4, Status = "new" });
            Tasks.Add(new Task() { Room_ID = 204, Task_ID = 5, Status = "Finished" });
            Tasks.Add(new Task() { Room_ID = 205, Task_ID = 6, Status = "new" });

            List<Task_Type> Task_Types = new List<Task_Type>();
            Task_Types.Add(new Task_Type() { Task_ID = 1, Post_ID = 1, Type = "Cleaning" });
            Task_Types.Add(new Task_Type() { Task_ID = 2, Post_ID = 2, Type = "Service" });
            Task_Types.Add(new Task_Type() { Task_ID = 3, Post_ID = 3, Type = "Maintance" });
            Task_Types.Add(new Task_Type() { Task_ID = 4, Post_ID = 1, Type = "Cleaning" });
            Task_Types.Add(new Task_Type() { Task_ID = 5, Post_ID = 2, Type = "Service" });
            Task_Types.Add(new Task_Type() { Task_ID = 6, Post_ID = 3, Type = "Maintance" });
          
            */
            TaskList.SelectedIndex = 0;
            foreach (Task t in tasks)
            {
                if (t.Task_Type == "Maintenance")
                {
                    TaskList.Items.Add(t.Room_ID);
                    ServiceList.Items.Add(t.Status);
                }
            }

            // Cleaning
            // Maintenance 
            // Service
        }
        private void ServiceButton_Click(object sender, RoutedEventArgs e)
        {

            while (TaskList.Items.Count != 0)
            {
                TaskList.Items.RemoveAt(0);
                ServiceList.Items.RemoveAt(0);
            }

            /*
            List<Task> Tasks = new List<Task>();
            Tasks.Add(new Task() { Room_ID = 200, Task_ID = 1, Status = "new" });
            Tasks.Add(new Task() { Room_ID = 201, Task_ID = 2, Status = "In process" });
            Tasks.Add(new Task() { Room_ID = 202, Task_ID = 3, Status = "In process" });
            Tasks.Add(new Task() { Room_ID = 203, Task_ID = 4, Status = "new" });
            Tasks.Add(new Task() { Room_ID = 204, Task_ID = 5, Status = "Finished" });
            Tasks.Add(new Task() { Room_ID = 205, Task_ID = 6, Status = "new" });

            List<Task_Type> Task_Types = new List<Task_Type>();
            Task_Types.Add(new Task_Type() { Task_ID = 1, Post_ID = 1, Type = "Cleaning" });
            Task_Types.Add(new Task_Type() { Task_ID = 2, Post_ID = 2, Type = "Service" });
            Task_Types.Add(new Task_Type() { Task_ID = 3, Post_ID = 3, Type = "Maintance" });
            Task_Types.Add(new Task_Type() { Task_ID = 4, Post_ID = 1, Type = "Cleaning" });
            Task_Types.Add(new Task_Type() { Task_ID = 5, Post_ID = 2, Type = "Service" });
            Task_Types.Add(new Task_Type() { Task_ID = 6, Post_ID = 3, Type = "Maintance" });
           

            foreach (ListViewItem eachItem in TaskList.SelectedItems)
            {
                TaskList.Items.Remove(eachItem);
            }


            foreach (Task_Type t in Task_Types)
            {
                if (t.Post_ID == 2)
                {
                    foreach (Task task in Tasks)
                    {
                        if (task.Task_ID == t.Task_ID)
                        {
                            TaskList.Items.Add(task.Task_ID);
                            ServiceList.Items.Add(task.Status);
                        }
                    }
                }
            }
            */
        }
        private void CleanerButton_Click(object sender, RoutedEventArgs e)
        {
            while (TaskList.Items.Count != 0)
            {
                TaskList.Items.RemoveAt(0);
                ServiceList.Items.RemoveAt(0);
            }
            /*
            List<Task> Tasks = new List<Task>();
            Tasks.Add(new Task() { Room_ID = 200, Task_ID = 1, Status = "new" });
            Tasks.Add(new Task() { Room_ID = 201, Task_ID = 2, Status = "In process" });
            Tasks.Add(new Task() { Room_ID = 202, Task_ID = 3, Status = "In process" });
            Tasks.Add(new Task() { Room_ID = 203, Task_ID = 4, Status = "new" });
            Tasks.Add(new Task() { Room_ID = 204, Task_ID = 5, Status = "Finished" });
            Tasks.Add(new Task() { Room_ID = 205, Task_ID = 6, Status = "new" });

            List<Task_Type> Task_Types = new List<Task_Type>();
            Task_Types.Add(new Task_Type() { Task_ID = 1, Post_ID = 1, Type = "Cleaning" });
            Task_Types.Add(new Task_Type() { Task_ID = 2, Post_ID = 2, Type = "Service" });
            Task_Types.Add(new Task_Type() { Task_ID = 3, Post_ID = 3, Type = "Maintance" });
            Task_Types.Add(new Task_Type() { Task_ID = 4, Post_ID = 1, Type = "Cleaning" });
            Task_Types.Add(new Task_Type() { Task_ID = 5, Post_ID = 2, Type = "Service" });
            Task_Types.Add(new Task_Type() { Task_ID = 6, Post_ID = 3, Type = "Maintance" });
            


            foreach (Task_Type t in Task_Types)
            {
                if (t.Post_ID == 1)
                {
                    foreach (Task task in Tasks)
                    {
                        if (task.Task_ID == t.Task_ID)
                        {
                            TaskList.Items.Add(task.Task_ID);
                            ServiceList.Items.Add(task.Status);
                        }
                    }
                }
            }
            */
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

