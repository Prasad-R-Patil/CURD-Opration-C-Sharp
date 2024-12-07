namespace CURD_in_C_Sharp
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
            label1 = new Label();
            IDlbl = new Label();
            IDtxt = new TextBox();
            Nametxt = new TextBox();
            Namelbl = new Label();
            Designtxt = new TextBox();
            Designlbl = new Label();
            Colorlbl = new Label();
            Colortxt = new ComboBox();
            Insertbtn = new Button();
            dataGridView1 = new DataGridView();
            Updatebtn = new Button();
            Deletebtn = new Button();
            Searchbtn = new Button();
            Clearbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(220, 9);
            label1.Name = "label1";
            label1.Size = new Size(549, 53);
            label1.TabIndex = 0;
            label1.Text = "CURD-Operation-In-C#";
            // 
            // IDlbl
            // 
            IDlbl.AutoSize = true;
            IDlbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IDlbl.ForeColor = Color.White;
            IDlbl.Location = new Point(204, 88);
            IDlbl.Name = "IDlbl";
            IDlbl.Size = new Size(156, 35);
            IDlbl.TabIndex = 1;
            IDlbl.Text = "Product-ID :";
            // 
            // IDtxt
            // 
            IDtxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IDtxt.Location = new Point(379, 93);
            IDtxt.Name = "IDtxt";
            IDtxt.Size = new Size(376, 30);
            IDtxt.TabIndex = 2;
            // 
            // Nametxt
            // 
            Nametxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nametxt.Location = new Point(379, 150);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(376, 30);
            Nametxt.TabIndex = 4;
            // 
            // Namelbl
            // 
            Namelbl.AutoSize = true;
            Namelbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Namelbl.ForeColor = Color.White;
            Namelbl.Location = new Point(204, 145);
            Namelbl.Name = "Namelbl";
            Namelbl.Size = new Size(164, 35);
            Namelbl.TabIndex = 3;
            Namelbl.Text = "Item-Name :";
            // 
            // Designtxt
            // 
            Designtxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Designtxt.Location = new Point(379, 208);
            Designtxt.Name = "Designtxt";
            Designtxt.Size = new Size(376, 30);
            Designtxt.TabIndex = 6;
            // 
            // Designlbl
            // 
            Designlbl.AutoSize = true;
            Designlbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Designlbl.ForeColor = Color.White;
            Designlbl.Location = new Point(204, 203);
            Designlbl.Name = "Designlbl";
            Designlbl.Size = new Size(109, 35);
            Designlbl.TabIndex = 5;
            Designlbl.Text = "Design :";
            // 
            // Colorlbl
            // 
            Colorlbl.AutoSize = true;
            Colorlbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Colorlbl.ForeColor = Color.White;
            Colorlbl.Location = new Point(204, 263);
            Colorlbl.Name = "Colorlbl";
            Colorlbl.Size = new Size(92, 35);
            Colorlbl.TabIndex = 7;
            Colorlbl.Text = "Color :";
            // 
            // Colortxt
            // 
            Colortxt.DropDownStyle = ComboBoxStyle.DropDownList;
            Colortxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Colortxt.FormattingEnabled = true;
            Colortxt.Items.AddRange(new object[] { "", "Black", "Black & White", "Blue", "Blue & Black", "Brown", "Gray", "Green", "Nevy-Blue", "Orange", "Pink", "Red", "Red & Black", "Silver", "Sky-Blue", "White", "Yellow", "Yellow & Black" });
            Colortxt.Location = new Point(379, 267);
            Colortxt.Name = "Colortxt";
            Colortxt.Size = new Size(376, 31);
            Colortxt.Sorted = true;
            Colortxt.TabIndex = 8;
            // 
            // Insertbtn
            // 
            Insertbtn.BackColor = Color.FromArgb(192, 0, 192);
            Insertbtn.Font = new Font("Calisto MT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Insertbtn.ForeColor = Color.White;
            Insertbtn.Location = new Point(102, 361);
            Insertbtn.Name = "Insertbtn";
            Insertbtn.Size = new Size(116, 48);
            Insertbtn.TabIndex = 9;
            Insertbtn.Text = "Insert";
            Insertbtn.UseVisualStyleBackColor = false;
            Insertbtn.Click += Insertbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(109, 426);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(802, 254);
            dataGridView1.TabIndex = 10;
            // 
            // Updatebtn
            // 
            Updatebtn.BackColor = Color.FromArgb(192, 0, 192);
            Updatebtn.Font = new Font("Calisto MT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Updatebtn.ForeColor = Color.White;
            Updatebtn.Location = new Point(278, 361);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(116, 48);
            Updatebtn.TabIndex = 11;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = false;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = Color.FromArgb(192, 0, 192);
            Deletebtn.Font = new Font("Calisto MT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Deletebtn.ForeColor = Color.White;
            Deletebtn.Location = new Point(453, 361);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(116, 48);
            Deletebtn.TabIndex = 12;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Searchbtn
            // 
            Searchbtn.BackColor = Color.FromArgb(192, 0, 192);
            Searchbtn.Font = new Font("Calisto MT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Searchbtn.ForeColor = Color.White;
            Searchbtn.Location = new Point(640, 361);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(116, 48);
            Searchbtn.TabIndex = 13;
            Searchbtn.Text = "Search";
            Searchbtn.UseVisualStyleBackColor = false;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // Clearbtn
            // 
            Clearbtn.BackColor = Color.FromArgb(192, 0, 192);
            Clearbtn.Font = new Font("Calisto MT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clearbtn.ForeColor = Color.White;
            Clearbtn.Location = new Point(810, 361);
            Clearbtn.Name = "Clearbtn";
            Clearbtn.Size = new Size(116, 48);
            Clearbtn.TabIndex = 14;
            Clearbtn.Text = "Clear";
            Clearbtn.UseVisualStyleBackColor = false;
            Clearbtn.Click += Clearbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(1038, 722);
            Controls.Add(Clearbtn);
            Controls.Add(Searchbtn);
            Controls.Add(Deletebtn);
            Controls.Add(Updatebtn);
            Controls.Add(dataGridView1);
            Controls.Add(Insertbtn);
            Controls.Add(Colortxt);
            Controls.Add(Colorlbl);
            Controls.Add(Designtxt);
            Controls.Add(Designlbl);
            Controls.Add(Nametxt);
            Controls.Add(Namelbl);
            Controls.Add(IDtxt);
            Controls.Add(IDlbl);
            Controls.Add(label1);
            Name = "Form1";
            Text = "CURD-Operation-From";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label IDlbl;
        private TextBox IDtxt;
        private TextBox Nametxt;
        private Label Namelbl;
        private TextBox Designtxt;
        private Label Designlbl;
        private Label Colorlbl;
        private ComboBox Colortxt;
        private Button Insertbtn;
        private DataGridView dataGridView1;
        private Button Updatebtn;
        private Button Deletebtn;
        private Button Searchbtn;
        private Button Clearbtn;
    }
}
