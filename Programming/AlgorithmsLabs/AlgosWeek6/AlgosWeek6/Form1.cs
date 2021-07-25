using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgosWeek6
{
    public partial class Form1 : Form
    {
        Hashtable Books = new Hashtable();

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddSubmitButton_Click(object sender, EventArgs e)
        {
            Books.Add(AddIsbnTextBox.Text, new Book(AddIsbnTextBox.Text, AddTitleTextBox.Text));
            ConfirmationLabel.Text = AddTitleTextBox.Text + " sucessfully added to database";
        }

        private void SearchIsbnButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string isbn = SearchIsbnTextBox.Text;
            Book temp = new Book();
            if (Books.Contains(isbn))
            {
                foreach (DictionaryEntry entry in Books)
                {
                    if (entry.Key.ToString() == isbn)
                    {
                        temp = (Book)entry.Value;
                        listBox1.Items.Add("Title: " + temp.Title + " ISBN: " + temp.ISBN + " Onloan: " + temp.Onloan);
                    }

                }
            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("No matching records");
            }
        }

        private void SearchTitleButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string title = SearchTitleTextBox.Text;
            Book temp = new Book();
            Book temp2 = new Book();
            Boolean isThere = false;
            foreach (DictionaryEntry entry in Books)
            {
                temp2 = (Book)entry.Value;
                if (temp2.Title.Contains(title))
                {
                    temp = (Book)entry.Value;
                    listBox1.Items.Add("Title: " + temp.Title + " ISBN: " + temp.ISBN + " Onloan: " + temp.Onloan);
                    isThere = true;
                }

            }
            if (isThere == false)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("No matching records");
            }
            
        }

        private void RemoveSelectedButton_Click(object sender, EventArgs e)
        {
           
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Books.Remove(RemoveText.Text);
            ConfirmationLabel.Text = "Book removed from database";
        }

        private void LoanButton_Click(object sender, EventArgs e)
        {
            string isbn = StatusText.Text;
            Book temp = new Book();
            Boolean isThere = false;

            foreach (DictionaryEntry entry in Books)
            {
                if (entry.Key.ToString() == isbn)
                {
                    temp = (Book)entry.Value;
                    temp.Onloan = !temp.Onloan;
                    isThere = true;
                }
                
            }
            if (isThere == true)
            {
                Books.Remove(StatusText.Text);
                Books.Add(temp.ISBN, temp);
            }
            if (isThere == false)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("No matching records");
            }


        }
    }
}
