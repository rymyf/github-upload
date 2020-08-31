namespace MovieBookingSystem
{
    partial class Search
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
            this.Welcomelabel1 = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.MyMoviebutton = new System.Windows.Forms.Button();
            this.Cartbutton2 = new System.Windows.Forms.Button();
            this.AvailableMovieslabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBygroupBox = new System.Windows.Forms.GroupBox();
            this.DateradioButton = new System.Windows.Forms.RadioButton();
            this.CinNameradioButton = new System.Windows.Forms.RadioButton();
            this.MovieNameradioButton = new System.Windows.Forms.RadioButton();
            this.Datepanel = new System.Windows.Forms.Panel();
            this.SearchDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Datelabel2 = new System.Windows.Forms.Label();
            this.SearchDatebutton = new System.Windows.Forms.Button();
            this.Cinemapanel = new System.Windows.Forms.Panel();
            this.SearchCinbutton = new System.Windows.Forms.Button();
            this.CinemaNamecomboBox = new System.Windows.Forms.ComboBox();
            this.CinemaNamelabel2 = new System.Windows.Forms.Label();
            this.Moviepanel = new System.Windows.Forms.Panel();
            this.SearchMovbutton = new System.Windows.Forms.Button();
            this.MovieNametextBox = new System.Windows.Forms.TextBox();
            this.MovieNamelabel3 = new System.Windows.Forms.Label();
            this.SearchBygroupBox.SuspendLayout();
            this.Datepanel.SuspendLayout();
            this.Cinemapanel.SuspendLayout();
            this.Moviepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcomelabel1
            // 
            this.Welcomelabel1.AutoSize = true;
            this.Welcomelabel1.Location = new System.Drawing.Point(21, 20);
            this.Welcomelabel1.Name = "Welcomelabel1";
            this.Welcomelabel1.Size = new System.Drawing.Size(53, 13);
            this.Welcomelabel1.TabIndex = 0;
            this.Welcomelabel1.Text = "Welcome ";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(90, 20);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(34, 13);
            this.Namelabel.TabIndex = 1;
            this.Namelabel.Text = "Name";
            // 
            // MyMoviebutton
            // 
            this.MyMoviebutton.Location = new System.Drawing.Point(22, 55);
            this.MyMoviebutton.Name = "MyMoviebutton";
            this.MyMoviebutton.Size = new System.Drawing.Size(75, 23);
            this.MyMoviebutton.TabIndex = 2;
            this.MyMoviebutton.Text = "My Movies";
            this.MyMoviebutton.UseVisualStyleBackColor = true;
            this.MyMoviebutton.Click += new System.EventHandler(this.MyMoviebutton_Click);
            // 
            // Cartbutton2
            // 
            this.Cartbutton2.Location = new System.Drawing.Point(331, 15);
            this.Cartbutton2.Name = "Cartbutton2";
            this.Cartbutton2.Size = new System.Drawing.Size(46, 23);
            this.Cartbutton2.TabIndex = 3;
            this.Cartbutton2.Text = "Cart";
            this.Cartbutton2.UseVisualStyleBackColor = true;
            this.Cartbutton2.Click += new System.EventHandler(this.Cartbutton2_Click);
            // 
            // AvailableMovieslabel1
            // 
            this.AvailableMovieslabel1.AutoSize = true;
            this.AvailableMovieslabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableMovieslabel1.Location = new System.Drawing.Point(127, 83);
            this.AvailableMovieslabel1.Name = "AvailableMovieslabel1";
            this.AvailableMovieslabel1.Size = new System.Drawing.Size(170, 23);
            this.AvailableMovieslabel1.TabIndex = 5;
            this.AvailableMovieslabel1.Text = "Available Movies";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // SearchBygroupBox
            // 
            this.SearchBygroupBox.Controls.Add(this.MovieNameradioButton);
            this.SearchBygroupBox.Controls.Add(this.CinNameradioButton);
            this.SearchBygroupBox.Controls.Add(this.DateradioButton);
            this.SearchBygroupBox.Location = new System.Drawing.Point(34, 135);
            this.SearchBygroupBox.Name = "SearchBygroupBox";
            this.SearchBygroupBox.Size = new System.Drawing.Size(343, 60);
            this.SearchBygroupBox.TabIndex = 15;
            this.SearchBygroupBox.TabStop = false;
            this.SearchBygroupBox.Text = "Search By";
            // 
            // DateradioButton
            // 
            this.DateradioButton.AutoSize = true;
            this.DateradioButton.Location = new System.Drawing.Point(15, 28);
            this.DateradioButton.Name = "DateradioButton";
            this.DateradioButton.Size = new System.Drawing.Size(48, 17);
            this.DateradioButton.TabIndex = 0;
            this.DateradioButton.TabStop = true;
            this.DateradioButton.Text = "Date";
            this.DateradioButton.UseVisualStyleBackColor = true;
            this.DateradioButton.CheckedChanged += new System.EventHandler(this.DateradioButton_CheckedChanged);
            // 
            // CinNameradioButton
            // 
            this.CinNameradioButton.AutoSize = true;
            this.CinNameradioButton.Location = new System.Drawing.Point(100, 28);
            this.CinNameradioButton.Name = "CinNameradioButton";
            this.CinNameradioButton.Size = new System.Drawing.Size(90, 17);
            this.CinNameradioButton.TabIndex = 1;
            this.CinNameradioButton.TabStop = true;
            this.CinNameradioButton.Text = "Cinema Name";
            this.CinNameradioButton.UseVisualStyleBackColor = true;
            this.CinNameradioButton.CheckedChanged += new System.EventHandler(this.CinNameradioButton_CheckedChanged);
            // 
            // MovieNameradioButton
            // 
            this.MovieNameradioButton.AutoSize = true;
            this.MovieNameradioButton.Location = new System.Drawing.Point(217, 28);
            this.MovieNameradioButton.Name = "MovieNameradioButton";
            this.MovieNameradioButton.Size = new System.Drawing.Size(83, 17);
            this.MovieNameradioButton.TabIndex = 2;
            this.MovieNameradioButton.TabStop = true;
            this.MovieNameradioButton.Text = "Movie Name";
            this.MovieNameradioButton.UseVisualStyleBackColor = true;
            this.MovieNameradioButton.CheckedChanged += new System.EventHandler(this.MovieNameradioButton_CheckedChanged);
            // 
            // Datepanel
            // 
            this.Datepanel.Controls.Add(this.SearchDateTimePicker);
            this.Datepanel.Controls.Add(this.Datelabel2);
            this.Datepanel.Controls.Add(this.SearchDatebutton);
            this.Datepanel.Location = new System.Drawing.Point(24, 235);
            this.Datepanel.Name = "Datepanel";
            this.Datepanel.Size = new System.Drawing.Size(158, 108);
            this.Datepanel.TabIndex = 16;
            // 
            // SearchDateTimePicker
            // 
            this.SearchDateTimePicker.Location = new System.Drawing.Point(13, 31);
            this.SearchDateTimePicker.Name = "SearchDateTimePicker";
            this.SearchDateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.SearchDateTimePicker.TabIndex = 15;
            // 
            // Datelabel2
            // 
            this.Datelabel2.AutoSize = true;
            this.Datelabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel2.Location = new System.Drawing.Point(53, 15);
            this.Datelabel2.Name = "Datelabel2";
            this.Datelabel2.Size = new System.Drawing.Size(36, 14);
            this.Datelabel2.TabIndex = 14;
            this.Datelabel2.Text = "Date";
            // 
            // SearchDatebutton
            // 
            this.SearchDatebutton.Location = new System.Drawing.Point(45, 73);
            this.SearchDatebutton.Name = "SearchDatebutton";
            this.SearchDatebutton.Size = new System.Drawing.Size(75, 23);
            this.SearchDatebutton.TabIndex = 13;
            this.SearchDatebutton.Tag = "date";
            this.SearchDatebutton.Text = "Search";
            this.SearchDatebutton.UseVisualStyleBackColor = true;
            this.SearchDatebutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // Cinemapanel
            // 
            this.Cinemapanel.Controls.Add(this.SearchCinbutton);
            this.Cinemapanel.Controls.Add(this.CinemaNamecomboBox);
            this.Cinemapanel.Controls.Add(this.CinemaNamelabel2);
            this.Cinemapanel.Location = new System.Drawing.Point(188, 235);
            this.Cinemapanel.Name = "Cinemapanel";
            this.Cinemapanel.Size = new System.Drawing.Size(135, 108);
            this.Cinemapanel.TabIndex = 17;
            // 
            // SearchCinbutton
            // 
            this.SearchCinbutton.Location = new System.Drawing.Point(34, 73);
            this.SearchCinbutton.Name = "SearchCinbutton";
            this.SearchCinbutton.Size = new System.Drawing.Size(75, 23);
            this.SearchCinbutton.TabIndex = 16;
            this.SearchCinbutton.Tag = "cinema";
            this.SearchCinbutton.Text = "Search";
            this.SearchCinbutton.UseVisualStyleBackColor = true;
            this.SearchCinbutton.Click += new System.EventHandler(this.SearchCinbutton_Click);
            // 
            // CinemaNamecomboBox
            // 
            this.CinemaNamecomboBox.FormattingEnabled = true;
            this.CinemaNamecomboBox.Items.AddRange(new object[] {
            " VOX Cinema",
            "AMC Cinema"});
            this.CinemaNamecomboBox.Location = new System.Drawing.Point(8, 31);
            this.CinemaNamecomboBox.Name = "CinemaNamecomboBox";
            this.CinemaNamecomboBox.Size = new System.Drawing.Size(121, 21);
            this.CinemaNamecomboBox.TabIndex = 15;
            // 
            // CinemaNamelabel2
            // 
            this.CinemaNamelabel2.AutoSize = true;
            this.CinemaNamelabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CinemaNamelabel2.Location = new System.Drawing.Point(31, 15);
            this.CinemaNamelabel2.Name = "CinemaNamelabel2";
            this.CinemaNamelabel2.Size = new System.Drawing.Size(88, 14);
            this.CinemaNamelabel2.TabIndex = 14;
            this.CinemaNamelabel2.Text = "Cinema Name";
            // 
            // Moviepanel
            // 
            this.Moviepanel.Controls.Add(this.SearchMovbutton);
            this.Moviepanel.Controls.Add(this.MovieNametextBox);
            this.Moviepanel.Controls.Add(this.MovieNamelabel3);
            this.Moviepanel.Location = new System.Drawing.Point(330, 235);
            this.Moviepanel.Name = "Moviepanel";
            this.Moviepanel.Size = new System.Drawing.Size(162, 108);
            this.Moviepanel.TabIndex = 18;
            // 
            // SearchMovbutton
            // 
            this.SearchMovbutton.Location = new System.Drawing.Point(43, 72);
            this.SearchMovbutton.Name = "SearchMovbutton";
            this.SearchMovbutton.Size = new System.Drawing.Size(75, 23);
            this.SearchMovbutton.TabIndex = 17;
            this.SearchMovbutton.Tag = "movie";
            this.SearchMovbutton.Text = "Search";
            this.SearchMovbutton.UseVisualStyleBackColor = true;
            // 
            // MovieNametextBox
            // 
            this.MovieNametextBox.Location = new System.Drawing.Point(31, 30);
            this.MovieNametextBox.Name = "MovieNametextBox";
            this.MovieNametextBox.Size = new System.Drawing.Size(100, 20);
            this.MovieNametextBox.TabIndex = 16;
            // 
            // MovieNamelabel3
            // 
            this.MovieNamelabel3.AutoSize = true;
            this.MovieNamelabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieNamelabel3.Location = new System.Drawing.Point(40, 14);
            this.MovieNamelabel3.Name = "MovieNamelabel3";
            this.MovieNamelabel3.Size = new System.Drawing.Size(80, 14);
            this.MovieNamelabel3.TabIndex = 15;
            this.MovieNamelabel3.Text = "Movie Name";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(528, 364);
            this.Controls.Add(this.Moviepanel);
            this.Controls.Add(this.Cinemapanel);
            this.Controls.Add(this.Datepanel);
            this.Controls.Add(this.SearchBygroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AvailableMovieslabel1);
            this.Controls.Add(this.Cartbutton2);
            this.Controls.Add(this.MyMoviebutton);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.Welcomelabel1);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Booking System";
            this.SearchBygroupBox.ResumeLayout(false);
            this.SearchBygroupBox.PerformLayout();
            this.Datepanel.ResumeLayout(false);
            this.Datepanel.PerformLayout();
            this.Cinemapanel.ResumeLayout(false);
            this.Cinemapanel.PerformLayout();
            this.Moviepanel.ResumeLayout(false);
            this.Moviepanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcomelabel1;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Button MyMoviebutton;
        private System.Windows.Forms.Button Cartbutton2;
        private System.Windows.Forms.Label AvailableMovieslabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox SearchBygroupBox;
        private System.Windows.Forms.RadioButton MovieNameradioButton;
        private System.Windows.Forms.RadioButton CinNameradioButton;
        private System.Windows.Forms.RadioButton DateradioButton;
        private System.Windows.Forms.Panel Datepanel;
        private System.Windows.Forms.DateTimePicker SearchDateTimePicker;
        private System.Windows.Forms.Label Datelabel2;
        private System.Windows.Forms.Button SearchDatebutton;
        private System.Windows.Forms.Panel Cinemapanel;
        private System.Windows.Forms.Button SearchCinbutton;
        private System.Windows.Forms.ComboBox CinemaNamecomboBox;
        private System.Windows.Forms.Label CinemaNamelabel2;
        private System.Windows.Forms.Panel Moviepanel;
        private System.Windows.Forms.Button SearchMovbutton;
        private System.Windows.Forms.TextBox MovieNametextBox;
        private System.Windows.Forms.Label MovieNamelabel3;
    }
}