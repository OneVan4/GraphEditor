namespace GraphEditor
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            StartPageButton.Hide();
           
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraphEditorMain gem = new GraphEditorMain();    
            gem.Show();
            this.Hide();    
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (StartPageCheck.Checked)
            {
                StartPageButton.Show();
              

            }
            else 
            { 
                StartPageButton.Hide();
               
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}