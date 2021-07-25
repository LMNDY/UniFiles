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
    public partial class BookTypeSelectScreen : Form
    {
        public BookTypeSelectScreen()
        {
            InitializeComponent();
        }

        private void FantasyBookButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            FantasyBook fb = new FantasyBook();

            fb.Show();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

            Forms.MainScreen home = new Forms.MainScreen();

            home.Show();
            this.Hide();
        }
    }
}
