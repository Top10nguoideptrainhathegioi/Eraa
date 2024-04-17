namespace dep_trai_s1_vn
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
            Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtname = new TextBox();
            cbcustomertype = new ComboBox();
            label4 = new Label();
            txtmember = new TextBox();
            label5 = new Label();
            txtlastmonth = new TextBox();
            label6 = new Label();
            txtcurrentmonth = new TextBox();
            btncalculate = new Button();
            btnAdd = new Button();
            btnclear = new Button();
            groupBox1 = new GroupBox();
            btnedit = new Button();
            groupBox2 = new GroupBox();
            lstvresult = new ListView();
            txtResult = new TextBox();
            label7 = new Label();
            btnclr = new Button();
            btnexit = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 108);
            label3.Name = "label3";
            label3.Size = new Size(173, 31);
            label3.TabIndex = 3;
            label3.Text = "Customer Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ScrollBar;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(403, 26);
            label1.Name = "label1";
            label1.Size = new Size(408, 54);
            label1.TabIndex = 0;
            label1.Text = "Water Bill Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(163, 44);
            label2.Name = "label2";
            label2.Size = new Size(77, 31);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // txtname
            // 
            txtname.Location = new Point(263, 44);
            txtname.Name = "txtname";
            txtname.Size = new Size(226, 27);
            txtname.TabIndex = 2;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // cbcustomertype
            // 
            cbcustomertype.FormattingEnabled = true;
            cbcustomertype.Items.AddRange(new object[] { "Household", "Public Services", "Production Units", "Business Services" });
            cbcustomertype.Location = new Point(263, 111);
            cbcustomertype.Name = "cbcustomertype";
            cbcustomertype.Size = new Size(226, 28);
            cbcustomertype.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(136, 169);
            label4.Name = "label4";
            label4.Size = new Size(104, 31);
            label4.TabIndex = 5;
            label4.Text = "Member";
            // 
            // txtmember
            // 
            txtmember.Location = new Point(263, 169);
            txtmember.Name = "txtmember";
            txtmember.Size = new Size(226, 27);
            txtmember.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 231);
            label5.Name = "label5";
            label5.Size = new Size(202, 31);
            label5.TabIndex = 7;
            label5.Text = "Last Month Index";
            // 
            // txtlastmonth
            // 
            txtlastmonth.Location = new Point(263, 231);
            txtlastmonth.Name = "txtlastmonth";
            txtlastmonth.Size = new Size(226, 27);
            txtlastmonth.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 301);
            label6.Name = "label6";
            label6.Size = new Size(240, 31);
            label6.TabIndex = 9;
            label6.Text = "Current Month Index";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtcurrentmonth
            // 
            txtcurrentmonth.Location = new Point(263, 301);
            txtcurrentmonth.Name = "txtcurrentmonth";
            txtcurrentmonth.Size = new Size(226, 27);
            txtcurrentmonth.TabIndex = 10;
            // 
            // btncalculate
            // 
            btncalculate.BackColor = SystemColors.MenuHighlight;
            btncalculate.ForeColor = Color.FromArgb(255, 192, 192);
            btncalculate.Location = new Point(524, 23);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(84, 68);
            btncalculate.TabIndex = 11;
            btncalculate.Text = "Calculate";
            btncalculate.UseVisualStyleBackColor = false;
            btncalculate.Click += btncalculate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Red;
            btnAdd.ForeColor = Color.FromArgb(255, 192, 192);
            btnAdd.Location = new Point(524, 108);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(84, 63);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.Lime;
            btnclear.Location = new Point(524, 284);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(84, 61);
            btnclear.TabIndex = 13;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(btnedit);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtcurrentmonth);
            groupBox1.Controls.Add(btncalculate);
            groupBox1.Controls.Add(btnclear);
            groupBox1.Controls.Add(txtlastmonth);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtname);
            groupBox1.Controls.Add(txtmember);
            groupBox1.Controls.Add(cbcustomertype);
            groupBox1.Location = new Point(12, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(623, 354);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnedit
            // 
            btnedit.BackColor = Color.Yellow;
            btnedit.ForeColor = Color.FromArgb(64, 0, 0);
            btnedit.Location = new Point(524, 194);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(84, 64);
            btnedit.TabIndex = 14;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstvresult);
            groupBox2.Location = new Point(641, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(663, 485);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Result";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lstvresult
            // 
            lstvresult.Location = new Point(6, 23);
            lstvresult.Name = "lstvresult";
            lstvresult.Size = new Size(651, 456);
            lstvresult.TabIndex = 0;
            lstvresult.UseCompatibleStateImageBehavior = false;
            lstvresult.SelectedIndexChanged += lstvresult_SelectedIndexChanged;
            // 
            // txtResult
            // 
            txtResult.Enabled = false;
            txtResult.Location = new Point(275, 468);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(226, 79);
            txtResult.TabIndex = 16;
            txtResult.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(172, 468);
            label7.Name = "label7";
            label7.Size = new Size(80, 31);
            label7.TabIndex = 17;
            label7.Text = "Result";
            // 
            // btnclr
            // 
            btnclr.BackColor = Color.Transparent;
            btnclr.Location = new Point(647, 609);
            btnclr.Name = "btnclr";
            btnclr.Size = new Size(109, 61);
            btnclr.TabIndex = 18;
            btnclr.Text = "Clear Result";
            btnclr.UseVisualStyleBackColor = false;
            btnclr.Click += btnclr_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(53, 659);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(94, 29);
            btnexit.TabIndex = 19;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1316, 721);
            Controls.Add(btnexit);
            Controls.Add(btnclr);
            Controls.Add(label7);
            Controls.Add(txtResult);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtname;
        private Label label3;
        private ComboBox cbcustomertype;
        private Label label4;
        private TextBox txtmember;
        private Label label5;
        private TextBox txtlastmonth;
        private Label label6;
        private TextBox txtcurrentmonth;
        private Button btncalculate;
        private Button btnAdd;
        private Button btnclear;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnedit;
        private ListView lstvresult;
        private TextBox txtResult;
        private Label label7;
        private Button btnclr;
        private Button btnexit;
    }
}
