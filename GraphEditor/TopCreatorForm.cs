using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphEditor
{
    public partial class TopCreatorForm : Form
    {
        public TopCreatorForm()
        {
            InitializeComponent();
        }
        public string topname = " ";
        public Color topcolor = Color.Black;
        private void ColorDialogOpenButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Colorlabel1.BackColor = colorDialog1.Color;
            Colorlabel1.ForeColor = colorDialog1.Color;
            
        }
        public static bool isvalidparametrs = true;
        private void SetButton_Click(object sender, EventArgs e)
        {
            isvalidparametrs = true;
            topname = textBox1.Text;
            topcolor= colorDialog1.Color;
            foreach (Label lb in GraphEditorMain.labellist)
            {
                if (lb.Text == topname)
                {
                    isvalidparametrs = false;
                    MessageBox.Show("Точка с таким именем уже существует !", "Ошибка создания вершины", MessageBoxButtons.OK);
                }
            }
            if (isvalidparametrs == true) { 
                GraphEditor.GraphEditorMain.Top_Name = topname;
                GraphEditor.GraphEditorMain.Top_Color = topcolor;
                this.Close(); }
         

        }
    }
}
