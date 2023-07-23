namespace CityBookCentre.Admin
{
    partial class welcome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(16, 27);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(117, 42);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.BackColor = System.Drawing.Color.Transparent;
            this.role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.role.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.Location = new System.Drawing.Point(480, 27);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(95, 42);
            this.role.TabIndex = 1;
            this.role.Text = "Role";
            this.role.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.BackColor = System.Drawing.Color.Transparent;
            this.labelRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(659, 27);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(118, 42);
            this.labelRole.TabIndex = 3;
            this.labelRole.Text = "label3";
            this.labelRole.Click += new System.EventHandler(this.labelRole_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(202, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(118, 42);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CityBookCentre.Properties.Resources.grid;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(930, 464);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.role);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "welcome";
            this.Size = new System.Drawing.Size(933, 464);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
