using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

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
                if (db.movie.Any())
                {
                    int ID = db.movie.ToList().Last().movieID;
                    IDtextBox.Text = (ID + 1) + "";
                }
                else { IDtextBox.Text = "1"; }
               
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
            //cinema VOX = db.cinema.FirstOrDefault(X => X.cinemaID == 1);
            //cinema AMC = db.cinema.FirstOrDefault(X => X.cinemaID == 2);

            movie m = new movie();

            string cName=CinemacomboBox.Text; 
            
            m.movieName = MovieNameTextBox.Text;
            m.movieType = MovieTypecomboBox.SelectedItem.ToString();// !! 
            m.movieDate = dateTimePicker.Value;
            m.movieTime = TimeSpan.Parse(TimecomboBox.SelectedItem.ToString());
            
            

            int seats;
            try
            {
                // HERE PROBLEEM AFTER CLAEAR //
                seats = Convert.ToInt32(AvailableSeatstextBox.Text);
                m.availableSeat = seats;

                m.moviePicture = ImageToByteArray(MoviepictureBox.Image);

                db.cinema.FirstOrDefault(X => X.cinemaName == cName).movie.Add(m);
                db.SaveChanges();

               


                MessageBox.Show("Added Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
            }
            catch
            {
                MessageBox.Show("Please Enter Correct Number of seats ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto CATCH;
            }

            //clear
            MovieNameTextBox.Text = "movie name";
            MovieTypecomboBox.Text = "";
            dateTimePicker.Value = DateTime.Now;
            TimecomboBox.Text = "";
            AvailableSeatstextBox.Text = "Available Seats";
            MoviepictureBox.Image= MoviepictureBox.InitialImage;
            addPiclabel.Visible = true;
            CinemacomboBox.Text = "Cinema Name";

        CATCH:;

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
            try
            {
                CinemaNamelabel.Text = db.movie.SingleOrDefault(x => x.movieID == selectedMov.movieID).cinema.SingleOrDefault(x => x.cinemaID == x.cinemaID).cinemaName;
                movieNamelabel.Text = selectedMov.movieName;
                movieTypelabel.Text = selectedMov.movieType;
                movieDatelabel.Text = selectedMov.movieDate.ToShortDateString();
                movieTimelabel.Text = selectedMov.movieTime.ToString();
                movieAvSeatlabel.Text = "" + selectedMov.availableSeat;
            }
            catch {
                MessageBox.Show("There are no Tickets to delete! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(DeleteIDTextBox.Text);
                movie mov = db.movie.SingleOrDefault(x => x.movieID == id);

                string cName = CinemaNamelabel.Text;

                db.cinema.FirstOrDefault(X => X.cinemaName == cName).movie.Remove(mov);
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
        }

        private void DeleteLabel_Click(object sender, EventArgs e)
        {

        }

        private byte[] ImageToByteArray(System.Drawing.Image imageIn) {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        public static string location = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null) {
                open.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*gif|All Files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK) {
                    location = open.FileName.ToString();
                    p.Image = Image.FromFile(open.FileName);
                    p.ImageLocation = location;
                }
            }

            addPiclabel.Visible = false;
        }

        // Enter Leave //
        private void MovieNameTextBox_Enter(object sender, EventArgs e)
        {
            if (MovieNameTextBox.Text == "movie name")
            {
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
            DeleteIDTextBox.ForeColor = Color.Gray;
        }

       
        private void UpdateIDTextBox_Enter(object sender, EventArgs e)
        {
            if (UpdateIDTextBox.Text == "Enter ID")
                UpdateIDTextBox.Text = "";
        }

        private void UpdateIDTextBox_Leave(object sender, EventArgs e)
        {
            if (UpdateIDTextBox.Text == "")
                UpdateIDTextBox.Text = "Enter ID";
            UpdateIDTextBox.ForeColor = Color.Gray;
        }

        // Enter Leave //
    }
}
