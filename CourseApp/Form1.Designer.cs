﻿namespace CourseApp
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnAddAll = new Button();
            btnFinal = new Button();
            btnRemoveAll = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(68, 107);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(338, 264);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(670, 107);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(338, 264);
            listBox2.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(483, 107);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 40);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(483, 164);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(120, 40);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "REMOVE";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAddAll
            // 
            btnAddAll.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddAll.Location = new Point(483, 219);
            btnAddAll.Name = "btnAddAll";
            btnAddAll.Size = new Size(120, 40);
            btnAddAll.TabIndex = 4;
            btnAddAll.Text = "ADD ALL";
            btnAddAll.UseVisualStyleBackColor = true;
            btnAddAll.Click += btnAddAll_Click;
            // 
            // btnFinal
            // 
            btnFinal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFinal.Location = new Point(483, 331);
            btnFinal.Name = "btnFinal";
            btnFinal.Size = new Size(120, 40);
            btnFinal.TabIndex = 5;
            btnFinal.Text = "FINALIZE";
            btnFinal.UseVisualStyleBackColor = true;
            btnFinal.Click += btnFinal_Click;
            // 
            // btnRemoveAll
            // 
            btnRemoveAll.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveAll.Location = new Point(483, 274);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new Size(120, 40);
            btnRemoveAll.TabIndex = 6;
            btnRemoveAll.Text = "REMOVE ALL";
            btnRemoveAll.UseVisualStyleBackColor = true;
            btnRemoveAll.Click += btnRemoveAll_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(159, 415);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(752, 287);
            dataGridView1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 680);
            Controls.Add(dataGridView1);
            Controls.Add(btnRemoveAll);
            Controls.Add(btnFinal);
            Controls.Add(btnAddAll);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnAddAll;
        private Button btnFinal;
        private Button btnRemoveAll;
        private DataGridView dataGridView1;
    }
}
