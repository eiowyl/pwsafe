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
            this.SuspendLayout();
            // 
            // EndSession
            // 
            this.EndSession.Location = new System.Drawing.Point(544, 198);
            this.EndSession.Name = "EndSession";
            this.EndSession.Size = new System.Drawing.Size(176, 51);
            this.EndSession.TabIndex = 0;
            this.EndSession.Text = "Exit Program";
            this.EndSession.UseVisualStyleBackColor = true;
            this.EndSession.Click += new System.EventHandler(this.EndSession_Click);
            // 
            // OpenConn
            // 
            this.OpenConn.Location = new System.Drawing.Point(181, 48);
            this.OpenConn.Name = "OpenConn";
            this.OpenConn.Size = new System.Drawing.Size(138, 23);
            this.OpenConn.TabIndex = 1;
            this.OpenConn.Text = "Open A Connection";
            this.OpenConn.UseVisualStyleBackColor = true;
            this.OpenConn.Click += new System.EventHandler(this.OpenConn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 261);
            this.Controls.Add(this.OpenConn);
            this.Controls.Add(this.EndSession);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EndSession;
        private System.Windows.Forms.Button OpenConn;
    }
}