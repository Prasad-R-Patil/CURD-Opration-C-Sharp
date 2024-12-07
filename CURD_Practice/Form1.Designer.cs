namespace CURD_Practice
{
    partial class CURD
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
            idlbl = new Label();
            IDtxt = new TextBox();
            Heading = new Label();
            Nametxt = new TextBox();
            namelbl = new Label();
            Snametxt = new TextBox();
            label2 = new Label();
            Agetxt = new TextBox();
            label3 = new Label();
            insertbtn = new Button();
            dataGridView1 = new DataGridView();
            UPDATEbtn = new Button();
            DeleteBtn = new Button();
            Searchbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // idlbl
            // 
            idlbl.AutoSize = true;
            idlbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idlbl.Location = new Point(231, 108);
            idlbl.Name = "idlbl";
            idlbl.Size = new Size(63, 38);
            idlbl.TabIndex = 0;
            idlbl.Text = "ID :";
            // 
            // IDtxt
            // 
            IDtxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IDtxt.Location = new Point(368, 116);
            IDtxt.Name = "IDtxt";
            IDtxt.Size = new Size(339, 30);
            IDtxt.TabIndex = 1;
            // 
            // Heading
            // 
            Heading.AutoSize = true;
            Heading.Font = new Font("Algerian", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Heading.ForeColor = Color.Red;
            Heading.Location = new Point(326, 20);
            Heading.Name = "Heading";
            Heading.Size = new Size(282, 38);
            Heading.TabIndex = 2;
            Heading.Text = "CURD Practice";
            // 
            // Nametxt
            // 
            Nametxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nametxt.Location = new Point(368, 179);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(339, 30);
            Nametxt.TabIndex = 4;
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namelbl.Location = new Point(231, 171);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(111, 38);
            namelbl.TabIndex = 3;
            namelbl.Text = "Name :";
            // 
            // Snametxt
            // 
            Snametxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Snametxt.Location = new Point(368, 236);
            Snametxt.Name = "Snametxt";
            Snametxt.Size = new Size(339, 30);
            Snametxt.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(231, 228);
            label2.Name = "label2";
            label2.Size = new Size(140, 38);
            label2.TabIndex = 5;
            label2.Text = "Sir-Name";
            // 
            // Agetxt
            // 
            Agetxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Agetxt.Location = new Point(368, 294);
            Agetxt.Name = "Agetxt";
            Agetxt.Size = new Size(339, 30);
            Agetxt.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(231, 286);
            label3.Name = "label3";
            label3.Size = new Size(69, 38);
            label3.TabIndex = 7;
            label3.Text = "Age";
            // 
            // insertbtn
            // 
            insertbtn.BackColor = Color.Red;
            insertbtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insertbtn.Location = new Point(162, 388);
            insertbtn.Name = "insertbtn";
            insertbtn.Size = new Size(106, 49);
            insertbtn.TabIndex = 9;
            insertbtn.Text = "INSERT";
            insertbtn.UseVisualStyleBackColor = false;
            insertbtn.Click += insertbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(88, 483);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(804, 227);
            dataGridView1.TabIndex = 10;
            // 
            // UPDATEbtn
            // 
            UPDATEbtn.BackColor = Color.Red;
            UPDATEbtn.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UPDATEbtn.Location = new Point(313, 388);
            UPDATEbtn.Name = "UPDATEbtn";
            UPDATEbtn.Size = new Size(106, 49);
            UPDATEbtn.TabIndex = 11;
            UPDATEbtn.Text = "UPDATE";
            UPDATEbtn.UseVisualStyleBackColor = false;
            UPDATEbtn.Click += UPDATEbtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(456, 388);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(106, 49);
            DeleteBtn.TabIndex = 12;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // Searchbtn
            // 
            Searchbtn.BackColor = Color.Red;
            Searchbtn.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Searchbtn.Location = new Point(601, 389);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(106, 49);
            Searchbtn.TabIndex = 13;
            Searchbtn.Text = "SEARCH";
            Searchbtn.UseVisualStyleBackColor = false;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // CURD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(987, 722);
            Controls.Add(Searchbtn);
            Controls.Add(DeleteBtn);
            Controls.Add(UPDATEbtn);
            Controls.Add(dataGridView1);
            Controls.Add(insertbtn);
            Controls.Add(Agetxt);
            Controls.Add(label3);
            Controls.Add(Snametxt);
            Controls.Add(label2);
            Controls.Add(Nametxt);
            Controls.Add(namelbl);
            Controls.Add(Heading);
            Controls.Add(IDtxt);
            Controls.Add(idlbl);
            Name = "CURD";
            Text = "CURD";
            Load += CURD_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idlbl;
        private TextBox IDtxt;
        private Label Heading;
        private TextBox Nametxt;
        private Label namelbl;
        private TextBox Snametxt;
        private Label label2;
        private TextBox Agetxt;
        private Label label3;
        private Button insertbtn;
        private DataGridView dataGridView1;
        private Button UPDATEbtn;
        private Button DeleteBtn;
        private Button Searchbtn;
    }
}
