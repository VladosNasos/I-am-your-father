namespace I_am_your_father
{
    public partial class Form1 : Form
    {
        private Luke LukeForm;
        public Form1()
        {
            InitializeComponent();

            LukeForm = new Luke();
            LukeForm.LukeTextChanged += LukeTextBox_TextChanged;
        }

        private void LukeTextBox_TextChanged(object sender, EventArgs e)
        {
            VaderTextBox.Text = LukeForm.LukeTextBox.Text;
        }

        private void parentTextBox_TextChanged(object sender, EventArgs e)
        {
            LukeForm.LukeTextBox.Text = VaderTextBox.Text;
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            LukeForm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LukeForm.Show();
            LukeForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            LukeForm.Size = this.Size;
            LukeForm.Activate();
        }

        private void VaderTextBox_TextChanged(object sender, EventArgs e)
        {
            LukeForm.LukeTextBox.Text = VaderTextBox.Text;
        }
    }
}