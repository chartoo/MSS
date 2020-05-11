using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSS.UI
{
    public partial class ReceivablePayable : Form
    {
        public ReceivablePayable()
        {
            InitializeComponent();
        }
        public Panel ReceivablePayablePanel()
        {
            return panelReceivablePayable;
        }
        private void ReceivablePayable_Load(object sender, EventArgs e)
        {

        }
    }
}
