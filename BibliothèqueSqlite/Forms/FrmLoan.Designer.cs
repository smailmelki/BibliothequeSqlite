﻿namespace BibliothèqueSqlite.Forms
{
    partial class FrmLoan
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNewPublishing = new System.Windows.Forms.Button();
            this.cmbnomPrnom = new System.Windows.Forms.ComboBox();
            this.cmbTitalBook = new System.Windows.Forms.ComboBox();
            this.dtpEntry = new System.Windows.Forms.DateTimePicker();
            this.dtpExit = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Location = new System.Drawing.Point(337, 0);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Location = new System.Drawing.Point(167, 0);
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.Location = new System.Drawing.Point(250, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnNewPublishing);
            this.panel2.Controls.Add(this.cmbnomPrnom);
            this.panel2.Controls.Add(this.cmbTitalBook);
            this.panel2.Controls.Add(this.dtpEntry);
            this.panel2.Controls.Add(this.dtpExit);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbStatus);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 288);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::BibliothèqueSqlite.Properties.Resources.add_24px;
            this.button1.Location = new System.Drawing.Point(0, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 32);
            this.button1.TabIndex = 38;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNewPublishing
            // 
            this.btnNewPublishing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPublishing.FlatAppearance.BorderSize = 0;
            this.btnNewPublishing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPublishing.Image = global::BibliothèqueSqlite.Properties.Resources.add_24px;
            this.btnNewPublishing.Location = new System.Drawing.Point(0, 29);
            this.btnNewPublishing.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewPublishing.Name = "btnNewPublishing";
            this.btnNewPublishing.Size = new System.Drawing.Size(30, 32);
            this.btnNewPublishing.TabIndex = 38;
            this.btnNewPublishing.UseVisualStyleBackColor = true;
            this.btnNewPublishing.Click += new System.EventHandler(this.btnNewPublishing_Click);
            // 
            // cmbnomPrnom
            // 
            this.cmbnomPrnom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbnomPrnom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbnomPrnom.FormattingEnabled = true;
            this.cmbnomPrnom.Location = new System.Drawing.Point(32, 70);
            this.cmbnomPrnom.Margin = new System.Windows.Forms.Padding(4);
            this.cmbnomPrnom.Name = "cmbnomPrnom";
            this.cmbnomPrnom.Size = new System.Drawing.Size(248, 30);
            this.cmbnomPrnom.TabIndex = 37;
            // 
            // cmbTitalBook
            // 
            this.cmbTitalBook.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTitalBook.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTitalBook.FormattingEnabled = true;
            this.cmbTitalBook.Location = new System.Drawing.Point(32, 29);
            this.cmbTitalBook.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTitalBook.Name = "cmbTitalBook";
            this.cmbTitalBook.Size = new System.Drawing.Size(248, 30);
            this.cmbTitalBook.TabIndex = 37;
            // 
            // dtpEntry
            // 
            this.dtpEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEntry.Location = new System.Drawing.Point(32, 214);
            this.dtpEntry.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEntry.Name = "dtpEntry";
            this.dtpEntry.Size = new System.Drawing.Size(249, 29);
            this.dtpEntry.TabIndex = 36;
            // 
            // dtpExit
            // 
            this.dtpExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpExit.Location = new System.Drawing.Point(32, 165);
            this.dtpExit.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExit.Name = "dtpExit";
            this.dtpExit.Size = new System.Drawing.Size(249, 29);
            this.dtpExit.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(292, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "عنوان الكتاب";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatus.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ممتاز",
            "جيد جدا",
            "جيد",
            "متوسط",
            "سيئ ",
            "سيئ جدا"});
            this.cmbStatus.Location = new System.Drawing.Point(32, 117);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbStatus.Size = new System.Drawing.Size(249, 30);
            this.cmbStatus.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(292, 227);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 22);
            this.label7.TabIndex = 31;
            this.label7.Text = "تاريخ الاسترجاع";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(292, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "تاريخ الاعارة";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(292, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "حالة الكتاب";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(292, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "الاسم و اللقب";
            // 
            // FrmLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 315);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmLoan";
            this.Tag = "";
            this.Text = "FrmLoan";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpEntry;
        private System.Windows.Forms.DateTimePicker dtpExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbnomPrnom;
        private System.Windows.Forms.ComboBox cmbTitalBook;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNewPublishing;
    }
}