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
    public partial class ProfitLost : Form
    {
        public ProfitLost()
        {
            InitializeComponent();
        }

        public Panel ProfitLostPanel()
        {
            return panelProfitLost;
        }
        private void ProfitLost_Load(object sender, EventArgs e)
        {

        }
    }
}
