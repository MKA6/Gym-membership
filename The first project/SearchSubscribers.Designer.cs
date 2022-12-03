namespace The_first_project
{
    partial class SearchSubscribers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchSubscribers));
            this.dataGridViewSearchSubscribers = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textSearchSubscribers = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchSubscribers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSearchSubscribers
            // 
            this.dataGridViewSearchSubscribers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchSubscribers.Location = new System.Drawing.Point(70, 237);
            this.dataGridViewSearchSubscribers.Name = "dataGridViewSearchSubscribers";
            this.dataGridViewSearchSubscribers.RowTemplate.Height = 25;
            this.dataGridViewSearchSubscribers.Size = new System.Drawing.Size(644, 312);
            this.dataGridViewSearchSubscribers.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(290, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 30);
            this.label11.TabIndex = 32;
            this.label11.Text = "Gymnasium";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(344, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 74);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(199, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 31);
            this.label1.TabIndex = 34;
            this.label1.Text = "Search for Subscribers";
            // 
            // textSearchSubscribers
            // 
            this.textSearchSubscribers.Location = new System.Drawing.Point(199, 177);
            this.textSearchSubscribers.Name = "textSearchSubscribers";
            this.textSearchSubscribers.Size = new System.Drawing.Size(320, 23);
            this.textSearchSubscribers.TabIndex = 35;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Red;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(589, 163);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(113, 47);
            this.buttonSearch.TabIndex = 36;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchSubscribers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textSearchSubscribers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSearchSubscribers);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SearchSubscribers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchSubscribers";
            this.Load += new System.EventHandler(this.SearchSubscribers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchSubscribers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewSearchSubscribers;
        private Label label11;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textSearchSubscribers;
        private Button buttonSearch;
    }
}