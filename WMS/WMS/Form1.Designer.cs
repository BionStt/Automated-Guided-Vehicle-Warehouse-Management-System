namespace WMS
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btn_page2 = new System.Windows.Forms.Button();
            this.btn_page1 = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.button_mini = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.tracer_stat = new MetroFramework.Controls.MetroTabControl();
            this.stat_page1 = new MetroFramework.Controls.MetroTabPage();
            this.lbl_tracer2_stat = new System.Windows.Forms.Label();
            this.lbl_tracer1_stat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stat_page2 = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inventory = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.lbl_today_notgood = new System.Windows.Forms.Label();
            this.lbl_today_good = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_today = new System.Windows.Forms.Label();
            this.lbl_notgood_num = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_good_num = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.lbl_record_notgood = new System.Windows.Forms.Label();
            this.lbl_record_good = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SidePanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.HeadPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tracer_stat.SuspendLayout();
            this.stat_page1.SuspendLayout();
            this.stat_page2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.inventory.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.SidePanel.Controls.Add(this.btn_page2);
            this.SidePanel.Controls.Add(this.btn_page1);
            this.SidePanel.Controls.Add(this.LogoPanel);
            this.SidePanel.Location = new System.Drawing.Point(2, 2);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(181, 442);
            this.SidePanel.TabIndex = 0;
            // 
            // btn_page2
            // 
            this.btn_page2.Location = new System.Drawing.Point(0, 196);
            this.btn_page2.Name = "btn_page2";
            this.btn_page2.Size = new System.Drawing.Size(176, 63);
            this.btn_page2.TabIndex = 4;
            this.btn_page2.Text = "라인트레이서 상태";
            this.btn_page2.UseVisualStyleBackColor = true;
            this.btn_page2.Click += new System.EventHandler(this.btn_page2_Click);
            // 
            // btn_page1
            // 
            this.btn_page1.Location = new System.Drawing.Point(0, 108);
            this.btn_page1.Name = "btn_page1";
            this.btn_page1.Size = new System.Drawing.Size(177, 62);
            this.btn_page1.TabIndex = 3;
            this.btn_page1.Text = "재고 현황";
            this.btn_page1.UseVisualStyleBackColor = true;
            this.btn_page1.Click += new System.EventHandler(this.btn_page1_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.SlateGray;
            this.LogoPanel.Controls.Add(this.label1);
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(178, 68);
            this.LogoPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "창고 관리 시스템";
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.Color.DarkGray;
            this.HeadPanel.Controls.Add(this.button_mini);
            this.HeadPanel.Controls.Add(this.button_exit);
            this.HeadPanel.Controls.Add(this.User);
            this.HeadPanel.Location = new System.Drawing.Point(185, 3);
            this.HeadPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(733, 68);
            this.HeadPanel.TabIndex = 1;
            // 
            // button_mini
            // 
            this.button_mini.Location = new System.Drawing.Point(678, 10);
            this.button_mini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_mini.Name = "button_mini";
            this.button_mini.Size = new System.Drawing.Size(18, 18);
            this.button_mini.TabIndex = 2;
            this.button_mini.Text = "_";
            this.button_mini.UseVisualStyleBackColor = true;
            this.button_mini.Click += new System.EventHandler(this.button_mini_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(702, 10);
            this.button_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(19, 19);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("굴림", 30F);
            this.User.Location = new System.Drawing.Point(23, 12);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(102, 40);
            this.User.TabIndex = 0;
            this.User.Text = "User";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tracer_stat);
            this.panel2.Location = new System.Drawing.Point(188, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 369);
            this.panel2.TabIndex = 7;
            // 
            // tracer_stat
            // 
            this.tracer_stat.Controls.Add(this.stat_page1);
            this.tracer_stat.Controls.Add(this.stat_page2);
            this.tracer_stat.Location = new System.Drawing.Point(4, 3);
            this.tracer_stat.Name = "tracer_stat";
            this.tracer_stat.SelectedIndex = 0;
            this.tracer_stat.Size = new System.Drawing.Size(725, 363);
            this.tracer_stat.TabIndex = 0;
            this.tracer_stat.UseSelectable = true;
            // 
            // stat_page1
            // 
            this.stat_page1.Controls.Add(this.lbl_tracer2_stat);
            this.stat_page1.Controls.Add(this.lbl_tracer1_stat);
            this.stat_page1.Controls.Add(this.label5);
            this.stat_page1.Controls.Add(this.label4);
            this.stat_page1.HorizontalScrollbarBarColor = true;
            this.stat_page1.HorizontalScrollbarHighlightOnWheel = false;
            this.stat_page1.HorizontalScrollbarSize = 10;
            this.stat_page1.Location = new System.Drawing.Point(4, 38);
            this.stat_page1.Name = "stat_page1";
            this.stat_page1.Size = new System.Drawing.Size(717, 321);
            this.stat_page1.TabIndex = 0;
            this.stat_page1.Text = "전체";
            this.stat_page1.VerticalScrollbarBarColor = true;
            this.stat_page1.VerticalScrollbarHighlightOnWheel = false;
            this.stat_page1.VerticalScrollbarSize = 10;
            // 
            // lbl_tracer2_stat
            // 
            this.lbl_tracer2_stat.AutoSize = true;
            this.lbl_tracer2_stat.Font = new System.Drawing.Font("굴림", 20F);
            this.lbl_tracer2_stat.Location = new System.Drawing.Point(324, 90);
            this.lbl_tracer2_stat.Name = "lbl_tracer2_stat";
            this.lbl_tracer2_stat.Size = new System.Drawing.Size(273, 27);
            this.lbl_tracer2_stat.TabIndex = 5;
            this.lbl_tracer2_stat.Text = "(라인트레이서2 상태)";
            // 
            // lbl_tracer1_stat
            // 
            this.lbl_tracer1_stat.AutoSize = true;
            this.lbl_tracer1_stat.Font = new System.Drawing.Font("굴림", 20F);
            this.lbl_tracer1_stat.Location = new System.Drawing.Point(324, 37);
            this.lbl_tracer1_stat.Name = "lbl_tracer1_stat";
            this.lbl_tracer1_stat.Size = new System.Drawing.Size(273, 27);
            this.lbl_tracer1_stat.TabIndex = 4;
            this.lbl_tracer1_stat.Text = "(라인트레이서1 상태)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 20F);
            this.label5.Location = new System.Drawing.Point(38, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "라인트레이서 2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 20F);
            this.label4.Location = new System.Drawing.Point(38, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "라인트레이서 1 :";
            // 
            // stat_page2
            // 
            this.stat_page2.Controls.Add(this.pictureBox1);
            this.stat_page2.HorizontalScrollbarBarColor = true;
            this.stat_page2.HorizontalScrollbarHighlightOnWheel = false;
            this.stat_page2.HorizontalScrollbarSize = 10;
            this.stat_page2.Location = new System.Drawing.Point(4, 38);
            this.stat_page2.Name = "stat_page2";
            this.stat_page2.Size = new System.Drawing.Size(717, 321);
            this.stat_page2.TabIndex = 1;
            this.stat_page2.Text = "경로";
            this.stat_page2.VerticalScrollbarBarColor = true;
            this.stat_page2.VerticalScrollbarHighlightOnWheel = false;
            this.stat_page2.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(126, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.inventory);
            this.panel1.Location = new System.Drawing.Point(188, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 373);
            this.panel1.TabIndex = 8;
            // 
            // inventory
            // 
            this.inventory.Controls.Add(this.metroTabPage1);
            this.inventory.Controls.Add(this.metroTabPage2);
            this.inventory.Location = new System.Drawing.Point(5, 6);
            this.inventory.Name = "inventory";
            this.inventory.SelectedIndex = 0;
            this.inventory.Size = new System.Drawing.Size(722, 357);
            this.inventory.TabIndex = 0;
            this.inventory.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.lbl_today_notgood);
            this.metroTabPage1.Controls.Add(this.lbl_today_good);
            this.metroTabPage1.Controls.Add(this.label7);
            this.metroTabPage1.Controls.Add(this.label6);
            this.metroTabPage1.Controls.Add(this.lbl_today);
            this.metroTabPage1.Controls.Add(this.lbl_notgood_num);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.lbl_good_num);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(714, 315);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "현재";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // lbl_today_notgood
            // 
            this.lbl_today_notgood.AutoSize = true;
            this.lbl_today_notgood.Font = new System.Drawing.Font("굴림", 15F);
            this.lbl_today_notgood.Location = new System.Drawing.Point(276, 239);
            this.lbl_today_notgood.Name = "lbl_today_notgood";
            this.lbl_today_notgood.Size = new System.Drawing.Size(175, 20);
            this.lbl_today_notgood.TabIndex = 10;
            this.lbl_today_notgood.Text = "(금일 불량품 개수)";
            // 
            // lbl_today_good
            // 
            this.lbl_today_good.AutoSize = true;
            this.lbl_today_good.Font = new System.Drawing.Font("굴림", 15F);
            this.lbl_today_good.Location = new System.Drawing.Point(276, 197);
            this.lbl_today_good.Name = "lbl_today_good";
            this.lbl_today_good.Size = new System.Drawing.Size(155, 20);
            this.lbl_today_good.TabIndex = 9;
            this.lbl_today_good.Text = "(금일 양품 개수)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 15F);
            this.label7.Location = new System.Drawing.Point(39, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "금일 불량품 개수:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 15F);
            this.label6.Location = new System.Drawing.Point(39, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "금일 양품 개수   :";
            // 
            // lbl_today
            // 
            this.lbl_today.AutoSize = true;
            this.lbl_today.Font = new System.Drawing.Font("굴림", 15F);
            this.lbl_today.Location = new System.Drawing.Point(41, 151);
            this.lbl_today.Name = "lbl_today";
            this.lbl_today.Size = new System.Drawing.Size(101, 20);
            this.lbl_today.TabIndex = 6;
            this.lbl_today.Text = "(오늘날짜)";
            // 
            // lbl_notgood_num
            // 
            this.lbl_notgood_num.AutoSize = true;
            this.lbl_notgood_num.Font = new System.Drawing.Font("굴림", 20F);
            this.lbl_notgood_num.Location = new System.Drawing.Point(313, 94);
            this.lbl_notgood_num.Name = "lbl_notgood_num";
            this.lbl_notgood_num.Size = new System.Drawing.Size(239, 27);
            this.lbl_notgood_num.TabIndex = 5;
            this.lbl_notgood_num.Text = "(전체 불량품 개수)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 20F);
            this.label3.Location = new System.Drawing.Point(38, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "전체 불량품 개수:";
            // 
            // lbl_good_num
            // 
            this.lbl_good_num.AutoSize = true;
            this.lbl_good_num.Font = new System.Drawing.Font("굴림", 20F);
            this.lbl_good_num.Location = new System.Drawing.Point(313, 39);
            this.lbl_good_num.Name = "lbl_good_num";
            this.lbl_good_num.Size = new System.Drawing.Size(212, 27);
            this.lbl_good_num.TabIndex = 3;
            this.lbl_good_num.Text = "(전체 양품 개수)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 20F);
            this.label2.Location = new System.Drawing.Point(39, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "전체 양품 개수   :";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.lbl_record_notgood);
            this.metroTabPage2.Controls.Add(this.lbl_record_good);
            this.metroTabPage2.Controls.Add(this.label9);
            this.metroTabPage2.Controls.Add(this.label8);
            this.metroTabPage2.Controls.Add(this.dateTimePicker1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 8;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(714, 315);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "기록";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 9;
            // 
            // lbl_record_notgood
            // 
            this.lbl_record_notgood.AutoSize = true;
            this.lbl_record_notgood.Font = new System.Drawing.Font("굴림", 15F);
            this.lbl_record_notgood.Location = new System.Drawing.Point(272, 215);
            this.lbl_record_notgood.Name = "lbl_record_notgood";
            this.lbl_record_notgood.Size = new System.Drawing.Size(222, 20);
            this.lbl_record_notgood.TabIndex = 6;
            this.lbl_record_notgood.Text = "(해당 날짜 불량품 개수)";
            // 
            // lbl_record_good
            // 
            this.lbl_record_good.AutoSize = true;
            this.lbl_record_good.Font = new System.Drawing.Font("굴림", 15F);
            this.lbl_record_good.Location = new System.Drawing.Point(272, 142);
            this.lbl_record_good.Name = "lbl_record_good";
            this.lbl_record_good.Size = new System.Drawing.Size(202, 20);
            this.lbl_record_good.TabIndex = 5;
            this.lbl_record_good.Text = "(해당 날짜 양품 개수)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 15F);
            this.label9.Location = new System.Drawing.Point(33, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "해당 날짜 불량품 개수 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 15F);
            this.label8.Location = new System.Drawing.Point(34, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "해당 날짜 양품 개수    :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(489, 41);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 21);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "00.jpg");
            this.imageList1.Images.SetKeyName(1, "01.jpg");
            this.imageList1.Images.SetKeyName(2, "02.jpg");
            this.imageList1.Images.SetKeyName(3, "10.jpg");
            this.imageList1.Images.SetKeyName(4, "11.jpg");
            this.imageList1.Images.SetKeyName(5, "12.jpg");
            this.imageList1.Images.SetKeyName(6, "20.jpg");
            this.imageList1.Images.SetKeyName(7, "21.jpg");
            this.imageList1.Images.SetKeyName(8, "22.jpg");
            this.imageList1.Images.SetKeyName(9, "30.jpg");
            this.imageList1.Images.SetKeyName(10, "31.jpg");
            this.imageList1.Images.SetKeyName(11, "32.jpg");
            this.imageList1.Images.SetKeyName(12, "40.jpg");
            this.imageList1.Images.SetKeyName(13, "41.jpg");
            this.imageList1.Images.SetKeyName(14, "42.jpg");
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(920, 442);
            this.Controls.Add(this.HeadPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "TeamProject";
            this.SidePanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.HeadPanel.ResumeLayout(false);
            this.HeadPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tracer_stat.ResumeLayout(false);
            this.stat_page1.ResumeLayout(false);
            this.stat_page1.PerformLayout();
            this.stat_page2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.inventory.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.Button btn_page1;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btn_page2;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTabControl tracer_stat;
        private MetroFramework.Controls.MetroTabPage stat_page1;
        private System.Windows.Forms.Label lbl_tracer2_stat;
        private System.Windows.Forms.Label lbl_tracer1_stat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl inventory;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Label lbl_notgood_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_good_num;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTabPage stat_page2;
        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label lbl_today_notgood;
        private System.Windows.Forms.Label lbl_today_good;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_today;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_record_notgood;
        private System.Windows.Forms.Label lbl_record_good;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_mini;
    }
}