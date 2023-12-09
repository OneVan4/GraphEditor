namespace GraphEditor
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartPageButton = new System.Windows.Forms.Button();
            this.StartPageCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // StartPageButton
            // 
            this.StartPageButton.Location = new System.Drawing.Point(366, 354);
            this.StartPageButton.Name = "StartPageButton";
            this.StartPageButton.Size = new System.Drawing.Size(124, 60);
            this.StartPageButton.TabIndex = 0;
            this.StartPageButton.Text = "Начать";
            this.StartPageButton.UseVisualStyleBackColor = true;
            this.StartPageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartPageCheck
            // 
            this.StartPageCheck.AutoSize = true;
            this.StartPageCheck.Location = new System.Drawing.Point(234, 289);
            this.StartPageCheck.Name = "StartPageCheck";
            this.StartPageCheck.Size = new System.Drawing.Size(426, 24);
            this.StartPageCheck.TabIndex = 1;
            this.StartPageCheck.Text = "Я подтверждаю,что умею читать  текст на русском языке";
            this.StartPageCheck.UseVisualStyleBackColor = true;
            this.StartPageCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 508);
            this.Controls.Add(this.StartPageCheck);
            this.Controls.Add(this.StartPageButton);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph Editor";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button StartPageButton;
        private CheckBox StartPageCheck;
    }
}