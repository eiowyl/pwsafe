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
            this.SQLDataDisplayBox = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Label();
            this.Website = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.pw = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.options = new System.Windows.Forms.ComboBox();
            this.websiteTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.SubmitSQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SQLDataDisplayBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EndSession
            // 
            this.EndSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndSession.Location = new System.Drawing.Point(503, 12);
            this.EndSession.Name = "EndSession";
            this.EndSession.Size = new System.Drawing.Size(176, 51);
            this.EndSession.TabIndex = 0;
            this.EndSession.Text = "Exit Program";
            this.EndSession.UseVisualStyleBackColor = true;
            this.EndSession.Click += new System.EventHandler(this.EndSession_Click);
            // 
            // SQLDataDisplayBox
            // 
            this.SQLDataDisplayBox.AllowUserToAddRows = false;
            this.SQLDataDisplayBox.AllowUserToDeleteRows = false;
            this.SQLDataDisplayBox.AllowUserToResizeRows = false;
            this.SQLDataDisplayBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SQLDataDisplayBox.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SQLDataDisplayBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SQLDataDisplayBox.Location = new System.Drawing.Point(251, 80);
            this.SQLDataDisplayBox.Name = "SQLDataDisplayBox";
            this.SQLDataDisplayBox.ReadOnly = true;
            this.SQLDataDisplayBox.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SQLDataDisplayBox.Size = new System.Drawing.Size(428, 449);
            this.SQLDataDisplayBox.TabIndex = 6;
            this.SQLDataDisplayBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SQLDataDisplayBox_CellContentClick);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(13, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(351, 31);
            this.Title.TabIndex = 7;
            this.Title.Text = "Welcome to PassSafe (c)";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Insert
            // 
            this.Insert.AutoSize = true;
            this.Insert.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.Location = new System.Drawing.Point(19, 80);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(105, 20);
            this.Insert.TabIndex = 8;
            this.Insert.Text = "Insert New Row:";
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Website
            // 
            this.Website.AutoSize = true;
            this.Website.Location = new System.Drawing.Point(20, 135);
            this.Website.Name = "Website";
            this.Website.Size = new System.Drawing.Size(46, 13);
            this.Website.TabIndex = 9;
            this.Website.Text = "Website";
            this.Website.Click += new System.EventHandler(this.Website_Click);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(20, 169);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(55, 13);
            this.User.TabIndex = 10;
            this.User.Text = "Username";
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // pw
            // 
            this.pw.AutoSize = true;
            this.pw.Location = new System.Drawing.Point(20, 199);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(53, 13);
            this.pw.TabIndex = 11;
            this.pw.Text = "Password";
            this.pw.Click += new System.EventHandler(this.pw_Click);
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Location = new System.Drawing.Point(20, 258);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(49, 13);
            this.category.TabIndex = 12;
            this.category.Text = "Category";
            this.category.Click += new System.EventHandler(this.category_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(20, 229);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(32, 13);
            this.email.TabIndex = 13;
            this.email.Text = "Email";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // options
            // 
            this.options.FormattingEnabled = true;
            this.options.Items.AddRange(new object[] {
            "Primary Account",
            "General",
            "Gaming",
            "Shopping"});
            this.options.Location = new System.Drawing.Point(98, 254);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(121, 21);
            this.options.TabIndex = 14;
            this.options.SelectedIndexChanged += new System.EventHandler(this.options_SelectedIndexChanged);
            // 
            // websiteTB
            // 
            this.websiteTB.Location = new System.Drawing.Point(98, 132);
            this.websiteTB.Name = "websiteTB";
            this.websiteTB.Size = new System.Drawing.Size(121, 20);
            this.websiteTB.TabIndex = 15;
            this.websiteTB.TextChanged += new System.EventHandler(this.websiteTB_TextChanged);
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(98, 162);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(121, 20);
            this.usernameTB.TabIndex = 16;
            this.usernameTB.TextChanged += new System.EventHandler(this.usernameTB_TextChanged);
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(98, 193);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(121, 20);
            this.passwordTB.TabIndex = 18;
            this.passwordTB.TextChanged += new System.EventHandler(this.passwordTB_TextChanged);
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(98, 223);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(121, 20);
            this.emailTB.TabIndex = 19;
            this.emailTB.TextChanged += new System.EventHandler(this.emailTB_TextChanged);
            // 
            // SubmitSQL
            // 
            this.SubmitSQL.Location = new System.Drawing.Point(144, 286);
            this.SubmitSQL.Name = "SubmitSQL";
            this.SubmitSQL.Size = new System.Drawing.Size(75, 23);
            this.SubmitSQL.TabIndex = 20;
            this.SubmitSQL.Text = "Submit";
            this.SubmitSQL.UseVisualStyleBackColor = true;
            this.SubmitSQL.Click += new System.EventHandler(this.SubmitSQL_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 541);
            this.Controls.Add(this.SubmitSQL);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.websiteTB);
            this.Controls.Add(this.options);
            this.Controls.Add(this.email);
            this.Controls.Add(this.category);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Website);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.SQLDataDisplayBox);
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
        private System.Windows.Forms.DataGridView SQLDataDisplayBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Website;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label pw;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.ComboBox options;
        private System.Windows.Forms.TextBox websiteTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Button SubmitSQL;
    }
}