namespace Algorithm_Project
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
            this.cb_options = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.txt_show = new System.Windows.Forms.TextBox();
            this.txt_file = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_output_path = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_options
            // 
            this.cb_options.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_options.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_options.FormattingEnabled = true;
            this.cb_options.Location = new System.Drawing.Point(12, 61);
            this.cb_options.Name = "cb_options";
            this.cb_options.Size = new System.Drawing.Size(370, 24);
            this.cb_options.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(12, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(12, 105);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(370, 24);
            this.txt_input.TabIndex = 2;
            this.txt_input.Text = "write number to search";
            // 
            // txt_show
            // 
            this.txt_show.Location = new System.Drawing.Point(12, 154);
            this.txt_show.Name = "txt_show";
            this.txt_show.Size = new System.Drawing.Size(370, 24);
            this.txt_show.TabIndex = 3;
            // 
            // txt_file
            // 
            this.txt_file.Location = new System.Drawing.Point(12, 13);
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(370, 24);
            this.txt_file.TabIndex = 4;
            this.txt_file.Text = "write path of file";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(370, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "output of sort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_output_path
            // 
            this.txt_output_path.Location = new System.Drawing.Point(0, 14);
            this.txt_output_path.Name = "txt_output_path";
            this.txt_output_path.Size = new System.Drawing.Size(370, 24);
            this.txt_output_path.TabIndex = 6;
            this.txt_output_path.Text = "write path of  output file";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_output_path);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(12, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 100);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 369);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_file);
            this.Controls.Add(this.txt_show);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_options);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_options;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.TextBox txt_show;
        private System.Windows.Forms.TextBox txt_file;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_output_path;
        private System.Windows.Forms.Panel panel1;
    }
}

