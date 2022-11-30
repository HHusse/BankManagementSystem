
namespace BankManagementSystem.Forms
{
    partial class DepunereOperator
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
            this.ContBox = new System.Windows.Forms.TextBox();
            this.SumaBox = new System.Windows.Forms.TextBox();
            this.DepunereBox = new System.Windows.Forms.Button();
            this.InapoiButton = new System.Windows.Forms.Button();
            this.ContLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CautareButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContBox
            // 
            this.ContBox.Location = new System.Drawing.Point(179, 149);
            this.ContBox.Name = "ContBox";
            this.ContBox.Size = new System.Drawing.Size(322, 22);
            this.ContBox.TabIndex = 0;
            // 
            // SumaBox
            // 
            this.SumaBox.Location = new System.Drawing.Point(178, 213);
            this.SumaBox.Name = "SumaBox";
            this.SumaBox.Size = new System.Drawing.Size(322, 22);
            this.SumaBox.TabIndex = 1;
            // 
            // DepunereBox
            // 
            this.DepunereBox.Location = new System.Drawing.Point(182, 308);
            this.DepunereBox.Name = "DepunereBox";
            this.DepunereBox.Size = new System.Drawing.Size(322, 32);
            this.DepunereBox.TabIndex = 2;
            this.DepunereBox.Text = "Depune";
            this.DepunereBox.UseVisualStyleBackColor = true;
            this.DepunereBox.Click += new System.EventHandler(this.DepunereBox_Click);
            // 
            // InapoiButton
            // 
            this.InapoiButton.Location = new System.Drawing.Point(182, 346);
            this.InapoiButton.Name = "InapoiButton";
            this.InapoiButton.Size = new System.Drawing.Size(322, 33);
            this.InapoiButton.TabIndex = 3;
            this.InapoiButton.Text = "Inapoi";
            this.InapoiButton.UseVisualStyleBackColor = true;
            this.InapoiButton.Click += new System.EventHandler(this.InapoiButton_Click);
            // 
            // ContLabel
            // 
            this.ContLabel.AutoSize = true;
            this.ContLabel.Location = new System.Drawing.Point(179, 126);
            this.ContLabel.Name = "ContLabel";
            this.ContLabel.Size = new System.Drawing.Size(86, 17);
            this.ContLabel.TabIndex = 4;
            this.ContLabel.Text = "Cont Bancar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Suma dorita";
            // 
            // CautareButton
            // 
            this.CautareButton.Location = new System.Drawing.Point(349, 57);
            this.CautareButton.Name = "CautareButton";
            this.CautareButton.Size = new System.Drawing.Size(151, 23);
            this.CautareButton.TabIndex = 6;
            this.CautareButton.Text = "Cautare dupa CNP";
            this.CautareButton.UseVisualStyleBackColor = true;
            this.CautareButton.Click += new System.EventHandler(this.CautareButton_Click);
            // 
            // DepunereOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.CautareButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ContLabel);
            this.Controls.Add(this.InapoiButton);
            this.Controls.Add(this.DepunereBox);
            this.Controls.Add(this.SumaBox);
            this.Controls.Add(this.ContBox);
            this.Name = "DepunereOperator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepunereOperator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ContBox;
        private System.Windows.Forms.TextBox SumaBox;
        private System.Windows.Forms.Button DepunereBox;
        private System.Windows.Forms.Button InapoiButton;
        private System.Windows.Forms.Label ContLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CautareButton;
    }
}