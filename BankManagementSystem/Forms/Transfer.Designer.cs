
namespace BankManagementSystem.Forms
{
    partial class Transfer
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
            this.SumaBox = new System.Windows.Forms.TextBox();
            this.MonedaLabel = new System.Windows.Forms.Label();
            this.CatreBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SoldLabel = new System.Windows.Forms.Label();
            this.TransferButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SumaBox
            // 
            this.SumaBox.Location = new System.Drawing.Point(105, 72);
            this.SumaBox.Name = "SumaBox";
            this.SumaBox.Size = new System.Drawing.Size(235, 22);
            this.SumaBox.TabIndex = 0;
            // 
            // MonedaLabel
            // 
            this.MonedaLabel.AutoSize = true;
            this.MonedaLabel.Location = new System.Drawing.Point(351, 72);
            this.MonedaLabel.Name = "MonedaLabel";
            this.MonedaLabel.Size = new System.Drawing.Size(59, 17);
            this.MonedaLabel.TabIndex = 1;
            this.MonedaLabel.Text = "Moneda";
            // 
            // CatreBox
            // 
            this.CatreBox.Location = new System.Drawing.Point(105, 114);
            this.CatreBox.Name = "CatreBox";
            this.CatreBox.Size = new System.Drawing.Size(235, 22);
            this.CatreBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Catre:";
            // 
            // SoldLabel
            // 
            this.SoldLabel.AutoSize = true;
            this.SoldLabel.Location = new System.Drawing.Point(194, 32);
            this.SoldLabel.Name = "SoldLabel";
            this.SoldLabel.Size = new System.Drawing.Size(46, 17);
            this.SoldLabel.TabIndex = 4;
            this.SoldLabel.Text = "SOLD";
            // 
            // TransferButton
            // 
            this.TransferButton.Location = new System.Drawing.Point(73, 174);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(75, 23);
            this.TransferButton.TabIndex = 5;
            this.TransferButton.Text = "Transfer";
            this.TransferButton.UseVisualStyleBackColor = true;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Suma dorita:";
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 236);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.SoldLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CatreBox);
            this.Controls.Add(this.MonedaLabel);
            this.Controls.Add(this.SumaBox);
            this.Name = "Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SumaBox;
        private System.Windows.Forms.Label MonedaLabel;
        private System.Windows.Forms.TextBox CatreBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SoldLabel;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.Label label1;
    }
}