namespace NSCmusical
{
    public partial class Form1 : Form
    {
        List<int> notes = new List<int>();

        public void reset_color()
        {
            this.key0.BackColor = System.Drawing.Color.White;
            this.key1.BackColor = System.Drawing.Color.Black;
            this.key2.BackColor = System.Drawing.Color.White;
            this.key3.BackColor = System.Drawing.Color.Black;
            this.key4.BackColor = System.Drawing.Color.White;
            this.key5.BackColor = System.Drawing.Color.Black;
            this.key6.BackColor = System.Drawing.Color.White;
            this.key7.BackColor = System.Drawing.Color.Black;
            this.key8.BackColor = System.Drawing.Color.White;
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            foreach (int i in notes)
            {
                result += i.ToString() + " ";
            }

            MessageBox.Show(result);
            notes.Clear();
        }

        private void key0_Click(object sender, EventArgs e)
        {
            notes.Add(0);
            notes.Add(100);
            reset_color();
            this.key0.BackColor = System.Drawing.Color.Green;
        }

        private void key1_Click(object sender, EventArgs e)
        {
            notes.Add(1);
            notes.Add(100);
            reset_color();
            this.key1.BackColor = System.Drawing.Color.Green;
        }

        

        private void key2_Click(object sender, EventArgs e)
        {
            notes.Add(2);
            notes.Add(100);
            reset_color();
            this.key2.BackColor = System.Drawing.Color.Green;
        }

        private void key3_Click(object sender, EventArgs e)
        {
            notes.Add(3);
            notes.Add(100);
            reset_color();
            this.key3.BackColor = System.Drawing.Color.Green;
        }

        private void key4_Click(object sender, EventArgs e)
        {
            notes.Add(4);
            notes.Add(100);
            reset_color();
            this.key4.BackColor = System.Drawing.Color.Green;
        }

        private void key5_Click(object sender, EventArgs e)
        {
            notes.Add(5);
            notes.Add(100);
            reset_color();
            this.key5.BackColor = System.Drawing.Color.Green;
        }

        private void key6_Click(object sender, EventArgs e)
        {
            notes.Add(6);
            notes.Add(100);
            reset_color();
            this.key6.BackColor = System.Drawing.Color.Green;
        }

        private void key7_Click(object sender, EventArgs e)
        {
            notes.Add(7);
            notes.Add(100);
            reset_color();
            this.key7.BackColor = System.Drawing.Color.Green;
        }

        private void key8_Click(object sender, EventArgs e)
        {
            notes.Add(8);
            notes.Add(100);
            reset_color();
            this.key8.BackColor = System.Drawing.Color.Green;
        }
    }
}
