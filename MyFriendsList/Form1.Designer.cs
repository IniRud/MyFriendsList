
namespace MyFriendsList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_newFriend = new System.Windows.Forms.TextBox();
            this.btn_addFiend = new System.Windows.Forms.Button();
            this.btn_addFive = new System.Windows.Forms.Button();
            this.btn_sortAsc = new System.Windows.Forms.Button();
            this.btn_sortDesc = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(203, 354);
            this.listBox1.TabIndex = 0;
            // 
            // txt_newFriend
            // 
            this.txt_newFriend.Location = new System.Drawing.Point(270, 21);
            this.txt_newFriend.Name = "txt_newFriend";
            this.txt_newFriend.Size = new System.Drawing.Size(373, 31);
            this.txt_newFriend.TabIndex = 1;
            // 
            // btn_addFiend
            // 
            this.btn_addFiend.Location = new System.Drawing.Point(270, 103);
            this.btn_addFiend.Name = "btn_addFiend";
            this.btn_addFiend.Size = new System.Drawing.Size(112, 34);
            this.btn_addFiend.TabIndex = 2;
            this.btn_addFiend.Text = "Add Friend";
            this.btn_addFiend.UseVisualStyleBackColor = true;
            this.btn_addFiend.Click += new System.EventHandler(this.btn_addFiend_Click);
            // 
            // btn_addFive
            // 
            this.btn_addFive.Location = new System.Drawing.Point(270, 191);
            this.btn_addFive.Name = "btn_addFive";
            this.btn_addFive.Size = new System.Drawing.Size(112, 34);
            this.btn_addFive.TabIndex = 3;
            this.btn_addFive.Text = "Add 5 Friends";
            this.btn_addFive.UseVisualStyleBackColor = true;
            this.btn_addFive.Click += new System.EventHandler(this.btn_addFive_Click);
            // 
            // btn_sortAsc
            // 
            this.btn_sortAsc.Location = new System.Drawing.Point(270, 340);
            this.btn_sortAsc.Name = "btn_sortAsc";
            this.btn_sortAsc.Size = new System.Drawing.Size(112, 34);
            this.btn_sortAsc.TabIndex = 4;
            this.btn_sortAsc.Text = "A -> Z";
            this.btn_sortAsc.UseVisualStyleBackColor = true;
            this.btn_sortAsc.Click += new System.EventHandler(this.btn_sortAsc_Click);
            // 
            // btn_sortDesc
            // 
            this.btn_sortDesc.Location = new System.Drawing.Point(531, 341);
            this.btn_sortDesc.Name = "btn_sortDesc";
            this.btn_sortDesc.Size = new System.Drawing.Size(112, 34);
            this.btn_sortDesc.TabIndex = 5;
            this.btn_sortDesc.Text = "Z -> A";
            this.btn_sortDesc.UseVisualStyleBackColor = true;
            this.btn_sortDesc.Click += new System.EventHandler(this.btn_sortDesc_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(531, 191);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(112, 34);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_sortDesc);
            this.Controls.Add(this.btn_sortAsc);
            this.Controls.Add(this.btn_addFive);
            this.Controls.Add(this.btn_addFiend);
            this.Controls.Add(this.txt_newFriend);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "My Friends";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_newFriend;
        private System.Windows.Forms.Button btn_addFiend;
        private System.Windows.Forms.Button btn_addFive;
        private System.Windows.Forms.Button btn_sortAsc;
        private System.Windows.Forms.Button btn_sortDesc;
        private System.Windows.Forms.Button btn_clear;
    }
}

