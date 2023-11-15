using System.Windows.Forms;

namespace Draft1
{
    partial class Formdata
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tab_data = new System.Windows.Forms.TabControl();
            this.tab_books = new System.Windows.Forms.TabPage();
            this.dgv_books = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tab_authors = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tab_categories = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tab_readers = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tab_histories = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tab_data.SuspendLayout();
            this.tab_books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tab_authors.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tab_categories.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tab_readers.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tab_histories.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(12, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 40);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(136, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(96, 40);
            this.btn_edit.TabIndex = 0;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(255, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(101, 40);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // tab_data
            // 
            this.tab_data.Controls.Add(this.tab_books);
            this.tab_data.Controls.Add(this.tab_authors);
            this.tab_data.Controls.Add(this.tab_categories);
            this.tab_data.Controls.Add(this.tab_readers);
            this.tab_data.Controls.Add(this.tab_histories);
            this.tab_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_data.ItemSize = new System.Drawing.Size(42, 18);
            this.tab_data.Location = new System.Drawing.Point(12, 61);
            this.tab_data.Name = "tab_data";
            this.tab_data.SelectedIndex = 0;
            this.tab_data.Size = new System.Drawing.Size(808, 405);
            this.tab_data.TabIndex = 1;
            // 
            // tab_books
            // 
            this.tab_books.Controls.Add(this.dgv_books);
            this.tab_books.Controls.Add(this.groupBox1);
            this.tab_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_books.Location = new System.Drawing.Point(4, 22);
            this.tab_books.Name = "tab_books";
            this.tab_books.Padding = new System.Windows.Forms.Padding(3);
            this.tab_books.Size = new System.Drawing.Size(800, 379);
            this.tab_books.TabIndex = 0;
            this.tab_books.Text = "Books";
            this.tab_books.UseVisualStyleBackColor = true;
            // 
            // dgv_books
            // 
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.Location = new System.Drawing.Point(356, 18);
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.Size = new System.Drawing.Size(438, 355);
            this.dgv_books.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 329);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(114, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 26);
            this.textBox1.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(114, 161);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(198, 26);
            this.textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(114, 110);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(198, 26);
            this.textBox7.TabIndex = 12;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(114, 55);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(198, 26);
            this.textBox8.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "CategoryID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "AuthorID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Title";
            // 
            // tab_authors
            // 
            this.tab_authors.Controls.Add(this.groupBox2);
            this.tab_authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_authors.Location = new System.Drawing.Point(4, 22);
            this.tab_authors.Margin = new System.Windows.Forms.Padding(5);
            this.tab_authors.Name = "tab_authors";
            this.tab_authors.Padding = new System.Windows.Forms.Padding(3);
            this.tab_authors.Size = new System.Drawing.Size(800, 379);
            this.tab_authors.TabIndex = 1;
            this.tab_authors.Text = "Authors";
            this.tab_authors.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(21, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 329);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(115, 214);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(198, 26);
            this.textBox9.TabIndex = 10;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(115, 163);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(198, 26);
            this.textBox10.TabIndex = 11;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(115, 112);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(198, 26);
            this.textBox11.TabIndex = 12;
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(115, 57);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(198, 26);
            this.textBox12.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hometown";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "DoB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Name";
            // 
            // tab_categories
            // 
            this.tab_categories.Controls.Add(this.groupBox3);
            this.tab_categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_categories.Location = new System.Drawing.Point(4, 22);
            this.tab_categories.Margin = new System.Windows.Forms.Padding(5);
            this.tab_categories.Name = "tab_categories";
            this.tab_categories.Size = new System.Drawing.Size(800, 379);
            this.tab_categories.TabIndex = 2;
            this.tab_categories.Text = "Categories";
            this.tab_categories.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox13);
            this.groupBox3.Controls.Add(this.textBox16);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(21, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 329);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(112, 121);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(198, 26);
            this.textBox13.TabIndex = 10;
            // 
            // textBox16
            // 
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(113, 71);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(198, 26);
            this.textBox16.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Description";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(46, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 24);
            this.label12.TabIndex = 8;
            this.label12.Text = "Name";
            // 
            // tab_readers
            // 
            this.tab_readers.Controls.Add(this.groupBox4);
            this.tab_readers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_readers.Location = new System.Drawing.Point(4, 22);
            this.tab_readers.Margin = new System.Windows.Forms.Padding(5);
            this.tab_readers.Name = "tab_readers";
            this.tab_readers.Size = new System.Drawing.Size(800, 379);
            this.tab_readers.TabIndex = 3;
            this.tab_readers.Text = "Readers";
            this.tab_readers.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox17);
            this.groupBox4.Controls.Add(this.textBox18);
            this.groupBox4.Controls.Add(this.textBox19);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox20);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(21, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 329);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(110, 229);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 26);
            this.textBox2.TabIndex = 10;
            // 
            // textBox17
            // 
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(109, 277);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(198, 26);
            this.textBox17.TabIndex = 10;
            // 
            // textBox18
            // 
            this.textBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.Location = new System.Drawing.Point(108, 174);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(198, 26);
            this.textBox18.TabIndex = 11;
            // 
            // textBox19
            // 
            this.textBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox19.Location = new System.Drawing.Point(108, 123);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(198, 26);
            this.textBox19.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(108, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 26);
            this.textBox3.TabIndex = 13;
            // 
            // textBox20
            // 
            this.textBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox20.Location = new System.Drawing.Point(107, 77);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(198, 26);
            this.textBox20.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "Gender";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 277);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 24);
            this.label13.TabIndex = 5;
            this.label13.Text = "Hometown";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(56, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 24);
            this.label14.TabIndex = 6;
            this.label14.Text = "DoB";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 24);
            this.label15.TabIndex = 7;
            this.label15.Text = "Username";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 24);
            this.label11.TabIndex = 8;
            this.label11.Text = "First Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(5, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 24);
            this.label16.TabIndex = 8;
            this.label16.Text = "Last Name";
            // 
            // tab_histories
            // 
            this.tab_histories.Controls.Add(this.groupBox5);
            this.tab_histories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_histories.Location = new System.Drawing.Point(4, 22);
            this.tab_histories.Margin = new System.Windows.Forms.Padding(5);
            this.tab_histories.Name = "tab_histories";
            this.tab_histories.Size = new System.Drawing.Size(800, 379);
            this.tab_histories.TabIndex = 4;
            this.tab_histories.Text = "Histories";
            this.tab_histories.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox22);
            this.groupBox5.Controls.Add(this.textBox23);
            this.groupBox5.Controls.Add(this.textBox24);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Location = new System.Drawing.Point(5, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(319, 329);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            // 
            // textBox22
            // 
            this.textBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox22.Location = new System.Drawing.Point(116, 199);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(198, 26);
            this.textBox22.TabIndex = 11;
            // 
            // textBox23
            // 
            this.textBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox23.Location = new System.Drawing.Point(116, 148);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(198, 26);
            this.textBox23.TabIndex = 12;
            // 
            // textBox24
            // 
            this.textBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox24.Location = new System.Drawing.Point(116, 93);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(198, 26);
            this.textBox24.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 250);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 24);
            this.label17.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(62, 201);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 24);
            this.label18.TabIndex = 6;
            this.label18.Text = "Date";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(40, 150);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 24);
            this.label19.TabIndex = 7;
            this.label19.Text = "BookID";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(21, 93);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 24);
            this.label20.TabIndex = 8;
            this.label20.Text = "ReaderID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear All Data";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Formdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tab_data);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Name = "Formdata";
            this.Text = "Formdata";
            this.tab_data.ResumeLayout(false);
            this.tab_books.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_authors.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tab_categories.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tab_readers.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tab_histories.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TabControl tab_data;
        private System.Windows.Forms.TabPage tab_books;
        private System.Windows.Forms.TabPage tab_authors;
        private System.Windows.Forms.TabPage tab_categories;
        private System.Windows.Forms.TabPage tab_readers;
        private System.Windows.Forms.TabPage tab_histories;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgv_books;
    }
}