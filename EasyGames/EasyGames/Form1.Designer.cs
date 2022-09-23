namespace EasyGames
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data_display = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_add_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nam = new System.Windows.Forms.TextBox();
            this.lb_comment = new System.Windows.Forms.Label();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_surn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lb_amount = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_c_bal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_display)).BeginInit();
            this.SuspendLayout();
            // 
            // data_display
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_display.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_display.DefaultCellStyle = dataGridViewCellStyle5;
            this.data_display.Location = new System.Drawing.Point(290, 115);
            this.data_display.Name = "data_display";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_display.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.data_display.RowTemplate.Height = 25;
            this.data_display.Size = new System.Drawing.Size(625, 283);
            this.data_display.TabIndex = 0;
            this.data_display.DoubleClick += new System.EventHandler(this.data_display_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "SELECT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_add_update
            // 
            this.btn_add_update.Location = new System.Drawing.Point(387, 398);
            this.btn_add_update.Name = "btn_add_update";
            this.btn_add_update.Size = new System.Drawing.Size(94, 48);
            this.btn_add_update.TabIndex = 2;
            this.btn_add_update.Text = "ADD/UPDATE";
            this.btn_add_update.UseVisualStyleBackColor = true;
            this.btn_add_update.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(487, 398);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 48);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(14, 385);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(205, 23);
            this.txt_name.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname";
            // 
            // txt_nam
            // 
            this.txt_nam.Location = new System.Drawing.Point(15, 115);
            this.txt_nam.Name = "txt_nam";
            this.txt_nam.Size = new System.Drawing.Size(205, 23);
            this.txt_nam.TabIndex = 7;
            // 
            // lb_comment
            // 
            this.lb_comment.AutoSize = true;
            this.lb_comment.Location = new System.Drawing.Point(10, 287);
            this.lb_comment.Name = "lb_comment";
            this.lb_comment.Size = new System.Drawing.Size(61, 15);
            this.lb_comment.TabIndex = 8;
            this.lb_comment.Text = "Comment";
            this.lb_comment.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_comment
            // 
            this.txt_comment.Location = new System.Drawing.Point(12, 305);
            this.txt_comment.Multiline = true;
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(205, 59);
            this.txt_comment.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "SEARCH";
            // 
            // txt_find
            // 
            this.txt_find.Location = new System.Drawing.Point(347, 73);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(397, 23);
            this.txt_find.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(762, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 43);
            this.button4.TabIndex = 12;
            this.button4.Text = "FIND";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_surn
            // 
            this.txt_surn.Location = new System.Drawing.Point(12, 155);
            this.txt_surn.Name = "txt_surn";
            this.txt_surn.Size = new System.Drawing.Size(205, 23);
            this.txt_surn.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Client ID";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(587, 398);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(91, 48);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lb_amount
            // 
            this.lb_amount.AutoSize = true;
            this.lb_amount.Location = new System.Drawing.Point(12, 243);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.Size = new System.Drawing.Size(51, 15);
            this.lb_amount.TabIndex = 16;
            this.lb_amount.Text = "Amount";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 23);
            this.textBox1.TabIndex = 17;
            // 
            // txt_c_bal
            // 
            this.txt_c_bal.Location = new System.Drawing.Point(12, 199);
            this.txt_c_bal.Name = "txt_c_bal";
            this.txt_c_bal.Size = new System.Drawing.Size(201, 23);
            this.txt_c_bal.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "ClientBalance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_c_bal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_amount);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_surn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txt_find);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_comment);
            this.Controls.Add(this.lb_comment);
            this.Controls.Add(this.txt_nam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add_update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.data_display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView data_display;
        private Button button1;
        private Button btn_add_update;
        private Button btn_delete;
        private Label label1;
        private TextBox txt_name;
        private Label label2;
        private TextBox txt_nam;
        private Label lb_comment;
        private TextBox txt_comment;
        private Label label4;
        private TextBox txt_find;
        private Button button4;
        private TextBox txt_surn;
        private Label label5;
        private Button btn_cancel;
        private Label lb_amount;
        private TextBox textBox1;
        private TextBox txt_c_bal;
        private Label label7;
    }
}