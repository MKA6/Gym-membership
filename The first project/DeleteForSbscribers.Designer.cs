namespace The_first_project
{
    partial class DeleteForSbscribers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteForSbscribers));
            this.dataGridViewDeleteSubscribers = new System.Windows.Forms.DataGridView();
            this.textDeleteSubscribers = new System.Windows.Forms.TextBox();
            this.buttonDeleteSubscribers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteSubscribers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDeleteSubscribers
            // 
            this.dataGridViewDeleteSubscribers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeleteSubscribers.Location = new System.Drawing.Point(43, 260);
            this.dataGridViewDeleteSubscribers.Name = "dataGridViewDeleteSubscribers";
            this.dataGridViewDeleteSubscribers.RowTemplate.Height = 25;
            this.dataGridViewDeleteSubscribers.Size = new System.Drawing.Size(694, 268);
            this.dataGridViewDeleteSubscribers.TabIndex = 44;
            // 
            // textDeleteSubscribers
            // 
            this.textDeleteSubscribers.Location = new System.Drawing.Point(221, 214);
            this.textDeleteSubscribers.Name = "textDeleteSubscribers";
            this.textDeleteSubscribers.Size = new System.Drawing.Size(292, 23);
            this.textDeleteSubscribers.TabIndex = 43;
            // 
            // buttonDeleteSubscribers
            // 
            this.buttonDeleteSubscribers.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonDeleteSubscribers.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteSubscribers.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteSubscribers.Location = new System.Drawing.Point(494, 160);
            this.buttonDeleteSubscribers.Name = "buttonDeleteSubscribers";
            this.buttonDeleteSubscribers.Size = new System.Drawing.Size(100, 48);
            this.buttonDeleteSubscribers.TabIndex = 42;
            this.buttonDeleteSubscribers.Text = "Delete";
            this.buttonDeleteSubscribers.UseVisualStyleBackColor = false;
            this.buttonDeleteSubscribers.Click += new System.EventHandler(this.buttonSearcEquipment_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(221, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 37);
            this.label2.TabIndex = 47;
            this.label2.Text = "Delete for Subscribers";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(295, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 30);
            this.label11.TabIndex = 46;
            this.label11.Text = "Gymnasium";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(349, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 74);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // DeleteForSbscribers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewDeleteSubscribers);
            this.Controls.Add(this.textDeleteSubscribers);
            this.Controls.Add(this.buttonDeleteSubscribers);
            this.Name = "DeleteForSbscribers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteForSbscribers";
            this.Load += new System.EventHandler(this.DeleteForSbscribers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteSubscribers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewDeleteSubscribers;
        private TextBox textDeleteSubscribers;
        private Button buttonDeleteSubscribers;
        private Label label2;
        private Label label11;
        private PictureBox pictureBox1;
    }
}