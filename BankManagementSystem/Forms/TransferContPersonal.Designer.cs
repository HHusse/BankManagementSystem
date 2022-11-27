
namespace BankManagementSystem.Forms
{
    partial class TransferContPersonal
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
            this.ConturiBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SumaBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MonedaLabel = new System.Windows.Forms.Label();
            this.TransferButton = new System.Windows.Forms.Button();
            this.SoldLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConturiBox
            // 
            this.ConturiBox.FormattingEnabled = true;
            this.ConturiBox.Location = new System.Drawing.Point(112, 100);
            this.ConturiBox.Name = "ConturiBox";
            this.ConturiBox.Size = new System.Drawing.Size(262, 24);
            this.ConturiBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "In contul:";
            // 
            // SumaBox
            // 
            this.SumaBox.Location = new System.Drawing.Point(112, 153);
            this.SumaBox.Name = "SumaBox";
            this.SumaBox.Size = new System.Drawing.Size(262, 22);
            this.SumaBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Suma dorita:";
            // 
            // MonedaLabel
            // 
            this.MonedaLabel.AutoSize = true;
            this.MonedaLabel.Location = new System.Drawing.Point(392, 157);
            this.MonedaLabel.Name = "MonedaLabel";
            this.MonedaLabel.Size = new System.Drawing.Size(59, 17);
            this.MonedaLabel.TabIndex = 4;
            this.MonedaLabel.Text = "Moneda";
            // 
            // TransferButton
            // 
            this.TransferButton.Location = new System.Drawing.Point(53, 253);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(385, 35);
            this.TransferButton.TabIndex = 5;
            this.TransferButton.Text = "Transfer";
            this.TransferButton.UseVisualStyleBackColor = true;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // SoldLabel
            // 
            this.SoldLabel.AutoSize = true;
            this.SoldLabel.Location = new System.Drawing.Point(109, 37);
            this.SoldLabel.Name = "SoldLabel";
            this.SoldLabel.Size = new System.Drawing.Size(46, 17);
            this.SoldLabel.TabIndex = 6;
            this.SoldLabel.Text = "SOLD";
            // 
            // TransferContPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 351);
            this.Controls.Add(this.SoldLabel);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.MonedaLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SumaBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConturiBox);
            this.Name = "TransferContPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransferContPersonal";
            this.Load += new System.EventHandler(this.TransferContPersonal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ConturiBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SumaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MonedaLabel;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.Label SoldLabel;
    }
}