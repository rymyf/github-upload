using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBookingSystem
{
    public partial class AdminControl : Form
    {

        user_ U;
        MovieBookingSystemEntities1 db = new MovieBookingSystemEntities1();

        public AdminControl(user_ u)
        {
            InitializeComponent();
            Namelabel.Text = u.firstName + " " + u.lastName;
            U = u;
        }

        // Enter Leave //
        private void MovieNameTextBox_Enter(object sender, EventArgs e)
        {
            if (MovieNameTextBox.Text == "movie name") {
                MovieNameTextBox.Text = "";
                MovieNameTextBox.ForeColor = Color.Black;
            }
        }

        private void MovieNameTextBox_Leave(object sender, EventArgs e)
        {
            if (MovieNameTextBox.Text == "")
            {
                MovieNameTextBox.Text = "movie name";
                MovieNameTextBox.ForeColor = Color.Gray;

            }
        }
        
        private void AvailableSeatstextBox_Enter(object sender, EventArgs e)
        {
            if (AvailableSeatstextBox.Text == "Available Seats")
            {
                AvailableSeatstextBox.Text = "";
                AvailableSeatstextBox.ForeColor = Color.Black;
            }
        }

        private void AvailableSeatstextBox_Leave(object sender, EventArgs e)
        {
            if (AvailableSeatstextBox.Text == "")
            {
                AvailableSeatstextBox.Text = "Available Seats";
                AvailableSeatstextBox.ForeColor = Color.Gray;

            }
        }
        
        private void DeleteTextBox_Enter(object sender, EventArgs e)
        {
            if (DeleteIDTextBox.Text == "Enter ID")
                DeleteIDTextBox.Text = "";
            
        }

        private void DeleteTextBox_Leave(object sender, EventArgs e)
        {
            if (DeleteIDTextBox.Text == "")
                DeleteIDTextBox.Text = "Enter ID";
        }

        // Enter Leave //

        private void DeleteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DeleteRadioButton.Checked)
            {
                Deletepanel.Visible = true;
            }
            else Deletepanel.Visible = false;
        }

        private void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AddRadioButton.Checked)
            {
                AddMoviePanel.Visible = true;
               
            }
            else AddMoviePanel.Visible = false;
        }

        private void UpdateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateRadioButton.Checked)
            {
                Updapanel.Visible = true;
            }
            else Updapanel.Visible = false;
        }


        private void AdminControl_Load(object sender, EventArgs e)
        {
            Deletepanel.Visible = false;
            Updapanel.Visible = false;

            Namelabel.Text = U.firstName + " " + U.lastName;

        }

        private void AddMoviebutton_Click(object sender, EventArgs e)
        {
           
            movie m = new movie();
            //m.cinema.cinemaName = CinemacomboBox.Text; // ناخذ اللي بعد المساواة ونحطها في الفلم لكن المشكلة مافي عامود لها في الداتابيس 
            m.movieName = MovieNameTextBox.Text;
            m.movieType = MovieTypecomboBox.SelectedItem.ToString();// !! 
            m.movieDate = dateTimePicker.Value;
            m.movieTime = TimeSpan.Parse(TimecomboBox.SelectedItem.ToString());
            

            int seats;
            try
            {
                seats = Convert.ToInt32(AvailableSeatstextBox.Text);
                m.availableSeat = seats;
                db.movie.Add(m);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("please Enter Correct Number of Seats!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private movie selectedMov = null;
        private void selectUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                var movs = from mov in db.movie select mov;
                
                foreach (var id in movs)
                {
                    if (id.movieID == Convert.ToInt32(UpdateIDTextBox.Text))
                    {
                        Selectpanel.Visible = true;
                        selectedMov = id;
                        goto EndSelect;
                    }

                }
                    MessageBox.Show("Invalid ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("please Enter Correct Number of ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        EndSelect:

            updatemovtextBox.Text = selectedMov.movieName;
            updatemovcomboBox.Text = selectedMov.movieType;
            updatedateTimePicker.Value = selectedMov.movieDate;
            updateTimecomboBox.Text = selectedMov.movieTime.ToString();
            updateseattextBox.Text =""+ selectedMov.availableSeat;

        }

        private void UpdateButton_Click_1(object sender, EventArgs e)
        { 
            //cinema c = new cinema();
            //c.cinemaName = CinemacomboBox.SelectedItem.ToString(); // ناخذ اللي بعد المساواة ونحطها في الفلم لكن المشكلة مافي عامود لها في الداتابيس 
            
           // Cinema Name && Connection PROBLEM !!!!!!!!!!!!!

            
            try
            {
                
                int seatsNo =  Convert.ToInt32(updateseattextBox.Text);
                int id = Convert.ToInt32(UpdateIDTextBox.Text);
                movie mov = db.movie.SingleOrDefault(x=>x.movieID == id);
                mov.movieName = updatemovtextBox.Text;
                mov.movieType = updatemovcomboBox.Text;
                mov.movieDate = updatedateTimePicker.Value;
                mov.movieTime = TimeSpan.Parse(updateTimecomboBox.Text);
                mov.availableSeat = seatsNo;
                db.SaveChanges();

                MessageBox.Show("Updated successfully :) ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + "please Enter Correct Number of Seats!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }

        private void SelectDButton_Click(object sender, EventArgs e)
        {
            try
            {
                var movs = from mov in db.movie select mov;

                foreach (var id in movs)
                {
                    if (id.movieID == Convert.ToInt32(DeleteIDTextBox.Text))
                    {
                        delPanel.Visible = true;
                        selectedMov = id;
                        goto EndSelect;
                    }

                }
                MessageBox.Show("Invalid ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("please Enter Correct Number of ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        EndSelect:

            CinemaNamelabel.Text = selectedMov.movieName;
            movieTypelabel.Text = selectedMov.movieType;
            movieDatelabel.Text = selectedMov.movieDate.ToShortDateString();
            movieTimelabel.Text = selectedMov.movieTime.ToString();
            movieAvSeatlabel.Text = "" + selectedMov.availableSeat;

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(DeleteIDTextBox.Text);
                movie mov = db.movie.SingleOrDefault(x => x.movieID == id);
                db.movie.Remove(mov);
                db.SaveChanges();
                MessageBox.Show("Deleted (:", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                delPanel.Visible = false;
            }
            catch(FormatException ex)
            {
                MessageBox.Show("please Enter Correct Number of ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logOutbutton_Click(object sender, EventArgs e)
        {

            Close();
            
           
            //WelcomeForm welcome = new WelcomeForm();
            //welcome.ShowDialog();
        }
    }
}
