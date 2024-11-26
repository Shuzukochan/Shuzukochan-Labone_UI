namespace Labone_UI
{
    partial class OTA
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
            mainPanel = new ShuzukoPanel();
            nextButton = new ShuzukoButton();
            shuzukoPanel3 = new ShuzukoPanel();
            in4Button = new ShuzukoButton();
            label3 = new Label();
            shuzukoPanel2 = new ShuzukoPanel();
            otaButton = new ShuzukoButton();
            label2 = new Label();
            groundPanel.SuspendLayout();
            underLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Clock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Calendar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            mainPanel.SuspendLayout();
            shuzukoPanel3.SuspendLayout();
            shuzukoPanel2.SuspendLayout();
            SuspendLayout();
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
            groundPanel.Controls.Add(mainPanel);
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
            playButton.Image = Properties.Resources.Play;
            playButton.ImageAlign = ContentAlignment.MiddleLeft;
            playButton.Location = new Point(1630, 364);
            playButton.Name = "playButton";
            playButton.Size = new Size(261, 68);
            playButton.TabIndex = 8;
            playButton.Text = "   RUN";
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
            Calendar.Location = new Point(495, 9);
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
            KingTubeAuto.Location = new Point(205, 9);
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
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.BorderRadius = 15;
            mainPanel.Controls.Add(nextButton);
            mainPanel.Controls.Add(shuzukoPanel3);
            mainPanel.Controls.Add(shuzukoPanel2);
            mainPanel.ForeColor = Color.Black;
            mainPanel.GradientAngle = 180F;
            mainPanel.GradientBottomColor = Color.FromArgb(92, 158, 252);
            mainPanel.GradientTopColor = Color.FromArgb(124, 213, 255);
            mainPanel.Location = new Point(12, 12);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1882, 345);
            mainPanel.TabIndex = 2;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.FromArgb(135, 191, 252);
            nextButton.BackgroundColor = Color.FromArgb(135, 191, 252);
            nextButton.BorderColor = Color.PaleVioletRed;
            nextButton.BorderRadius = 20;
            nextButton.BorderSize = 0;
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.ForeColor = Color.White;
            nextButton.Image = Properties.Resources.Back;
            nextButton.Location = new Point(15, 47);
            nextButton.Name = "nextButton";
            nextButton.RightToLeft = RightToLeft.No;
            nextButton.Size = new Size(163, 250);
            nextButton.TabIndex = 0;
            nextButton.TextColor = Color.White;
            nextButton.TextOffsetX = 0;
            nextButton.TextOffsetY = 0;
            nextButton.UseVisualStyleBackColor = false;
            // 
            // shuzukoPanel3
            // 
            shuzukoPanel3.BackColor = Color.White;
            shuzukoPanel3.BorderRadius = 30;
            shuzukoPanel3.Controls.Add(in4Button);
            shuzukoPanel3.Controls.Add(label3);
            shuzukoPanel3.ForeColor = Color.Black;
            shuzukoPanel3.GradientAngle = -90F;
            shuzukoPanel3.GradientBottomColor = Color.FromArgb(226, 227, 229);
            shuzukoPanel3.GradientTopColor = Color.FromArgb(226, 227, 229);
            shuzukoPanel3.Location = new Point(548, 46);
            shuzukoPanel3.Name = "shuzukoPanel3";
            shuzukoPanel3.Size = new Size(300, 250);
            shuzukoPanel3.TabIndex = 2;
            // 
            // in4Button
            // 
            in4Button.BackColor = Color.White;
            in4Button.BackgroundColor = Color.White;
            in4Button.BorderColor = Color.PaleVioletRed;
            in4Button.BorderRadius = 15;
            in4Button.BorderSize = 0;
            in4Button.FlatAppearance.BorderSize = 0;
            in4Button.FlatStyle = FlatStyle.Flat;
            in4Button.ForeColor = Color.White;
            in4Button.Image = Properties.Resources.information;
            in4Button.Location = new Point(0, -1);
            in4Button.Name = "in4Button";
            in4Button.Size = new Size(300, 190);
            in4Button.TabIndex = 0;
            in4Button.TextColor = Color.White;
            in4Button.TextOffsetX = 0;
            in4Button.TextOffsetY = 0;
            in4Button.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(45, 48, 129);
            label3.Location = new Point(38, 198);
            label3.Name = "label3";
            label3.Size = new Size(234, 41);
            label3.TabIndex = 1;
            label3.Text = "INFORMATION";
            // 
            // shuzukoPanel2
            // 
            shuzukoPanel2.BackColor = Color.White;
            shuzukoPanel2.BorderRadius = 30;
            shuzukoPanel2.Controls.Add(otaButton);
            shuzukoPanel2.Controls.Add(label2);
            shuzukoPanel2.ForeColor = Color.Black;
            shuzukoPanel2.GradientAngle = -90F;
            shuzukoPanel2.GradientBottomColor = Color.FromArgb(226, 227, 229);
            shuzukoPanel2.GradientTopColor = Color.FromArgb(226, 227, 229);
            shuzukoPanel2.Location = new Point(213, 47);
            shuzukoPanel2.Name = "shuzukoPanel2";
            shuzukoPanel2.Size = new Size(300, 250);
            shuzukoPanel2.TabIndex = 2;
            // 
            // otaButton
            // 
            otaButton.BackColor = Color.White;
            otaButton.BackgroundColor = Color.White;
            otaButton.BorderColor = Color.PaleVioletRed;
            otaButton.BorderRadius = 15;
            otaButton.BorderSize = 0;
            otaButton.FlatAppearance.BorderSize = 0;
            otaButton.FlatStyle = FlatStyle.Flat;
            otaButton.ForeColor = Color.White;
            otaButton.Image = Properties.Resources.OTA;
            otaButton.Location = new Point(0, -1);
            otaButton.Name = "otaButton";
            otaButton.Size = new Size(300, 190);
            otaButton.TabIndex = 0;
            otaButton.TextColor = Color.White;
            otaButton.TextOffsetX = 0;
            otaButton.TextOffsetY = 0;
            otaButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(45, 48, 129);
            label2.Location = new Point(53, 198);
            label2.Name = "label2";
            label2.Size = new Size(200, 41);
            label2.TabIndex = 1;
            label2.Text = "OTA UPDATE";
            // 
            // OTA
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(54, 176, 253);
            ClientSize = new Size(1904, 441);
            Controls.Add(groundPanel);
            Name = "OTA";
            Text = "Form1";
            groundPanel.ResumeLayout(false);
            underLeftPanel.ResumeLayout(false);
            underLeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Clock).EndInit();
            ((System.ComponentModel.ISupportInitialize)Calendar).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            mainPanel.ResumeLayout(false);
            shuzukoPanel3.ResumeLayout(false);
            shuzukoPanel3.PerformLayout();
            shuzukoPanel2.ResumeLayout(false);
            shuzukoPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ShuzukoPanel groundPanel;
        private ShuzukoPanel mainPanel;
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
        private ShuzukoPanel shuzukoPanel3;
        private ShuzukoButton in4Button;
        private ShuzukoPanel shuzukoPanel2;
        private ShuzukoButton otaButton;
        private Label label3;
        private Label label2;
        private ShuzukoButton nextButton;
    }
}
