using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void about_Load(object sender, EventArgs e)
        {
            label4.Text = "The Window 10 Home Single Language Operating System And It's User\r\n" +
                "Interafce Protected By Tranding or Other Existing Intellectual Propertity\r\n" +
                " Right In The United State And Other Country/Region";
        }
    }
}
