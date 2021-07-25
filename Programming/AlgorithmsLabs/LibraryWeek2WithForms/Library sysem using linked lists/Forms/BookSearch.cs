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
    public partial class BookSearch : Form
    {
        public BookSearch()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            
            MainScreen back = new MainScreen();

            back.Show();
            this.Hide();
        }
    }
}
