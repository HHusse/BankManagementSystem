
namespace BankManagementSystem.Forms
{
    partial class RetragereOperator
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
            this.label2 = new System.Windows.Forms.Label();
            this.ContLabel = new System.Windows.Forms.Label();
            this.InapoiButton = new System.Windows.Forms.Button();
            this.RetragereBox = new System.Windows.Forms.Button();
            this.SumaBox = new System.Windows.Forms.TextBox();
            this.ContBox = new System.Windows.Forms.TextBox();
            this.VerificareButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CautareButton
            // 
            this.CautareButton.Location = new System.Drawing.Point(414, 59);
            this.CautareButton.Name = "CautareButton";
            this.CautareButton.Size = new System.Drawing.Size(154, 24);
            this.CautareButton.TabIndex = 13;
            this.CautareButton.Text = "Cautare dupa CNP";
            this.CautareButton.UseVisualStyleBackColor = true;
            this.CautareButton.Click += new System.EventHandler(this.CautareButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Suma dorita";
            // 
            // ContLabel
            // 
            this.ContLabel.AutoSize = true;
            this.ContLabel.Location = new System.Drawing.Point(247, 128);
            this.ContLabel.Name = "ContLabel";
            this.ContLabel.Size = new System.Drawing.Size(86, 17);
            this.ContLabel.TabIndex = 11;
            this.ContLabel.Text = "Cont Bancar";
            // 
            // InapoiButton
            // 
            this.InapoiButton.Location = new System.Drawing.Point(250, 348);
            this.InapoiButton.Name = "InapoiButton";
            this.InapoiButton.Size = new System.Drawing.Size(322, 33);
            this.InapoiButton.TabIndex = 10;
            this.InapoiButton.Text = "Inapoi";
            this.InapoiButton.UseVisualStyleBackColor = true;
            this.InapoiButton.Click += new System.EventHandler(this.InapoiButton_Click);
            // 
            // RetragereBox
            // 
            this.RetragereBox.Location = new System.Drawing.Point(247, 310);
            this.RetragereBox.Name = "RetragereBox";
            this.RetragereBox.Size = new System.Drawing.Size(322, 32);
            this.RetragereBox.TabIndex = 9;
            this.RetragereBox.Text = "Retragere";
            this.RetragereBox.UseVisualStyleBackColor = true;
            this.RetragereBox.Click += new System.EventHandler(this.RetragereBox_Click);
            // 
            // SumaBox
            // 
            this.SumaBox.Location = new System.Drawing.Point(247, 220);
            this.SumaBox.Name = "SumaBox";
            this.SumaBox.Size = new System.Drawing.Size(322, 22);
            this.SumaBox.TabIndex = 8;
            // 
            // ContBox
            // 
            this.ContBox.Location = new System.Drawing.Point(247, 151);
            this.ContBox.Name = "ContBox";
            this.ContBox.Size = new System.Drawing.Size(322, 22);
            this.ContBox.TabIndex = 7;
            // 
            // VerificareButton
            // 
            this.VerificareButton.Location = new System.Drawing.Point(589, 146);
            this.VerificareButton.Name = "VerificareButton";
            this.VerificareButton.Size = new System.Drawing.Size(120, 32);
            this.VerificareButton.TabIndex = 14;
            this.VerificareButton.Text = "Verificare sold";
            this.VerificareButton.UseVisualStyleBackColor = true;
            this.VerificareButton.Click += new System.EventHandler(this.VerificareButton_Click);
            // 
            // RetragereOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VerificareButton);
            this.Controls.Add(this.CautareButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ContLabel);
            this.Controls.Add(this.InapoiButton);
            this.Controls.Add(this.RetragereBox);
            this.Controls.Add(this.SumaBox);
            this.Controls.Add(this.ContBox);
            this.Name = "RetragereOperator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RetragereOperator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CautareButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ContLabel;
        private System.Windows.Forms.Button InapoiButton;
        private System.Windows.Forms.Button RetragereBox;
        private System.Windows.Forms.TextBox SumaBox;
        private System.Windows.Forms.TextBox ContBox;
        private System.Windows.Forms.Button VerificareButton;
    }
}