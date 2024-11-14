namespace Labone_UI
{
    partial class Home
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
            rightLabelPicture = new PictureBox();
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
            label3 = new Label();
            label4 = new Label();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rightLabelPicture).BeginInit();
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
            rightPanel.Controls.Add(rightLabelPicture);
            rightPanel.ForeColor = Color.Black;
            rightPanel.GradientAngle = 180F;
            rightPanel.GradientBottomColor = Color.FromArgb(106, 183, 253);
            rightPanel.GradientTopColor = Color.FromArgb(125, 214, 255);
            rightPanel.Location = new Point(956, 12);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(938, 345);
            rightPanel.TabIndex = 1;
            // 
            // rightLabelPicture
            // 
            rightLabelPicture.Anchor = AnchorStyles.None;
            rightLabelPicture.BackColor = Color.Transparent;
            rightLabelPicture.Image = Properties.Resources.rightLabelPicture;
            rightLabelPicture.Location = new Point(345, 47);
            rightLabelPicture.Name = "rightLabelPicture";
            rightLabelPicture.Size = new Size(247, 250);
            rightLabelPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            rightLabelPicture.TabIndex = 0;
            rightLabelPicture.TabStop = false;
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
            playButton.Image = Properties.Resources.Play;
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
            // leftPanel
            // 
            leftPanel.BackColor = Color.White;
            leftPanel.BorderRadius = 30;
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(label4);
            leftPanel.ForeColor = Color.Black;
            leftPanel.GradientAngle = 180F;
            leftPanel.GradientBottomColor = Color.FromArgb(92, 158, 252);
            leftPanel.GradientTopColor = Color.FromArgb(105, 182, 252);
            leftPanel.Location = new Point(12, 12);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(938, 345);
            leftPanel.TabIndex = 2;
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(241, 250);
            label3.Name = "label3";
            label3.Size = new Size(456, 32);
            label3.TabIndex = 1;
            label3.Text = "Wait a moment for the machine to boot...";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 24F);
            label4.ForeColor = Color.FromArgb(23, 55, 114);
            label4.Location = new Point(60, 110);
            label4.Name = "label4";
            label4.Size = new Size(817, 90);
            label4.TabIndex = 0;
            label4.Text = "ENSURE THE PATH IS CLEAR AS THE MACHINE INTIATES\nITS HOMEWARD JOURNEY";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(54, 176, 253);
            ClientSize = new Size(1904, 441);
            Controls.Add(rightPanel);
            Controls.Add(groundPanel);
            Name = "Home";
            Text = "Form1";
            rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rightLabelPicture).EndInit();
            groundPanel.ResumeLayout(false);
            underLeftPanel.ResumeLayout(false);
            underLeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Clock).EndInit();
            ((System.ComponentModel.ISupportInitialize)Calendar).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ShuzukoPanel rightPanel;
        private ShuzukoPanel groundPanel;
        private ShuzukoPanel leftPanel;
        private Label label3;
        private Label label4;
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
        private PictureBox rightLabelPicture;
    }
}
