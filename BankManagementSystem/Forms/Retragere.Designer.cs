
namespace BankManagementSystem.Forms
{
    partial class Retragere
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
            this.RetragereButton = new System.Windows.Forms.Button();
            this.SoldLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SumaBox
            // 
            this.SumaBox.Location = new System.Drawing.Point(70, 74);
            this.SumaBox.Name = "SumaBox";
            this.SumaBox.Size = new System.Drawing.Size(304, 22);
            this.SumaBox.TabIndex = 0;
            // 
            // MonedaLabel
            // 
            this.MonedaLabel.AutoSize = true;
            this.MonedaLabel.Location = new System.Drawing.Point(381, 78);
            this.MonedaLabel.Name = "MonedaLabel";
            this.MonedaLabel.Size = new System.Drawing.Size(68, 17);
            this.MonedaLabel.TabIndex = 1;
            this.MonedaLabel.Text = "MONEDA";
            // 
            // RetragereButton
            // 
            this.RetragereButton.Location = new System.Drawing.Point(70, 126);
            this.RetragereButton.Name = "RetragereButton";
            this.RetragereButton.Size = new System.Drawing.Size(139, 31);
            this.RetragereButton.TabIndex = 2;
            this.RetragereButton.Text = "Retragere";
            this.RetragereButton.UseVisualStyleBackColor = true;
            this.RetragereButton.Click += new System.EventHandler(this.RetragereButton_Click);
            // 
            // SoldLabel
            // 
            this.SoldLabel.AutoSize = true;
            this.SoldLabel.Location = new System.Drawing.Point(67, 25);
            this.SoldLabel.Name = "SoldLabel";
            this.SoldLabel.Size = new System.Drawing.Size(46, 17);
            this.SoldLabel.TabIndex = 3;
            this.SoldLabel.Text = "SOLD";
            // 
            // Retragere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 205);
            this.Controls.Add(this.SoldLabel);
            this.Controls.Add(this.RetragereButton);
            this.Controls.Add(this.MonedaLabel);
            this.Controls.Add(this.SumaBox);
            this.Name = "Retragere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retragere";
            this.Load += new System.EventHandler(this.Retragere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SumaBox;
        private System.Windows.Forms.Label MonedaLabel;
        private System.Windows.Forms.Button RetragereButton;
        private System.Windows.Forms.Label SoldLabel;
    }
}