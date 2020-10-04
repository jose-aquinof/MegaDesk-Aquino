using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Aquino
{
    public partial class MainMenu : Form
    {

        int width;
        int depth;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AddQuote f2 = new AddQuote();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DisplayQuote f3 = new DisplayQuote();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            SearchQuotes f4 = new SearchQuotes();
            f4.Show();
        }
    }
}
