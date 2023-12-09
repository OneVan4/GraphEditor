namespace GraphEditor
{
    partial class TopCreatorForm
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
            this.SetButton = new System.Windows.Forms.Button();
            this.ColorDialogOpenButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.topsnamelabel = new System.Windows.Forms.Label();
            this.TopsColorLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Colorlabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(351, 248);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(94, 29);
            this.SetButton.TabIndex = 0;
            this.SetButton.Text = "Сохранить";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // ColorDialogOpenButton
            // 
            this.ColorDialogOpenButton.Location = new System.Drawing.Point(212, 143);
            this.ColorDialogOpenButton.Name = "ColorDialogOpenButton";
            this.ColorDialogOpenButton.Size = new System.Drawing.Size(81, 29);
            this.ColorDialogOpenButton.TabIndex = 2;
            this.ColorDialogOpenButton.Text = "выбрать";
            this.ColorDialogOpenButton.UseVisualStyleBackColor = true;
            this.ColorDialogOpenButton.Click += new System.EventHandler(this.ColorDialogOpenButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 3;
            // 
            // topsnamelabel
            // 
            this.topsnamelabel.AutoSize = true;
            this.topsnamelabel.Location = new System.Drawing.Point(12, 79);
            this.topsnamelabel.Name = "topsnamelabel";
            this.topsnamelabel.Size = new System.Drawing.Size(167, 20);
            this.topsnamelabel.TabIndex = 4;
            this.topsnamelabel.Text = "Введите имя вершины";
            // 
            // TopsColorLabel
            // 
            this.TopsColorLabel.AutoSize = true;
            this.TopsColorLabel.Location = new System.Drawing.Point(12, 147);
            this.TopsColorLabel.Name = "TopsColorLabel";
            this.TopsColorLabel.Size = new System.Drawing.Size(182, 20);
            this.TopsColorLabel.TabIndex = 5;
            this.TopsColorLabel.Text = "Выберете цвет вершины";
            // 
            // Colorlabel1
            // 
            this.Colorlabel1.AutoSize = true;
            this.Colorlabel1.BackColor = System.Drawing.Color.Transparent;
            this.Colorlabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Colorlabel1.Location = new System.Drawing.Point(327, 147);
            this.Colorlabel1.Name = "Colorlabel1";
            this.Colorlabel1.Size = new System.Drawing.Size(47, 22);
            this.Colorlabel1.TabIndex = 6;
            this.Colorlabel1.Text = "Color";
            // 
            // TopCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 277);
            this.Controls.Add(this.Colorlabel1);
            this.Controls.Add(this.TopsColorLabel);
            this.Controls.Add(this.topsnamelabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ColorDialogOpenButton);
            this.Controls.Add(this.SetButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TopCreatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TopCreatorForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SetButton;
        private Button ColorDialogOpenButton;
        private TextBox textBox1;
        private Label topsnamelabel;
        private Label TopsColorLabel;
        private ColorDialog colorDialog1;
        private Label Colorlabel1;
    }
}