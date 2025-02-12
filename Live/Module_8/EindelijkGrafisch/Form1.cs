namespace EindelijkGrafisch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                this.BackColor = colorDialog1.Color;
            }
        }
    }
}
