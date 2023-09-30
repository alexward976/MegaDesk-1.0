namespace MegaDesk
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.AddQuoteCloseButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.CustNameInput = new System.Windows.Forms.TextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.DrawersLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SurfaceMaterialLabel = new System.Windows.Forms.Label();
            this.SurfaceMaterialInput = new System.Windows.Forms.TextBox();
            this.RushDaysLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ViewTotalButton = new System.Windows.Forms.Button();
            this.WidthInput = new System.Windows.Forms.TextBox();
            this.DepthInput = new System.Windows.Forms.TextBox();
            this.DrawersInput = new System.Windows.Forms.TextBox();
            this.RushOrderInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddQuoteCloseButton
            // 
            this.AddQuoteCloseButton.AutoSize = true;
            this.AddQuoteCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuoteCloseButton.Location = new System.Drawing.Point(247, 511);
            this.AddQuoteCloseButton.Name = "AddQuoteCloseButton";
            this.AddQuoteCloseButton.Size = new System.Drawing.Size(75, 38);
            this.AddQuoteCloseButton.TabIndex = 7;
            this.AddQuoteCloseButton.Text = "Close";
            this.AddQuoteCloseButton.UseVisualStyleBackColor = true;
            this.AddQuoteCloseButton.Click += new System.EventHandler(this.AddQuoteCloseButton_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(7, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(138, 29);
            this.title.TabIndex = 2;
            this.title.Text = "New Quote";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustNameInput
            // 
            this.CustNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNameInput.Location = new System.Drawing.Point(12, 82);
            this.CustNameInput.Name = "CustNameInput";
            this.CustNameInput.Size = new System.Drawing.Size(258, 23);
            this.CustNameInput.TabIndex = 0;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLabel.Location = new System.Drawing.Point(9, 63);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(135, 16);
            this.fullNameLabel.TabIndex = 4;
            this.fullNameLabel.Text = "Customer Full Name";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthLabel.Location = new System.Drawing.Point(9, 119);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(172, 16);
            this.WidthLabel.TabIndex = 5;
            this.WidthLabel.Text = "Desk width (24 in. - 96 in.)";
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthLabel.Location = new System.Drawing.Point(9, 174);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(176, 16);
            this.DepthLabel.TabIndex = 7;
            this.DepthLabel.Text = "Desk depth (12 in. - 48 in.)";
            // 
            // DrawersLabel
            // 
            this.DrawersLabel.AutoSize = true;
            this.DrawersLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawersLabel.Location = new System.Drawing.Point(9, 231);
            this.DrawersLabel.Name = "DrawersLabel";
            this.DrawersLabel.Size = new System.Drawing.Size(169, 16);
            this.DrawersLabel.TabIndex = 9;
            this.DrawersLabel.Text = "Number of drawers (0 - 7)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "inches";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "inches";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "drawers";
            // 
            // SurfaceMaterialLabel
            // 
            this.SurfaceMaterialLabel.AutoSize = true;
            this.SurfaceMaterialLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceMaterialLabel.Location = new System.Drawing.Point(9, 293);
            this.SurfaceMaterialLabel.Name = "SurfaceMaterialLabel";
            this.SurfaceMaterialLabel.Size = new System.Drawing.Size(268, 32);
            this.SurfaceMaterialLabel.TabIndex = 13;
            this.SurfaceMaterialLabel.Text = "Desktop surface material (choose from \r\nlaminate, oak, rosewood, veneer, or pine)" +
    "";
            // 
            // SurfaceMaterialInput
            // 
            this.SurfaceMaterialInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceMaterialInput.Location = new System.Drawing.Point(12, 330);
            this.SurfaceMaterialInput.Name = "SurfaceMaterialInput";
            this.SurfaceMaterialInput.Size = new System.Drawing.Size(258, 23);
            this.SurfaceMaterialInput.TabIndex = 4;
            // 
            // RushDaysLabel
            // 
            this.RushDaysLabel.AutoSize = true;
            this.RushDaysLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushDaysLabel.Location = new System.Drawing.Point(9, 372);
            this.RushDaysLabel.Name = "RushDaysLabel";
            this.RushDaysLabel.Size = new System.Drawing.Size(251, 32);
            this.RushDaysLabel.TabIndex = 16;
            this.RushDaysLabel.Text = "Rush order option (3, 5, or 7 days - for\r\nstandard 14 day delivery, enter 0)";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ViewTotalButton
            // 
            this.ViewTotalButton.AutoSize = true;
            this.ViewTotalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTotalButton.Location = new System.Drawing.Point(12, 511);
            this.ViewTotalButton.Name = "ViewTotalButton";
            this.ViewTotalButton.Size = new System.Drawing.Size(151, 38);
            this.ViewTotalButton.TabIndex = 6;
            this.ViewTotalButton.Text = "View Quote Total";
            this.ViewTotalButton.UseVisualStyleBackColor = true;
            this.ViewTotalButton.Click += new System.EventHandler(this.ViewTotalButton_Click);
            // 
            // WidthInput
            // 
            this.WidthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthInput.Location = new System.Drawing.Point(12, 138);
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(79, 23);
            this.WidthInput.TabIndex = 1;
            this.WidthInput.Validating += new System.ComponentModel.CancelEventHandler(this.WidthInput_Validating);
            this.WidthInput.Validated += new System.EventHandler(this.WidthInput_Validated);
            // 
            // DepthInput
            // 
            this.DepthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthInput.Location = new System.Drawing.Point(12, 193);
            this.DepthInput.Name = "DepthInput";
            this.DepthInput.Size = new System.Drawing.Size(79, 23);
            this.DepthInput.TabIndex = 2;
            this.DepthInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DepthInput_KeyDown);
            this.DepthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthInput_KeyPress);
            // 
            // DrawersInput
            // 
            this.DrawersInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawersInput.Location = new System.Drawing.Point(12, 250);
            this.DrawersInput.Name = "DrawersInput";
            this.DrawersInput.Size = new System.Drawing.Size(79, 23);
            this.DrawersInput.TabIndex = 3;
            // 
            // RushOrderInput
            // 
            this.RushOrderInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderInput.Location = new System.Drawing.Point(12, 407);
            this.RushOrderInput.Name = "RushOrderInput";
            this.RushOrderInput.Size = new System.Drawing.Size(79, 23);
            this.RushOrderInput.TabIndex = 5;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 561);
            this.Controls.Add(this.RushOrderInput);
            this.Controls.Add(this.DrawersInput);
            this.Controls.Add(this.DepthInput);
            this.Controls.Add(this.WidthInput);
            this.Controls.Add(this.ViewTotalButton);
            this.Controls.Add(this.RushDaysLabel);
            this.Controls.Add(this.SurfaceMaterialInput);
            this.Controls.Add(this.SurfaceMaterialLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrawersLabel);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.CustNameInput);
            this.Controls.Add(this.title);
            this.Controls.Add(this.AddQuoteCloseButton);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddQuoteCloseButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox CustNameInput;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.Label DrawersLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SurfaceMaterialLabel;
        private System.Windows.Forms.TextBox SurfaceMaterialInput;
        private System.Windows.Forms.Label RushDaysLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button ViewTotalButton;
        private System.Windows.Forms.TextBox RushOrderInput;
        private System.Windows.Forms.TextBox DrawersInput;
        private System.Windows.Forms.TextBox DepthInput;
        private System.Windows.Forms.TextBox WidthInput;
    }
}