namespace Labone_UI
{
    partial class SelectProgram
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
            rightPanel = new ShuzukoPanel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            shuzukoPanel12 = new ShuzukoPanel();
            shuzukoPanel11 = new ShuzukoPanel();
            label1 = new Label();
            groundPanel = new ShuzukoPanel();
            vectorButton = new ShuzukoButton();
            playButton = new ShuzukoButton();
            settingButton = new ShuzukoButton();
            enterButton = new ShuzukoButton();
            backButton = new ShuzukoButton();
            homeButton = new ShuzukoButton();
            underLeftPanel = new ShuzukoPanel();
            Clock = new PictureBox();
            Calendar = new PictureBox();
            KingTubeAuto = new Label();
            logo = new PictureBox();
            leftPanel = new ShuzukoPanel();
            shuzukoPanel10 = new ShuzukoPanel();
            shuzukoPanel9 = new ShuzukoPanel();
            shuzukoPanel8 = new ShuzukoPanel();
            shuzukoPanel7 = new ShuzukoPanel();
            shuzukoPanel6 = new ShuzukoPanel();
            shuzukoPanel5 = new ShuzukoPanel();
            shuzukoPanel4 = new ShuzukoPanel();
            shuzukoPanel3 = new ShuzukoPanel();
            shuzukoPanel2 = new ShuzukoPanel();
            shuzukoPanel1 = new ShuzukoPanel();
            rightPanel.SuspendLayout();
            shuzukoPanel11.SuspendLayout();
            groundPanel.SuspendLayout();
            underLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Clock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Calendar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            leftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.White;
            rightPanel.BorderRadius = 30;
            rightPanel.Controls.Add(label7);
            rightPanel.Controls.Add(label6);
            rightPanel.Controls.Add(label5);
            rightPanel.Controls.Add(label4);
            rightPanel.Controls.Add(label3);
            rightPanel.Controls.Add(label2);
            rightPanel.Controls.Add(shuzukoPanel12);
            rightPanel.Controls.Add(shuzukoPanel11);
            rightPanel.ForeColor = Color.Black;
            rightPanel.GradientAngle = 180F;
            rightPanel.GradientBottomColor = Color.FromArgb(106, 183, 253);
            rightPanel.GradientTopColor = Color.FromArgb(125, 214, 255);
            rightPanel.Location = new Point(956, 12);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(938, 345);
            rightPanel.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(119, 197, 254);
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(45, 48, 129);
            label7.Location = new Point(256, 313);
            label7.Name = "label7";
            label7.Size = new Size(158, 30);
            label7.TabIndex = 10;
            label7.Text = "Antidrop (deg) :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(119, 197, 254);
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(45, 48, 129);
            label6.Location = new Point(212, 272);
            label6.Name = "label6";
            label6.Size = new Size(202, 30);
            label6.TabIndex = 9;
            label6.Text = "SpeedXY (mm/min) :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(119, 197, 254);
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(45, 48, 129);
            label5.Location = new Point(269, 231);
            label5.Name = "label5";
            label5.Size = new Size(145, 30);
            label5.TabIndex = 8;
            label5.Text = "TubeID (mm) :";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(119, 197, 254);
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(45, 48, 129);
            label4.Location = new Point(224, 190);
            label4.Name = "label4";
            label4.Size = new Size(190, 30);
            label4.TabIndex = 7;
            label4.Text = "PumpSpeed (rpm) :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(119, 197, 254);
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(45, 48, 129);
            label3.Location = new Point(274, 149);
            label3.Name = "label3";
            label3.Size = new Size(140, 30);
            label3.TabIndex = 6;
            label3.Text = "Volume (mL) :";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(119, 197, 254);
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(45, 48, 129);
            label2.Location = new Point(310, 108);
            label2.Name = "label2";
            label2.Size = new Size(104, 30);
            label2.TabIndex = 5;
            label2.Text = "Quantity :";
            // 
            // shuzukoPanel12
            // 
            shuzukoPanel12.BackColor = Color.FromArgb(149, 210, 254);
            shuzukoPanel12.BorderRadius = 30;
            shuzukoPanel12.ForeColor = Color.Black;
            shuzukoPanel12.GradientAngle = 90F;
            shuzukoPanel12.GradientBottomColor = Color.FromArgb(149, 210, 254);
            shuzukoPanel12.GradientTopColor = Color.FromArgb(149, 210, 254);
            shuzukoPanel12.Location = new Point(10, 60);
            shuzukoPanel12.Name = "shuzukoPanel12";
            shuzukoPanel12.Size = new Size(920, 45);
            shuzukoPanel12.TabIndex = 4;
            // 
            // shuzukoPanel11
            // 
            shuzukoPanel11.BackColor = Color.FromArgb(149, 210, 254);
            shuzukoPanel11.BorderRadius = 30;
            shuzukoPanel11.Controls.Add(label1);
            shuzukoPanel11.ForeColor = Color.Black;
            shuzukoPanel11.GradientAngle = 90F;
            shuzukoPanel11.GradientBottomColor = Color.FromArgb(149, 210, 254);
            shuzukoPanel11.GradientTopColor = Color.FromArgb(149, 210, 254);
            shuzukoPanel11.Location = new Point(10, 10);
            shuzukoPanel11.Name = "shuzukoPanel11";
            shuzukoPanel11.Size = new Size(920, 45);
            shuzukoPanel11.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(149, 210, 254);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(45, 48, 129);
            label1.Location = new Point(342, 7);
            label1.Name = "label1";
            label1.Size = new Size(236, 32);
            label1.TabIndex = 0;
            label1.Text = "SELECT PROGRAMS";
            label1.Click += label1_Click_1;
            // 
            // groundPanel
            // 
            groundPanel.BackColor = Color.White;
            groundPanel.BorderRadius = 0;
            groundPanel.Controls.Add(vectorButton);
            groundPanel.Controls.Add(playButton);
            groundPanel.Controls.Add(settingButton);
            groundPanel.Controls.Add(enterButton);
            groundPanel.Controls.Add(backButton);
            groundPanel.Controls.Add(homeButton);
            groundPanel.Controls.Add(underLeftPanel);
            groundPanel.Controls.Add(leftPanel);
            groundPanel.Dock = DockStyle.Fill;
            groundPanel.ForeColor = Color.Black;
            groundPanel.GradientAngle = 180F;
            groundPanel.GradientBottomColor = Color.FromArgb(20, 116, 252);
            groundPanel.GradientTopColor = Color.FromArgb(69, 198, 255);
            groundPanel.Location = new Point(0, 0);
            groundPanel.Name = "groundPanel";
            groundPanel.Size = new Size(1904, 441);
            groundPanel.TabIndex = 2;
            // 
            // vectorButton
            // 
            vectorButton.BackColor = Color.White;
            vectorButton.BackgroundColor = Color.White;
            vectorButton.BorderColor = Color.Transparent;
            vectorButton.BorderRadius = 34;
            vectorButton.BorderSize = 0;
            vectorButton.FlatAppearance.BorderSize = 0;
            vectorButton.FlatStyle = FlatStyle.Flat;
            vectorButton.ForeColor = Color.White;
            vectorButton.Image = Properties.Resources.Vector;
            vectorButton.Location = new Point(1550, 363);
            vectorButton.Name = "vectorButton";
            vectorButton.Size = new Size(68, 68);
            vectorButton.TabIndex = 9;
            vectorButton.TextColor = Color.White;
            vectorButton.TextOffsetX = 0;
            vectorButton.TextOffsetY = 0;
            vectorButton.UseVisualStyleBackColor = false;
            // 
            // playButton
            // 
            playButton.BackColor = Color.White;
            playButton.BackgroundColor = Color.White;
            playButton.BorderColor = Color.Transparent;
            playButton.BorderRadius = 34;
            playButton.BorderSize = 0;
            playButton.FlatAppearance.BorderSize = 0;
            playButton.FlatStyle = FlatStyle.Flat;
            playButton.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            playButton.ForeColor = Color.FromArgb(45, 48, 129);
            playButton.ImageAlign = ContentAlignment.MiddleLeft;
            playButton.Location = new Point(1630, 364);
            playButton.Name = "playButton";
            playButton.Size = new Size(261, 68);
            playButton.TabIndex = 8;
            playButton.Text = "LET'S GO";
            playButton.TextColor = Color.FromArgb(45, 48, 129);
            playButton.TextOffsetX = 80;
            playButton.TextOffsetY = 9;
            playButton.UseVisualStyleBackColor = false;
            // 
            // settingButton
            // 
            settingButton.BackColor = Color.White;
            settingButton.BackgroundColor = Color.White;
            settingButton.BorderColor = Color.Transparent;
            settingButton.BorderRadius = 34;
            settingButton.BorderSize = 0;
            settingButton.FlatAppearance.BorderSize = 0;
            settingButton.FlatStyle = FlatStyle.Flat;
            settingButton.ForeColor = Color.White;
            settingButton.Image = Properties.Resources.Setting;
            settingButton.Location = new Point(1270, 363);
            settingButton.Name = "settingButton";
            settingButton.Size = new Size(68, 68);
            settingButton.TabIndex = 7;
            settingButton.TextColor = Color.White;
            settingButton.TextOffsetX = 0;
            settingButton.TextOffsetY = 0;
            settingButton.UseVisualStyleBackColor = false;
            // 
            // enterButton
            // 
            enterButton.BackColor = Color.White;
            enterButton.BackgroundColor = Color.White;
            enterButton.BorderColor = Color.Transparent;
            enterButton.BorderRadius = 34;
            enterButton.BorderSize = 0;
            enterButton.FlatAppearance.BorderSize = 0;
            enterButton.FlatStyle = FlatStyle.Flat;
            enterButton.ForeColor = Color.White;
            enterButton.Image = Properties.Resources.Enter;
            enterButton.Location = new Point(1170, 363);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(68, 68);
            enterButton.TabIndex = 6;
            enterButton.TextColor = Color.White;
            enterButton.TextOffsetX = 0;
            enterButton.TextOffsetY = 0;
            enterButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.BackgroundColor = Color.White;
            backButton.BorderColor = Color.Transparent;
            backButton.BorderRadius = 34;
            backButton.BorderSize = 0;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.ForeColor = Color.White;
            backButton.Image = Properties.Resources.Left;
            backButton.Location = new Point(1070, 363);
            backButton.Name = "backButton";
            backButton.Size = new Size(68, 68);
            backButton.TabIndex = 5;
            backButton.TextColor = Color.White;
            backButton.TextOffsetX = 0;
            backButton.TextOffsetY = 0;
            backButton.UseVisualStyleBackColor = false;
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.White;
            homeButton.BackgroundColor = Color.White;
            homeButton.BorderColor = Color.Transparent;
            homeButton.BorderRadius = 34;
            homeButton.BorderSize = 0;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.ForeColor = Color.White;
            homeButton.Image = Properties.Resources.Home;
            homeButton.Location = new Point(970, 363);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(68, 68);
            homeButton.TabIndex = 4;
            homeButton.TextColor = Color.White;
            homeButton.TextOffsetX = 0;
            homeButton.TextOffsetY = 0;
            homeButton.UseVisualStyleBackColor = false;
            // 
            // underLeftPanel
            // 
            underLeftPanel.BackColor = Color.White;
            underLeftPanel.BorderRadius = 30;
            underLeftPanel.Controls.Add(Clock);
            underLeftPanel.Controls.Add(Calendar);
            underLeftPanel.Controls.Add(KingTubeAuto);
            underLeftPanel.Controls.Add(logo);
            underLeftPanel.ForeColor = Color.Black;
            underLeftPanel.GradientAngle = 0F;
            underLeftPanel.GradientBottomColor = Color.White;
            underLeftPanel.GradientTopColor = Color.White;
            underLeftPanel.Location = new Point(12, 372);
            underLeftPanel.Name = "underLeftPanel";
            underLeftPanel.Size = new Size(938, 58);
            underLeftPanel.TabIndex = 3;
            // 
            // Clock
            // 
            Clock.Image = Properties.Resources.clock;
            Clock.Location = new Point(717, 9);
            Clock.Name = "Clock";
            Clock.Size = new Size(40, 40);
            Clock.SizeMode = PictureBoxSizeMode.StretchImage;
            Clock.TabIndex = 3;
            Clock.TabStop = false;
            // 
            // Calendar
            // 
            Calendar.Image = Properties.Resources.Calendar;
            Calendar.Location = new Point(480, 9);
            Calendar.Name = "Calendar";
            Calendar.Size = new Size(37, 40);
            Calendar.SizeMode = PictureBoxSizeMode.StretchImage;
            Calendar.TabIndex = 2;
            Calendar.TabStop = false;
            // 
            // KingTubeAuto
            // 
            KingTubeAuto.AutoSize = true;
            KingTubeAuto.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            KingTubeAuto.ForeColor = Color.FromArgb(45, 48, 129);
            KingTubeAuto.Location = new Point(190, 9);
            KingTubeAuto.Name = "KingTubeAuto";
            KingTubeAuto.Size = new Size(201, 37);
            KingTubeAuto.TabIndex = 1;
            KingTubeAuto.Text = "KingTubeAuto";
            // 
            // logo
            // 
            logo.Image = Properties.Resources.KingLab;
            logo.Location = new Point(17, 4);
            logo.Name = "logo";
            logo.Size = new Size(143, 50);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.White;
            leftPanel.BorderRadius = 30;
            leftPanel.Controls.Add(shuzukoPanel10);
            leftPanel.Controls.Add(shuzukoPanel9);
            leftPanel.Controls.Add(shuzukoPanel8);
            leftPanel.Controls.Add(shuzukoPanel7);
            leftPanel.Controls.Add(shuzukoPanel6);
            leftPanel.Controls.Add(shuzukoPanel5);
            leftPanel.Controls.Add(shuzukoPanel4);
            leftPanel.Controls.Add(shuzukoPanel3);
            leftPanel.Controls.Add(shuzukoPanel2);
            leftPanel.Controls.Add(shuzukoPanel1);
            leftPanel.ForeColor = Color.Black;
            leftPanel.GradientAngle = 180F;
            leftPanel.GradientBottomColor = Color.FromArgb(92, 158, 252);
            leftPanel.GradientTopColor = Color.FromArgb(105, 182, 252);
            leftPanel.Location = new Point(12, 12);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(938, 345);
            leftPanel.TabIndex = 2;
            leftPanel.Paint += leftPanel_Paint_1;
            // 
            // shuzukoPanel10
            // 
            shuzukoPanel10.BackColor = Color.White;
            shuzukoPanel10.BorderRadius = 30;
            shuzukoPanel10.ForeColor = Color.Black;
            shuzukoPanel10.GradientAngle = 90F;
            shuzukoPanel10.GradientBottomColor = Color.White;
            shuzukoPanel10.GradientTopColor = Color.White;
            shuzukoPanel10.Location = new Point(480, 291);
            shuzukoPanel10.Name = "shuzukoPanel10";
            shuzukoPanel10.Size = new Size(450, 45);
            shuzukoPanel10.TabIndex = 2;
            // 
            // shuzukoPanel9
            // 
            shuzukoPanel9.BackColor = Color.White;
            shuzukoPanel9.BorderRadius = 30;
            shuzukoPanel9.ForeColor = Color.Black;
            shuzukoPanel9.GradientAngle = 90F;
            shuzukoPanel9.GradientBottomColor = Color.White;
            shuzukoPanel9.GradientTopColor = Color.White;
            shuzukoPanel9.Location = new Point(480, 219);
            shuzukoPanel9.Name = "shuzukoPanel9";
            shuzukoPanel9.Size = new Size(450, 45);
            shuzukoPanel9.TabIndex = 2;
            // 
            // shuzukoPanel8
            // 
            shuzukoPanel8.BackColor = Color.White;
            shuzukoPanel8.BorderRadius = 30;
            shuzukoPanel8.ForeColor = Color.Black;
            shuzukoPanel8.GradientAngle = 90F;
            shuzukoPanel8.GradientBottomColor = Color.White;
            shuzukoPanel8.GradientTopColor = Color.White;
            shuzukoPanel8.Location = new Point(480, 147);
            shuzukoPanel8.Name = "shuzukoPanel8";
            shuzukoPanel8.Size = new Size(450, 45);
            shuzukoPanel8.TabIndex = 2;
            // 
            // shuzukoPanel7
            // 
            shuzukoPanel7.BackColor = Color.White;
            shuzukoPanel7.BorderRadius = 30;
            shuzukoPanel7.ForeColor = Color.Black;
            shuzukoPanel7.GradientAngle = 90F;
            shuzukoPanel7.GradientBottomColor = Color.White;
            shuzukoPanel7.GradientTopColor = Color.White;
            shuzukoPanel7.Location = new Point(480, 75);
            shuzukoPanel7.Name = "shuzukoPanel7";
            shuzukoPanel7.Size = new Size(450, 45);
            shuzukoPanel7.TabIndex = 2;
            // 
            // shuzukoPanel6
            // 
            shuzukoPanel6.BackColor = Color.White;
            shuzukoPanel6.BorderRadius = 30;
            shuzukoPanel6.ForeColor = Color.Black;
            shuzukoPanel6.GradientAngle = 90F;
            shuzukoPanel6.GradientBottomColor = Color.White;
            shuzukoPanel6.GradientTopColor = Color.White;
            shuzukoPanel6.Location = new Point(480, 10);
            shuzukoPanel6.Name = "shuzukoPanel6";
            shuzukoPanel6.Size = new Size(450, 45);
            shuzukoPanel6.TabIndex = 2;
            // 
            // shuzukoPanel5
            // 
            shuzukoPanel5.BackColor = Color.White;
            shuzukoPanel5.BorderRadius = 30;
            shuzukoPanel5.ForeColor = Color.Black;
            shuzukoPanel5.GradientAngle = 90F;
            shuzukoPanel5.GradientBottomColor = Color.White;
            shuzukoPanel5.GradientTopColor = Color.White;
            shuzukoPanel5.Location = new Point(10, 80);
            shuzukoPanel5.Name = "shuzukoPanel5";
            shuzukoPanel5.Size = new Size(450, 45);
            shuzukoPanel5.TabIndex = 1;
            // 
            // shuzukoPanel4
            // 
            shuzukoPanel4.BackColor = Color.White;
            shuzukoPanel4.BorderRadius = 30;
            shuzukoPanel4.ForeColor = Color.Black;
            shuzukoPanel4.GradientAngle = 90F;
            shuzukoPanel4.GradientBottomColor = Color.White;
            shuzukoPanel4.GradientTopColor = Color.White;
            shuzukoPanel4.Location = new Point(10, 290);
            shuzukoPanel4.Name = "shuzukoPanel4";
            shuzukoPanel4.Size = new Size(450, 45);
            shuzukoPanel4.TabIndex = 1;
            // 
            // shuzukoPanel3
            // 
            shuzukoPanel3.BackColor = Color.White;
            shuzukoPanel3.BorderRadius = 30;
            shuzukoPanel3.ForeColor = Color.Black;
            shuzukoPanel3.GradientAngle = 90F;
            shuzukoPanel3.GradientBottomColor = Color.White;
            shuzukoPanel3.GradientTopColor = Color.White;
            shuzukoPanel3.Location = new Point(10, 220);
            shuzukoPanel3.Name = "shuzukoPanel3";
            shuzukoPanel3.Size = new Size(450, 45);
            shuzukoPanel3.TabIndex = 1;
            // 
            // shuzukoPanel2
            // 
            shuzukoPanel2.BackColor = Color.White;
            shuzukoPanel2.BorderRadius = 30;
            shuzukoPanel2.ForeColor = Color.Black;
            shuzukoPanel2.GradientAngle = 90F;
            shuzukoPanel2.GradientBottomColor = Color.White;
            shuzukoPanel2.GradientTopColor = Color.White;
            shuzukoPanel2.Location = new Point(10, 150);
            shuzukoPanel2.Name = "shuzukoPanel2";
            shuzukoPanel2.Size = new Size(450, 45);
            shuzukoPanel2.TabIndex = 1;
            // 
            // shuzukoPanel1
            // 
            shuzukoPanel1.BackColor = Color.White;
            shuzukoPanel1.BorderRadius = 30;
            shuzukoPanel1.ForeColor = Color.Black;
            shuzukoPanel1.GradientAngle = 90F;
            shuzukoPanel1.GradientBottomColor = Color.White;
            shuzukoPanel1.GradientTopColor = Color.White;
            shuzukoPanel1.Location = new Point(10, 10);
            shuzukoPanel1.Name = "shuzukoPanel1";
            shuzukoPanel1.Size = new Size(450, 45);
            shuzukoPanel1.TabIndex = 0;
            // 
            // SelectProgram
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(54, 176, 253);
            ClientSize = new Size(1904, 441);
            Controls.Add(rightPanel);
            Controls.Add(groundPanel);
            Name = "SelectProgram";
            Text = "Form1";
            Load += Home_Load;
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            shuzukoPanel11.ResumeLayout(false);
            shuzukoPanel11.PerformLayout();
            groundPanel.ResumeLayout(false);
            underLeftPanel.ResumeLayout(false);
            underLeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Clock).EndInit();
            ((System.ComponentModel.ISupportInitialize)Calendar).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            leftPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ShuzukoPanel rightPanel;
        private ShuzukoPanel groundPanel;
        private ShuzukoPanel leftPanel;
        private ShuzukoPanel underLeftPanel;
        private Label KingTubeAuto;
        private PictureBox logo;
        private PictureBox Clock;
        private PictureBox Calendar;
        private ShuzukoButton backButton;
        private ShuzukoButton homeButton;
        private ShuzukoButton vectorButton;
        private ShuzukoButton playButton;
        private ShuzukoButton settingButton;
        private ShuzukoButton enterButton;
        private ShuzukoPanel shuzukoPanel4;
        private ShuzukoPanel shuzukoPanel3;
        private ShuzukoPanel shuzukoPanel2;
        private ShuzukoPanel shuzukoPanel1;
        private ShuzukoPanel shuzukoPanel5;
        private ShuzukoPanel shuzukoPanel10;
        private ShuzukoPanel shuzukoPanel9;
        private ShuzukoPanel shuzukoPanel8;
        private ShuzukoPanel shuzukoPanel7;
        private ShuzukoPanel shuzukoPanel6;
        private ShuzukoPanel shuzukoPanel11;
        private Label label1;
        private ShuzukoPanel shuzukoPanel12;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label7;
    }
}
