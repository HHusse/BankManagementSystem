
namespace BankManagementSystem.Forms
{
    partial class AdaugareContBancar
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
            this.RONButton = new System.Windows.Forms.RadioButton();
            this.EURButton = new System.Windows.Forms.RadioButton();
            this.USDButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RONButton
            // 
            this.RONButton.AutoSize = true;
            this.RONButton.Location = new System.Drawing.Point(159, 172);
            this.RONButton.Name = "RONButton";
            this.RONButton.Size = new System.Drawing.Size(60, 21);
            this.RONButton.TabIndex = 0;
            this.RONButton.TabStop = true;
            this.RONButton.Text = "RON";
            this.RONButton.UseVisualStyleBackColor = true;
            this.RONButton.CheckedChanged += new System.EventHandler(this.RONButton_CheckedChanged);
            // 
            // EURButton
            // 
            this.EURButton.AutoSize = true;
            this.EURButton.Location = new System.Drawing.Point(308, 172);
            this.EURButton.Name = "EURButton";
            this.EURButton.Size = new System.Drawing.Size(58, 21);
            this.EURButton.TabIndex = 1;
            this.EURButton.TabStop = true;
            this.EURButton.Text = "EUR";
            this.EURButton.UseVisualStyleBackColor = true;
            this.EURButton.CheckedChanged += new System.EventHandler(this.EURButton_CheckedChanged);
            // 
            // USDButton
            // 
            this.USDButton.AutoSize = true;
            this.USDButton.Location = new System.Drawing.Point(455, 172);
            this.USDButton.Name = "USDButton";
            this.USDButton.Size = new System.Drawing.Size(58, 21);
            this.USDButton.TabIndex = 2;
            this.USDButton.TabStop = true;
            this.USDButton.Text = "USD";
            this.USDButton.UseVisualStyleBackColor = true;
            this.USDButton.CheckedChanged += new System.EventHandler(this.USDButton_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Creare cont bancar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(406, 22);
            this.textBox1.TabIndex = 4;
            // 
            // AdaugareContBancar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 300);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.USDButton);
            this.Controls.Add(this.EURButton);
            this.Controls.Add(this.RONButton);
            this.Name = "AdaugareContBancar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdaugareContBancar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RONButton;
        private System.Windows.Forms.RadioButton EURButton;
        private System.Windows.Forms.RadioButton USDButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}