namespace BookingForm
{
    partial class frmBooking
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
            this.components = new System.ComponentModel.Container();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.btnNextPic = new System.Windows.Forms.Button();
            this.btnPrevPic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mcPeriod = new System.Windows.Forms.MonthCalendar();
            this.l = new System.Windows.Forms.Label();
            this.lblCheckInTxt = new System.Windows.Forms.Label();
            this.lblCheckOutTxt = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.pbPictures = new System.Windows.Forms.PictureBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMinusRooms = new System.Windows.Forms.Button();
            this.btnAddRooms = new System.Windows.Forms.Button();
            this.lblRoomsNumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMinusChildren = new System.Windows.Forms.Button();
            this.btnAddChildren = new System.Windows.Forms.Button();
            this.lblChildrenNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMinusAdults = new System.Windows.Forms.Button();
            this.btnAddAdults = new System.Windows.Forms.Button();
            this.lblAdultNumbr = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timerChangePic = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPictures)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.rb1.FlatAppearance.BorderSize = 3;
            this.rb1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.rb1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.rb1.Location = new System.Drawing.Point(794, 370);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(14, 13);
            this.rb1.TabIndex = 1;
            this.rb1.TabStop = true;
            this.rb1.Tag = "1";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.rb2.FlatAppearance.BorderSize = 3;
            this.rb2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.rb2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.rb2.Location = new System.Drawing.Point(828, 370);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(14, 13);
            this.rb2.TabIndex = 2;
            this.rb2.Tag = "2";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.rb3.FlatAppearance.BorderSize = 3;
            this.rb3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.rb3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.rb3.Location = new System.Drawing.Point(862, 370);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(14, 13);
            this.rb3.TabIndex = 3;
            this.rb3.Tag = "3";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // btnNextPic
            // 
            this.btnNextPic.FlatAppearance.BorderSize = 0;
            this.btnNextPic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNextPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnNextPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPic.Location = new System.Drawing.Point(1167, 180);
            this.btnNextPic.Name = "btnNextPic";
            this.btnNextPic.Size = new System.Drawing.Size(77, 74);
            this.btnNextPic.TabIndex = 4;
            this.btnNextPic.Text = ">";
            this.btnNextPic.UseVisualStyleBackColor = true;
            this.btnNextPic.Click += new System.EventHandler(this.btnNextPic_Click);
            // 
            // btnPrevPic
            // 
            this.btnPrevPic.FlatAppearance.BorderSize = 0;
            this.btnPrevPic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrevPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnPrevPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevPic.Location = new System.Drawing.Point(426, 180);
            this.btnPrevPic.Name = "btnPrevPic";
            this.btnPrevPic.Size = new System.Drawing.Size(77, 74);
            this.btnPrevPic.TabIndex = 5;
            this.btnPrevPic.Text = "<";
            this.btnPrevPic.UseVisualStyleBackColor = true;
            this.btnPrevPic.Click += new System.EventHandler(this.btnPrevPic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Al Mokhtara Diamond";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "★★★";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(31, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 100);
            this.label3.TabIndex = 8;
            this.label3.Text = "hotel aswer, Al Haram, Al-Madinah al-Munawwarah 42311, Al Madinah, Saudi Arabia –" +
    "";
            // 
            // mcPeriod
            // 
            this.mcPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcPeriod.Location = new System.Drawing.Point(38, 262);
            this.mcPeriod.MinDate = new System.DateTime(2023, 11, 28, 0, 0, 0, 0);
            this.mcPeriod.Name = "mcPeriod";
            this.mcPeriod.ShowTodayCircle = false;
            this.mcPeriod.TabIndex = 9;
            this.mcPeriod.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcPeriod_DateChanged);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(11, 225);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(200, 28);
            this.l.TabIndex = 10;
            this.l.Text = "Check Your Period:";
            // 
            // lblCheckInTxt
            // 
            this.lblCheckInTxt.AutoSize = true;
            this.lblCheckInTxt.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInTxt.Location = new System.Drawing.Point(32, 453);
            this.lblCheckInTxt.Name = "lblCheckInTxt";
            this.lblCheckInTxt.Size = new System.Drawing.Size(181, 31);
            this.lblCheckInTxt.TabIndex = 12;
            this.lblCheckInTxt.Text = "Check in date :";
            this.lblCheckInTxt.Visible = false;
            // 
            // lblCheckOutTxt
            // 
            this.lblCheckOutTxt.AutoSize = true;
            this.lblCheckOutTxt.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutTxt.Location = new System.Drawing.Point(32, 497);
            this.lblCheckOutTxt.Name = "lblCheckOutTxt";
            this.lblCheckOutTxt.Size = new System.Drawing.Size(198, 31);
            this.lblCheckOutTxt.TabIndex = 13;
            this.lblCheckOutTxt.Text = "Check out date :";
            this.lblCheckOutTxt.Visible = false;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblCheckIn.Location = new System.Drawing.Point(219, 455);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(58, 29);
            this.lblCheckIn.TabIndex = 14;
            this.lblCheckIn.Text = "date";
            this.lblCheckIn.Visible = false;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblCheckOut.Location = new System.Drawing.Point(236, 499);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(58, 29);
            this.lblCheckOut.TabIndex = 15;
            this.lblCheckOut.Text = "date";
            this.lblCheckOut.Visible = false;
            // 
            // pbPictures
            // 
            this.pbPictures.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbPictures.Image = global::BookingForm.Properties.Resources._1;
            this.pbPictures.Location = new System.Drawing.Point(532, 53);
            this.pbPictures.Name = "pbPictures";
            this.pbPictures.Size = new System.Drawing.Size(606, 308);
            this.pbPictures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPictures.TabIndex = 0;
            this.pbPictures.TabStop = false;
            this.pbPictures.Tag = "1";
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(496, 508);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(110, 46);
            this.btnBook.TabIndex = 16;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMinusRooms);
            this.groupBox1.Controls.Add(this.btnAddRooms);
            this.groupBox1.Controls.Add(this.lblRoomsNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnMinusChildren);
            this.groupBox1.Controls.Add(this.btnAddChildren);
            this.groupBox1.Controls.Add(this.lblChildrenNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnMinusAdults);
            this.groupBox1.Controls.Add(this.btnAddAdults);
            this.groupBox1.Controls.Add(this.lblAdultNumbr);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(794, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 151);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Book Detiles";
            // 
            // btnMinusRooms
            // 
            this.btnMinusRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinusRooms.Enabled = false;
            this.btnMinusRooms.FlatAppearance.BorderSize = 0;
            this.btnMinusRooms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMinusRooms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnMinusRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinusRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusRooms.ForeColor = System.Drawing.Color.Black;
            this.btnMinusRooms.Location = new System.Drawing.Point(175, 89);
            this.btnMinusRooms.Name = "btnMinusRooms";
            this.btnMinusRooms.Size = new System.Drawing.Size(26, 35);
            this.btnMinusRooms.TabIndex = 29;
            this.btnMinusRooms.Tag = "Rooms";
            this.btnMinusRooms.Text = "-";
            this.btnMinusRooms.UseVisualStyleBackColor = true;
            this.btnMinusRooms.Click += new System.EventHandler(this.MinusPeople_Click);
            // 
            // btnAddRooms
            // 
            this.btnAddRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRooms.FlatAppearance.BorderSize = 0;
            this.btnAddRooms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddRooms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnAddRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRooms.ForeColor = System.Drawing.Color.Black;
            this.btnAddRooms.Location = new System.Drawing.Point(260, 90);
            this.btnAddRooms.Name = "btnAddRooms";
            this.btnAddRooms.Size = new System.Drawing.Size(26, 35);
            this.btnAddRooms.TabIndex = 28;
            this.btnAddRooms.Tag = "Rooms";
            this.btnAddRooms.Text = "+";
            this.btnAddRooms.UseVisualStyleBackColor = true;
            this.btnAddRooms.Click += new System.EventHandler(this.AddPeople_Click);
            // 
            // lblRoomsNumber
            // 
            this.lblRoomsNumber.AutoSize = true;
            this.lblRoomsNumber.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomsNumber.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblRoomsNumber.Location = new System.Drawing.Point(216, 95);
            this.lblRoomsNumber.Name = "lblRoomsNumber";
            this.lblRoomsNumber.Size = new System.Drawing.Size(21, 26);
            this.lblRoomsNumber.TabIndex = 27;
            this.lblRoomsNumber.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(28, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Rooms";
            // 
            // btnMinusChildren
            // 
            this.btnMinusChildren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinusChildren.Enabled = false;
            this.btnMinusChildren.FlatAppearance.BorderSize = 0;
            this.btnMinusChildren.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMinusChildren.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnMinusChildren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinusChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusChildren.ForeColor = System.Drawing.Color.Black;
            this.btnMinusChildren.Location = new System.Drawing.Point(175, 59);
            this.btnMinusChildren.Name = "btnMinusChildren";
            this.btnMinusChildren.Size = new System.Drawing.Size(26, 35);
            this.btnMinusChildren.TabIndex = 25;
            this.btnMinusChildren.Tag = "Children";
            this.btnMinusChildren.Text = "-";
            this.btnMinusChildren.UseVisualStyleBackColor = true;
            this.btnMinusChildren.Click += new System.EventHandler(this.MinusPeople_Click);
            // 
            // btnAddChildren
            // 
            this.btnAddChildren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddChildren.FlatAppearance.BorderSize = 0;
            this.btnAddChildren.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddChildren.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnAddChildren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChildren.ForeColor = System.Drawing.Color.Black;
            this.btnAddChildren.Location = new System.Drawing.Point(260, 60);
            this.btnAddChildren.Name = "btnAddChildren";
            this.btnAddChildren.Size = new System.Drawing.Size(26, 35);
            this.btnAddChildren.TabIndex = 24;
            this.btnAddChildren.Tag = "Children";
            this.btnAddChildren.Text = "+";
            this.btnAddChildren.UseVisualStyleBackColor = true;
            this.btnAddChildren.Click += new System.EventHandler(this.AddPeople_Click);
            // 
            // lblChildrenNumber
            // 
            this.lblChildrenNumber.AutoSize = true;
            this.lblChildrenNumber.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildrenNumber.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblChildrenNumber.Location = new System.Drawing.Point(216, 65);
            this.lblChildrenNumber.Name = "lblChildrenNumber";
            this.lblChildrenNumber.Size = new System.Drawing.Size(24, 26);
            this.lblChildrenNumber.TabIndex = 23;
            this.lblChildrenNumber.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(28, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Children";
            // 
            // btnMinusAdults
            // 
            this.btnMinusAdults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinusAdults.Enabled = false;
            this.btnMinusAdults.FlatAppearance.BorderSize = 0;
            this.btnMinusAdults.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMinusAdults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnMinusAdults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinusAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusAdults.ForeColor = System.Drawing.Color.Black;
            this.btnMinusAdults.Location = new System.Drawing.Point(175, 23);
            this.btnMinusAdults.Name = "btnMinusAdults";
            this.btnMinusAdults.Size = new System.Drawing.Size(26, 35);
            this.btnMinusAdults.TabIndex = 21;
            this.btnMinusAdults.Tag = "Adults";
            this.btnMinusAdults.Text = "-";
            this.btnMinusAdults.UseVisualStyleBackColor = true;
            this.btnMinusAdults.Click += new System.EventHandler(this.MinusPeople_Click);
            // 
            // btnAddAdults
            // 
            this.btnAddAdults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAdults.FlatAppearance.BorderSize = 0;
            this.btnAddAdults.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddAdults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnAddAdults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdults.ForeColor = System.Drawing.Color.Black;
            this.btnAddAdults.Location = new System.Drawing.Point(260, 24);
            this.btnAddAdults.Name = "btnAddAdults";
            this.btnAddAdults.Size = new System.Drawing.Size(26, 35);
            this.btnAddAdults.TabIndex = 20;
            this.btnAddAdults.Tag = "Adults";
            this.btnAddAdults.Text = "+";
            this.btnAddAdults.UseVisualStyleBackColor = true;
            this.btnAddAdults.Click += new System.EventHandler(this.AddPeople_Click);
            // 
            // lblAdultNumbr
            // 
            this.lblAdultNumbr.AutoSize = true;
            this.lblAdultNumbr.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdultNumbr.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblAdultNumbr.Location = new System.Drawing.Point(216, 29);
            this.lblAdultNumbr.Name = "lblAdultNumbr";
            this.lblAdultNumbr.Size = new System.Drawing.Size(21, 26);
            this.lblAdultNumbr.TabIndex = 19;
            this.lblAdultNumbr.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Adults";
            // 
            // timerChangePic
            // 
            this.timerChangePic.Enabled = true;
            this.timerChangePic.Interval = 3000;
            this.timerChangePic.Tick += new System.EventHandler(this.timerChangePic_Tick);
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 588);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.lblCheckOutTxt);
            this.Controls.Add(this.lblCheckInTxt);
            this.Controls.Add(this.l);
            this.Controls.Add(this.mcPeriod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrevPic);
            this.Controls.Add(this.btnNextPic);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.pbPictures);
            this.Name = "frmBooking";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.frmBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPictures)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPictures;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.Button btnNextPic;
        private System.Windows.Forms.Button btnPrevPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar mcPeriod;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label lblCheckInTxt;
        private System.Windows.Forms.Label lblCheckOutTxt;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMinusAdults;
        private System.Windows.Forms.Button btnAddAdults;
        private System.Windows.Forms.Label lblAdultNumbr;
        private System.Windows.Forms.Button btnMinusChildren;
        private System.Windows.Forms.Button btnAddChildren;
        private System.Windows.Forms.Label lblChildrenNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMinusRooms;
        private System.Windows.Forms.Button btnAddRooms;
        private System.Windows.Forms.Label lblRoomsNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timerChangePic;
    }
}

