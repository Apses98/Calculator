namespace Calculator
{
    partial class main_form
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
            this.main_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.plus_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.minus_button = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.multiplication_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.equal_button = new System.Windows.Forms.Button();
            this.division_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.log_listBox = new System.Windows.Forms.ListBox();
            this.backspace_button = new System.Windows.Forms.Button();
            this.last_usedLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_textbox
            // 
            this.main_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_textbox.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_textbox.Location = new System.Drawing.Point(12, 110);
            this.main_textbox.Name = "main_textbox";
            this.main_textbox.ReadOnly = true;
            this.main_textbox.Size = new System.Drawing.Size(193, 52);
            this.main_textbox.TabIndex = 0;
            this.main_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.main_textbox_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 87);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(84, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 87);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(165, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 87);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // plus_button
            // 
            this.plus_button.BackColor = System.Drawing.Color.DimGray;
            this.plus_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plus_button.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plus_button.ForeColor = System.Drawing.SystemColors.Window;
            this.plus_button.Location = new System.Drawing.Point(246, 3);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(76, 87);
            this.plus_button.TabIndex = 13;
            this.plus_button.Text = "+";
            this.plus_button.UseVisualStyleBackColor = false;
            this.plus_button.Click += new System.EventHandler(this.plus_button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(3, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 87);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.Window;
            this.button5.Location = new System.Drawing.Point(84, 96);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 87);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DimGray;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.SystemColors.Window;
            this.button6.Location = new System.Drawing.Point(165, 96);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 87);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // minus_button
            // 
            this.minus_button.BackColor = System.Drawing.Color.DimGray;
            this.minus_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minus_button.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minus_button.ForeColor = System.Drawing.SystemColors.Window;
            this.minus_button.Location = new System.Drawing.Point(246, 96);
            this.minus_button.Name = "minus_button";
            this.minus_button.Size = new System.Drawing.Size(76, 87);
            this.minus_button.TabIndex = 14;
            this.minus_button.Text = "-";
            this.minus_button.UseVisualStyleBackColor = false;
            this.minus_button.Click += new System.EventHandler(this.minus_button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DimGray;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.SystemColors.Window;
            this.button7.Location = new System.Drawing.Point(3, 189);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 87);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DimGray;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.SystemColors.Window;
            this.button8.Location = new System.Drawing.Point(84, 189);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 87);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DimGray;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.SystemColors.Window;
            this.button9.Location = new System.Drawing.Point(165, 189);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 87);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // multiplication_button
            // 
            this.multiplication_button.BackColor = System.Drawing.Color.DimGray;
            this.multiplication_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplication_button.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplication_button.ForeColor = System.Drawing.SystemColors.Window;
            this.multiplication_button.Location = new System.Drawing.Point(246, 189);
            this.multiplication_button.Name = "multiplication_button";
            this.multiplication_button.Size = new System.Drawing.Size(76, 87);
            this.multiplication_button.TabIndex = 15;
            this.multiplication_button.Text = "X";
            this.multiplication_button.UseVisualStyleBackColor = false;
            this.multiplication_button.Click += new System.EventHandler(this.multiplication_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.DimGray;
            this.clear_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clear_button.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear_button.ForeColor = System.Drawing.SystemColors.Window;
            this.clear_button.Location = new System.Drawing.Point(3, 282);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 87);
            this.clear_button.TabIndex = 11;
            this.clear_button.Text = "C";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.DimGray;
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button0.ForeColor = System.Drawing.SystemColors.Window;
            this.button0.Location = new System.Drawing.Point(84, 282);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 87);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // equal_button
            // 
            this.equal_button.BackColor = System.Drawing.Color.DimGray;
            this.equal_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equal_button.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equal_button.ForeColor = System.Drawing.SystemColors.Window;
            this.equal_button.Location = new System.Drawing.Point(165, 282);
            this.equal_button.Name = "equal_button";
            this.equal_button.Size = new System.Drawing.Size(75, 87);
            this.equal_button.TabIndex = 12;
            this.equal_button.Text = "=";
            this.equal_button.UseVisualStyleBackColor = false;
            this.equal_button.Click += new System.EventHandler(this.equal_button_Click);
            // 
            // division_button
            // 
            this.division_button.BackColor = System.Drawing.Color.DimGray;
            this.division_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.division_button.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.division_button.ForeColor = System.Drawing.SystemColors.Window;
            this.division_button.Location = new System.Drawing.Point(246, 282);
            this.division_button.Name = "division_button";
            this.division_button.Size = new System.Drawing.Size(76, 87);
            this.division_button.TabIndex = 16;
            this.division_button.Text = "/";
            this.division_button.UseVisualStyleBackColor = false;
            this.division_button.Click += new System.EventHandler(this.division_button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.clear_button, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.equal_button, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.division_button, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.multiplication_button, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.plus_button, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.minus_button, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 169);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(325, 372);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // log_listBox
            // 
            this.log_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log_listBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.log_listBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.log_listBox.FormattingEnabled = true;
            this.log_listBox.ItemHeight = 17;
            this.log_listBox.Location = new System.Drawing.Point(11, 12);
            this.log_listBox.Name = "log_listBox";
            this.log_listBox.Size = new System.Drawing.Size(319, 89);
            this.log_listBox.TabIndex = 16;
            this.log_listBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.log_listBox_MouseClick);
            // 
            // backspace_button
            // 
            this.backspace_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backspace_button.Location = new System.Drawing.Point(213, 108);
            this.backspace_button.Name = "backspace_button";
            this.backspace_button.Size = new System.Drawing.Size(47, 56);
            this.backspace_button.TabIndex = 1;
            this.backspace_button.Text = "<-";
            this.backspace_button.UseVisualStyleBackColor = true;
            this.backspace_button.Click += new System.EventHandler(this.backspace_button_Click);
            // 
            // last_usedLabel
            // 
            this.last_usedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.last_usedLabel.AutoSize = true;
            this.last_usedLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.last_usedLabel.Location = new System.Drawing.Point(266, 110);
            this.last_usedLabel.Name = "last_usedLabel";
            this.last_usedLabel.Size = new System.Drawing.Size(61, 46);
            this.last_usedLabel.TabIndex = 17;
            this.last_usedLabel.Text = "+0";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(343, 553);
            this.Controls.Add(this.last_usedLabel);
            this.Controls.Add(this.backspace_button);
            this.Controls.Add(this.log_listBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.main_textbox);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(359, 592);
            this.Name = "main_form";
            this.Text = "Calculator App by Ahmad Abo Warda";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox main_textbox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button plus_button;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button minus_button;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button multiplication_button;
        private Button clear_button;
        private Button button0;
        private Button equal_button;
        private Button division_button;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox log_listBox;
        private Button backspace_button;
        private Label last_usedLabel;
    }
}