
namespace frame4_injector
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.portbox = new System.Windows.Forms.TextBox();
            this.ipbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusUp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(130)))), ((int)(((byte)(218)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(17, 124);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 22);
            this.button1.TabIndex = 11;
            this.button1.Text = "Inject Payload";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // portbox
            // 
            this.portbox.BackColor = System.Drawing.Color.White;
            this.portbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portbox.ForeColor = System.Drawing.Color.Black;
            this.portbox.Location = new System.Drawing.Point(106, 100);
            this.portbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.portbox.Name = "portbox";
            this.portbox.Size = new System.Drawing.Size(115, 20);
            this.portbox.TabIndex = 10;
            this.portbox.Text = "Enter Console Port";
            // 
            // ipbox
            // 
            this.ipbox.BackColor = System.Drawing.Color.White;
            this.ipbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipbox.ForeColor = System.Drawing.Color.Black;
            this.ipbox.Location = new System.Drawing.Point(106, 65);
            this.ipbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ipbox.Name = "ipbox";
            this.ipbox.Size = new System.Drawing.Size(115, 20);
            this.ipbox.TabIndex = 9;
            this.ipbox.Text = "Enter console IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Console Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Console IP:";
            // 
            // StatusUp
            // 
            this.StatusUp.AutoSize = true;
            this.StatusUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StatusUp.ForeColor = System.Drawing.Color.Red;
            this.StatusUp.Location = new System.Drawing.Point(22, 182);
            this.StatusUp.Name = "StatusUp";
            this.StatusUp.Size = new System.Drawing.Size(102, 17);
            this.StatusUp.TabIndex = 13;
            this.StatusUp.Text = "Not Connected";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Connection Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(254, 206);
            this.Controls.Add(this.StatusUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.portbox);
            this.Controls.Add(this.ipbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Frame4.bin Injector";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox portbox;
        private System.Windows.Forms.TextBox ipbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatusUp;
        private System.Windows.Forms.Label label3;
    }
}

