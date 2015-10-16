namespace ShopWithUs
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblAmtBeforeDiscLabel = new System.Windows.Forms.Label();
            this.lblDiscAmtLabel = new System.Windows.Forms.Label();
            this.lblAmtAfterDiscLabel = new System.Windows.Forms.Label();
            this.lblAmtBeforeDisc = new System.Windows.Forms.Label();
            this.lblDiscAmt = new System.Windows.Forms.Label();
            this.lblAmtAfterDisc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 392);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(227, 162);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(258, 392);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(228, 162);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lblAmtBeforeDiscLabel
            // 
            this.lblAmtBeforeDiscLabel.AutoSize = true;
            this.lblAmtBeforeDiscLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmtBeforeDiscLabel.Location = new System.Drawing.Point(512, 432);
            this.lblAmtBeforeDiscLabel.Name = "lblAmtBeforeDiscLabel";
            this.lblAmtBeforeDiscLabel.Size = new System.Drawing.Size(219, 24);
            this.lblAmtBeforeDiscLabel.TabIndex = 2;
            this.lblAmtBeforeDiscLabel.Text = "Amount Before Discount:";
            // 
            // lblDiscAmtLabel
            // 
            this.lblDiscAmtLabel.AutoSize = true;
            this.lblDiscAmtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscAmtLabel.Location = new System.Drawing.Point(512, 459);
            this.lblDiscAmtLabel.Name = "lblDiscAmtLabel";
            this.lblDiscAmtLabel.Size = new System.Drawing.Size(159, 24);
            this.lblDiscAmtLabel.TabIndex = 3;
            this.lblDiscAmtLabel.Text = "Discount Amount:";
            // 
            // lblAmtAfterDiscLabel
            // 
            this.lblAmtAfterDiscLabel.AutoSize = true;
            this.lblAmtAfterDiscLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmtAfterDiscLabel.Location = new System.Drawing.Point(512, 484);
            this.lblAmtAfterDiscLabel.Name = "lblAmtAfterDiscLabel";
            this.lblAmtAfterDiscLabel.Size = new System.Drawing.Size(248, 24);
            this.lblAmtAfterDiscLabel.TabIndex = 4;
            this.lblAmtAfterDiscLabel.Text = "Total Amount After Discount:";
            // 
            // lblAmtBeforeDisc
            // 
            this.lblAmtBeforeDisc.AutoSize = true;
            this.lblAmtBeforeDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmtBeforeDisc.Location = new System.Drawing.Point(830, 432);
            this.lblAmtBeforeDisc.Name = "lblAmtBeforeDisc";
            this.lblAmtBeforeDisc.Size = new System.Drawing.Size(45, 24);
            this.lblAmtBeforeDisc.TabIndex = 5;
            this.lblAmtBeforeDisc.Text = "0.00";
            // 
            // lblDiscAmt
            // 
            this.lblDiscAmt.AutoSize = true;
            this.lblDiscAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscAmt.Location = new System.Drawing.Point(830, 459);
            this.lblDiscAmt.Name = "lblDiscAmt";
            this.lblDiscAmt.Size = new System.Drawing.Size(45, 24);
            this.lblDiscAmt.TabIndex = 6;
            this.lblDiscAmt.Text = "0.00";
            // 
            // lblAmtAfterDisc
            // 
            this.lblAmtAfterDisc.AutoSize = true;
            this.lblAmtAfterDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmtAfterDisc.Location = new System.Drawing.Point(830, 484);
            this.lblAmtAfterDisc.Name = "lblAmtAfterDisc";
            this.lblAmtAfterDisc.Size = new System.Drawing.Size(45, 24);
            this.lblAmtAfterDisc.TabIndex = 7;
            this.lblAmtAfterDisc.Text = "0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 571);
            this.Controls.Add(this.lblAmtAfterDisc);
            this.Controls.Add(this.lblDiscAmt);
            this.Controls.Add(this.lblAmtBeforeDisc);
            this.Controls.Add(this.lblAmtAfterDiscLabel);
            this.Controls.Add(this.lblDiscAmtLabel);
            this.Controls.Add(this.lblAmtBeforeDiscLabel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblAmtBeforeDiscLabel;
        private System.Windows.Forms.Label lblDiscAmtLabel;
        private System.Windows.Forms.Label lblAmtAfterDiscLabel;
        private System.Windows.Forms.Label lblAmtBeforeDisc;
        private System.Windows.Forms.Label lblDiscAmt;
        private System.Windows.Forms.Label lblAmtAfterDisc;
    }
}

