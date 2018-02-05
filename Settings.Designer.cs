namespace T_WIN_EpiBubble_2017
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.title = new System.Windows.Forms.Label();
            this.arrowsColorLbl = new System.Windows.Forms.Label();
            this.arrowColorCmbx = new System.Windows.Forms.ComboBox();
            this.boxOk = new System.Windows.Forms.PictureBox();
            this.boxExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.boxOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.title.Font = new System.Drawing.Font("Mistral", 78F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.DarkRed;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(316, 126);
            this.title.TabIndex = 4;
            this.title.Text = "Settings";
            // 
            // arrowsColorLbl
            // 
            this.arrowsColorLbl.AutoSize = true;
            this.arrowsColorLbl.BackColor = System.Drawing.Color.Transparent;
            this.arrowsColorLbl.Font = new System.Drawing.Font("Mistral", 25F, System.Drawing.FontStyle.Bold);
            this.arrowsColorLbl.ForeColor = System.Drawing.Color.White;
            this.arrowsColorLbl.Location = new System.Drawing.Point(12, 168);
            this.arrowsColorLbl.Name = "arrowsColorLbl";
            this.arrowsColorLbl.Size = new System.Drawing.Size(180, 41);
            this.arrowsColorLbl.TabIndex = 5;
            this.arrowsColorLbl.Text = "Arrow\'s color";
            // 
            // arrowColorCmbx
            // 
            this.arrowColorCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arrowColorCmbx.Font = new System.Drawing.Font("Mistral", 15F);
            this.arrowColorCmbx.FormattingEnabled = true;
            this.arrowColorCmbx.Items.AddRange(new object[] {
            "Sélectionnez une couleur",
            "Astral",
            "Rose",
            "Olive",
            "Gray",
            "Maroon",
            "Gold"});
            this.arrowColorCmbx.Location = new System.Drawing.Point(217, 177);
            this.arrowColorCmbx.Name = "arrowColorCmbx";
            this.arrowColorCmbx.Size = new System.Drawing.Size(505, 31);
            this.arrowColorCmbx.TabIndex = 6;
            // 
            // boxOk
            // 
            this.boxOk.BackColor = System.Drawing.Color.Transparent;
            this.boxOk.BackgroundImage = global::T_WIN_EpiBubble_2017.Properties.Resources.btn_ok;
            this.boxOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boxOk.Location = new System.Drawing.Point(627, 292);
            this.boxOk.Name = "boxOk";
            this.boxOk.Size = new System.Drawing.Size(95, 95);
            this.boxOk.TabIndex = 7;
            this.boxOk.TabStop = false;
            this.boxOk.Click += new System.EventHandler(this.boxOk_Click);
            // 
            // boxExit
            // 
            this.boxExit.BackColor = System.Drawing.Color.Transparent;
            this.boxExit.BackgroundImage = global::T_WIN_EpiBubble_2017.Properties.Resources.btn_four;
            this.boxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boxExit.Location = new System.Drawing.Point(506, 292);
            this.boxExit.Name = "boxExit";
            this.boxExit.Size = new System.Drawing.Size(95, 95);
            this.boxExit.TabIndex = 8;
            this.boxExit.TabStop = false;
            this.boxExit.Click += new System.EventHandler(this.boxExit_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::T_WIN_EpiBubble_2017.Properties.Resources.spacecat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 399);
            this.Controls.Add(this.boxExit);
            this.Controls.Add(this.boxOk);
            this.Controls.Add(this.arrowColorCmbx);
            this.Controls.Add(this.arrowsColorLbl);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label arrowsColorLbl;
        private System.Windows.Forms.ComboBox arrowColorCmbx;
        private System.Windows.Forms.PictureBox boxOk;
        private System.Windows.Forms.PictureBox boxExit;
    }
}