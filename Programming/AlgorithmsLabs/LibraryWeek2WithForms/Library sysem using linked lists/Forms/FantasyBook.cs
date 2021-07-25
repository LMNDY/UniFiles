using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_sysem_using_linked_lists
{
    public partial class FantasyBook : Form
    {

        LinkList fantasyBooks = new LinkList();

        public FantasyBook()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            

            BookTypeSelectScreen back = new BookTypeSelectScreen();

            back.Show();
            this.Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            fantasyBooks.AddItem(new Classes.BookTypes.Fantasy(TitleInput.Text, NameInput.Text));
            ConfLabel.Text = "Book added: " + TitleInput.Text + " by " + NameInput.Text;
            TitleInput.Text = " ";
            NameInput.Text = " ";
            
        }
    }
}
