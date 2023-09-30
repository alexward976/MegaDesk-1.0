namespace MegaDesk
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.addQuoteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.searchQuotesButton = new System.Windows.Forms.Button();
            this.viewQuotesButton = new System.Windows.Forms.Button();
            this.deskImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.deskImage)).BeginInit();
            this.SuspendLayout();
            // 
            // addQuoteButton
            // 
            this.addQuoteButton.BackColor = System.Drawing.Color.LightGray;
            this.addQuoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addQuoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addQuoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addQuoteButton.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteButton.ForeColor = System.Drawing.Color.Black;
            this.addQuoteButton.Location = new System.Drawing.Point(25, 16);
            this.addQuoteButton.Name = "addQuoteButton";
            this.addQuoteButton.Size = new System.Drawing.Size(161, 51);
            this.addQuoteButton.TabIndex = 0;
            this.addQuoteButton.Text = "&Add New Quote";
            this.addQuoteButton.UseVisualStyleBackColor = false;
            this.addQuoteButton.Click += new System.EventHandler(this.addQuoteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LightGray;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(25, 187);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(161, 51);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // searchQuotesButton
            // 
            this.searchQuotesButton.BackColor = System.Drawing.Color.LightGray;
            this.searchQuotesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchQuotesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.searchQuotesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchQuotesButton.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotesButton.ForeColor = System.Drawing.Color.Black;
            this.searchQuotesButton.Location = new System.Drawing.Point(25, 130);
            this.searchQuotesButton.Name = "searchQuotesButton";
            this.searchQuotesButton.Size = new System.Drawing.Size(161, 51);
            this.searchQuotesButton.TabIndex = 2;
            this.searchQuotesButton.Text = "&Search Quotes";
            this.searchQuotesButton.UseVisualStyleBackColor = false;
            this.searchQuotesButton.Click += new System.EventHandler(this.searchQuotesButton_Click);
            // 
            // viewQuotesButton
            // 
            this.viewQuotesButton.BackColor = System.Drawing.Color.LightGray;
            this.viewQuotesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewQuotesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.viewQuotesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewQuotesButton.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuotesButton.ForeColor = System.Drawing.Color.Black;
            this.viewQuotesButton.Location = new System.Drawing.Point(25, 73);
            this.viewQuotesButton.Name = "viewQuotesButton";
            this.viewQuotesButton.Size = new System.Drawing.Size(161, 51);
            this.viewQuotesButton.TabIndex = 1;
            this.viewQuotesButton.Text = "&View Quotes";
            this.viewQuotesButton.UseVisualStyleBackColor = false;
            this.viewQuotesButton.Click += new System.EventHandler(this.viewQuotesButton_Click);
            // 
            // deskImage
            // 
            this.deskImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deskImage.Image = ((System.Drawing.Image)(resources.GetObject("deskImage.Image")));
            this.deskImage.Location = new System.Drawing.Point(230, 54);
            this.deskImage.Name = "deskImage";
            this.deskImage.Size = new System.Drawing.Size(165, 139);
            this.deskImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deskImage.TabIndex = 4;
            this.deskImage.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(427, 250);
            this.Controls.Add(this.deskImage);
            this.Controls.Add(this.viewQuotesButton);
            this.Controls.Add(this.searchQuotesButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addQuoteButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.deskImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addQuoteButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button searchQuotesButton;
        private System.Windows.Forms.Button viewQuotesButton;
        private System.Windows.Forms.PictureBox deskImage;
    }
}

