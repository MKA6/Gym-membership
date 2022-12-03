namespace The_first_project
{
    partial class DeleteForEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteForEquipment));
            this.dataGridViewDeleteEquipment = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textDeleteEquipment = new System.Windows.Forms.TextBox();
            this.buttonDeleteEquipment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDeleteEquipment
            // 
            this.dataGridViewDeleteEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeleteEquipment.Location = new System.Drawing.Point(45, 256);
            this.dataGridViewDeleteEquipment.Name = "dataGridViewDeleteEquipment";
            this.dataGridViewDeleteEquipment.RowTemplate.Height = 25;
            this.dataGridViewDeleteEquipment.Size = new System.Drawing.Size(694, 268);
            this.dataGridViewDeleteEquipment.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(216, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 37);
            this.label2.TabIndex = 58;
            this.label2.Text = "Delete for Equipment";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(290, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 30);
            this.label11.TabIndex = 57;
            this.label11.Text = "Gymnasium";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(344, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 74);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // textDeleteEquipment
            // 
            this.textDeleteEquipment.Location = new System.Drawing.Point(216, 214);
            this.textDeleteEquipment.Name = "textDeleteEquipment";
            this.textDeleteEquipment.Size = new System.Drawing.Size(292, 23);
            this.textDeleteEquipment.TabIndex = 55;
            // 
            // buttonDeleteEquipment
            // 
            this.buttonDeleteEquipment.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonDeleteEquipment.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteEquipment.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteEquipment.Location = new System.Drawing.Point(489, 159);
            this.buttonDeleteEquipment.Name = "buttonDeleteEquipment";
            this.buttonDeleteEquipment.Size = new System.Drawing.Size(100, 48);
            this.buttonDeleteEquipment.TabIndex = 54;
            this.buttonDeleteEquipment.Text = "Delete";
            this.buttonDeleteEquipment.UseVisualStyleBackColor = false;
            this.buttonDeleteEquipment.Click += new System.EventHandler(this.buttonDeleteEquipment_Click);
            // 
            // DeleteForEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridViewDeleteEquipment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textDeleteEquipment);
            this.Controls.Add(this.buttonDeleteEquipment);
            this.Name = "DeleteForEquipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteForEquipment";
            this.Load += new System.EventHandler(this.DeleteForEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewDeleteEquipment;
        private Label label2;
        private Label label11;
        private PictureBox pictureBox1;
        private TextBox textDeleteEquipment;
        private Button buttonDeleteEquipment;
    }
}