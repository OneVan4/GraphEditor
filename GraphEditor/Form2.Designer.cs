namespace GraphEditor
{
    partial class GraphEditorMain
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
            this.MenuButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label111 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(767, 465);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(105, 42);
            this.MenuButton.TabIndex = 0;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(577, 23);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(281, 28);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(12, 0);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(172, 20);
            this.label111.TabIndex = 3;
            this.label111.Text = "Инструменты создания";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.Location = new System.Drawing.Point(612, 0);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(227, 20);
            this.label143.TabIndex = 4;
            this.label143.Text = "Инструменты работы с графом";
            this.label143.Click += new System.EventHandler(this.label143_Click);
            // 
            // GraphEditorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 508);
            this.Controls.Add(this.label143);
            this.Controls.Add(this.label111);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.MenuButton);
            this.Name = "GraphEditorMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph Editor";
            this.Load += new System.EventHandler(this.GraphEditorMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphEditorMain_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GraphEditorMain_MouseClick_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button MenuButton;
        private ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBox2;
        private Label label111;
        private Label label143;
    }
}