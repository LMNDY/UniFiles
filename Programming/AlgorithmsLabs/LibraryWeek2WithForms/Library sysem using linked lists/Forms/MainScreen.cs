using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_sysem_using_linked_lists.Forms
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void AddBooksButton_Click(object sender, EventArgs e)
        {
            

            BookTypeSelectScreen btss = new BookTypeSelectScreen();

            btss.Show();
            this.Hide();
        }

        private void CheckBooks_Click(object sender, EventArgs e)
        {
            BookSearch back = new BookSearch();

            back.Show();
            this.Hide();
        }
    }
}
