using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Calculator___Desktop
{
    public partial class frmTipCalculator : Form
    {
        public frmTipCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int cost = int.Parse(txtCost.Text);

            if (rdbtnGood.Checked == true)
            {
                int totalCost = cost + 5;
                lblTotalCost.Text = "Total cost is: " + totalCost;
            }
            else if (rdbtnVeryGood.Checked == true)
            {
                int totalCost = cost + 10;
                lblTotalCost.Text = "Total cost is: " + totalCost;
            }
            else if (rdbtnExcellent.Checked == true)
            {
                int totalCost = cost + 20;
                lblTotalCost.Text = "Total cost is: " + totalCost;
            }
        }
    }
}
