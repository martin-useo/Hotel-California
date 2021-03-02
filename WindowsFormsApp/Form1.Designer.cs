﻿
using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.RoomNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxViewRooms = new System.Windows.Forms.ComboBox();
            this.calendarStart = new System.Windows.Forms.MonthCalendar();
            this.calendarEnd = new System.Windows.Forms.MonthCalendar();
            this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxReservationSearch = new System.Windows.Forms.TextBox();
            this.buttonReservationSearch = new System.Windows.Forms.Button();
            this.buttonReservationShowAll = new System.Windows.Forms.Button();
            this.textBoxReservationRoomNumber = new System.Windows.Forms.TextBox();
            this.textBoxReservationName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxReservationStartDate = new System.Windows.Forms.TextBox();
            this.textBoxReservationEndDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.buttonDeleteTask = new System.Windows.Forms.Button();
            this.buttonReservationDelete = new System.Windows.Forms.Button();
            this.textBoxRoomNumberWork = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxWorkType = new System.Windows.Forms.ComboBox();
            this.buttonCreateTaskRequest = new System.Windows.Forms.Button();
            this.buttonReservationCreate = new System.Windows.Forms.Button();
            this.TaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.AllowUserToOrderColumns = true;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNr,
            this.Size,
            this.Quality,
            this.Status});
            this.dataGridViewRooms.Location = new System.Drawing.Point(12, 303);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.RowHeadersWidth = 51;
            this.dataGridViewRooms.RowTemplate.Height = 29;
            this.dataGridViewRooms.Size = new System.Drawing.Size(533, 373);
            this.dataGridViewRooms.TabIndex = 0;
            this.dataGridViewRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RoomNr
            // 
            this.RoomNr.HeaderText = "RoomNr";
            this.RoomNr.MinimumWidth = 6;
            this.RoomNr.Name = "RoomNr";
            this.RoomNr.Width = 125;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.MinimumWidth = 6;
            this.Size.Name = "Size";
            this.Size.Width = 125;
            // 
            // Quality
            // 
            this.Quality.HeaderText = "Quality";
            this.Quality.MinimumWidth = 6;
            this.Quality.Name = "Quality";
            this.Quality.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // comboBoxViewRooms
            // 
            this.comboBoxViewRooms.FormattingEnabled = true;
            this.comboBoxViewRooms.Items.AddRange(new object[] {
            "View available rooms within date range",
            "View all rooms"});
            this.comboBoxViewRooms.Location = new System.Drawing.Point(30, 256);
            this.comboBoxViewRooms.Name = "comboBoxViewRooms";
            this.comboBoxViewRooms.Size = new System.Drawing.Size(151, 28);
            this.comboBoxViewRooms.TabIndex = 3;
            // 
            // calendarStart
            // 
            this.calendarStart.Location = new System.Drawing.Point(18, 18);
            this.calendarStart.Name = "calendarStart";
            this.calendarStart.TabIndex = 4;
            this.calendarStart.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarStart_DateChanged);
            // 
            // calendarEnd
            // 
            this.calendarEnd.Location = new System.Drawing.Point(289, 18);
            this.calendarEnd.Name = "calendarEnd";
            this.calendarEnd.TabIndex = 5;
            this.calendarEnd.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarEnd_DateChanged);
            // 
            // dataGridViewReservations
            // 
            this.dataGridViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Room,
            this.Person,
            this.StartDate,
            this.EndDate});
            this.dataGridViewReservations.Location = new System.Drawing.Point(788, 18);
            this.dataGridViewReservations.Name = "dataGridViewReservations";
            this.dataGridViewReservations.RowHeadersWidth = 51;
            this.dataGridViewReservations.RowTemplate.Height = 29;
            this.dataGridViewReservations.Size = new System.Drawing.Size(561, 215);
            this.dataGridViewReservations.TabIndex = 6;
            // 
            // Room
            // 
            this.Room.HeaderText = "Room";
            this.Room.MinimumWidth = 6;
            this.Room.Name = "Room";
            this.Room.Width = 125;
            // 
            // Person
            // 
            this.Person.HeaderText = "Person";
            this.Person.MinimumWidth = 6;
            this.Person.Name = "Person";
            this.Person.Width = 125;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.MinimumWidth = 6;
            this.StartDate.Name = "StartDate";
            this.StartDate.Width = 125;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "End Date";
            this.EndDate.MinimumWidth = 6;
            this.EndDate.Name = "EndDate";
            this.EndDate.Width = 125;
            // 
            // textBoxReservationSearch
            // 
            this.textBoxReservationSearch.Location = new System.Drawing.Point(788, 256);
            this.textBoxReservationSearch.Name = "textBoxReservationSearch";
            this.textBoxReservationSearch.Size = new System.Drawing.Size(102, 27);
            this.textBoxReservationSearch.TabIndex = 7;
            this.textBoxReservationSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // buttonReservationSearch
            // 
            this.buttonReservationSearch.Location = new System.Drawing.Point(896, 256);
            this.buttonReservationSearch.Name = "buttonReservationSearch";
            this.buttonReservationSearch.Size = new System.Drawing.Size(133, 29);
            this.buttonReservationSearch.TabIndex = 8;
            this.buttonReservationSearch.Text = "Search person";
            this.buttonReservationSearch.UseVisualStyleBackColor = true;
            // 
            // buttonReservationShowAll
            // 
            this.buttonReservationShowAll.Location = new System.Drawing.Point(1035, 256);
            this.buttonReservationShowAll.Name = "buttonReservationShowAll";
            this.buttonReservationShowAll.Size = new System.Drawing.Size(157, 29);
            this.buttonReservationShowAll.TabIndex = 9;
            this.buttonReservationShowAll.Text = "Show all reservations";
            this.buttonReservationShowAll.UseVisualStyleBackColor = true;
            // 
            // textBoxReservationRoomNumber
            // 
            this.textBoxReservationRoomNumber.Location = new System.Drawing.Point(574, 41);
            this.textBoxReservationRoomNumber.Name = "textBoxReservationRoomNumber";
            this.textBoxReservationRoomNumber.Size = new System.Drawing.Size(125, 27);
            this.textBoxReservationRoomNumber.TabIndex = 10;
            // 
            // textBoxReservationName
            // 
            this.textBoxReservationName.Location = new System.Drawing.Point(572, 94);
            this.textBoxReservationName.Name = "textBoxReservationName";
            this.textBoxReservationName.Size = new System.Drawing.Size(125, 27);
            this.textBoxReservationName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Room number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(572, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name of owner of reservation:";
            // 
            // textBoxReservationStartDate
            // 
            this.textBoxReservationStartDate.Location = new System.Drawing.Point(572, 147);
            this.textBoxReservationStartDate.Name = "textBoxReservationStartDate";
            this.textBoxReservationStartDate.Size = new System.Drawing.Size(125, 27);
            this.textBoxReservationStartDate.TabIndex = 14;
            // 
            // textBoxReservationEndDate
            // 
            this.textBoxReservationEndDate.Location = new System.Drawing.Point(572, 206);
            this.textBoxReservationEndDate.Name = "textBoxReservationEndDate";
            this.textBoxReservationEndDate.Size = new System.Drawing.Size(125, 27);
            this.textBoxReservationEndDate.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Start date of booking";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "End date of booking";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskId,
            this.dataGridViewTextBoxColumn1,
            this.Type,
            this.dataGridViewTextBoxColumn2,
            this.Note});
            this.dataGridViewTasks.Location = new System.Drawing.Point(788, 387);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.RowHeadersWidth = 51;
            this.dataGridViewTasks.RowTemplate.Height = 29;
            this.dataGridViewTasks.Size = new System.Drawing.Size(569, 289);
            this.dataGridViewTasks.TabIndex = 18;
            // 
            // buttonDeleteTask
            // 
            this.buttonDeleteTask.Location = new System.Drawing.Point(852, 352);
            this.buttonDeleteTask.Name = "buttonDeleteTask";
            this.buttonDeleteTask.Size = new System.Drawing.Size(177, 29);
            this.buttonDeleteTask.TabIndex = 19;
            this.buttonDeleteTask.Text = "Delete task";
            this.buttonDeleteTask.UseVisualStyleBackColor = true;
            this.buttonDeleteTask.Click += new System.EventHandler(this.buttonDeleteTask_Click);
            // 
            // buttonReservationDelete
            // 
            this.buttonReservationDelete.Location = new System.Drawing.Point(1198, 256);
            this.buttonReservationDelete.Name = "buttonReservationDelete";
            this.buttonReservationDelete.Size = new System.Drawing.Size(145, 29);
            this.buttonReservationDelete.TabIndex = 20;
            this.buttonReservationDelete.Text = "Delete reservation";
            this.buttonReservationDelete.UseVisualStyleBackColor = true;
            this.buttonReservationDelete.Click += new System.EventHandler(this.buttonReservationDelete_Click);
            // 
            // textBoxRoomNumberWork
            // 
            this.textBoxRoomNumberWork.Location = new System.Drawing.Point(600, 435);
            this.textBoxRoomNumberWork.Name = "textBoxRoomNumberWork";
            this.textBoxRoomNumberWork.Size = new System.Drawing.Size(125, 27);
            this.textBoxRoomNumberWork.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Room number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(600, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Type of work:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBoxWorkType
            // 
            this.comboBoxWorkType.FormattingEnabled = true;
            this.comboBoxWorkType.Items.AddRange(new object[] {
            "Cleaning",
            "Maintenence",
            "Service"});
            this.comboBoxWorkType.Location = new System.Drawing.Point(600, 517);
            this.comboBoxWorkType.Name = "comboBoxWorkType";
            this.comboBoxWorkType.Size = new System.Drawing.Size(151, 28);
            this.comboBoxWorkType.TabIndex = 25;
            // 
            // buttonCreateTaskRequest
            // 
            this.buttonCreateTaskRequest.Location = new System.Drawing.Point(600, 579);
            this.buttonCreateTaskRequest.Name = "buttonCreateTaskRequest";
            this.buttonCreateTaskRequest.Size = new System.Drawing.Size(167, 29);
            this.buttonCreateTaskRequest.TabIndex = 26;
            this.buttonCreateTaskRequest.Text = "Create task request";
            this.buttonCreateTaskRequest.UseVisualStyleBackColor = true;
            this.buttonCreateTaskRequest.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonReservationCreate
            // 
            this.buttonReservationCreate.Location = new System.Drawing.Point(572, 256);
            this.buttonReservationCreate.Name = "buttonReservationCreate";
            this.buttonReservationCreate.Size = new System.Drawing.Size(153, 29);
            this.buttonReservationCreate.TabIndex = 27;
            this.buttonReservationCreate.Text = "Create Reservation";
            this.buttonReservationCreate.UseVisualStyleBackColor = true;
            this.buttonReservationCreate.Click += new System.EventHandler(this.buttonReservationCreate_Click);
            // 
            // TaskId
            // 
            this.TaskId.HeaderText = "TaskId";
            this.TaskId.MinimumWidth = 6;
            this.TaskId.Name = "TaskId";
            this.TaskId.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Room";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Status";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 688);
            this.Controls.Add(this.buttonReservationCreate);
            this.Controls.Add(this.buttonCreateTaskRequest);
            this.Controls.Add(this.comboBoxWorkType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRoomNumberWork);
            this.Controls.Add(this.buttonReservationDelete);
            this.Controls.Add(this.buttonDeleteTask);
            this.Controls.Add(this.dataGridViewTasks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxReservationEndDate);
            this.Controls.Add(this.textBoxReservationStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxReservationName);
            this.Controls.Add(this.textBoxReservationRoomNumber);
            this.Controls.Add(this.buttonReservationShowAll);
            this.Controls.Add(this.buttonReservationSearch);
            this.Controls.Add(this.textBoxReservationSearch);
            this.Controls.Add(this.dataGridViewReservations);
            this.Controls.Add(this.calendarEnd);
            this.Controls.Add(this.calendarStart);
            this.Controls.Add(this.comboBoxViewRooms);
            this.Controls.Add(this.dataGridViewRooms);
            this.Name = "Form1";
            this.Text = "Delete worker request";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ComboBox comboBoxViewRooms;
        private System.Windows.Forms.MonthCalendar calendarStart;
        private System.Windows.Forms.MonthCalendar calendarEnd;
        private System.Windows.Forms.DataGridView dataGridViewReservations;
        private System.Windows.Forms.TextBox textBoxReservationSearch;
        private System.Windows.Forms.Button buttonReservationSearch;
        private System.Windows.Forms.Button buttonReservationShowAll;
        private TextBox textBoxReservationRoomNumber;
        private TextBox textBoxReservationName;
        private Label label1;
        private Label label2;
        private TextBox textBoxReservationStartDate;
        private TextBox textBoxReservationEndDate;
        private Label label3;
        private Label label4;
        private DataGridView dataGridViewTasks;
        private Button buttonDeleteTask;
        private Button buttonReservationDelete;
        private TextBox textBoxRoomNumberWork;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxWorkType;
        private Button buttonCreateTaskRequest;
        private Button buttonReservationCreate;
        private DataGridViewTextBoxColumn Room;
        private DataGridViewTextBoxColumn Person;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
        private DataGridViewTextBoxColumn TaskId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Note;
    }
}

