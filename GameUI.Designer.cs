namespace PacmanSimulator
{
    partial class GameUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbDirection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.btnPlace = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picPackman = new System.Windows.Forms.PictureBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPackman)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.cbDirection);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbY);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbX);
            this.panel1.Controls.Add(this.btnPlace);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnMove);
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 497);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 98);
            this.panel1.TabIndex = 0;
            // 
            // cbDirection
            // 
            this.cbDirection.FormattingEnabled = true;
            this.cbDirection.Items.AddRange(new object[] {
            "NORTH",
            "SOUTH",
            "EAST",
            "WEST"});
            this.cbDirection.Location = new System.Drawing.Point(387, 19);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(84, 21);
            this.cbDirection.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Face";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(254, 20);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(84, 20);
            this.tbY.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(140, 20);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(84, 20);
            this.tbX.TabIndex = 4;
            // 
            // btnPlace
            // 
            this.btnPlace.Location = new System.Drawing.Point(26, 15);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(84, 28);
            this.btnPlace.TabIndex = 3;
            this.btnPlace.Text = "Place";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(254, 58);
            this.btnRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(84, 29);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(26, 58);
            this.btnMove.Margin = new System.Windows.Forms.Padding(2);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(84, 29);
            this.btnMove.TabIndex = 1;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(140, 58);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(84, 29);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.picPackman);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 497);
            this.panel2.TabIndex = 1;
            // 
            // picPackman
            // 
            this.picPackman.BackColor = System.Drawing.Color.Transparent;
            this.picPackman.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPackman.BackgroundImage")));
            this.picPackman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPackman.Location = new System.Drawing.Point(26, 123);
            this.picPackman.Margin = new System.Windows.Forms.Padding(2);
            this.picPackman.Name = "picPackman";
            this.picPackman.Size = new System.Drawing.Size(50, 52);
            this.picPackman.TabIndex = 0;
            this.picPackman.TabStop = false;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(387, 58);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(84, 29);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // GameUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(497, 595);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PacmanSimulator";
            this.Load += new System.EventHandler(this.GameUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPackman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.PictureBox picPackman;
        private System.Windows.Forms.ComboBox cbDirection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Button btnReport;
    }
}

