﻿namespace TestAppWithConnection
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
            this.SuspendLayout();
            // 
            // EndSession
            // 
            this.EndSession.Location = new System.Drawing.Point(55, 48);
            this.EndSession.Name = "EndSession";
            this.EndSession.Size = new System.Drawing.Size(596, 170);
            this.EndSession.TabIndex = 0;
            this.EndSession.Text = "Close the Current Session";
            this.EndSession.UseVisualStyleBackColor = true;
            this.EndSession.Click += new System.EventHandler(this.EndSession_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 261);
            this.Controls.Add(this.EndSession);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EndSession;
    }
}