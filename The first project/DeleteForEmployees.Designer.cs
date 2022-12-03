namespace The_first_project
{
    partial class DeleteForEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteForEmployees));
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textDeleteEmployees = new System.Windows.Forms.TextBox();
            this.buttonDeleteEmployees = new System.Windows.Forms.Button();
            this.dataGridViewDeleteEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(213, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 37);
            this.label2.TabIndex = 52;
            this.label2.Text = "Delete for Employees";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(287, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 30);
            this.label11.TabIndex = 51;
            this.label11.Text = "Gymnasium";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(341, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 74);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // textDeleteEmployees
            // 
            this.textDeleteEmployees.Location = new System.Drawing.Point(213, 210);
            this.textDeleteEmployees.Name = "textDeleteEmployees";
            this.textDeleteEmployees.Size = new System.Drawing.Size(292, 23);
            this.textDeleteEmployees.TabIndex = 49;
            // 
            // buttonDeleteEmployees
            // 
            this.buttonDeleteEmployees.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonDeleteEmployees.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteEmployees.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteEmployees.Location = new System.Drawing.Point(486, 156);
            this.buttonDeleteEmployees.Name = "buttonDeleteEmployees";
            this.buttonDeleteEmployees.Size = new System.Drawing.Size(100, 48);
            this.buttonDeleteEmployees.TabIndex = 48;
            this.buttonDeleteEmployees.Text = "Delete";
            this.buttonDeleteEmployees.UseVisualStyleBackColor = false;
            this.buttonDeleteEmployees.Click += new System.EventHandler(this.buttonSearcEmployees_Click);
            // 
            // dataGridViewDeleteEmployees
            // 
            this.dataGridViewDeleteEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeleteEmployees.Location = new System.Drawing.Point(42, 254);
            this.dataGridViewDeleteEmployees.Name = "dataGridViewDeleteEmployees";
            this.dataGridViewDeleteEmployees.RowTemplate.Height = 25;
            this.dataGridViewDeleteEmployees.Size = new System.Drawing.Size(694, 268);
            this.dataGridViewDeleteEmployees.TabIndex = 53;
            // 
            // DeleteForEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridViewDeleteEmployees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textDeleteEmployees);
            this.Controls.Add(this.buttonDeleteEmployees);
            this.Name = "DeleteForEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteForEmployees";
            this.Load += new System.EventHandler(this.DeleteForEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label11;
        private PictureBox pictureBox1;
        private TextBox textDeleteEmployees;
        private Button buttonDeleteEmployees;
        private DataGridView dataGridViewDeleteEmployees;
    }
}