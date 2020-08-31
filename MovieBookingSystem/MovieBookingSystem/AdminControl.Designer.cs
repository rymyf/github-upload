namespace MovieBookingSystem
{
    partial class AdminControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProceduresGroupBox = new System.Windows.Forms.GroupBox();
            this.UpdateRadioButton = new System.Windows.Forms.RadioButton();
            this.DeleteRadioButton = new System.Windows.Forms.RadioButton();
            this.AddRadioButton = new System.Windows.Forms.RadioButton();
            this.AddMoviePanel = new System.Windows.Forms.Panel();
            this.AddLabel = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.AddMoviebutton = new System.Windows.Forms.Button();
            this.AvailableSeatstextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TimecomboBox = new System.Windows.Forms.ComboBox();
            this.CinemacomboBox = new System.Windows.Forms.ComboBox();
            this.MovieTypecomboBox = new System.Windows.Forms.ComboBox();
            this.MovieNameTextBox = new System.Windows.Forms.TextBox();
            this.Deletepanel = new System.Windows.Forms.Panel();
            this.delPanel = new System.Windows.Forms.Panel();
            this.movieAvSeatlabel = new System.Windows.Forms.Label();
            this.movieTimelabel = new System.Windows.Forms.Label();
            this.movieDatelabel = new System.Windows.Forms.Label();
            this.movieTypelabel = new System.Windows.Forms.Label();
            this.movieNamelabel = new System.Windows.Forms.Label();
            this.CinemaNamelabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SelectDButton = new System.Windows.Forms.Button();
            this.DeleteIDTextBox = new System.Windows.Forms.TextBox();
            this.DeleteLabel = new System.Windows.Forms.Label();
            this.Updapanel = new System.Windows.Forms.Panel();
            this.Selectpanel = new System.Windows.Forms.Panel();
            this.updateTimecomboBox = new System.Windows.Forms.ComboBox();
            this.updateseattextBox = new System.Windows.Forms.TextBox();
            this.updatedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updatemovcomboBox = new System.Windows.Forms.ComboBox();
            this.updatemovtextBox = new System.Windows.Forms.TextBox();
            this.updateCincomboBox = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.selectUpButton = new System.Windows.Forms.Button();
            this.UpdateIDTextBox = new System.Windows.Forms.TextBox();
            this.Updatelabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Welcomelabel1 = new System.Windows.Forms.Label();
            this.logOutbutton = new System.Windows.Forms.Button();
            this.ProceduresGroupBox.SuspendLayout();
            this.AddMoviePanel.SuspendLayout();
            this.Deletepanel.SuspendLayout();
            this.delPanel.SuspendLayout();
            this.Updapanel.SuspendLayout();
            this.Selectpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProceduresGroupBox
            // 
            this.ProceduresGroupBox.Controls.Add(this.UpdateRadioButton);
            this.ProceduresGroupBox.Controls.Add(this.DeleteRadioButton);
            this.ProceduresGroupBox.Controls.Add(this.AddRadioButton);
            this.ProceduresGroupBox.Location = new System.Drawing.Point(15, 33);
            this.ProceduresGroupBox.Name = "ProceduresGroupBox";
            this.ProceduresGroupBox.Size = new System.Drawing.Size(348, 59);
            this.ProceduresGroupBox.TabIndex = 0;
            this.ProceduresGroupBox.TabStop = false;
            this.ProceduresGroupBox.Text = "Your Procedures:";
            // 
            // UpdateRadioButton
            // 
            this.UpdateRadioButton.AutoSize = true;
            this.UpdateRadioButton.Location = new System.Drawing.Point(234, 20);
            this.UpdateRadioButton.Name = "UpdateRadioButton";
            this.UpdateRadioButton.Size = new System.Drawing.Size(91, 17);
            this.UpdateRadioButton.TabIndex = 2;
            this.UpdateRadioButton.Text = "Update Movie";
            this.UpdateRadioButton.UseVisualStyleBackColor = true;
            this.UpdateRadioButton.CheckedChanged += new System.EventHandler(this.UpdateRadioButton_CheckedChanged);
            // 
            // DeleteRadioButton
            // 
            this.DeleteRadioButton.AutoSize = true;
            this.DeleteRadioButton.Location = new System.Drawing.Point(115, 20);
            this.DeleteRadioButton.Name = "DeleteRadioButton";
            this.DeleteRadioButton.Size = new System.Drawing.Size(87, 17);
            this.DeleteRadioButton.TabIndex = 1;
            this.DeleteRadioButton.Text = "Delete Movie";
            this.DeleteRadioButton.UseVisualStyleBackColor = true;
            this.DeleteRadioButton.CheckedChanged += new System.EventHandler(this.DeleteRadioButton_CheckedChanged);
            // 
            // AddRadioButton
            // 
            this.AddRadioButton.AutoSize = true;
            this.AddRadioButton.Location = new System.Drawing.Point(7, 20);
            this.AddRadioButton.Name = "AddRadioButton";
            this.AddRadioButton.Size = new System.Drawing.Size(75, 17);
            this.AddRadioButton.TabIndex = 0;
            this.AddRadioButton.Text = "Add Movie";
            this.AddRadioButton.UseVisualStyleBackColor = true;
            this.AddRadioButton.CheckedChanged += new System.EventHandler(this.AddRadioButton_CheckedChanged);
            // 
            // AddMoviePanel
            // 
            this.AddMoviePanel.Controls.Add(this.AddLabel);
            this.AddMoviePanel.Controls.Add(this.IDtextBox);
            this.AddMoviePanel.Controls.Add(this.AddMoviebutton);
            this.AddMoviePanel.Controls.Add(this.AvailableSeatstextBox);
            this.AddMoviePanel.Controls.Add(this.dateTimePicker);
            this.AddMoviePanel.Controls.Add(this.TimecomboBox);
            this.AddMoviePanel.Controls.Add(this.CinemacomboBox);
            this.AddMoviePanel.Controls.Add(this.MovieTypecomboBox);
            this.AddMoviePanel.Controls.Add(this.MovieNameTextBox);
            this.AddMoviePanel.Location = new System.Drawing.Point(15, 98);
            this.AddMoviePanel.Name = "AddMoviePanel";
            this.AddMoviePanel.Size = new System.Drawing.Size(227, 339);
            this.AddMoviePanel.TabIndex = 1;
            this.AddMoviePanel.Visible = false;
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLabel.Location = new System.Drawing.Point(83, 16);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(34, 16);
            this.AddLabel.TabIndex = 9;
            this.AddLabel.Text = "Add";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Enabled = false;
            this.IDtextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.IDtextBox.Location = new System.Drawing.Point(21, 53);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(121, 20);
            this.IDtextBox.TabIndex = 8;
            // 
            // AddMoviebutton
            // 
            this.AddMoviebutton.Location = new System.Drawing.Point(67, 299);
            this.AddMoviebutton.Name = "AddMoviebutton";
            this.AddMoviebutton.Size = new System.Drawing.Size(75, 23);
            this.AddMoviebutton.TabIndex = 7;
            this.AddMoviebutton.Text = "Add";
            this.AddMoviebutton.UseVisualStyleBackColor = true;
            this.AddMoviebutton.Click += new System.EventHandler(this.AddMoviebutton_Click);
            // 
            // AvailableSeatstextBox
            // 
            this.AvailableSeatstextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.AvailableSeatstextBox.Location = new System.Drawing.Point(21, 224);
            this.AvailableSeatstextBox.Name = "AvailableSeatstextBox";
            this.AvailableSeatstextBox.Size = new System.Drawing.Size(100, 20);
            this.AvailableSeatstextBox.TabIndex = 6;
            this.AvailableSeatstextBox.Text = "Available Seats";
            this.AvailableSeatstextBox.Enter += new System.EventHandler(this.AvailableSeatstextBox_Enter);
            this.AvailableSeatstextBox.Leave += new System.EventHandler(this.AvailableSeatstextBox_Leave);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(21, 168);
            this.dateTimePicker.MaxDate = new System.DateTime(2018, 12, 1, 23, 59, 59, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.Value = new System.DateTime(2018, 11, 28, 0, 0, 0, 0);
            // 
            // TimecomboBox
            // 
            this.TimecomboBox.FormattingEnabled = true;
            this.TimecomboBox.Items.AddRange(new object[] {
            "16:00:00",
            "17:30:00",
            "19:00:00",
            "20:30:00",
            "22:00:00"});
            this.TimecomboBox.Location = new System.Drawing.Point(21, 197);
            this.TimecomboBox.Name = "TimecomboBox";
            this.TimecomboBox.Size = new System.Drawing.Size(121, 21);
            this.TimecomboBox.TabIndex = 3;
            this.TimecomboBox.Text = "Time";
            // 
            // CinemacomboBox
            // 
            this.CinemacomboBox.FormattingEnabled = true;
            this.CinemacomboBox.Items.AddRange(new object[] {
            "VOX Cinema",
            "AMC Cinema"});
            this.CinemacomboBox.Location = new System.Drawing.Point(21, 79);
            this.CinemacomboBox.Name = "CinemacomboBox";
            this.CinemacomboBox.Size = new System.Drawing.Size(121, 21);
            this.CinemacomboBox.TabIndex = 2;
            this.CinemacomboBox.Text = "Cinema";
            // 
            // MovieTypecomboBox
            // 
            this.MovieTypecomboBox.FormattingEnabled = true;
            this.MovieTypecomboBox.Items.AddRange(new object[] {
            "Action",
            "Drama",
            "Comedy",
            "History",
            "Horror",
            "Sci-Fi",
            "Animation",
            "Documantry",
            "Adventure",
            "Crime",
            "Mystery",
            "Romance",
            "Sport",
            "Musical",
            "War"});
            this.MovieTypecomboBox.Location = new System.Drawing.Point(21, 132);
            this.MovieTypecomboBox.Name = "MovieTypecomboBox";
            this.MovieTypecomboBox.Size = new System.Drawing.Size(121, 21);
            this.MovieTypecomboBox.TabIndex = 1;
            this.MovieTypecomboBox.Text = "Movies Type";
            // 
            // MovieNameTextBox
            // 
            this.MovieNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MovieNameTextBox.Location = new System.Drawing.Point(21, 106);
            this.MovieNameTextBox.Name = "MovieNameTextBox";
            this.MovieNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.MovieNameTextBox.TabIndex = 0;
            this.MovieNameTextBox.Text = "movie name";
            this.MovieNameTextBox.Enter += new System.EventHandler(this.MovieNameTextBox_Enter);
            this.MovieNameTextBox.Leave += new System.EventHandler(this.MovieNameTextBox_Leave);
            // 
            // Deletepanel
            // 
            this.Deletepanel.Controls.Add(this.delPanel);
            this.Deletepanel.Controls.Add(this.SelectDButton);
            this.Deletepanel.Controls.Add(this.DeleteIDTextBox);
            this.Deletepanel.Controls.Add(this.DeleteLabel);
            this.Deletepanel.Location = new System.Drawing.Point(15, 98);
            this.Deletepanel.Name = "Deletepanel";
            this.Deletepanel.Size = new System.Drawing.Size(213, 339);
            this.Deletepanel.TabIndex = 2;
            // 
            // delPanel
            // 
            this.delPanel.Controls.Add(this.movieAvSeatlabel);
            this.delPanel.Controls.Add(this.movieTimelabel);
            this.delPanel.Controls.Add(this.movieDatelabel);
            this.delPanel.Controls.Add(this.movieTypelabel);
            this.delPanel.Controls.Add(this.movieNamelabel);
            this.delPanel.Controls.Add(this.CinemaNamelabel);
            this.delPanel.Controls.Add(this.DeleteButton);
            this.delPanel.Location = new System.Drawing.Point(4, 106);
            this.delPanel.Name = "delPanel";
            this.delPanel.Size = new System.Drawing.Size(206, 230);
            this.delPanel.TabIndex = 14;
            this.delPanel.Visible = false;
            // 
            // movieAvSeatlabel
            // 
            this.movieAvSeatlabel.AutoSize = true;
            this.movieAvSeatlabel.Location = new System.Drawing.Point(59, 160);
            this.movieAvSeatlabel.Name = "movieAvSeatlabel";
            this.movieAvSeatlabel.Size = new System.Drawing.Size(70, 13);
            this.movieAvSeatlabel.TabIndex = 22;
            this.movieAvSeatlabel.Text = "movieAvSeat";
            // 
            // movieTimelabel
            // 
            this.movieTimelabel.AutoSize = true;
            this.movieTimelabel.Location = new System.Drawing.Point(59, 130);
            this.movieTimelabel.Name = "movieTimelabel";
            this.movieTimelabel.Size = new System.Drawing.Size(57, 13);
            this.movieTimelabel.TabIndex = 21;
            this.movieTimelabel.Text = "movieTime";
            // 
            // movieDatelabel
            // 
            this.movieDatelabel.AutoSize = true;
            this.movieDatelabel.Location = new System.Drawing.Point(59, 101);
            this.movieDatelabel.Name = "movieDatelabel";
            this.movieDatelabel.Size = new System.Drawing.Size(58, 13);
            this.movieDatelabel.TabIndex = 20;
            this.movieDatelabel.Text = "movieDate";
            // 
            // movieTypelabel
            // 
            this.movieTypelabel.AutoSize = true;
            this.movieTypelabel.Location = new System.Drawing.Point(59, 73);
            this.movieTypelabel.Name = "movieTypelabel";
            this.movieTypelabel.Size = new System.Drawing.Size(59, 13);
            this.movieTypelabel.TabIndex = 19;
            this.movieTypelabel.Text = "movieType";
            // 
            // movieNamelabel
            // 
            this.movieNamelabel.AutoSize = true;
            this.movieNamelabel.Location = new System.Drawing.Point(59, 43);
            this.movieNamelabel.Name = "movieNamelabel";
            this.movieNamelabel.Size = new System.Drawing.Size(62, 13);
            this.movieNamelabel.TabIndex = 18;
            this.movieNamelabel.Text = "movieName";
            // 
            // CinemaNamelabel
            // 
            this.CinemaNamelabel.AutoSize = true;
            this.CinemaNamelabel.Location = new System.Drawing.Point(59, 17);
            this.CinemaNamelabel.Name = "CinemaNamelabel";
            this.CinemaNamelabel.Size = new System.Drawing.Size(69, 13);
            this.CinemaNamelabel.TabIndex = 17;
            this.CinemaNamelabel.Text = "CinemaName";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(62, 193);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SelectDButton
            // 
            this.SelectDButton.Location = new System.Drawing.Point(66, 79);
            this.SelectDButton.Name = "SelectDButton";
            this.SelectDButton.Size = new System.Drawing.Size(75, 23);
            this.SelectDButton.TabIndex = 13;
            this.SelectDButton.Text = "Select";
            this.SelectDButton.UseVisualStyleBackColor = true;
            this.SelectDButton.Click += new System.EventHandler(this.SelectDButton_Click);
            // 
            // DeleteIDTextBox
            // 
            this.DeleteIDTextBox.Location = new System.Drawing.Point(26, 53);
            this.DeleteIDTextBox.Name = "DeleteIDTextBox";
            this.DeleteIDTextBox.Size = new System.Drawing.Size(156, 20);
            this.DeleteIDTextBox.TabIndex = 12;
            this.DeleteIDTextBox.Text = "Enter ID";
            this.DeleteIDTextBox.Enter += new System.EventHandler(this.DeleteTextBox_Enter);
            this.DeleteIDTextBox.Leave += new System.EventHandler(this.DeleteTextBox_Leave);
            // 
            // DeleteLabel
            // 
            this.DeleteLabel.AutoSize = true;
            this.DeleteLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteLabel.Location = new System.Drawing.Point(76, 16);
            this.DeleteLabel.Name = "DeleteLabel";
            this.DeleteLabel.Size = new System.Drawing.Size(50, 16);
            this.DeleteLabel.TabIndex = 10;
            this.DeleteLabel.Text = "Delete";
            // 
            // Updapanel
            // 
            this.Updapanel.Controls.Add(this.Selectpanel);
            this.Updapanel.Controls.Add(this.selectUpButton);
            this.Updapanel.Controls.Add(this.UpdateIDTextBox);
            this.Updapanel.Controls.Add(this.Updatelabel);
            this.Updapanel.Location = new System.Drawing.Point(15, 98);
            this.Updapanel.Name = "Updapanel";
            this.Updapanel.Size = new System.Drawing.Size(220, 339);
            this.Updapanel.TabIndex = 3;
            // 
            // Selectpanel
            // 
            this.Selectpanel.Controls.Add(this.updateTimecomboBox);
            this.Selectpanel.Controls.Add(this.updateseattextBox);
            this.Selectpanel.Controls.Add(this.updatedateTimePicker);
            this.Selectpanel.Controls.Add(this.updatemovcomboBox);
            this.Selectpanel.Controls.Add(this.updatemovtextBox);
            this.Selectpanel.Controls.Add(this.updateCincomboBox);
            this.Selectpanel.Controls.Add(this.UpdateButton);
            this.Selectpanel.Location = new System.Drawing.Point(0, 106);
            this.Selectpanel.Name = "Selectpanel";
            this.Selectpanel.Size = new System.Drawing.Size(200, 230);
            this.Selectpanel.TabIndex = 18;
            this.Selectpanel.Visible = false;
            // 
            // updateTimecomboBox
            // 
            this.updateTimecomboBox.FormattingEnabled = true;
            this.updateTimecomboBox.Items.AddRange(new object[] {
            "16:00:00",
            "17:30:00",
            "19:00:00",
            "20:30:00",
            "22:00:00"});
            this.updateTimecomboBox.Location = new System.Drawing.Point(40, 127);
            this.updateTimecomboBox.Name = "updateTimecomboBox";
            this.updateTimecomboBox.Size = new System.Drawing.Size(121, 21);
            this.updateTimecomboBox.TabIndex = 10;
            this.updateTimecomboBox.Text = "Time";
            // 
            // updateseattextBox
            // 
            this.updateseattextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.updateseattextBox.Location = new System.Drawing.Point(40, 157);
            this.updateseattextBox.Name = "updateseattextBox";
            this.updateseattextBox.Size = new System.Drawing.Size(100, 20);
            this.updateseattextBox.TabIndex = 38;
            this.updateseattextBox.Text = "Available Seats";
            // 
            // updatedateTimePicker
            // 
            this.updatedateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.updatedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.updatedateTimePicker.Location = new System.Drawing.Point(40, 101);
            this.updatedateTimePicker.MaxDate = new System.DateTime(2018, 12, 1, 23, 59, 59, 0);
            this.updatedateTimePicker.Name = "updatedateTimePicker";
            this.updatedateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.updatedateTimePicker.TabIndex = 37;
            this.updatedateTimePicker.Value = new System.DateTime(2018, 11, 23, 0, 0, 0, 0);
            // 
            // updatemovcomboBox
            // 
            this.updatemovcomboBox.FormattingEnabled = true;
            this.updatemovcomboBox.Items.AddRange(new object[] {
            "Action",
            "Drama",
            "Comedy",
            "History",
            "Horror",
            "Sci-Fi",
            "Animation",
            "Documantry",
            "Adventure",
            "Crime",
            "Mystery",
            "Romance",
            "Sport",
            "Musical",
            "War"});
            this.updatemovcomboBox.Location = new System.Drawing.Point(40, 70);
            this.updatemovcomboBox.Name = "updatemovcomboBox";
            this.updatemovcomboBox.Size = new System.Drawing.Size(121, 21);
            this.updatemovcomboBox.TabIndex = 35;
            this.updatemovcomboBox.Text = "Movies Type";
            // 
            // updatemovtextBox
            // 
            this.updatemovtextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.updatemovtextBox.Location = new System.Drawing.Point(40, 43);
            this.updatemovtextBox.Name = "updatemovtextBox";
            this.updatemovtextBox.Size = new System.Drawing.Size(121, 20);
            this.updatemovtextBox.TabIndex = 34;
            this.updatemovtextBox.Text = "movie name";
            // 
            // updateCincomboBox
            // 
            this.updateCincomboBox.FormattingEnabled = true;
            this.updateCincomboBox.Items.AddRange(new object[] {
            "VOX Cinema",
            "AMC Cinema"});
            this.updateCincomboBox.Location = new System.Drawing.Point(40, 14);
            this.updateCincomboBox.Name = "updateCincomboBox";
            this.updateCincomboBox.Size = new System.Drawing.Size(121, 21);
            this.updateCincomboBox.TabIndex = 33;
            this.updateCincomboBox.Text = "Cinema";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(81, 193);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 32;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click_1);
            // 
            // selectUpButton
            // 
            this.selectUpButton.Location = new System.Drawing.Point(66, 79);
            this.selectUpButton.Name = "selectUpButton";
            this.selectUpButton.Size = new System.Drawing.Size(75, 23);
            this.selectUpButton.TabIndex = 17;
            this.selectUpButton.Text = "Select";
            this.selectUpButton.UseVisualStyleBackColor = true;
            this.selectUpButton.Click += new System.EventHandler(this.selectUpButton_Click);
            // 
            // UpdateIDTextBox
            // 
            this.UpdateIDTextBox.Location = new System.Drawing.Point(29, 53);
            this.UpdateIDTextBox.Name = "UpdateIDTextBox";
            this.UpdateIDTextBox.Size = new System.Drawing.Size(156, 20);
            this.UpdateIDTextBox.TabIndex = 16;
            this.UpdateIDTextBox.Text = "Enter ID";
            // 
            // Updatelabel
            // 
            this.Updatelabel.AutoSize = true;
            this.Updatelabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatelabel.Location = new System.Drawing.Point(78, 16);
            this.Updatelabel.Name = "Updatelabel";
            this.Updatelabel.Size = new System.Drawing.Size(54, 16);
            this.Updatelabel.TabIndex = 15;
            this.Updatelabel.Text = "Update";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(81, 9);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(34, 13);
            this.Namelabel.TabIndex = 5;
            this.Namelabel.Text = "Name";
            // 
            // Welcomelabel1
            // 
            this.Welcomelabel1.AutoSize = true;
            this.Welcomelabel1.Location = new System.Drawing.Point(12, 9);
            this.Welcomelabel1.Name = "Welcomelabel1";
            this.Welcomelabel1.Size = new System.Drawing.Size(53, 13);
            this.Welcomelabel1.TabIndex = 4;
            this.Welcomelabel1.Text = "Welcome ";
            // 
            // logOutbutton
            // 
            this.logOutbutton.Location = new System.Drawing.Point(288, 397);
            this.logOutbutton.Name = "logOutbutton";
            this.logOutbutton.Size = new System.Drawing.Size(75, 23);
            this.logOutbutton.TabIndex = 6;
            this.logOutbutton.Text = "Log Out";
            this.logOutbutton.UseVisualStyleBackColor = true;
            this.logOutbutton.Click += new System.EventHandler(this.logOutbutton_Click);
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 457);
            this.Controls.Add(this.logOutbutton);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.Updapanel);
            this.Controls.Add(this.Welcomelabel1);
            this.Controls.Add(this.Deletepanel);
            this.Controls.Add(this.AddMoviePanel);
            this.Controls.Add(this.ProceduresGroupBox);
            this.Name = "AdminControl";
            this.Text = "AdminControl";
            this.Load += new System.EventHandler(this.AdminControl_Load);
            this.ProceduresGroupBox.ResumeLayout(false);
            this.ProceduresGroupBox.PerformLayout();
            this.AddMoviePanel.ResumeLayout(false);
            this.AddMoviePanel.PerformLayout();
            this.Deletepanel.ResumeLayout(false);
            this.Deletepanel.PerformLayout();
            this.delPanel.ResumeLayout(false);
            this.delPanel.PerformLayout();
            this.Updapanel.ResumeLayout(false);
            this.Updapanel.PerformLayout();
            this.Selectpanel.ResumeLayout(false);
            this.Selectpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ProceduresGroupBox;
        private System.Windows.Forms.RadioButton UpdateRadioButton;
        private System.Windows.Forms.RadioButton DeleteRadioButton;
        private System.Windows.Forms.RadioButton AddRadioButton;
        private System.Windows.Forms.Panel AddMoviePanel;
        private System.Windows.Forms.TextBox MovieNameTextBox;
        private System.Windows.Forms.ComboBox MovieTypecomboBox;
        private System.Windows.Forms.ComboBox CinemacomboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox TimecomboBox;
        private System.Windows.Forms.TextBox AvailableSeatstextBox;
        private System.Windows.Forms.Button AddMoviebutton;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Panel Deletepanel;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.TextBox DeleteIDTextBox;
        private System.Windows.Forms.Label DeleteLabel;
        private System.Windows.Forms.Button SelectDButton;
        private System.Windows.Forms.Panel Updapanel;
        private System.Windows.Forms.Button selectUpButton;
        private System.Windows.Forms.TextBox UpdateIDTextBox;
        private System.Windows.Forms.Label Updatelabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Welcomelabel1;
        private System.Windows.Forms.Panel Selectpanel;
        private System.Windows.Forms.TextBox updateseattextBox;
        private System.Windows.Forms.DateTimePicker updatedateTimePicker;
        private System.Windows.Forms.ComboBox updatemovcomboBox;
        private System.Windows.Forms.TextBox updatemovtextBox;
        private System.Windows.Forms.ComboBox updateCincomboBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ComboBox updateTimecomboBox;
        private System.Windows.Forms.Panel delPanel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label movieTimelabel;
        private System.Windows.Forms.Label movieDatelabel;
        private System.Windows.Forms.Label movieTypelabel;
        private System.Windows.Forms.Label movieNamelabel;
        private System.Windows.Forms.Label CinemaNamelabel;
        private System.Windows.Forms.Label movieAvSeatlabel;
        private System.Windows.Forms.Button logOutbutton;
    }
}