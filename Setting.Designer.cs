﻿namespace Labone_UI
{
    partial class Setting
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
            mainPanel = new ShuzukoPanel();
            nextButton = new ShuzukoButton();
            shuzukoPanel5 = new ShuzukoPanel();
            shutdownButton = new ShuzukoButton();
            label5 = new Label();
            shuzukoPanel4 = new ShuzukoPanel();
            setupButton = new ShuzukoButton();
            label4 = new Label();
            shuzukoPanel3 = new ShuzukoPanel();
            configButton = new ShuzukoButton();
            label3 = new Label();
            shuzukoPanel2 = new ShuzukoPanel();
            timeButton = new ShuzukoButton();
            label2 = new Label();
            shuzukoPanel1 = new ShuzukoPanel();
            calibrationButton = new ShuzukoButton();
            label1 = new Label();
            settingButton = new ShuzukoButton();
            enterButton = new ShuzukoButton();
            backButton = new ShuzukoButton();
            homeButton = new ShuzukoButton();
            groundPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            shuzukoPanel5.SuspendLayout();
            shuzukoPanel4.SuspendLayout();
            shuzukoPanel3.SuspendLayout();
            shuzukoPanel2.SuspendLayout();
            shuzukoPanel1.SuspendLayout();
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
            playButton.BackColor = Color.Silver;
            playButton.BackgroundColor = Color.Silver;
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
            playButton.Text = "  BEGIN";
            playButton.TextColor = Color.FromArgb(45, 48, 129);
            playButton.TextOffsetX = 80;
            playButton.TextOffsetY = 9;
            playButton.UseVisualStyleBackColor = false;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.Window;
            mainPanel.BorderRadius = 15;
            mainPanel.Controls.Add(nextButton);
            mainPanel.Controls.Add(shuzukoPanel5);
            mainPanel.Controls.Add(shuzukoPanel4);
            mainPanel.Controls.Add(shuzukoPanel3);
            mainPanel.Controls.Add(shuzukoPanel2);
            mainPanel.Controls.Add(shuzukoPanel1);
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
            nextButton.BackColor = Color.FromArgb(152, 221, 250);
            nextButton.BackgroundColor = Color.FromArgb(152, 221, 250);
            nextButton.BorderColor = Color.PaleVioletRed;
            nextButton.BorderRadius = 15;
            nextButton.BorderSize = 0;
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.ForeColor = Color.White;
            nextButton.Image = Properties.Resources.Next;
            nextButton.Location = new Point(1685, 45);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(170, 250);
            nextButton.TabIndex = 0;
            nextButton.TextColor = Color.White;
            nextButton.TextOffsetX = 0;
            nextButton.TextOffsetY = 0;
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // shuzukoPanel5
            // 
            shuzukoPanel5.BackColor = Color.FromArgb(226, 227, 229);
            shuzukoPanel5.BorderRadius = 30;
            shuzukoPanel5.Controls.Add(shutdownButton);
            shuzukoPanel5.Controls.Add(label5);
            shuzukoPanel5.ForeColor = Color.Black;
            shuzukoPanel5.GradientAngle = -90F;
            shuzukoPanel5.GradientBottomColor = Color.FromArgb(226, 227, 229);
            shuzukoPanel5.GradientTopColor = Color.FromArgb(226, 227, 229);
            shuzukoPanel5.Location = new Point(1355, 45);
            shuzukoPanel5.Name = "shuzukoPanel5";
            shuzukoPanel5.Size = new Size(260, 250);
            shuzukoPanel5.TabIndex = 2;
            // 
            // shutdownButton
            // 
            shutdownButton.BackColor = Color.White;
            shutdownButton.BackgroundColor = Color.White;
            shutdownButton.BorderColor = Color.PaleVioletRed;
            shutdownButton.BorderRadius = 15;
            shutdownButton.BorderSize = 0;
            shutdownButton.FlatAppearance.BorderSize = 0;
            shutdownButton.FlatStyle = FlatStyle.Flat;
            shutdownButton.ForeColor = Color.White;
            shutdownButton.Image = Properties.Resources.Shutdown;
            shutdownButton.Location = new Point(0, -1);
            shutdownButton.Name = "shutdownButton";
            shutdownButton.Size = new Size(260, 190);
            shutdownButton.TabIndex = 0;
            shutdownButton.TextColor = Color.White;
            shutdownButton.TextOffsetX = 0;
            shutdownButton.TextOffsetY = 0;
            shutdownButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(45, 48, 129);
            label5.Location = new Point(31, 198);
            label5.Name = "label5";
            label5.Size = new Size(205, 41);
            label5.TabIndex = 1;
            label5.Text = "SHUT DOWN";
            // 
            // shuzukoPanel4
            // 
            shuzukoPanel4.BackColor = Color.FromArgb(226, 227, 229);
            shuzukoPanel4.BorderRadius = 30;
            shuzukoPanel4.Controls.Add(setupButton);
            shuzukoPanel4.Controls.Add(label4);
            shuzukoPanel4.ForeColor = Color.Black;
            shuzukoPanel4.GradientAngle = -90F;
            shuzukoPanel4.GradientBottomColor = Color.FromArgb(226, 227, 229);
            shuzukoPanel4.GradientTopColor = Color.FromArgb(226, 227, 229);
            shuzukoPanel4.Location = new Point(1020, 45);
            shuzukoPanel4.Name = "shuzukoPanel4";
            shuzukoPanel4.Size = new Size(260, 250);
            shuzukoPanel4.TabIndex = 2;
            // 
            // setupButton
            // 
            setupButton.BackColor = Color.White;
            setupButton.BackgroundColor = Color.White;
            setupButton.BackgroundImage = Properties.Resources.SetupProgram;
            setupButton.BackgroundImageLayout = ImageLayout.Center;
            setupButton.BorderColor = Color.PaleVioletRed;
            setupButton.BorderRadius = 15;
            setupButton.BorderSize = 0;
            setupButton.FlatAppearance.BorderSize = 0;
            setupButton.FlatStyle = FlatStyle.Flat;
            setupButton.ForeColor = Color.White;
            setupButton.Location = new Point(0, -1);
            setupButton.Name = "setupButton";
            setupButton.Size = new Size(260, 190);
            setupButton.TabIndex = 0;
            setupButton.TextColor = Color.White;
            setupButton.TextOffsetX = 0;
            setupButton.TextOffsetY = 0;
            setupButton.UseVisualStyleBackColor = false;
            setupButton.Click += setupButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(45, 48, 129);
            label4.Location = new Point(-3, 198);
            label4.Name = "label4";
            label4.Size = new Size(269, 41);
            label4.TabIndex = 1;
            label4.Text = "SETUP PROGRAM";
            // 
            // shuzukoPanel3
            // 
            shuzukoPanel3.BackColor = Color.FromArgb(226, 227, 229);
            shuzukoPanel3.BorderRadius = 30;
            shuzukoPanel3.Controls.Add(configButton);
            shuzukoPanel3.Controls.Add(label3);
            shuzukoPanel3.ForeColor = Color.Black;
            shuzukoPanel3.GradientAngle = -90F;
            shuzukoPanel3.GradientBottomColor = Color.FromArgb(226, 227, 229);
            shuzukoPanel3.GradientTopColor = Color.FromArgb(226, 227, 229);
            shuzukoPanel3.Location = new Point(685, 45);
            shuzukoPanel3.Name = "shuzukoPanel3";
            shuzukoPanel3.Size = new Size(260, 250);
            shuzukoPanel3.TabIndex = 2;
            // 
            // configButton
            // 
            configButton.BackColor = Color.White;
            configButton.BackgroundColor = Color.White;
            configButton.BorderColor = Color.PaleVioletRed;
            configButton.BorderRadius = 15;
            configButton.BorderSize = 0;
            configButton.FlatAppearance.BorderSize = 0;
            configButton.FlatStyle = FlatStyle.Flat;
            configButton.ForeColor = Color.White;
            configButton.Image = Properties.Resources.Config;
            configButton.Location = new Point(0, -1);
            configButton.Name = "configButton";
            configButton.Size = new Size(260, 190);
            configButton.TabIndex = 0;
            configButton.TextColor = Color.White;
            configButton.TextOffsetX = 0;
            configButton.TextOffsetY = 0;
            configButton.UseVisualStyleBackColor = false;
            configButton.Click += configButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(45, 48, 129);
            label3.Location = new Point(65, 198);
            label3.Name = "label3";
            label3.Size = new Size(131, 41);
            label3.TabIndex = 1;
            label3.Text = "CONFIG";
            // 
            // shuzukoPanel2
            // 
            shuzukoPanel2.BackColor = Color.FromArgb(226, 227, 229);
            shuzukoPanel2.BorderRadius = 30;
            shuzukoPanel2.Controls.Add(timeButton);
            shuzukoPanel2.Controls.Add(label2);
            shuzukoPanel2.ForeColor = Color.Black;
            shuzukoPanel2.GradientAngle = -90F;
            shuzukoPanel2.GradientBottomColor = Color.FromArgb(226, 227, 229);
            shuzukoPanel2.GradientTopColor = Color.FromArgb(226, 227, 229);
            shuzukoPanel2.Location = new Point(350, 45);
            shuzukoPanel2.Name = "shuzukoPanel2";
            shuzukoPanel2.Size = new Size(260, 250);
            shuzukoPanel2.TabIndex = 2;
            // 
            // timeButton
            // 
            timeButton.BackColor = Color.White;
            timeButton.BackgroundColor = Color.White;
            timeButton.BorderColor = Color.PaleVioletRed;
            timeButton.BorderRadius = 15;
            timeButton.BorderSize = 0;
            timeButton.FlatAppearance.BorderSize = 0;
            timeButton.FlatStyle = FlatStyle.Flat;
            timeButton.ForeColor = Color.White;
            timeButton.Image = Properties.Resources.Time;
            timeButton.Location = new Point(0, -1);
            timeButton.Name = "timeButton";
            timeButton.Size = new Size(260, 190);
            timeButton.TabIndex = 0;
            timeButton.TextColor = Color.White;
            timeButton.TextOffsetX = 0;
            timeButton.TextOffsetY = 0;
            timeButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(45, 48, 129);
            label2.Location = new Point(85, 198);
            label2.Name = "label2";
            label2.Size = new Size(91, 41);
            label2.TabIndex = 1;
            label2.Text = "TIME";
            // 
            // shuzukoPanel1
            // 
            shuzukoPanel1.BackColor = Color.FromArgb(226, 227, 229);
            shuzukoPanel1.BorderRadius = 30;
            shuzukoPanel1.Controls.Add(calibrationButton);
            shuzukoPanel1.Controls.Add(label1);
            shuzukoPanel1.ForeColor = Color.Black;
            shuzukoPanel1.GradientAngle = -90F;
            shuzukoPanel1.GradientBottomColor = Color.FromArgb(226, 227, 229);
            shuzukoPanel1.GradientTopColor = Color.FromArgb(226, 227, 229);
            shuzukoPanel1.Location = new Point(15, 45);
            shuzukoPanel1.Name = "shuzukoPanel1";
            shuzukoPanel1.Size = new Size(260, 250);
            shuzukoPanel1.TabIndex = 2;
            // 
            // calibrationButton
            // 
            calibrationButton.BackColor = Color.White;
            calibrationButton.BackgroundColor = Color.White;
            calibrationButton.BorderColor = Color.Transparent;
            calibrationButton.BorderRadius = 15;
            calibrationButton.BorderSize = 0;
            calibrationButton.FlatAppearance.BorderSize = 0;
            calibrationButton.FlatStyle = FlatStyle.Flat;
            calibrationButton.ForeColor = Color.White;
            calibrationButton.Image = Properties.Resources.balance;
            calibrationButton.Location = new Point(0, -1);
            calibrationButton.Name = "calibrationButton";
            calibrationButton.Size = new Size(260, 190);
            calibrationButton.TabIndex = 0;
            calibrationButton.TextColor = Color.White;
            calibrationButton.TextOffsetX = 0;
            calibrationButton.TextOffsetY = 0;
            calibrationButton.UseVisualStyleBackColor = false;
            calibrationButton.Click += calibrationButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 48, 129);
            label1.Location = new Point(22, 198);
            label1.Name = "label1";
            label1.Size = new Size(216, 41);
            label1.TabIndex = 1;
            label1.Text = "CALIBRATION";
            // 
            // settingButton
            // 
            settingButton.BackColor = Color.DarkGray;
            settingButton.BackgroundColor = Color.DarkGray;
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
            enterButton.BackColor = Color.DarkGray;
            enterButton.BackgroundColor = Color.DarkGray;
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
            backButton.Click += backButton_Click;
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
            homeButton.Click += homeButton_Click;
            // 
            // Setting
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(54, 176, 253);
            ClientSize = new Size(1904, 441);
            Controls.Add(groundPanel);
            Name = "Setting";
            Text = "Form1";
            groundPanel.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            shuzukoPanel5.ResumeLayout(false);
            shuzukoPanel5.PerformLayout();
            shuzukoPanel4.ResumeLayout(false);
            shuzukoPanel4.PerformLayout();
            shuzukoPanel3.ResumeLayout(false);
            shuzukoPanel3.PerformLayout();
            shuzukoPanel2.ResumeLayout(false);
            shuzukoPanel2.PerformLayout();
            shuzukoPanel1.ResumeLayout(false);
            shuzukoPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ShuzukoPanel groundPanel;
        private ShuzukoPanel mainPanel;
        private ShuzukoButton vectorButton;
        private ShuzukoButton playButton;
        private ShuzukoPanel shuzukoPanel1;
        private ShuzukoButton calibrationButton;
        private ShuzukoPanel shuzukoPanel5;
        private ShuzukoButton shutdownButton;
        private ShuzukoPanel shuzukoPanel4;
        private ShuzukoButton setupButton;
        private ShuzukoPanel shuzukoPanel3;
        private ShuzukoButton configButton;
        private ShuzukoPanel shuzukoPanel2;
        private ShuzukoButton timeButton;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ShuzukoButton nextButton;
        private ShuzukoButton settingButton;
        private ShuzukoButton enterButton;
        private ShuzukoButton backButton;
        private ShuzukoButton homeButton;
    }
}
