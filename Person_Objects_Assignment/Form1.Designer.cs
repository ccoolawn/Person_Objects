namespace Person_Objects_Assignment
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txBxEmail = new System.Windows.Forms.TextBox();
            this.btnAddNewEmail = new System.Windows.Forms.Button();
            this.btnDeleteEmail = new System.Windows.Forms.Button();
            this.btnDeleteCellNum = new System.Windows.Forms.Button();
            this.btnAddCellNum = new System.Windows.Forms.Button();
            this.txBxCellNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(19, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(255, 293);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(280, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(208, 293);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // txBxEmail
            // 
            this.txBxEmail.Location = new System.Drawing.Point(507, 43);
            this.txBxEmail.Name = "txBxEmail";
            this.txBxEmail.Size = new System.Drawing.Size(180, 23);
            this.txBxEmail.TabIndex = 2;
            // 
            // btnAddNewEmail
            // 
            this.btnAddNewEmail.Location = new System.Drawing.Point(507, 72);
            this.btnAddNewEmail.Name = "btnAddNewEmail";
            this.btnAddNewEmail.Size = new System.Drawing.Size(180, 23);
            this.btnAddNewEmail.TabIndex = 3;
            this.btnAddNewEmail.Text = "Add New Email";
            this.btnAddNewEmail.UseVisualStyleBackColor = true;
            this.btnAddNewEmail.Click += new System.EventHandler(this.btnAddNewEmail_Click);
            // 
            // btnDeleteEmail
            // 
            this.btnDeleteEmail.Location = new System.Drawing.Point(507, 101);
            this.btnDeleteEmail.Name = "btnDeleteEmail";
            this.btnDeleteEmail.Size = new System.Drawing.Size(180, 23);
            this.btnDeleteEmail.TabIndex = 4;
            this.btnDeleteEmail.Text = "Delete Specified Email";
            this.btnDeleteEmail.UseVisualStyleBackColor = true;
            this.btnDeleteEmail.Click += new System.EventHandler(this.btnDeleteEmail_Click);
            // 
            // btnDeleteCellNum
            // 
            this.btnDeleteCellNum.Location = new System.Drawing.Point(507, 239);
            this.btnDeleteCellNum.Name = "btnDeleteCellNum";
            this.btnDeleteCellNum.Size = new System.Drawing.Size(180, 45);
            this.btnDeleteCellNum.TabIndex = 7;
            this.btnDeleteCellNum.Text = "Delete Selected Cell Number";
            this.btnDeleteCellNum.UseVisualStyleBackColor = true;
            this.btnDeleteCellNum.Click += new System.EventHandler(this.btnDeleteCellNum_Click);
            // 
            // btnAddCellNum
            // 
            this.btnAddCellNum.Location = new System.Drawing.Point(507, 210);
            this.btnAddCellNum.Name = "btnAddCellNum";
            this.btnAddCellNum.Size = new System.Drawing.Size(180, 23);
            this.btnAddCellNum.TabIndex = 6;
            this.btnAddCellNum.Text = "Add New Cell Number";
            this.btnAddCellNum.UseVisualStyleBackColor = true;
            this.btnAddCellNum.Click += new System.EventHandler(this.btnAddCellNum_Click);
            // 
            // txBxCellNum
            // 
            this.txBxCellNum.Location = new System.Drawing.Point(507, 181);
            this.txBxCellNum.Name = "txBxCellNum";
            this.txBxCellNum.Size = new System.Drawing.Size(180, 23);
            this.txBxCellNum.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(726, 330);
            this.Controls.Add(this.btnDeleteCellNum);
            this.Controls.Add(this.btnAddCellNum);
            this.Controls.Add(this.txBxCellNum);
            this.Controls.Add(this.btnDeleteEmail);
            this.Controls.Add(this.btnAddNewEmail);
            this.Controls.Add(this.txBxEmail);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txBxEmail;
        private System.Windows.Forms.Button btnAddNewEmail;
        private System.Windows.Forms.Button btnDeleteEmail;
        private System.Windows.Forms.Button btnDeleteCellNum;
        private System.Windows.Forms.Button btnAddCellNum;
        private System.Windows.Forms.TextBox txBxCellNum;
    }
}

