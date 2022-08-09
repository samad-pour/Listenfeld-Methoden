namespace Listenfeld_Methoden
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
            this.lst_words = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_new = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtn_end = new System.Windows.Forms.RadioButton();
            this.rbtn_start = new System.Windows.Forms.RadioButton();
            this.rbtn_selection = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_replace = new System.Windows.Forms.Button();
            this.txt_replace = new System.Windows.Forms.TextBox();
            this.btn_delete_all = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_words
            // 
            this.lst_words.FormattingEnabled = true;
            this.lst_words.ItemHeight = 15;
            this.lst_words.Items.AddRange(new object[] {
            "Montag",
            "Dienstag",
            "Mitwoch",
            "Donnerstag",
            "Freitag",
            "Samstag",
            "Sonntag"});
            this.lst_words.Location = new System.Drawing.Point(12, 12);
            this.lst_words.Name = "lst_words";
            this.lst_words.Size = new System.Drawing.Size(143, 124);
            this.lst_words.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Neues Element:";
            // 
            // txt_new
            // 
            this.txt_new.Location = new System.Drawing.Point(211, 31);
            this.txt_new.Name = "txt_new";
            this.txt_new.Size = new System.Drawing.Size(128, 23);
            this.txt_new.TabIndex = 2;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(211, 60);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "Einfügen";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Einfügeort:";
            // 
            // rbtn_end
            // 
            this.rbtn_end.AutoSize = true;
            this.rbtn_end.Checked = true;
            this.rbtn_end.Location = new System.Drawing.Point(211, 139);
            this.rbtn_end.Name = "rbtn_end";
            this.rbtn_end.Size = new System.Drawing.Size(120, 19);
            this.rbtn_end.TabIndex = 5;
            this.rbtn_end.TabStop = true;
            this.rbtn_end.Text = "Am Ende der Liste";
            this.rbtn_end.UseVisualStyleBackColor = true;
            // 
            // rbtn_start
            // 
            this.rbtn_start.AutoSize = true;
            this.rbtn_start.Location = new System.Drawing.Point(211, 164);
            this.rbtn_start.Name = "rbtn_start";
            this.rbtn_start.Size = new System.Drawing.Size(133, 19);
            this.rbtn_start.TabIndex = 6;
            this.rbtn_start.Text = "Am Anfang der Liste";
            this.rbtn_start.UseVisualStyleBackColor = true;
            // 
            // rbtn_selection
            // 
            this.rbtn_selection.AutoSize = true;
            this.rbtn_selection.Location = new System.Drawing.Point(211, 189);
            this.rbtn_selection.Name = "rbtn_selection";
            this.rbtn_selection.Size = new System.Drawing.Size(168, 19);
            this.rbtn_selection.TabIndex = 7;
            this.rbtn_selection.Text = "Vor ausgewähltem Element";
            this.rbtn_selection.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ausgewähltes Element:";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(12, 207);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Löschen";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_replace
            // 
            this.btn_replace.Location = new System.Drawing.Point(12, 236);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(114, 23);
            this.btn_replace.TabIndex = 11;
            this.btn_replace.Text = "Ersatzen durch";
            this.btn_replace.UseVisualStyleBackColor = true;
            this.btn_replace.Click += new System.EventHandler(this.btn_replace_Click);
            // 
            // txt_replace
            // 
            this.txt_replace.Location = new System.Drawing.Point(12, 265);
            this.txt_replace.Name = "txt_replace";
            this.txt_replace.Size = new System.Drawing.Size(114, 23);
            this.txt_replace.TabIndex = 12;
            // 
            // btn_delete_all
            // 
            this.btn_delete_all.Location = new System.Drawing.Point(211, 264);
            this.btn_delete_all.Name = "btn_delete_all";
            this.btn_delete_all.Size = new System.Drawing.Size(105, 23);
            this.btn_delete_all.TabIndex = 13;
            this.btn_delete_all.Text = "Alles löschen";
            this.btn_delete_all.UseVisualStyleBackColor = true;
            this.btn_delete_all.Click += new System.EventHandler(this.btn_delete_all_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 313);
            this.Controls.Add(this.btn_delete_all);
            this.Controls.Add(this.txt_replace);
            this.Controls.Add(this.btn_replace);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbtn_selection);
            this.Controls.Add(this.rbtn_start);
            this.Controls.Add(this.rbtn_end);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_new);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_words);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lst_words;
        private Label label1;
        private TextBox txt_new;
        private Button btn_insert;
        private Label label2;
        private RadioButton rbtn_end;
        private RadioButton rbtn_start;
        private RadioButton rbtn_selection;
        private Label label3;
        private Button btn_delete;
        private Button btn_replace;
        private TextBox txt_replace;
        private Button btn_delete_all;
    }
}