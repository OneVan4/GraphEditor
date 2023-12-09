using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphEditor
{
    public partial class Save : Form
    {
        public Save()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        bool wasset = true; 
        private void button1_Click(object sender, EventArgs e)
        {
            double weight =0;
            wasset = true;
            try { weight=Convert.ToDouble(textBox1.Text); }
            catch (Exception ex) 
            { 
               wasset = false; 
              MessageBox.Show("Неверное значение !", "Неудача");
            }
            if (wasset == true)
            {
                GraphEditor.GraphEditorMain.weight = weight;
                this.Close();
            }
         
        }
    }
}
