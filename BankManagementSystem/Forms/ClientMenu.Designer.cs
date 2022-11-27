
namespace BankManagementSystem.Forms
{
    partial class ClientMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.SoldButton = new System.Windows.Forms.Button();
            this.AdaugareContButton = new System.Windows.Forms.Button();
            this.InapoiSelectareButton = new System.Windows.Forms.Button();
            this.DepunereButton = new System.Windows.Forms.Button();
            this.RetragereButton = new System.Windows.Forms.Button();
            this.TransferButton = new System.Windows.Forms.Button();
            this.LichidareButton = new System.Windows.Forms.Button();
            this.TransferContPersonalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "XXXXXXXXXXXXX";
            // 
            // SoldButton
            // 
            this.SoldButton.Location = new System.Drawing.Point(12, 150);
            this.SoldButton.Name = "SoldButton";
            this.SoldButton.Size = new System.Drawing.Size(173, 32);
            this.SoldButton.TabIndex = 1;
            this.SoldButton.Text = "Interogare Sold";
            this.SoldButton.UseVisualStyleBackColor = true;
            this.SoldButton.Click += new System.EventHandler(this.SoldButton_Click);
            // 
            // AdaugareContButton
            // 
            this.AdaugareContButton.Location = new System.Drawing.Point(447, 387);
            this.AdaugareContButton.Name = "AdaugareContButton";
            this.AdaugareContButton.Size = new System.Drawing.Size(173, 32);
            this.AdaugareContButton.TabIndex = 2;
            this.AdaugareContButton.Text = "Adaugare Cont Nou";
            this.AdaugareContButton.UseVisualStyleBackColor = true;
            this.AdaugareContButton.Click += new System.EventHandler(this.AdaugareContButton_Click);
            // 
            // InapoiSelectareButton
            // 
            this.InapoiSelectareButton.Location = new System.Drawing.Point(12, 387);
            this.InapoiSelectareButton.Name = "InapoiSelectareButton";
            this.InapoiSelectareButton.Size = new System.Drawing.Size(173, 32);
            this.InapoiSelectareButton.TabIndex = 3;
            this.InapoiSelectareButton.Text = "Inapoi la selectare cont";
            this.InapoiSelectareButton.UseVisualStyleBackColor = true;
            this.InapoiSelectareButton.Click += new System.EventHandler(this.InapoiSelectareButton_Click);
            // 
            // DepunereButton
            // 
            this.DepunereButton.Location = new System.Drawing.Point(12, 230);
            this.DepunereButton.Name = "DepunereButton";
            this.DepunereButton.Size = new System.Drawing.Size(173, 32);
            this.DepunereButton.TabIndex = 4;
            this.DepunereButton.Text = "Depunere numerar";
            this.DepunereButton.UseVisualStyleBackColor = true;
            this.DepunereButton.Click += new System.EventHandler(this.DepunereButton_Click);
            // 
            // RetragereButton
            // 
            this.RetragereButton.Location = new System.Drawing.Point(12, 298);
            this.RetragereButton.Name = "RetragereButton";
            this.RetragereButton.Size = new System.Drawing.Size(173, 32);
            this.RetragereButton.TabIndex = 5;
            this.RetragereButton.Text = "Retragere numerar";
            this.RetragereButton.UseVisualStyleBackColor = true;
            this.RetragereButton.Click += new System.EventHandler(this.RetragereButton_Click);
            // 
            // TransferButton
            // 
            this.TransferButton.Location = new System.Drawing.Point(447, 150);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(173, 32);
            this.TransferButton.TabIndex = 6;
            this.TransferButton.Text = "Transfer Bancar";
            this.TransferButton.UseVisualStyleBackColor = true;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // LichidareButton
            // 
            this.LichidareButton.Location = new System.Drawing.Point(447, 298);
            this.LichidareButton.Name = "LichidareButton";
            this.LichidareButton.Size = new System.Drawing.Size(173, 32);
            this.LichidareButton.TabIndex = 7;
            this.LichidareButton.Text = "Lichidar Cont";
            this.LichidareButton.UseVisualStyleBackColor = true;
            this.LichidareButton.Click += new System.EventHandler(this.LichidareButton_Click);
            // 
            // TransferContPersonalButton
            // 
            this.TransferContPersonalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferContPersonalButton.Location = new System.Drawing.Point(447, 230);
            this.TransferContPersonalButton.Name = "TransferContPersonalButton";
            this.TransferContPersonalButton.Size = new System.Drawing.Size(173, 32);
            this.TransferContPersonalButton.TabIndex = 8;
            this.TransferContPersonalButton.Text = "Transfer Conturi Personale";
            this.TransferContPersonalButton.UseVisualStyleBackColor = true;
            this.TransferContPersonalButton.Click += new System.EventHandler(this.TransferContPersonalButton_Click);
            // 
            // ClientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.TransferContPersonalButton);
            this.Controls.Add(this.LichidareButton);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.RetragereButton);
            this.Controls.Add(this.DepunereButton);
            this.Controls.Add(this.InapoiSelectareButton);
            this.Controls.Add(this.AdaugareContButton);
            this.Controls.Add(this.SoldButton);
            this.Controls.Add(this.label1);
            this.Name = "ClientMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientMenu";
            this.Load += new System.EventHandler(this.ClientMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SoldButton;
        private System.Windows.Forms.Button AdaugareContButton;
        private System.Windows.Forms.Button InapoiSelectareButton;
        private System.Windows.Forms.Button DepunereButton;
        private System.Windows.Forms.Button RetragereButton;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.Button LichidareButton;
        private System.Windows.Forms.Button TransferContPersonalButton;
    }
}