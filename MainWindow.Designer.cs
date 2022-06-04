
namespace NFT
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.inkButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.startDrawingButton = new System.Windows.Forms.Button();
            this.shapeDrop = new System.Windows.Forms.ComboBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.fillButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(9, 9);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 40);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveButton.BackgroundImage")));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.Transparent;
            this.saveButton.Location = new System.Drawing.Point(71, 9);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(52, 39);
            this.saveButton.TabIndex = 1;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.Transparent;
            this.printButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("printButton.BackgroundImage")));
            this.printButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.printButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Location = new System.Drawing.Point(138, 14);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(54, 31);
            this.printButton.TabIndex = 2;
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // inkButton
            // 
            this.inkButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inkButton.BackgroundImage")));
            this.inkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.inkButton.FlatAppearance.BorderSize = 0;
            this.inkButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.inkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inkButton.Location = new System.Drawing.Point(198, 18);
            this.inkButton.Name = "inkButton";
            this.inkButton.Size = new System.Drawing.Size(47, 23);
            this.inkButton.TabIndex = 3;
            this.inkButton.UseVisualStyleBackColor = true;
            this.inkButton.Click += new System.EventHandler(this.inkButton_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(353, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 36);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // startDrawingButton
            // 
            this.startDrawingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startDrawingButton.BackgroundImage")));
            this.startDrawingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.startDrawingButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startDrawingButton.FlatAppearance.BorderSize = 0;
            this.startDrawingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.startDrawingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startDrawingButton.ForeColor = System.Drawing.Color.Transparent;
            this.startDrawingButton.Location = new System.Drawing.Point(467, 4);
            this.startDrawingButton.Name = "startDrawingButton";
            this.startDrawingButton.Size = new System.Drawing.Size(47, 50);
            this.startDrawingButton.TabIndex = 5;
            this.startDrawingButton.UseVisualStyleBackColor = true;
            this.startDrawingButton.Click += new System.EventHandler(this.startDrawingButton_Click);
            // 
            // shapeDrop
            // 
            this.shapeDrop.AllowDrop = true;
            this.shapeDrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shapeDrop.DropDownHeight = 100;
            this.shapeDrop.DropDownWidth = 100;
            this.shapeDrop.FormattingEnabled = true;
            this.shapeDrop.ImeMode = System.Windows.Forms.ImeMode.On;
            this.shapeDrop.IntegralHeight = false;
            this.shapeDrop.ItemHeight = 13;
            this.shapeDrop.Items.AddRange(new object[] {
            "Linii",
            "Triunghiuri",
            "Elipse",
            "Dreptunghiuri",
            "Poligoane",
            "Curbe Bezier"});
            this.shapeDrop.Location = new System.Drawing.Point(404, 20);
            this.shapeDrop.Name = "shapeDrop";
            this.shapeDrop.Size = new System.Drawing.Size(18, 21);
            this.shapeDrop.TabIndex = 6;
            this.shapeDrop.SelectedIndexChanged += new System.EventHandler(this.shapeDrop_SelectedIndexChanged);
            // 
            // colorButton
            // 
            this.colorButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("colorButton.BackgroundImage")));
            this.colorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.colorButton.FlatAppearance.BorderSize = 0;
            this.colorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.colorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton.Location = new System.Drawing.Point(558, 4);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(46, 48);
            this.colorButton.TabIndex = 7;
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // fillButton
            // 
            this.fillButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fillButton.BackgroundImage")));
            this.fillButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fillButton.FlatAppearance.BorderSize = 0;
            this.fillButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.fillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillButton.Location = new System.Drawing.Point(610, 5);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(52, 47);
            this.fillButton.TabIndex = 8;
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("infoButton.BackgroundImage")));
            this.infoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.infoButton.FlatAppearance.BorderSize = 0;
            this.infoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.Location = new System.Drawing.Point(700, 5);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(75, 47);
            this.infoButton.TabIndex = 9;
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(198, 104);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(400, 400);
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.shapeDrop);
            this.Controls.Add(this.startDrawingButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.inkButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button inkButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button startDrawingButton;
        private System.Windows.Forms.ComboBox shapeDrop;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
    }
}