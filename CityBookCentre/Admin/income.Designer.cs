namespace CityBookCentre.Admin
{
    partial class income
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
            this.labelOrders = new System.Windows.Forms.Label();
            this.labelIncome = new System.Windows.Forms.Label();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.counter = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrders.Location = new System.Drawing.Point(159, 153);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(255, 31);
            this.labelOrders.TabIndex = 0;
            this.labelOrders.Text = "Total Orders Placed";
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncome.Location = new System.Drawing.Point(160, 254);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(171, 31);
            this.labelIncome.TabIndex = 1;
            this.labelIncome.Text = "Total Income";
            // 
            // txtIncome
            // 
            this.txtIncome.AllowDrop = true;
            this.txtIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncome.Location = new System.Drawing.Point(492, 253);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.ReadOnly = true;
            this.txtIncome.Size = new System.Drawing.Size(282, 38);
            this.txtIncome.TabIndex = 2;
            // 
            // counter
            // 
            this.counter.AllowDrop = true;
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counter.Location = new System.Drawing.Point(492, 150);
            this.counter.Name = "counter";
            this.counter.ReadOnly = true;
            this.counter.Size = new System.Drawing.Size(282, 38);
            this.counter.TabIndex = 3;
            this.counter.Text = "domainUpDown1";
            // 
            // income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.counter);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.labelIncome);
            this.Controls.Add(this.labelOrders);
            this.Name = "income";
            this.Size = new System.Drawing.Size(978, 509);
            this.Load += new System.EventHandler(this.income_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.DomainUpDown counter;
    }
}
