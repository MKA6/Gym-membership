namespace The_first_project
{
    partial class SearchEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchEquipment));
            this.dataGridViewSearchEquipment = new System.Windows.Forms.DataGridView();
            this.textSearchEquipment = new System.Windows.Forms.TextBox();
            this.buttonSearcEquipment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSearchEquipment
            // 
            this.dataGridViewSearchEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchEquipment.Location = new System.Drawing.Point(65, 230);
            this.dataGridViewSearchEquipment.Name = "dataGridViewSearchEquipment";
            this.dataGridViewSearchEquipment.RowTemplate.Height = 25;
            this.dataGridViewSearchEquipment.Size = new System.Drawing.Size(648, 289);
            this.dataGridViewSearchEquipment.TabIndex = 41;
            this.dataGridViewSearchEquipment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchEquipment_CellContentClick);
            // 
            // textSearchEquipment
            // 
            this.textSearchEquipment.Location = new System.Drawing.Point(212, 178);
            this.textSearchEquipment.Name = "textSearchEquipment";
            this.textSearchEquipment.Size = new System.Drawing.Size(292, 23);
            this.textSearchEquipment.TabIndex = 40;
            // 
            // buttonSearcEquipment
            // 
            this.buttonSearcEquipment.BackColor = System.Drawing.Color.Red;
            this.buttonSearcEquipment.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearcEquipment.ForeColor = System.Drawing.Color.White;
            this.buttonSearcEquipment.Location = new System.Drawing.Point(585, 163);
            this.buttonSearcEquipment.Name = "buttonSearcEquipment";
            this.buttonSearcEquipment.Size = new System.Drawing.Size(100, 48);
            this.buttonSearcEquipment.TabIndex = 39;
            this.buttonSearcEquipment.Text = "Search";
            this.buttonSearcEquipment.UseVisualStyleBackColor = false;
            this.buttonSearcEquipment.Click += new System.EventHandler(this.buttonSearcEquipment_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(212, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 37);
            this.label2.TabIndex = 38;
            this.label2.Text = "Search for Equipment";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(283, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 30);
            this.label11.TabIndex = 37;
            this.label11.Text = "Gymnasium";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(337, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 74);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // SearchEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridViewSearchEquipment);
            this.Controls.Add(this.textSearchEquipment);
            this.Controls.Add(this.buttonSearcEquipment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SearchEquipment";
            this.Text = "SearchEquipment";
            this.Load += new System.EventHandler(this.SearchEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewSearchEquipment;
        private TextBox textSearchEquipment;
        private Button buttonSearcEquipment;
        private Label label2;
        private Label label11;
        private PictureBox pictureBox1;
    }
}