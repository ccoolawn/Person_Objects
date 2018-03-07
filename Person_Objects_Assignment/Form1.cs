using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Person_Objects_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //List Object
        List<Person> people = new List<Person>();

        //Storage variable
        int year;
        int month;
        int day;
        int cell1;
        int cell2;

        Random rand = new Random();

        private void Display()
        {
            listBox1.Items.Clear();

            foreach (Person person in people)
            {
                //Person[] friends = person.Friends;
                listBox1.Items.Add(person.Firstname + " " +
                                   person.Lastname + " " +
                                   person.DateOfBirth.ToShortDateString());
            }
        }

        private void rtbDisplay()
        {
            //get index of the selected person
            int index = listBox1.SelectedIndex;
            Person p = people[index];

            //extract the emails & cell# from the List people
            //get the Friends Array property
            string[] Emails = p.EmailsList;
            string[] CellNums = p.CellNumsList;

            //clear richText Box
            richTextBox1.Clear();
            foreach (string email in Emails)
            {
                richTextBox1.AppendText(email + "\n");
            }

            foreach (string cellNum in CellNums)
            {
                string phNumFormat = String.Format("{0:(###) ###-####}\n",
                                        Convert.ToInt64(cellNum));
                richTextBox1.AppendText(phNumFormat);
            }

            richTextBox1.AppendText("Current Age: " + p.GetAge(p.DateOfBirth) + "\n");
            richTextBox1.AppendText("You have " + p.GetDaysUntilNextBirthday(p.DateOfBirth) 
                                    + " until your next birthday!");
        }

        //Random Generators
        public void RandomGen()
        {
            year = rand.Next(1970, 2017);
            month = rand.Next(1, 13);
            day = rand.Next(1, 29);
            cell1 = rand.Next(011111111, 0999999999);
            cell2 = rand.Next(0111111111, 0999999999);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * prepopulate the List<Person> with at least 7 
             * people and to each person add at least 2 emails 
             * and 2 cellphones
             */

            //Create People
            RandomGen();
            DateTime DOB1 = new DateTime(year, month, day);
            Person p1 = new Person("Wayne", "Johnson", DOB1);
            p1.AddCellPhone(cell1.ToString(), cell2.ToString());
            p1.AddEmail("wjohnson@job.com", "wjohnson@home.com");
            people.Add(p1);

            RandomGen();
            DateTime DOB2 = new DateTime(year, month, day);
            Person p2 = new Person("Kallie", "Robinson", DOB2);
            p2.AddCellPhone(cell1.ToString(), cell2.ToString());
            p2.AddEmail("krobinson@job.com", "krobinson@home.com");
            people.Add(p2);

            RandomGen();
            DateTime DOB3 = new DateTime(year, month, day);
            Person p3 = new Person("Thomas A.", "Anderson", DOB3);
            p3.AddCellPhone(cell1.ToString(), cell2.ToString());
            p3.AddEmail("tanderson@job.com", "neo@matrix.com");
            people.Add(p3);

            RandomGen();
            DateTime DOB4 = new DateTime(year, month, day);
            Person p4 = new Person("Steve", "Stifler", DOB4);
            p4.AddCellPhone(cell1.ToString(), cell2.ToString());
            p4.AddEmail("sstifler@job.com", "notmymom@ampie.com");
            people.Add(p4);

            RandomGen();
            DateTime DOB5 = new DateTime(year, month, day);
            Person p5 = new Person("Brick", "Tamland", DOB5);
            p5.AddCellPhone(cell1.ToString(), cell2.ToString());
            p5.AddEmail("btamland@ch4sandiego.com", "btamland@iq48.com");
            people.Add(p5);

            RandomGen();
            DateTime DOB6 = new DateTime(year, month, day);
            Person p6 = new Person("John", "Appleseed", DOB6);
            p6.AddCellPhone(cell1.ToString(), cell2.ToString());
            p6.AddEmail("jappleseed@theappletrees.com", "apples@seeds.com");
            people.Add(p6);

            RandomGen();
            DateTime DOB7 = new DateTime(year, month, day);
            Person p7 = new Person("Doc", "Holliday", DOB7);
            p7.AddCellPhone(cell1.ToString(), cell2.ToString());
            p7.AddEmail("dholliday@tombstone.com", "huckleberry@gunfighter.com");
            people.Add(p7);

            Display();// Display all of the people in the list
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                rtbDisplay();
            } 
        }

        private void btnAddNewEmail_Click(object sender, EventArgs e)
        {
            //get index of the selected person
            int index = listBox1.SelectedIndex;
            Person p = people[index];

            if (txBxEmail.Text != String.Empty)
            {
                p.UpdateEmail(txBxEmail.Text);
                rtbDisplay();
            }
            else
            {
                MessageBox.Show("Please enter a value in the field.");
            }
        }

        private void btnDeleteEmail_Click(object sender, EventArgs e)
        {
            //get index of the selected person
            int index = listBox1.SelectedIndex;
            Person p = people[index];

            if (txBxEmail.Text != String.Empty)
            {
                p.RemoveEmail(txBxEmail.Text);
                rtbDisplay();
            }
            else
            {
                MessageBox.Show("Please enter a value in the field.");
            }
        }

        private void btnAddCellNum_Click(object sender, EventArgs e)
        {
            //get index of the selected person
            int index = listBox1.SelectedIndex;
            Person p = people[index];

            if (txBxCellNum.Text != String.Empty)
            {
                p.updateCellNum(txBxCellNum.Text);
                rtbDisplay();
            }
            else
            {
                MessageBox.Show("Please enter a value in the field.");
            }
        }

        private void btnDeleteCellNum_Click(object sender, EventArgs e)
        {
            //get index of the selected person
            int index = listBox1.SelectedIndex;
            Person p = people[index];

            if (txBxCellNum.Text != String.Empty)
            {
                p.DeleteCellNum(txBxCellNum.Text);
                rtbDisplay();
            }
            else
            {
                MessageBox.Show("Please enter a value in the field.");
            }
        }
    }
}
