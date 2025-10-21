namespace UserCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string[] username=new string[120];
        public static string[] password = new string[120];
        public static string[] date= new string[120];
        public static int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                // MessageBox.Show("Please enter username and password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProvider1.SetError(textBox1, "Please enter username");
                errorProvider2.SetError(textBox2, "Please enter password");
            }
            else
            {
                notifyIcon1.BalloonTipTitle = "Information";
                notifyIcon1.BalloonTipText = "User Added Successfully";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.ShowBalloonTip(10000);

                errorProvider1.Clear();
                errorProvider2.Clear();
              
                String user_name = textBox1.Text;
                String pass_word = textBox2.Text;
                String date_now = DateTime.Now.ToString();

                username[i]=user_name;
                password[i] = pass_word;
                date[i] = date_now;
                i++;
                
                dataGridView1.Rows.Add(user_name, pass_word, date_now);
                
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
