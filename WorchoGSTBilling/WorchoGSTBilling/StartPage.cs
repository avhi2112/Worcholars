using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GST.ProductManagement.UI;

namespace WorchoGSTBilling
{
    public partial class StartPage : Form
    {
        ContainerForm cf = new ContainerForm();
        ProductManagement prodMgmt = new ProductManagement();
        frmSalesInvoice saleInv = new frmSalesInvoice();
        public StartPage()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void userManagementButton_Click(object sender, EventArgs e)
        {

        }

        private void prodManagementButton_Click(object sender, EventArgs e)
        {
            if (cf.IsDisposed)
            {
                cf = new ContainerForm();
                cf.Show();
            }
            if (prodMgmt.IsDisposed)
            {
                prodMgmt = new ProductManagement();
                prodMgmt.MdiParent = cf;
                prodMgmt.Show();
            }
            if (!cf.Visible && !cf.IsDisposed)
            {
                cf.Show();
            }
            if (!prodMgmt.Visible && !prodMgmt.IsDisposed)
            {
                prodMgmt.MdiParent = cf;
                prodMgmt.Show();
            }
           
            
            //this.Visible = false;
        }

        private void billingButton_Click(object sender, EventArgs e)
        {
            if (cf.IsDisposed)
            {
                cf = new ContainerForm();
                cf.Show();
            }
            if (saleInv.IsDisposed)
            {
                saleInv = new frmSalesInvoice();
                saleInv.MdiParent = cf;
                saleInv.Show();
            }
            if (!cf.Visible && !cf.IsDisposed)
            {
                cf.Show();
            }
            if (!saleInv.Visible && !saleInv.IsDisposed)
            {
                saleInv.MdiParent = cf;
                saleInv.Show();
            }
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {

        }

        private void prodManagementButton_Enter(object sender, EventArgs e)
        {
            this.prodManagementButton_Click(sender,e);
        }

        private void billingButton_Enter(object sender, EventArgs e)
        {
            this.billingButton_Click(sender, e);
        }

        private void reportsButton_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Reports Management");
        }

        private void userManagementButton_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("User Management");
        }

        private void StartPage_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    MessageBox.Show("User Management");
                    break;
                case Keys.F2:
                    this.prodManagementButton_Click(sender, e);
                    break;
                case Keys.F3:
                    this.billingButton_Click(sender, e);
                    break;
                case Keys.F4:
                    MessageBox.Show("Reports Management");
                    break;
            }


        }

    }
}
