
namespace BankManagementSystem.Forms
{
    partial class Register
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
            this.NumeBox = new System.Windows.Forms.TextBox();
            this.PrenumeBox = new System.Windows.Forms.TextBox();
            this.CNPBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.PINBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ValidareButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumeBox
            // 
            this.NumeBox.Location = new System.Drawing.Point(181, 67);
            this.NumeBox.Name = "NumeBox";
            this.NumeBox.Size = new System.Drawing.Size(384, 22);
            this.NumeBox.TabIndex = 0;
            this.NumeBox.TextChanged += new System.EventHandler(this.NumeBox_TextChanged);
            // 
            // PrenumeBox
            // 
            this.PrenumeBox.Location = new System.Drawing.Point(181, 95);
            this.PrenumeBox.Name = "PrenumeBox";
            this.PrenumeBox.Size = new System.Drawing.Size(384, 22);
            this.PrenumeBox.TabIndex = 1;
            this.PrenumeBox.TextChanged += new System.EventHandler(this.PrenumeBox_TextChanged);
            // 
            // CNPBox
            // 
            this.CNPBox.Location = new System.Drawing.Point(181, 123);
            this.CNPBox.Name = "CNPBox";
            this.CNPBox.Size = new System.Drawing.Size(384, 22);
            this.CNPBox.TabIndex = 2;
            this.CNPBox.TextChanged += new System.EventHandler(this.CNPBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "CNP";
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(181, 242);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(210, 22);
            this.UserBox.TabIndex = 6;
            // 
            // PINBox
            // 
            this.PINBox.Location = new System.Drawing.Point(181, 271);
            this.PINBox.MaxLength = 4;
            this.PINBox.Name = "PINBox";
            this.PINBox.PasswordChar = '*';
            this.PINBox.Size = new System.Drawing.Size(210, 22);
            this.PINBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "PIN";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Enabled = false;
            this.RegisterButton.Location = new System.Drawing.Point(106, 357);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(459, 30);
            this.RegisterButton.TabIndex = 10;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // ValidareButton
            // 
            this.ValidareButton.Location = new System.Drawing.Point(470, 151);
            this.ValidareButton.Name = "ValidareButton";
            this.ValidareButton.Size = new System.Drawing.Size(95, 30);
            this.ValidareButton.TabIndex = 11;
            this.ValidareButton.Text = "Validare";
            this.ValidareButton.UseVisualStyleBackColor = true;
            this.ValidareButton.Click += new System.EventHandler(this.ValidareButton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.ValidareButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PINBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CNPBox);
            this.Controls.Add(this.PrenumeBox);
            this.Controls.Add(this.NumeBox);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumeBox;
        private System.Windows.Forms.TextBox PrenumeBox;
        private System.Windows.Forms.TextBox CNPBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox PINBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button ValidareButton;
    }
}