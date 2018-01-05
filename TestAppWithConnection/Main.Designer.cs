namespace TestAppWithConnection
{
    partial class Main
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
            this.EndSession = new System.Windows.Forms.Button();
            this.OpenConn = new System.Windows.Forms.Button();
            this.Website = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.SQLDataDisplayBox = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SQLDataDisplayBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EndSession
            // 
            this.EndSession.Location = new System.Drawing.Point(544, 593);
            this.EndSession.Name = "EndSession";
            this.EndSession.Size = new System.Drawing.Size(176, 51);
            this.EndSession.TabIndex = 0;
            this.EndSession.Text = "Exit Program";
            this.EndSession.UseVisualStyleBackColor = true;
            this.EndSession.Click += new System.EventHandler(this.EndSession_Click);
            // 
            // OpenConn
            // 
            this.OpenConn.Location = new System.Drawing.Point(21, 24);
            this.OpenConn.Name = "OpenConn";
            this.OpenConn.Size = new System.Drawing.Size(138, 23);
            this.OpenConn.TabIndex = 1;
            this.OpenConn.Text = "Open A Connection";
            this.OpenConn.UseVisualStyleBackColor = true;
            this.OpenConn.Click += new System.EventHandler(this.OpenConn_Click);
            // 
            // Website
            // 
            this.Website.AutoSize = true;
            this.Website.Location = new System.Drawing.Point(184, 29);
            this.Website.Name = "Website";
            this.Website.Size = new System.Drawing.Size(46, 13);
            this.Website.TabIndex = 2;
            this.Website.Text = "Website";
            this.Website.Click += new System.EventHandler(this.Website_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(266, 29);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Location = new System.Drawing.Point(352, 29);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(53, 13);
            this.Pass.TabIndex = 4;
            this.Pass.Text = "Password";
            this.Pass.Click += new System.EventHandler(this.Pass_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(431, 29);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 5;
            this.Email.Text = "Email";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // SQLDataDisplayBox
            // 
            this.SQLDataDisplayBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SQLDataDisplayBox.Location = new System.Drawing.Point(21, 69);
            this.SQLDataDisplayBox.Name = "SQLDataDisplayBox";
            this.SQLDataDisplayBox.Size = new System.Drawing.Size(507, 575);
            this.SQLDataDisplayBox.TabIndex = 6;
            this.SQLDataDisplayBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SQLDataDisplayBox_CellContentClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 656);
            this.Controls.Add(this.SQLDataDisplayBox);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Website);
            this.Controls.Add(this.OpenConn);
            this.Controls.Add(this.EndSession);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.SQLDataDisplayBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EndSession;
        private System.Windows.Forms.Button OpenConn;
        private System.Windows.Forms.Label Website;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.DataGridView SQLDataDisplayBox;
    }
}