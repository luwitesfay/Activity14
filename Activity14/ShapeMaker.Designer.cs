namespace Activity14
{
    partial class ShapeMaker
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.shapeNameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.shapesList = new System.Windows.Forms.ListBox();
            this.fillModegroupBox = new System.Windows.Forms.GroupBox();
            this.fillRadioButton = new System.Windows.Forms.RadioButton();
            this.outlineRadioButton = new System.Windows.Forms.RadioButton();
            this.DetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.DateCB = new System.Windows.Forms.CheckBox();
            this.NameCB = new System.Windows.Forms.CheckBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.displayShapePanel = new System.Windows.Forms.Panel();
            this.fillModegroupBox.SuspendLayout();
            this.DetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(79, 97);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(193, 36);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Select a shape";
            // 
            // shapeNameLabel
            // 
            this.shapeNameLabel.AutoSize = true;
            this.shapeNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shapeNameLabel.Location = new System.Drawing.Point(763, 581);
            this.shapeNameLabel.Name = "shapeNameLabel";
            this.shapeNameLabel.Size = new System.Drawing.Size(0, 36);
            this.shapeNameLabel.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(763, 517);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 36);
            this.dateLabel.TabIndex = 2;
            // 
            // shapesList
            // 
            this.shapesList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shapesList.FormattingEnabled = true;
            this.shapesList.ItemHeight = 36;
            this.shapesList.Items.AddRange(new object[] {
            "Circle",
            "Triangle",
            "Rectangle",
            "Pentagon",
            "Hexagon"});
            this.shapesList.Location = new System.Drawing.Point(79, 139);
            this.shapesList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.shapesList.Name = "shapesList";
            this.shapesList.Size = new System.Drawing.Size(240, 184);
            this.shapesList.TabIndex = 3;
            this.shapesList.SelectedIndexChanged += new System.EventHandler(this.shapesList_SelectedIndexChanged);
            // 
            // fillModegroupBox
            // 
            this.fillModegroupBox.Controls.Add(this.fillRadioButton);
            this.fillModegroupBox.Controls.Add(this.outlineRadioButton);
            this.fillModegroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fillModegroupBox.Location = new System.Drawing.Point(79, 381);
            this.fillModegroupBox.Name = "fillModegroupBox";
            this.fillModegroupBox.Size = new System.Drawing.Size(400, 200);
            this.fillModegroupBox.TabIndex = 4;
            this.fillModegroupBox.TabStop = false;
            this.fillModegroupBox.Text = "Select fill mode";
            // 
            // fillRadioButton
            // 
            this.fillRadioButton.AutoSize = true;
            this.fillRadioButton.Location = new System.Drawing.Point(18, 108);
            this.fillRadioButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.fillRadioButton.Name = "fillRadioButton";
            this.fillRadioButton.Size = new System.Drawing.Size(91, 40);
            this.fillRadioButton.TabIndex = 7;
            this.fillRadioButton.TabStop = true;
            this.fillRadioButton.Text = "Fill";
            this.fillRadioButton.UseVisualStyleBackColor = true;
            // 
            // outlineRadioButton
            // 
            this.outlineRadioButton.AutoSize = true;
            this.outlineRadioButton.Location = new System.Drawing.Point(18, 53);
            this.outlineRadioButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.outlineRadioButton.Name = "outlineRadioButton";
            this.outlineRadioButton.Size = new System.Drawing.Size(140, 40);
            this.outlineRadioButton.TabIndex = 6;
            this.outlineRadioButton.TabStop = true;
            this.outlineRadioButton.Text = "Outline";
            this.outlineRadioButton.UseVisualStyleBackColor = true;
            // 
            // DetailsGroupBox
            // 
            this.DetailsGroupBox.Controls.Add(this.DateCB);
            this.DetailsGroupBox.Controls.Add(this.NameCB);
            this.DetailsGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DetailsGroupBox.Location = new System.Drawing.Point(79, 618);
            this.DetailsGroupBox.Name = "DetailsGroupBox";
            this.DetailsGroupBox.Size = new System.Drawing.Size(400, 200);
            this.DetailsGroupBox.TabIndex = 5;
            this.DetailsGroupBox.TabStop = false;
            this.DetailsGroupBox.Text = "Select details";
            // 
            // DateCB
            // 
            this.DateCB.AutoSize = true;
            this.DateCB.Location = new System.Drawing.Point(26, 117);
            this.DateCB.Name = "DateCB";
            this.DateCB.Size = new System.Drawing.Size(107, 40);
            this.DateCB.TabIndex = 1;
            this.DateCB.Text = "Date";
            this.DateCB.UseVisualStyleBackColor = true;
            // 
            // NameCB
            // 
            this.NameCB.AutoSize = true;
            this.NameCB.Location = new System.Drawing.Point(26, 56);
            this.NameCB.Name = "NameCB";
            this.NameCB.Size = new System.Drawing.Size(121, 40);
            this.NameCB.TabIndex = 0;
            this.NameCB.Text = "Name";
            this.NameCB.UseVisualStyleBackColor = true;
            // 
            // drawButton
            // 
            this.drawButton.BackColor = System.Drawing.Color.LimeGreen;
            this.drawButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drawButton.Location = new System.Drawing.Point(573, 706);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(206, 55);
            this.drawButton.TabIndex = 2;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = false;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Gainsboro;
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(834, 706);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(195, 55);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // displayShapePanel
            // 
            this.displayShapePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.displayShapePanel.Location = new System.Drawing.Point(584, 108);
            this.displayShapePanel.Name = "displayShapePanel";
            this.displayShapePanel.Size = new System.Drawing.Size(467, 366);
            this.displayShapePanel.TabIndex = 7;
            // 
            // ShapeMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1222, 938);
            this.Controls.Add(this.displayShapePanel);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.DetailsGroupBox);
            this.Controls.Add(this.fillModegroupBox);
            this.Controls.Add(this.shapesList);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.shapeNameLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "ShapeMaker";
            this.Text = "ShapeMaker";
            this.fillModegroupBox.ResumeLayout(false);
            this.fillModegroupBox.PerformLayout();
            this.DetailsGroupBox.ResumeLayout(false);
            this.DetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLabel;
        private Label shapeNameLabel;
        private Label dateLabel;
        private ListBox shapesList;
        private GroupBox fillModegroupBox;
        private RadioButton fillRadioButton;
        private RadioButton outlineRadioButton;
        private GroupBox DetailsGroupBox;
        private CheckBox DateCB;
        private CheckBox NameCB;
        private Button drawButton;
        private Button clearButton;
        private Panel displayShapePanel;
    }
}