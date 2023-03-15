namespace WindowsFormsApplication1
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
            this.submit = new System.Windows.Forms.Button();
            this.firstNameInputField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameInputField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.submit.Location = new System.Drawing.Point(169, 299);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(142, 56);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstNameInputField
            // 
            this.firstNameInputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.firstNameInputField.Location = new System.Drawing.Point(102, 152);
            this.firstNameInputField.Name = "firstNameInputField";
            this.firstNameInputField.Size = new System.Drawing.Size(189, 21);
            this.firstNameInputField.TabIndex = 1;
            this.firstNameInputField.Text = "Enter First Name Here";
            this.firstNameInputField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(89, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(89, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // lastNameInputField
            // 
            this.lastNameInputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lastNameInputField.Location = new System.Drawing.Point(102, 230);
            this.lastNameInputField.Name = "lastNameInputField";
            this.lastNameInputField.Size = new System.Drawing.Size(189, 21);
            this.lastNameInputField.TabIndex = 4;
            this.lastNameInputField.Text = "Enter Last Name Here";
            this.lastNameInputField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.Location = new System.Drawing.Point(85, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Greetings Generator!";
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.exit.Location = new System.Drawing.Point(169, 375);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(142, 56);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 473);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastNameInputField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameInputField);
            this.Controls.Add(this.submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox firstNameInputField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameInputField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exit;
    }
}

