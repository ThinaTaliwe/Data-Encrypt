using System;
using Caesar_Cipher;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar_Cipher
{
    public partial class frmCC : Form
    {
        public frmCC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "Final Encrypted Message: " + new CaesarCipherEnc(txtMessage.Text, int.Parse(txtShift.Text)).encryptMessage(txtMessage.Text, int.Parse(txtShift.Text)).ToString() ;

        }

        private void frmCC_Load(object sender, EventArgs e)
        {

        }
    }
}
