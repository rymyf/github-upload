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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminControl));
            this.ProceduresGroupBox = new System.Windows.Forms.GroupBox();
            this.UpdateRadioButton = new System.Windows.Forms.RadioButton();
            this.DeleteRadioButton = new System.Windows.Forms.RadioButton();
            this.AddRadioButton = new System.Windows.Forms.RadioButton();
            this.AddMoviePanel = new System.Windows.Forms.Panel();
            this.addPiclabel = new System.Windows.Forms.Label();
            this.MoviepictureBox = new System.Windows.Forms.PictureBox();
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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.selectUpButton = new System.Windows.Forms.Button();
            this.UpdateIDTextBox = new System.Windows.Forms.TextBox();
            this.Updatelabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Welcomelabel1 = new System.Windows.Forms.Label();
            this.logOutbutton = new System.Windows.Forms.Button();
            this.ProceduresGroupBox.SuspendLayout();
            this.AddMoviePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviepictureBox)).BeginInit();
            this.Deletepanel.SuspendLayout();
            this.delPanel.SuspendLayout();
            this.Updapanel.SuspendLayout();
            this.Selectpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProceduresGroupBox
            // 
            this.ProceduresGroupBox.BackColor = System.Drawing.Color.White;
            this.ProceduresGroupBox.Controls.Add(this.UpdateRadioButton);
            this.ProceduresGroupBox.Controls.Add(this.DeleteRadioButton);
            this.ProceduresGroupBox.Controls.Add(this.AddRadioButton);
            this.ProceduresGroupBox.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProceduresGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ProceduresGroupBox.Location = new System.Drawing.Point(15, 53);
            this.ProceduresGroupBox.Name = "ProceduresGroupBox";
            this.ProceduresGroupBox.Size = new System.Drawing.Size(348, 49);
            this.ProceduresGroupBox.TabIndex = 0;
            this.ProceduresGroupBox.TabStop = false;
            this.ProceduresGroupBox.Text = "Your Procedures:";
            // 
            // UpdateRadioButton
            // 
            this.UpdateRadioButton.AutoSize = true;
            this.UpdateRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateRadioButton.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateRadioButton.Location = new System.Drawing.Point(234, 20);
            this.UpdateRadioButton.Name = "UpdateRadioButton";
            this.UpdateRadioButton.Size = new System.Drawing.Size(98, 26);
            this.UpdateRadioButton.TabIndex = 2;
            this.UpdateRadioButton.Text = "Update Movie";
            this.UpdateRadioButton.UseVisualStyleBackColor = false;
            this.UpdateRadioButton.CheckedChanged += new System.EventHandler(this.UpdateRadioButton_CheckedChanged);
            // 
            // DeleteRadioButton
            // 
            this.DeleteRadioButton.AutoSize = true;
            this.DeleteRadioButton.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRadioButton.Location = new System.Drawing.Point(115, 20);
            this.DeleteRadioButton.Name = "DeleteRadioButton";
            this.DeleteRadioButton.Size = new System.Drawing.Size(96, 26);
            this.DeleteRadioButton.TabIndex = 1;
            this.DeleteRadioButton.Text = "Delete Movie";
            this.DeleteRadioButton.UseVisualStyleBackColor = true;
            this.DeleteRadioButton.CheckedChanged += new System.EventHandler(this.DeleteRadioButton_CheckedChanged);
            // 
            // AddRadioButton
            // 
            this.AddRadioButton.AutoSize = true;
            this.AddRadioButton.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRadioButton.Location = new System.Drawing.Point(7, 20);
            this.AddRadioButton.Name = "AddRadioButton";
            this.AddRadioButton.Size = new System.Drawing.Size(81, 26);
            this.AddRadioButton.TabIndex = 0;
            this.AddRadioButton.Text = "Add Movie";
            this.AddRadioButton.UseVisualStyleBackColor = true;
            this.AddRadioButton.CheckedChanged += new System.EventHandler(this.AddRadioButton_CheckedChanged);
            // 
            // AddMoviePanel
            // 
            this.AddMoviePanel.Controls.Add(this.addPiclabel);
            this.AddMoviePanel.Controls.Add(this.MoviepictureBox);
            this.AddMoviePanel.Controls.Add(this.AddLabel);
            this.AddMoviePanel.Controls.Add(this.IDtextBox);
            this.AddMoviePanel.Controls.Add(this.AddMoviebutton);
            this.AddMoviePanel.Controls.Add(this.AvailableSeatstextBox);
            this.AddMoviePanel.Controls.Add(this.dateTimePicker);
            this.AddMoviePanel.Controls.Add(this.TimecomboBox);
            this.AddMoviePanel.Controls.Add(this.CinemacomboBox);
            this.AddMoviePanel.Controls.Add(this.MovieTypecomboBox);
            this.AddMoviePanel.Controls.Add(this.MovieNameTextBox);
            this.AddMoviePanel.Location = new System.Drawing.Point(110, 130);
            this.AddMoviePanel.Name = "AddMoviePanel";
            this.AddMoviePanel.Size = new System.Drawing.Size(158, 353);
            this.AddMoviePanel.TabIndex = 1;
            this.AddMoviePanel.Visible = false;
            // 
            // addPiclabel
            // 
            this.addPiclabel.AutoSize = true;
            this.addPiclabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPiclabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addPiclabel.Location = new System.Drawing.Point(32, 268);
            this.addPiclabel.Name = "addPiclabel";
            this.addPiclabel.Size = new System.Drawing.Size(66, 22);
            this.addPiclabel.TabIndex = 7;
            this.addPiclabel.Text = "Add Picture";
            // 
            // MoviepictureBox
            // 
            this.MoviepictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MoviepictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoviepictureBox.Location = new System.Drawing.Point(21, 244);
            this.MoviepictureBox.Name = "MoviepictureBox";
            this.MoviepictureBox.Size = new System.Drawing.Size(95, 73);
            this.MoviepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviepictureBox.TabIndex = 10;
            this.MoviepictureBox.TabStop = false;
            this.MoviepictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddLabel.Location = new System.Drawing.Point(63, 19);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(35, 18);
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
            this.AddMoviebutton.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMoviebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddMoviebutton.Location = new System.Drawing.Point(84, 323);
            this.AddMoviebutton.Name = "AddMoviebutton";
            this.AddMoviebutton.Size = new System.Drawing.Size(58, 24);
            this.AddMoviebutton.TabIndex = 7;
            this.AddMoviebutton.Text = "Add";
            this.AddMoviebutton.UseVisualStyleBackColor = true;
            this.AddMoviebutton.Click += new System.EventHandler(this.AddMoviebutton_Click);
            // 
            // AvailableSeatstextBox
            // 
            this.AvailableSeatstextBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableSeatstextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.AvailableSeatstextBox.Location = new System.Drawing.Point(21, 220);
            this.AvailableSeatstextBox.Name = "AvailableSeatstextBox";
            this.AvailableSeatstextBox.Size = new System.Drawing.Size(100, 20);
            this.AvailableSeatstextBox.TabIndex = 6;
            this.AvailableSeatstextBox.Text = "Available Seats";
            this.AvailableSeatstextBox.Enter += new System.EventHandler(this.AvailableSeatstextBox_Enter);
            this.AvailableSeatstextBox.Leave += new System.EventHandler(this.AvailableSeatstextBox_Leave);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(21, 162);
            this.dateTimePicker.MaxDate = new System.DateTime(2024, 12, 19, 23, 59, 59, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.Value = new System.DateTime(2018, 11, 28, 0, 0, 0, 0);
            // 
            // TimecomboBox
            // 
            this.TimecomboBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimecomboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TimecomboBox.FormattingEnabled = true;
            this.TimecomboBox.Items.AddRange(new object[] {
            "16:00:00",
            "17:30:00",
            "19:00:00",
            "20:30:00",
            "22:00:00"});
            this.TimecomboBox.Location = new System.Drawing.Point(21, 191);
            this.TimecomboBox.Name = "TimecomboBox";
            this.TimecomboBox.Size = new System.Drawing.Size(121, 22);
            this.TimecomboBox.TabIndex = 3;
            this.TimecomboBox.Text = "Time";
            // 
            // CinemacomboBox
            // 
            this.CinemacomboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CinemacomboBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CinemacomboBox.ForeColor = System.Drawing.Color.Black;
            this.CinemacomboBox.FormattingEnabled = true;
            this.CinemacomboBox.Items.AddRange(new object[] {
            "VOX",
            "AMC"});
            this.CinemacomboBox.Location = new System.Drawing.Point(21, 79);
            this.CinemacomboBox.Name = "CinemacomboBox";
            this.CinemacomboBox.Size = new System.Drawing.Size(121, 22);
            this.CinemacomboBox.TabIndex = 2;
            this.CinemacomboBox.Text = "Cinema";
            // 
            // MovieTypecomboBox
            // 
            this.MovieTypecomboBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTypecomboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
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
            this.MovieTypecomboBox.Size = new System.Drawing.Size(121, 22);
            this.MovieTypecomboBox.TabIndex = 1;
            this.MovieTypecomboBox.Text = "Movies Type";
            // 
            // MovieNameTextBox
            // 
            this.MovieNameTextBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MovieNameTextBox.Location = new System.Drawing.Point(21, 106);
            this.MovieNameTextBox.Name = "MovieNameTextBox";
            this.MovieNameTextBox.Size = new System.Drawing.Size(121, 21);
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
            this.Deletepanel.Location = new System.Drawing.Point(97, 133);
            this.Deletepanel.Name = "Deletepanel";
            this.Deletepanel.Size = new System.Drawing.Size(168, 339);
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
            this.delPanel.Location = new System.Drawing.Point(6, 106);
            this.delPanel.Name = "delPanel";
            this.delPanel.Size = new System.Drawing.Size(156, 230);
            this.delPanel.TabIndex = 14;
            this.delPanel.Visible = false;
            // 
            // movieAvSeatlabel
            // 
            this.movieAvSeatlabel.AutoSize = true;
            this.movieAvSeatlabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieAvSeatlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.movieAvSeatlabel.Location = new System.Drawing.Point(42, 160);
            this.movieAvSeatlabel.Name = "movieAvSeatlabel";
            this.movieAvSeatlabel.Size = new System.Drawing.Size(68, 14);
            this.movieAvSeatlabel.TabIndex = 22;
            this.movieAvSeatlabel.Text = "movieAvSeat";
            // 
            // movieTimelabel
            // 
            this.movieTimelabel.AutoSize = true;
            this.movieTimelabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTimelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.movieTimelabel.Location = new System.Drawing.Point(42, 130);
            this.movieTimelabel.Name = "movieTimelabel";
            this.movieTimelabel.Size = new System.Drawing.Size(61, 14);
            this.movieTimelabel.TabIndex = 21;
            this.movieTimelabel.Text = "movieTime";
            // 
            // movieDatelabel
            // 
            this.movieDatelabel.AutoSize = true;
            this.movieDatelabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieDatelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.movieDatelabel.Location = new System.Drawing.Point(42, 101);
            this.movieDatelabel.Name = "movieDatelabel";
            this.movieDatelabel.Size = new System.Drawing.Size(58, 14);
            this.movieDatelabel.TabIndex = 20;
            this.movieDatelabel.Text = "movieDate";
            // 
            // movieTypelabel
            // 
            this.movieTypelabel.AutoSize = true;
            this.movieTypelabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTypelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.movieTypelabel.Location = new System.Drawing.Point(42, 73);
            this.movieTypelabel.Name = "movieTypelabel";
            this.movieTypelabel.Size = new System.Drawing.Size(60, 14);
            this.movieTypelabel.TabIndex = 19;
            this.movieTypelabel.Text = "movieType";
            // 
            // movieNamelabel
            // 
            this.movieNamelabel.AutoSize = true;
            this.movieNamelabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieNamelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.movieNamelabel.Location = new System.Drawing.Point(42, 43);
            this.movieNamelabel.Name = "movieNamelabel";
            this.movieNamelabel.Size = new System.Drawing.Size(63, 14);
            this.movieNamelabel.TabIndex = 18;
            this.movieNamelabel.Text = "movieName";
            // 
            // CinemaNamelabel
            // 
            this.CinemaNamelabel.AutoSize = true;
            this.CinemaNamelabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CinemaNamelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CinemaNamelabel.Location = new System.Drawing.Point(42, 17);
            this.CinemaNamelabel.Name = "CinemaNamelabel";
            this.CinemaNamelabel.Size = new System.Drawing.Size(69, 14);
            this.CinemaNamelabel.TabIndex = 17;
            this.CinemaNamelabel.Text = "CinemaName";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DeleteButton.Location = new System.Drawing.Point(45, 193);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SelectDButton
            // 
            this.SelectDButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SelectDButton.Location = new System.Drawing.Point(46, 79);
            this.SelectDButton.Name = "SelectDButton";
            this.SelectDButton.Size = new System.Drawing.Size(75, 23);
            this.SelectDButton.TabIndex = 13;
            this.SelectDButton.Text = "Select";
            this.SelectDButton.UseVisualStyleBackColor = true;
            this.SelectDButton.Click += new System.EventHandler(this.SelectDButton_Click);
            // 
            // DeleteIDTextBox
            // 
            this.DeleteIDTextBox.Location = new System.Drawing.Point(29, 53);
            this.DeleteIDTextBox.Name = "DeleteIDTextBox";
            this.DeleteIDTextBox.Size = new System.Drawing.Size(112, 20);
            this.DeleteIDTextBox.TabIndex = 12;
            this.DeleteIDTextBox.Text = "Enter ID";
            this.DeleteIDTextBox.Enter += new System.EventHandler(this.DeleteTextBox_Enter);
            this.DeleteIDTextBox.Leave += new System.EventHandler(this.DeleteTextBox_Leave);
            // 
            // DeleteLabel
            // 
            this.DeleteLabel.AutoSize = true;
            this.DeleteLabel.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DeleteLabel.Location = new System.Drawing.Point(56, 16);
            this.DeleteLabel.Name = "DeleteLabel";
            this.DeleteLabel.Size = new System.Drawing.Size(57, 18);
            this.DeleteLabel.TabIndex = 10;
            this.DeleteLabel.Text = "Delete";
            this.DeleteLabel.Click += new System.EventHandler(this.DeleteLabel_Click);
            // 
            // Updapanel
            // 
            this.Updapanel.Controls.Add(this.Selectpanel);
            this.Updapanel.Controls.Add(this.selectUpButton);
            this.Updapanel.Controls.Add(this.UpdateIDTextBox);
            this.Updapanel.Controls.Add(this.Updatelabel);
            this.Updapanel.Location = new System.Drawing.Point(107, 115);
            this.Updapanel.Name = "Updapanel";
            this.Updapanel.Size = new System.Drawing.Size(160, 339);
            this.Updapanel.TabIndex = 3;
            // 
            // Selectpanel
            // 
            this.Selectpanel.Controls.Add(this.updateTimecomboBox);
            this.Selectpanel.Controls.Add(this.updateseattextBox);
            this.Selectpanel.Controls.Add(this.updatedateTimePicker);
            this.Selectpanel.Controls.Add(this.updatemovcomboBox);
            this.Selectpanel.Controls.Add(this.updatemovtextBox);
            this.Selectpanel.Controls.Add(this.UpdateButton);
            this.Selectpanel.Location = new System.Drawing.Point(10, 103);
            this.Selectpanel.Name = "Selectpanel";
            this.Selectpanel.Size = new System.Drawing.Size(141, 230);
            this.Selectpanel.TabIndex = 18;
            this.Selectpanel.Visible = false;
            // 
            // updateTimecomboBox
            // 
            this.updateTimecomboBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTimecomboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.updateTimecomboBox.FormattingEnabled = true;
            this.updateTimecomboBox.Items.AddRange(new object[] {
            "16:00:00",
            "17:30:00",
            "19:00:00",
            "20:30:00",
            "22:00:00"});
            this.updateTimecomboBox.Location = new System.Drawing.Point(10, 110);
            this.updateTimecomboBox.Name = "updateTimecomboBox";
            this.updateTimecomboBox.Size = new System.Drawing.Size(121, 22);
            this.updateTimecomboBox.TabIndex = 10;
            this.updateTimecomboBox.Text = "Time";
            // 
            // updateseattextBox
            // 
            this.updateseattextBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateseattextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.updateseattextBox.Location = new System.Drawing.Point(10, 141);
            this.updateseattextBox.Name = "updateseattextBox";
            this.updateseattextBox.Size = new System.Drawing.Size(100, 20);
            this.updateseattextBox.TabIndex = 38;
            this.updateseattextBox.Text = "Available Seats";
            // 
            // updatedateTimePicker
            // 
            this.updatedateTimePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.updatedateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.updatedateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.updatedateTimePicker.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.updatedateTimePicker.Location = new System.Drawing.Point(10, 78);
            this.updatedateTimePicker.MaxDate = new System.DateTime(2049, 12, 25, 0, 0, 0, 0);
            this.updatedateTimePicker.Name = "updatedateTimePicker";
            this.updatedateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.updatedateTimePicker.TabIndex = 37;
            this.updatedateTimePicker.Value = new System.DateTime(2018, 11, 23, 0, 0, 0, 0);
            // 
            // updatemovcomboBox
            // 
            this.updatemovcomboBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatemovcomboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
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
            this.updatemovcomboBox.Location = new System.Drawing.Point(10, 44);
            this.updatemovcomboBox.Name = "updatemovcomboBox";
            this.updatemovcomboBox.Size = new System.Drawing.Size(121, 22);
            this.updatemovcomboBox.TabIndex = 35;
            this.updatemovcomboBox.Text = "Movies Type";
            // 
            // updatemovtextBox
            // 
            this.updatemovtextBox.Enabled = false;
            this.updatemovtextBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatemovtextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.updatemovtextBox.Location = new System.Drawing.Point(10, 13);
            this.updatemovtextBox.Name = "updatemovtextBox";
            this.updatemovtextBox.Size = new System.Drawing.Size(121, 20);
            this.updatemovtextBox.TabIndex = 34;
            this.updatemovtextBox.Text = "movie name";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.UpdateButton.Location = new System.Drawing.Point(35, 196);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 32;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click_1);
            // 
            // selectUpButton
            // 
            this.selectUpButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.selectUpButton.Location = new System.Drawing.Point(36, 75);
            this.selectUpButton.Name = "selectUpButton";
            this.selectUpButton.Size = new System.Drawing.Size(75, 23);
            this.selectUpButton.TabIndex = 17;
            this.selectUpButton.Text = "Select";
            this.selectUpButton.UseVisualStyleBackColor = true;
            this.selectUpButton.Click += new System.EventHandler(this.selectUpButton_Click);
            // 
            // UpdateIDTextBox
            // 
            this.UpdateIDTextBox.Location = new System.Drawing.Point(13, 49);
            this.UpdateIDTextBox.Name = "UpdateIDTextBox";
            this.UpdateIDTextBox.Size = new System.Drawing.Size(130, 20);
            this.UpdateIDTextBox.TabIndex = 16;
            this.UpdateIDTextBox.Text = "Enter ID";
            this.UpdateIDTextBox.Enter += new System.EventHandler(this.UpdateIDTextBox_Enter);
            this.UpdateIDTextBox.Leave += new System.EventHandler(this.UpdateIDTextBox_Leave);
            // 
            // Updatelabel
            // 
            this.Updatelabel.AutoSize = true;
            this.Updatelabel.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Updatelabel.Location = new System.Drawing.Point(51, 16);
            this.Updatelabel.Name = "Updatelabel";
            this.Updatelabel.Size = new System.Drawing.Size(58, 18);
            this.Updatelabel.TabIndex = 15;
            this.Updatelabel.Text = "Update";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Namelabel.Location = new System.Drawing.Point(95, 9);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(41, 22);
            this.Namelabel.TabIndex = 5;
            this.Namelabel.Text = "Name";
            // 
            // Welcomelabel1
            // 
            this.Welcomelabel1.AutoSize = true;
            this.Welcomelabel1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Welcomelabel1.Location = new System.Drawing.Point(12, 9);
            this.Welcomelabel1.Name = "Welcomelabel1";
            this.Welcomelabel1.Size = new System.Drawing.Size(78, 18);
            this.Welcomelabel1.TabIndex = 4;
            this.Welcomelabel1.Text = "Welcome ";
            // 
            // logOutbutton
            // 
            this.logOutbutton.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.logOutbutton.Location = new System.Drawing.Point(305, 9);
            this.logOutbutton.Name = "logOutbutton";
            this.logOutbutton.Size = new System.Drawing.Size(58, 22);
            this.logOutbutton.TabIndex = 6;
            this.logOutbutton.Text = "Log Out";
            this.logOutbutton.UseVisualStyleBackColor = true;
            this.logOutbutton.Click += new System.EventHandler(this.logOutbutton_Click);
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 495);
            this.Controls.Add(this.Deletepanel);
            this.Controls.Add(this.logOutbutton);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.Welcomelabel1);
            this.Controls.Add(this.AddMoviePanel);
            this.Controls.Add(this.ProceduresGroupBox);
            this.Controls.Add(this.Updapanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminControl";
            this.Load += new System.EventHandler(this.AdminControl_Load);
            this.ProceduresGroupBox.ResumeLayout(false);
            this.ProceduresGroupBox.PerformLayout();
            this.AddMoviePanel.ResumeLayout(false);
            this.AddMoviePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviepictureBox)).EndInit();
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
        private System.Windows.Forms.PictureBox MoviepictureBox;
        private System.Windows.Forms.Label addPiclabel;
    }
}