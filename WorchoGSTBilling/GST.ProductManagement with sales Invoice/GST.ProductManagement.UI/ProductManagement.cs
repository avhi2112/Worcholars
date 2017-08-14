using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GST.ProductManagement.BL;
using GST.ProductManagement.DAL;

namespace GST.ProductManagement.UI
{
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            ProductBL prodbl = new ProductBL();
            //prodbl.fu();
            loadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                ProductBL prodbl = new ProductBL();
                ProductFull prodFull = new ProductFull();
                prodFull.description = txtDesc.Text.ToString();
                if (cbItmTyp.Text.Equals("Goods"))
                    prodFull.item_type = "G";
                else if (cbItmTyp.Text.Equals("Services"))
                    prodFull.item_type = "S";
                prodFull.hsn_number = txtHSN.Text;
                prodFull.item_unit = Convert.ToInt32(txtUnits.Text);
                prodFull.item_purchase_price = Convert.ToDecimal(txtPurPrice.Text);
                prodFull.item_sale_price = Convert.ToDecimal(txtSalePrice.Text);
                prodFull.discount = Convert.ToDecimal(txtDiscount.Text);
                prodFull.cgst_rate = Convert.ToDecimal(txtCGST.Text);
                prodFull.sgst_rate = Convert.ToDecimal(txtSGST.Text);
                prodFull.igst_rate = Convert.ToDecimal(txtIGST.Text);
                prodFull.company_id = 1;///TODO : Check how will this come
                prodFull.created_by = "USER";
                prodFull.created_date = DateTime.Now;
                prodFull.last_updated_by = "USER";
                prodFull.last_updated_date = DateTime.Now;

                int a = prodbl.insertProduct(prodFull);
                if (a == 1)
                {
                    MessageBox.Show("Product saved successfully.");
                    clearControls();
                }
            }
            loadData();
        }

        private void loadData()
        {
            ProductBL prodbl = new ProductBL();
            List<Product> products = new List<Product>();
            products = prodbl.getProducts();
            dataGridView1.DataSource = products;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Update
                MessageBox.Show("Update Product Id = " + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                //MessageBox.Show("Update Product Id = " + (e.RowIndex + 1).ToString());

            }
            else if (e.ColumnIndex == 1)
            {
                //Delete
                MessageBox.Show("Delete Product Id = " + (e.RowIndex + 1).ToString());
            }
        }

        private void clearControls()
        {
            txtDesc.Text = string.Empty;
            txtCGST.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtHSN.Text = string.Empty;
            txtIGST.Text = string.Empty;
            txtPurPrice.Text = string.Empty;
            txtSalePrice.Text = string.Empty;
            txtSGST.Text = string.Empty;
            txtUnits.Text = string.Empty;
            cbItmTyp.Text = string.Empty;
        }

        private bool ValidateControls()
        {
            bool result = true;

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSalesInvoice frm2 = new frmSalesInvoice();
            frm2.Show();
        }
    }
}
