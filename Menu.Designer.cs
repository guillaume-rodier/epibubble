using T_WIN_EpiBubble_2017.Classes; 

namespace T_WIN_EpiBubble_2017
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.PictureBox();
            this.btn_level = new System.Windows.Forms.PictureBox();
            this.btn_config = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.label_newGame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_config)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Image = global::T_WIN_EpiBubble_2017.Properties.Resources.btn_four;
            this.btn_exit.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.InitialImage")));
            this.btn_exit.Location = new System.Drawing.Point(238, 370);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(140, 140);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_exit.TabIndex = 1;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.Image = global::T_WIN_EpiBubble_2017.Properties.Resources.btn_one;
            this.btn_start.Location = new System.Drawing.Point(55, 194);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(140, 140);
            this.btn_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_start.TabIndex = 2;
            this.btn_start.TabStop = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_level
            // 
            this.btn_level.BackColor = System.Drawing.Color.Transparent;
            this.btn_level.Image = global::T_WIN_EpiBubble_2017.Properties.Resources.btn_two;
            this.btn_level.Location = new System.Drawing.Point(238, 194);
            this.btn_level.Name = "btn_level";
            this.btn_level.Size = new System.Drawing.Size(140, 140);
            this.btn_level.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_level.TabIndex = 2;
            this.btn_level.TabStop = false;
            this.btn_level.Click += new System.EventHandler(this.btn_level_Click);
            // 
            // btn_config
            // 
            this.btn_config.BackColor = System.Drawing.Color.Transparent;
            this.btn_config.Image = global::T_WIN_EpiBubble_2017.Properties.Resources.btn_three;
            this.btn_config.Location = new System.Drawing.Point(55, 370);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(140, 140);
            this.btn_config.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_config.TabIndex = 2;
            this.btn_config.TabStop = false;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.title.Font = new System.Drawing.Font("Mistral", 78F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.DarkRed;
            this.title.Location = new System.Drawing.Point(28, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(376, 126);
            this.title.TabIndex = 3;
            this.title.Text = "EpiBubble";
            // 
            // label_newGame
            // 
            this.label_newGame.AutoSize = true;
            this.label_newGame.Location = new System.Drawing.Point(100, 241);
            this.label_newGame.Name = "label_newGame";
            this.label_newGame.Size = new System.Drawing.Size(0, 13);
            this.label_newGame.TabIndex = 4;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 565);
            this.Controls.Add(this.label_newGame);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btn_level);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.btn_exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menu";
            this.Text = "EpiBoobs";
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_config)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.PictureBox btn_start;
        private System.Windows.Forms.PictureBox btn_level;
        private System.Windows.Forms.PictureBox btn_config;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label_newGame;
    }
}