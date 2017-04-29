namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Form_Progress = new System.Windows.Forms.ProgressBar();
            this.Form_Browse_Button = new System.Windows.Forms.Button();
            this.Form_Browse_Text = new System.Windows.Forms.TextBox();
            this.Form_Start = new System.Windows.Forms.Button();
            this.Form_Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Form_Progress
            // 
            this.Form_Progress.Location = new System.Drawing.Point(12, 141);
            this.Form_Progress.Name = "Form_Progress";
            this.Form_Progress.Size = new System.Drawing.Size(869, 23);
            this.Form_Progress.TabIndex = 0;
            // 
            // Form_Browse_Button
            // 
            this.Form_Browse_Button.Location = new System.Drawing.Point(806, 73);
            this.Form_Browse_Button.Name = "Form_Browse_Button";
            this.Form_Browse_Button.Size = new System.Drawing.Size(75, 23);
            this.Form_Browse_Button.TabIndex = 1;
            this.Form_Browse_Button.Text = "Browse";
            this.Form_Browse_Button.UseVisualStyleBackColor = true;
            this.Form_Browse_Button.Click += new System.EventHandler(this.Form_Browse_Click);
            // 
            // Form_Browse_Text
            // 
            this.Form_Browse_Text.Location = new System.Drawing.Point(12, 75);
            this.Form_Browse_Text.Name = "Form_Browse_Text";
            this.Form_Browse_Text.Size = new System.Drawing.Size(788, 20);
            this.Form_Browse_Text.TabIndex = 2;
            this.Form_Browse_Text.Text = "E:\\Documents\\My Games\\KillingFloor2\\KFGame\\Cache";
            this.Form_Browse_Text.WordWrap = false;
            // 
            // Form_Start
            // 
            this.Form_Start.Location = new System.Drawing.Point(606, 101);
            this.Form_Start.Name = "Form_Start";
            this.Form_Start.Size = new System.Drawing.Size(275, 32);
            this.Form_Start.TabIndex = 3;
            this.Form_Start.Text = "Go!";
            this.Form_Start.UseVisualStyleBackColor = true;
            this.Form_Start.Click += new System.EventHandler(this.Form_Start_Click);
            // 
            // Form_Text
            // 
            this.Form_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Form_Text.Location = new System.Drawing.Point(13, 13);
            this.Form_Text.Multiline = true;
            this.Form_Text.Name = "Form_Text";
            this.Form_Text.ReadOnly = true;
            this.Form_Text.Size = new System.Drawing.Size(868, 54);
            this.Form_Text.TabIndex = 4;
            this.Form_Text.Text = resources.GetString("Form_Text.Text");
            this.Form_Text.TextChanged += new System.EventHandler(this.Form_Text_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 176);
            this.Controls.Add(this.Form_Text);
            this.Controls.Add(this.Form_Start);
            this.Controls.Add(this.Form_Browse_Text);
            this.Controls.Add(this.Form_Browse_Button);
            this.Controls.Add(this.Form_Progress);
            this.Name = "Form1";
            this.Text = "KF2 Map Name Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Form_Progress;
        private System.Windows.Forms.Button Form_Browse_Button;
        private System.Windows.Forms.TextBox Form_Browse_Text;
        private System.Windows.Forms.Button Form_Start;
        private System.Windows.Forms.TextBox Form_Text;
    }
}

