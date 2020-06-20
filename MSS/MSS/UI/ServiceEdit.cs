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
    public partial class ServiceEdit : Form
    {
        int cleared=0, remainType = 0;
        DO.Service service=new DO.Service();
        public ServiceEdit()
        {
            InitializeComponent();
        }
        public ServiceEdit(int id)
        {

        }
       
    }
}
