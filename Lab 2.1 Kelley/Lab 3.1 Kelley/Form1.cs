/* Sean Kelley
 * CIS-161
 * 6 February 2022
 * Chapter 3 lab 1
 */

namespace Chapter_3_lab_1
{
    public partial class chapterThree : Form
    {
        public chapterThree()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void chapterThree_Load(object sender, EventArgs e)
        {

        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            string friend1;
            string friend2;
            friend1 = (friend1Textbox.Text);
            friend2 = (friend2Textbox.Text);
            result.Text = "The calculation " + friend1 + " > " + friend2 + " is " + friend1.CompareTo(friend2) + ".";
        }
    }
}