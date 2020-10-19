namespace WindowsFormsOrszagok
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView_Orszagok = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Orszagok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Orszagok
            // 
            this.dataGridView_Orszagok.AllowUserToAddRows = false;
            this.dataGridView_Orszagok.AllowUserToDeleteRows = false;
            this.dataGridView_Orszagok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Orszagok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Orszagok.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Orszagok.Name = "dataGridView_Orszagok";
            this.dataGridView_Orszagok.ReadOnly = true;
            this.dataGridView_Orszagok.RowHeadersWidth = 51;
            this.dataGridView_Orszagok.RowTemplate.Height = 24;
            this.dataGridView_Orszagok.Size = new System.Drawing.Size(800, 450);
            this.dataGridView_Orszagok.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_Orszagok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Orszagok adatbazis";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Orszagok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Orszagok;
    }
}

