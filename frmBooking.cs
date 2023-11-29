using BookingForm.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookingForm
{
    public partial class frmBooking : Form
    {
        void AddPeople(Button btnSender)
        {


            switch (btnSender.Tag.ToString())
            {
                case "Adults":
                    if (Convert.ToInt16(lblAdultNumbr.Text) == 19)
                    {
                        btnSender.Enabled = false;

                    }
                    btnMinusAdults.Enabled = true;
                    lblAdultNumbr.Text = (Convert.ToInt16(lblAdultNumbr.Text) + 1).ToString();
                    break;

                case "Children":
                    if (Convert.ToInt16(lblChildrenNumber.Text) == 19)
                    {
                        btnSender.Enabled = false;
                    }
                    btnMinusChildren.Enabled = true;
                    lblChildrenNumber.Text = (Convert.ToInt16(lblChildrenNumber.Text) + 1).ToString();
                    break;

                case "Rooms":
                    if (Convert.ToInt16(lblRoomsNumber.Text) == 19)
                    {
                        btnSender.Enabled = false;
                    }
                    btnMinusRooms.Enabled = true;
                    lblRoomsNumber.Text = (Convert.ToInt16(lblRoomsNumber.Text) + 1).ToString();
                    break;

                default:
                    break;
            }



        }
        void MinusPeople(Button btnSender)
        {
            switch (btnSender.Tag.ToString())
            {
                case "Adults":
                    if (Convert.ToInt16(lblAdultNumbr.Text) == 2)
                    {
                        btnSender.Enabled = false;
                    }
                    btnAddAdults.Enabled = true;
                    lblAdultNumbr.Text = (Convert.ToInt16(lblAdultNumbr.Text) - 1).ToString();
                    break;

                case "Children":
                    if (Convert.ToInt16(lblChildrenNumber.Text) == 1)
                    {
                        btnSender.Enabled = false;
                    }
                    btnAddChildren.Enabled = true;
                    lblChildrenNumber.Text = (Convert.ToInt16(lblChildrenNumber.Text) - 1).ToString();
                    break;

                case "Rooms":
                    if (Convert.ToInt16(lblRoomsNumber.Text) == 2)
                    {
                        btnSender.Enabled = false;
                    }
                    btnAddRooms.Enabled = true;
                    lblRoomsNumber.Text = (Convert.ToInt16(lblRoomsNumber.Text) - 1).ToString();
                    break;

                default:
                    break;

            }
        }

        void PrevPic()
        {
            switch (pbPictures.Tag.ToString())
            {
                case "1":
                    pbPictures.Image = Resources._3;
                    pbPictures.Tag = 3;
                    rb3.Select();
                    break;
                case "2":
                    pbPictures.Image = Resources._1;
                    pbPictures.Tag = 1;
                    rb1.Select();
                    break;
                case "3":
                    pbPictures.Image = Resources._2;
                    pbPictures.Tag = 2;
                    rb2.Select();
                    break;
                default:
                    break;

            }
        }
        void NextPic()
        {
            switch (pbPictures.Tag.ToString())
            {
                case "1":
                    pbPictures.Image = Resources._2;
                    pbPictures.Tag = 2;
                    rb2.Select();
                    break;
                case "2":
                    pbPictures.Image = Resources._3;
                    pbPictures.Tag = 3;
                    rb3.Select();
                    break;
                case "3":
                    pbPictures.Image = Resources._1;
                    pbPictures.Tag = 1;
                    rb1.Select();
                    break;
                default:
                    break;
            }
        }
        public frmBooking()
        {
            InitializeComponent();
        }


        private void btnNextPic_Click(object sender, EventArgs e)
        {

            NextPic();
        }
        private void btnPrevPic_Click(object sender, EventArgs e)
        {
            PrevPic();
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            mcPeriod.MinDate = mcPeriod.TodayDate;
            mcPeriod.Select();
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            switch (rb.Tag.ToString())
            {

                case "1":
                    pbPictures.Image = Resources._1;
                    pbPictures.Tag = 1;
                    break;

                case "2":
                    pbPictures.Image = Resources._2;
                    pbPictures.Tag = 2;
                    break;

                case "3":
                    pbPictures.Image = Resources._3;
                    pbPictures.Tag = 3;
                    break;
            }
        }


        private void mcPeriod_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblCheckIn.Text = mcPeriod.SelectionRange.Start.Year.ToString();
            lblCheckIn.Text += "/" + mcPeriod.SelectionRange.Start.Month.ToString();
            lblCheckIn.Text += "/" + mcPeriod.SelectionRange.Start.Day.ToString();
            lblCheckIn.Visible = true;
            lblCheckInTxt.Visible = true;

            lblCheckOut.Text = mcPeriod.SelectionRange.End.Year.ToString();
            lblCheckOut.Text += "/" + mcPeriod.SelectionRange.End.Month.ToString();
            lblCheckOut.Text += "/" + mcPeriod.SelectionRange.End.Day.ToString();
            lblCheckOut.Visible = true;
            lblCheckOutTxt.Visible = true;

            btnBook.Visible = true;
            btnBook.BackColor = Color.DeepSkyBlue;

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (!lblCheckIn.Visible)
            {
                MessageBox.Show("You have to check a period!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            mcPeriod.Enabled = false;
        }

        private void AddPeople_Click(object sender, EventArgs e)
        {
            AddPeople((Button)sender);
        }


        private void MinusPeople_Click(object sender, EventArgs e)
        {
            MinusPeople((Button)sender);
        }

        private void timerChangePic_Tick(object sender, EventArgs e)
        {
            NextPic();
        }
    }
}
