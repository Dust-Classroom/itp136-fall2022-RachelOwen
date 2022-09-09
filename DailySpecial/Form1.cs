namespace DailySpecial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        enum Day
        {
            SUNDAY = 1, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY
        }
        private void SpecialButton_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(dayBox.Text);
            string special;
            switch ((Day)day)
            {
                case Day.SUNDAY:
                    special = "fried chicken";
                    break;
                case Day.MONDAY:
                    special = "Sorry - closed";
                    break;
                case Day.TUESDAY:
                case Day.WEDNESDAY:
                case Day.THURSDAY:
                    special = "meat loaf";
                    break;
                case Day.FRIDAY:
                    special = "fish fry";
                    break;
                case Day.SATURDAY:
                    special = "liver and onions";
                    break;
                default:
                    special = "Invalid day";
                    break;
            }
            outputLabel.Text = "Today's special is " + special;
        }
    }
}