namespace CityBookCentre
{
    partial class AdminForm
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
            this.header = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.option3 = new System.Windows.Forms.Panel();
            this.option5 = new System.Windows.Forms.Panel();
            this.option2 = new System.Windows.Forms.Panel();
            this.option1 = new System.Windows.Forms.Panel();
            this.option4 = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(242, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(411, 60);
            this.header.TabIndex = 0;
            this.header.Text = "City Book Centre";
            this.header.Click += new System.EventHandler(this.label1_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Salmon;
            this.mainPanel.Controls.Add(this.option5);
            this.mainPanel.Location = new System.Drawing.Point(200, 80);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1080, 459);
            this.mainPanel.TabIndex = 1;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.DarkGray;
            this.sidePanel.Controls.Add(this.option1);
            this.sidePanel.Controls.Add(this.option2);
            this.sidePanel.Controls.Add(this.option3);
            this.sidePanel.Controls.Add(this.option4);
            this.sidePanel.Location = new System.Drawing.Point(0, 80);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(250, 456);
            this.sidePanel.TabIndex = 2;
            this.sidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topPanel.Controls.Add(this.header);
            this.topPanel.Location = new System.Drawing.Point(3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(841, 75);
            this.topPanel.TabIndex = 3;
            // 
            // option3
            // 
            this.option3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.option3.Location = new System.Drawing.Point(3, 215);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(200, 100);
            this.option3.TabIndex = 0;
            // 
            // option5
            // 
            this.option5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.option5.Location = new System.Drawing.Point(444, 43);
            this.option5.Name = "option5";
            this.option5.Size = new System.Drawing.Size(200, 100);
            this.option5.TabIndex = 1;
            // 
            // option2
            // 
            this.option2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.option2.Location = new System.Drawing.Point(3, 109);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(247, 100);
            this.option2.TabIndex = 1;
            // 
            // option1
            // 
            this.option1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.option1.Location = new System.Drawing.Point(3, 3);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(247, 100);
            this.option1.TabIndex = 1;
            // 
            // option4
            // 
            this.option4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.option4.Location = new System.Drawing.Point(3, 321);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(200, 100);
            this.option4.TabIndex = 4;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 687);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.Text = "Admin Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.FlowLayoutPanel sidePanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel option5;
        private System.Windows.Forms.Panel option1;
        private System.Windows.Forms.Panel option2;
        private System.Windows.Forms.Panel option3;
        private System.Windows.Forms.Panel option4;
    }
}