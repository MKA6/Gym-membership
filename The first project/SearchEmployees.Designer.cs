namespace The_first_project
{
    partial class SearchEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchEmployees));
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearchEmployees = new System.Windows.Forms.Button();
            this.textSearchEmployees = new System.Windows.Forms.TextBox();
            this.dataGridViewSearchEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(286, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 30);
            this.label11.TabIndex = 27;
            this.label11.Text = "Gymnasium";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(340, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 74);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(215, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 34);
            this.label2.TabIndex = 32;
            this.label2.Text = "Search of Employees";
            // 
            // buttonSearchEmployees
            // 
            this.buttonSearchEmployees.BackColor = System.Drawing.Color.Red;
            this.buttonSearchEmployees.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearchEmployees.ForeColor = System.Drawing.Color.White;
            this.buttonSearchEmployees.Location = new System.Drawing.Point(588, 164);
            this.buttonSearchEmployees.Name = "buttonSearchEmployees";
            this.buttonSearchEmployees.Size = new System.Drawing.Size(105, 45);
            this.buttonSearchEmployees.TabIndex = 33;
            this.buttonSearchEmployees.Text = "Search";
            this.buttonSearchEmployees.UseVisualStyleBackColor = false;
            this.buttonSearchEmployees.Click += new System.EventHandler(this.buttonSearchEmployees_Click);
            // 
            // textSearchEmployees
            // 
            this.textSearchEmployees.Location = new System.Drawing.Point(215, 177);
            this.textSearchEmployees.Name = "textSearchEmployees";
            this.textSearchEmployees.Size = new System.Drawing.Size(292, 23);
            this.textSearchEmployees.TabIndex = 34;
            // 
            // dataGridViewSearchEmployees
            // 
            this.dataGridViewSearchEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchEmployees.Location = new System.Drawing.Point(68, 229);
            this.dataGridViewSearchEmployees.Name = "dataGridViewSearchEmployees";
            this.dataGridViewSearchEmployees.RowTemplate.Height = 25;
            this.dataGridViewSearchEmployees.Size = new System.Drawing.Size(648, 289);
            this.dataGridViewSearchEmployees.TabIndex = 35;
            this.dataGridViewSearchEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchEmployees_CellContentClick);
            // 
            // SearchEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridViewSearchEmployees);
            this.Controls.Add(this.textSearchEmployees);
            this.Controls.Add(this.buttonSearchEmployees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SearchEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchEmployees";
            this.Load += new System.EventHandler(this.SearchEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label11;
        private PictureBox pictureBox1;
        private Label label2;
        private Button buttonSearchEmployees;
        private TextBox textSearchEmployees;
        private DataGridView dataGridViewSearchEmployees;
    }
}