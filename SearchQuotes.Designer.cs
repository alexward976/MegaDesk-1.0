﻿namespace MegaDesk
{
    partial class SearchQuotes
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
            this.SearchQuotesCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchQuotesCloseButton
            // 
            this.SearchQuotesCloseButton.Location = new System.Drawing.Point(247, 526);
            this.SearchQuotesCloseButton.Name = "SearchQuotesCloseButton";
            this.SearchQuotesCloseButton.Size = new System.Drawing.Size(75, 23);
            this.SearchQuotesCloseButton.TabIndex = 0;
            this.SearchQuotesCloseButton.Text = "Close";
            this.SearchQuotesCloseButton.UseVisualStyleBackColor = true;
            this.SearchQuotesCloseButton.Click += new System.EventHandler(this.SearchQuotesCloseButton_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 561);
            this.Controls.Add(this.SearchQuotesCloseButton);
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchQuotesCloseButton;
    }
}