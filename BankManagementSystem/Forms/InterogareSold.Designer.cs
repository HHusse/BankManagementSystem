
namespace BankManagementSystem.Forms
{
    partial class InterogareSold
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
            this.CautareButton = new System.Windows.Forms.Button();
            this.ContLabel = new System.Windows.Forms.Label();
            this.InapoiButton = new System.Windows.Forms.Button();
            this.DepunereBox = new System.Windows.Forms.Button();
            this.ContBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CautareButton
            // 
            this.CautareButton.Location = new System.Drawing.Point(408, 64);
            this.CautareButton.Name = "CautareButton";
            this.CautareButton.Size = new System.Drawing.Size(151, 28);
            this.CautareButton.TabIndex = 13;
            this.CautareButton.Text = "Cautare dupa CNP";
            this.CautareButton.UseVisualStyleBackColor = true;
            this.CautareButton.Click += new System.EventHandler(this.CautareButton_Click);
            // 
            // ContLabel
            // 
            this.ContLabel.AutoSize = true;
            this.ContLabel.Location = new System.Drawing.Point(238, 133);
            this.ContLabel.Name = "ContLabel";
            this.ContLabel.Size = new System.Drawing.Size(86, 17);
            this.ContLabel.TabIndex = 11;
            this.ContLabel.Text = "Cont Bancar";
            // 
            // InapoiButton
            // 
            this.InapoiButton.Location = new System.Drawing.Point(241, 252);
            this.InapoiButton.Name = "InapoiButton";
            this.InapoiButton.Size = new System.Drawing.Size(322, 30);
            this.InapoiButton.TabIndex = 10;
            this.InapoiButton.Text = "Inapoi";
            this.InapoiButton.UseVisualStyleBackColor = true;
            this.InapoiButton.Click += new System.EventHandler(this.InapoiButton_Click);
            // 
            // DepunereBox
            // 
            this.DepunereBox.Location = new System.Drawing.Point(241, 214);
            this.DepunereBox.Name = "DepunereBox";
            this.DepunereBox.Size = new System.Drawing.Size(322, 29);
            this.DepunereBox.TabIndex = 9;
            this.DepunereBox.Text = "Interogare Sold";
            this.DepunereBox.UseVisualStyleBackColor = true;
            this.DepunereBox.Click += new System.EventHandler(this.DepunereBox_Click);
            // 
            // ContBox
            // 
            this.ContBox.Location = new System.Drawing.Point(238, 156);
            this.ContBox.Name = "ContBox";
            this.ContBox.Size = new System.Drawing.Size(322, 22);
            this.ContBox.TabIndex = 7;
            // 
            // InterogareSold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 367);
            this.Controls.Add(this.CautareButton);
            this.Controls.Add(this.ContLabel);
            this.Controls.Add(this.InapoiButton);
            this.Controls.Add(this.DepunereBox);
            this.Controls.Add(this.ContBox);
            this.Name = "InterogareSold";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterogareSold";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CautareButton;
        private System.Windows.Forms.Label ContLabel;
        private System.Windows.Forms.Button InapoiButton;
        private System.Windows.Forms.Button DepunereBox;
        private System.Windows.Forms.TextBox ContBox;
    }
}