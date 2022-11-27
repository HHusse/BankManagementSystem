
namespace BankManagementSystem.Forms
{
    partial class Depunere
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
            this.label = new System.Windows.Forms.Label();
            this.DepunereButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SumaBox
            // 
            this.SumaBox.Location = new System.Drawing.Point(40, 46);
            this.SumaBox.Name = "SumaBox";
            this.SumaBox.Size = new System.Drawing.Size(315, 22);
            this.SumaBox.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(383, 49);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 17);
            this.label.TabIndex = 1;
            this.label.Text = "Moneda";
            // 
            // DepunereButton
            // 
            this.DepunereButton.Location = new System.Drawing.Point(40, 118);
            this.DepunereButton.Name = "DepunereButton";
            this.DepunereButton.Size = new System.Drawing.Size(166, 38);
            this.DepunereButton.TabIndex = 2;
            this.DepunereButton.Text = "Depunere";
            this.DepunereButton.UseVisualStyleBackColor = true;
            this.DepunereButton.Click += new System.EventHandler(this.DepunereButton_Click);
            // 
            // Depunere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 195);
            this.Controls.Add(this.DepunereButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.SumaBox);
            this.Name = "Depunere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depunere";
            this.Load += new System.EventHandler(this.Depunere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SumaBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button DepunereButton;
    }
}