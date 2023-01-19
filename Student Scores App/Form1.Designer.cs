namespace Student_Scores_App
{
    partial class Form1
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
            this.panel_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_sideMenu = new System.Windows.Forms.Panel();
            this.button_display = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.panel_cover = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_header.SuspendLayout();
            this.panel_sideMenu.SuspendLayout();
            this.panel_cover.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.Teal;
            this.panel_header.Controls.Add(this.label1);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1087, 46);
            this.panel_header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(367, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENTS SCORES APP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_sideMenu
            // 
            this.panel_sideMenu.BackColor = System.Drawing.Color.DimGray;
            this.panel_sideMenu.Controls.Add(this.button_display);
            this.panel_sideMenu.Controls.Add(this.button_update);
            this.panel_sideMenu.Controls.Add(this.button_create);
            this.panel_sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sideMenu.Location = new System.Drawing.Point(0, 46);
            this.panel_sideMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_sideMenu.Name = "panel_sideMenu";
            this.panel_sideMenu.Size = new System.Drawing.Size(144, 474);
            this.panel_sideMenu.TabIndex = 1;
            // 
            // button_display
            // 
            this.button_display.BackColor = System.Drawing.Color.DeepPink;
            this.button_display.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_display.FlatAppearance.BorderSize = 0;
            this.button_display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_display.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_display.ForeColor = System.Drawing.Color.White;
            this.button_display.Location = new System.Drawing.Point(8, 293);
            this.button_display.Margin = new System.Windows.Forms.Padding(0);
            this.button_display.Name = "button_display";
            this.button_display.Padding = new System.Windows.Forms.Padding(2);
            this.button_display.Size = new System.Drawing.Size(127, 34);
            this.button_display.TabIndex = 4;
            this.button_display.Text = "Print";
            this.button_display.UseVisualStyleBackColor = false;
            this.button_display.Click += new System.EventHandler(this.button_display_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.SeaGreen;
            this.button_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(9, 215);
            this.button_update.Margin = new System.Windows.Forms.Padding(0);
            this.button_update.Name = "button_update";
            this.button_update.Padding = new System.Windows.Forms.Padding(2);
            this.button_update.Size = new System.Drawing.Size(127, 34);
            this.button_update.TabIndex = 3;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_create
            // 
            this.button_create.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_create.FlatAppearance.BorderSize = 0;
            this.button_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_create.ForeColor = System.Drawing.Color.White;
            this.button_create.Location = new System.Drawing.Point(8, 136);
            this.button_create.Margin = new System.Windows.Forms.Padding(0);
            this.button_create.Name = "button_create";
            this.button_create.Padding = new System.Windows.Forms.Padding(2);
            this.button_create.Size = new System.Drawing.Size(127, 34);
            this.button_create.TabIndex = 2;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = false;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // panel_cover
            // 
            this.panel_cover.Controls.Add(this.panel_main);
            this.panel_cover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cover.Location = new System.Drawing.Point(144, 46);
            this.panel_cover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_cover.Name = "panel_cover";
            this.panel_cover.Size = new System.Drawing.Size(943, 474);
            this.panel_cover.TabIndex = 2;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.OldLace;
            this.panel_main.Controls.Add(this.button3);
            this.panel_main.Controls.Add(this.label4);
            this.panel_main.Controls.Add(this.label3);
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(943, 474);
            this.panel_main.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(326, 202);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(2);
            this.button3.Size = new System.Drawing.Size(187, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "Let\'s Begin";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label4.Location = new System.Drawing.Point(78, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "To continue Click \"Let\'s Begin\" !";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label3.Location = new System.Drawing.Point(78, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(635, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "You can create, update and print the students score here.\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(192, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome to Students Score App";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 520);
            this.Controls.Add(this.panel_cover);
            this.Controls.Add(this.panel_sideMenu);
            this.Controls.Add(this.panel_header);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1103, 559);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_sideMenu.ResumeLayout(false);
            this.panel_cover.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_header;
        private Label label1;
        private Panel panel_sideMenu;
        private Button button_display;
        private Button button_update;
        private Button button_create;
        private Panel panel_cover;
        private Panel panel_main;
        private Button button3;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}