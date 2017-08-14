using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using GST.ProductManagement.BL;
using GST.ProductManagement.DAL;
using System.Reflection;

namespace GST.ProductManagement.UI
{
    public partial class frmSalesInvoice : Form
    {


        #region"Constants"
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        #endregion
        ProductBL prodbl;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #region " Variables"
        DataTable customerTable = new DataTable();
        DataTable dtProductTable = new DataTable();
        bool blnIsRequired = false;
        string strOldHSN = string.Empty;
        #endregion
        public frmSalesInvoice()
        {
            InitializeComponent();
            prodbl = new ProductBL();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void frmSalesInvoice_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            tbSalesInvoice.SelectedTab = tbCreateSalesInvoice;
            btnProceed.Visible = false;
            try
            {
                btnViewData.Visible = false;
                #region "Customer Details"
                //grvDataGrid.DataSource = prodbl.GetTaxInformationDetails().Clone();
                //grvDataGrid.Rows.Count = 10;
                customerTable = prodbl.GetCustomerDetails();
                foreach (DataRow row in customerTable.Rows)
                {
                    namesCollection.Add(Convert.ToString(row[1]));
                }
                txtCustomerName.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtCustomerName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtCustomerName.AutoCompleteCustomSource = namesCollection;
                #endregion
                #region"Product Details"

                dtProductTable = prodbl.GetProductDetails();
                foreach (DataRow row in dtProductTable.Rows)
                {
                    namesCollection.Add(Convert.ToString(row[1]));
                }
                txtItemName.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtItemName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtItemName.AutoCompleteCustomSource = namesCollection;
                #endregion
                this.grvDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                this.grvDataGrid.ColumnHeadersHeight = this.grvDataGrid.ColumnHeadersHeight * 2;
                this.grvDataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                //string[] TaxType = { "CGST", "SGST", "IGST" };
                //int i = 0;
                //int j = 7;
                //while (j < 13)
                //{
                //    Rectangle r1 = this.grvDataGrid.GetCellDisplayRectangle(j, -1, true);
                //    int w2 = this.grvDataGrid.GetCellDisplayRectangle(j + 1, -1, true).Width;
                //    r1.X += 1;
                //    r1.Y += 1;
                //    r1.Width = r1.Width + w2 - 2;
                //    r1.Height = r1.Height / 2 - 2;
                //    e.Graphics.FillRectangle(new SolidBrush(this.grvDataGrid.ColumnHeadersDefaultCellStyle.BackColor), r1);
                //    StringFormat format = new StringFormat();
                //    format.Alignment = StringAlignment.Center;
                //    format.LineAlignment = StringAlignment.Center;
                //    e.Graphics.DrawString(TaxType[i], this.grvDataGrid.ColumnHeadersDefaultCellStyle.Font,
                //        new SolidBrush(this.grvDataGrid.ColumnHeadersDefaultCellStyle.ForeColor), r1, format);
                //    j += 2;
                //    i += 1;

                //}
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string strPrice = string.Empty;
            string strDiscount = string.Empty;
            string strTaxableAmount = string.Empty;
            double dblCGSTAmount = 0.0;
            double dblSGSTAmount = 0.0;
            double dblIGSTAmount = 0.0;
            double dblCGSTPer = 0.0;
            double dblSGSTPer = 0.0;
            double dblIGSTPer = 0.0;
            double dblDiscount = 0.0;
            double dblTaxableAmount = 0.0;
            double dblSGSTTaxableAmount = 0.0;
            double dblIGSTTaxableAmount = 0.0;
            double dblTotalAmount = 0.0;
            try
            {
                for (int i = 0; i < (grvDataGrid.Rows.Count - 1); i++)
                {
                    #region "Taxable Amount Without Discount"
                    if (e.ColumnIndex == 4 && grvDataGrid.Rows[i].Cells["Price"].Value != null)
                    {
                        strPrice = grvDataGrid.Rows[i].Cells["Price"].Value.ToString();
                        if (strPrice != string.Empty)
                        {
                            if (grvDataGrid.Columns[e.ColumnIndex].Name == "Price")
                            {
                                double qty = Convert.ToDouble(grvDataGrid["Quantity", grvDataGrid.CurrentRow.Index].Value);
                                double rate = Convert.ToDouble(grvDataGrid["Price", grvDataGrid.CurrentRow.Index].Value);
                                double totVal = qty * rate;
                                grvDataGrid["TaxableAmount", grvDataGrid.CurrentRow.Index].Value = totVal.ToString("#,###.00");
                            }
                        }
                    }
                    #endregion
                    #region "Taxable Amount With Discount if Any"
                    if (e.ColumnIndex == 5)
                    {
                        strDiscount = grvDataGrid.Rows[i].Cells["Discount"].Value.ToString();
                        strTaxableAmount = grvDataGrid.Rows[i].Cells["TaxableAmount"].Value.ToString();
                        if (strTaxableAmount != string.Empty)
                        {
                            if (grvDataGrid.Columns[e.ColumnIndex].Name == "Discount")
                            {
                                double TaxableAmt = Convert.ToDouble(grvDataGrid["TaxableAmount", grvDataGrid.CurrentRow.Index].Value);
                                dblDiscount = Convert.ToDouble(grvDataGrid["Discount", grvDataGrid.CurrentRow.Index].Value);
                                double TotalTaxVal = TaxableAmt - dblDiscount;
                                grvDataGrid["TaxableAmount", grvDataGrid.CurrentRow.Index].Value = TotalTaxVal.ToString("#,###.00");
                            }
                        }
                        break;
                    }
                    #endregion
                    #region "CGST Amount"

                    //dataGridView1.Rows[e.RowIndex].Cells[7].Value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (e.ColumnIndex == 6 && grvDataGrid.Rows[i].Cells["TaxableAmount"].Value != null && grvDataGrid.Rows[i].Cells["TaxableAmount"].Value.ToString() != string.Empty)
                    {
                        if (grvDataGrid.Rows[0].Cells[7].Value.ToString() != null && grvDataGrid.Rows[0].Cells[7].Value.ToString() != string.Empty)
                        {
                            dblCGSTPer = Convert.ToDouble(grvDataGrid.Rows[0].Cells[7].Value.ToString());
                            dblTaxableAmount = Convert.ToDouble(grvDataGrid.Rows[i].Cells["TaxableAmount"].Value.ToString());
                            if (grvDataGrid.Columns[e.ColumnIndex].Name == "TaxableAmount")
                            {
                                dblCGSTAmount = (dblCGSTPer * dblTaxableAmount) / 100;
                                grvDataGrid["CGSTAmount", grvDataGrid.CurrentRow.Index].Value = dblCGSTAmount.ToString("#,###.00");
                            }
                        }

                    }
                    #endregion
                    #region "SGST Amount"

                    //dataGridView1.Rows[e.RowIndex].Cells[7].Value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (e.ColumnIndex == 6 && grvDataGrid.Rows[i].Cells["TaxableAmount"].Value != null && grvDataGrid.Rows[i].Cells["TaxableAmount"].Value.ToString() != string.Empty)
                    {
                        dblSGSTPer = Convert.ToDouble(grvDataGrid.Rows[0].Cells[9].Value.ToString());
                        dblSGSTTaxableAmount = Convert.ToDouble(grvDataGrid.Rows[i].Cells["TaxableAmount"].Value.ToString());
                        if (grvDataGrid.Columns[e.ColumnIndex].Name == "TaxableAmount")
                        {
                            dblSGSTAmount = (dblSGSTPer * dblSGSTTaxableAmount) / 100;
                            grvDataGrid["SGSTAmount", grvDataGrid.CurrentRow.Index].Value = dblSGSTAmount.ToString("#,###.00");
                        }

                    }
                    #endregion
                    #region "IGST Amount"

                    //dataGridView1.Rows[e.RowIndex].Cells[7].Value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (e.ColumnIndex == 6 && grvDataGrid.Rows[i].Cells["TaxableAmount"].Value != null && grvDataGrid.Rows[i].Cells["TaxableAmount"].Value.ToString() != string.Empty)
                    {
                        dblIGSTPer = Convert.ToDouble(grvDataGrid.Rows[0].Cells[11].Value.ToString());
                        dblIGSTTaxableAmount = Convert.ToDouble(grvDataGrid.Rows[i].Cells["TaxableAmount"].Value.ToString());
                        if (grvDataGrid.Columns[e.ColumnIndex].Name == "TaxableAmount")
                        {
                            dblIGSTAmount = (dblIGSTPer * dblIGSTTaxableAmount) / 100;
                            grvDataGrid["IGSTAmount", grvDataGrid.CurrentRow.Index].Value = dblIGSTAmount.ToString("#,###.00");
                        }

                    }
                    #endregion
                    #region "Total"

                    if (e.ColumnIndex == 6 && grvDataGrid.Rows[i].Cells["TaxableAmount"].Value != null && grvDataGrid.Rows[i].Cells["TaxableAmount"].Value.ToString() != string.Empty)
                    {
                        dblCGSTAmount = Convert.ToDouble(grvDataGrid.Rows[i].Cells["CGSTAmount"].Value.ToString());
                        dblSGSTAmount = Convert.ToDouble(grvDataGrid.Rows[i].Cells["SGSTAmount"].Value.ToString());
                        dblIGSTAmount = Convert.ToDouble(grvDataGrid.Rows[i].Cells["IGSTAmount"].Value.ToString());
                        if (grvDataGrid.Columns[e.ColumnIndex].Name == "TaxableAmount")
                        {
                            dblTotalAmount = Convert.ToDouble(grvDataGrid.Rows[i].Cells["TaxableAmount"].Value.ToString()) + dblCGSTAmount + dblSGSTAmount + dblIGSTAmount;
                            grvDataGrid["Total", grvDataGrid.CurrentRow.Index].Value = dblTotalAmount.ToString("#,###.00");
                        }

                    }
                    #endregion

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void txtCustomerName_Enter(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            string strCustomerGSTIN = string.Empty;
            try
            {
                if (txtCustomerName.TextLength >= 3)
                {
                    DataRow[] drCustomerId = customerTable.Select("name = " + "'" + txtCustomerName.Text + "'");
                    if (drCustomerId.Length > 0)
                    {
                        txtCustomerName.Tag = drCustomerId[0]["customer_id"].ToString();
                    }
                    if (txtCustomerName.Tag != null && txtCustomerName.Text != string.Empty)
                    {
                        DataRow[] drCustomerDetails = customerTable.Select("customer_id = " + txtCustomerName.Tag.ToString());
                        if (drCustomerDetails.Length > 0)
                        {
                            txtBillingAddress.Text = drCustomerDetails[0]["billing_address"].ToString();
                            txtShippingAddress.Text = drCustomerDetails[0]["shipping_address"].ToString();
                            txtGSTIN.Text = drCustomerDetails[0]["gstin"].ToString();
                            //to check whether IGST or SGST which is applicable?

                            strCustomerGSTIN = txtGSTIN.Text.Substring(0, 2);
                            string strCompanyGSTIN = "08";
                            if (strCompanyGSTIN == strCustomerGSTIN)
                            {
                                cboIGSTRate.Enabled = false;
                                //txtIGSTAmount.Enabled = false;
                                txtIGSTAmount.Text = string.Empty;
                                cboCGSTRate.Enabled = true;
                                txtSGSTAmount.Enabled = true;
                            }
                            else if (strCompanyGSTIN != strCustomerGSTIN)
                            {
                                cboCGSTRate.Enabled = false;
                                //txtSGSTAmount.Enabled = false;
                                txtSGSTAmount.Text = string.Empty;
                                cboIGSTRate.Enabled = true;
                                txtIGSTAmount.Enabled = true;
                            }

                            cboPlaceofSupply.Text = drCustomerDetails[0]["state"].ToString();
                        }
                    }
                }
                else
                {
                    txtBillingAddress.Text = "";
                    txtShippingAddress.Text = "";
                    txtGSTIN.Text = "";
                    cboPlaceofSupply.Text = "Select";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                txtBillingAddress.Enabled = true;
                lnkSave.Visible = true;
                lkEdit.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void chkSame_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkSame.Checked)
                {
                    txtShippingAddress.Text = txtBillingAddress.Text;
                }
                else
                {
                    txtShippingAddress.Text = string.Empty;
                    txtShippingAddress.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lnkSave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strShippingAddress = string.Empty;
            try
            {
                if (lnkSave.Text == "Save")
                {
                    //string strQuery = "UPDATE worc_customer SET billing_address = '" + txtBillingAddress.Text + "' WHERE customer_id = " + txtCustomerName.Tag.ToString() + ";";
                    //dbconnect.Update(strQuery);
                    if (chkSame.Checked)
                    {
                        strShippingAddress = txtBillingAddress.Text;
                    }
                    else
                    {
                        strShippingAddress = txtShippingAddress.Text;
                    }
                    prodbl.UpdateAdress(txtBillingAddress.Text, strShippingAddress, txtCustomerName.Tag.ToString());
                    MessageBox.Show("Address Updated Successfully");
                    txtBillingAddress.Enabled = false;
                    lnkSave.Visible = false;
                    lkEdit.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void PaintDataGrid(object sender, PaintEventArgs e)
        {
            string[] TaxType = { "CGST", "SGST", "IGST" };
            int i = 0;
            int j = 7;
            while (j < 13)
            {
                Rectangle r1 = this.grvDataGrid.GetCellDisplayRectangle(j, -1, true);
                int w2 = this.grvDataGrid.GetCellDisplayRectangle(j + 1, -1, true).Width;
                r1.X += 1;
                r1.Y += 1;
                r1.Width = r1.Width + w2 - 2;
                r1.Height = r1.Height / 2 - 2;
                e.Graphics.FillRectangle(new SolidBrush(this.grvDataGrid.ColumnHeadersDefaultCellStyle.BackColor), r1);
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(TaxType[i], this.grvDataGrid.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(this.grvDataGrid.ColumnHeadersDefaultCellStyle.ForeColor), r1, format);
                j += 2;
                i += 1;
            }
        }
        private void ViewData()
        {
            decimal decTotalTaxableAmountBeforeGST = 0;
            decimal decTotalCGSTAmount = 0;
            decimal decTotalSGSTAmount = 0;
            decimal decTotalIGSTAmount = 0;
            decimal decTotalTaxAmount = 0;
            decimal decTotalTaxAmountIncludingGST = 0;
            decimal decTotalReverseCharge = 0;
            TaxInformationDetails AllTaxInformation = new TaxInformationDetails();
            DataTable dtTaxInformation = null;
            string strInvoiceNumber = string.Empty;
            int iCustomerId = 0;
            bool blnReverseChargeSuccessful = true;
            try
            {
                dtTaxInformation = prodbl.GetTaxInformationDetails();
                DataRow[] dr = dtTaxInformation.Select("Invoice_number = '" + txtInvoiceNumber.Text + "'");
                if (dr.Length > 0)
                {

                    grvDataGrid.DataSource = dr.CopyToDataTable();
                    if (grvDataGrid.Rows.Count > 0)
                        btnProceed.Visible = true;
                    strInvoiceNumber = dr[0]["Invoice_number"].ToString();
                    iCustomerId = Convert.ToInt32(dr[0]["customer_id"].ToString());
                    DataRow[] drCustomerDetails = customerTable.Select("customer_id = " + iCustomerId);
                    if (drCustomerDetails.Length > 0)
                    {
                        txtBillingAddress.Text = drCustomerDetails[0]["billing_address"].ToString();
                        txtShippingAddress.Text = drCustomerDetails[0]["shipping_address"].ToString();
                        txtGSTIN.Text = drCustomerDetails[0]["gstin"].ToString();
                        txtCustomerName.Text = drCustomerDetails[0]["name"].ToString();
                        cboPlaceofSupply.Text = drCustomerDetails[0]["state"].ToString();
                        //txtCustomerName.Enabled = false;
                    }
                }
                grvDataGrid.Columns["Invoice_number"].Visible = false;
                grvDataGrid.Columns["product_id"].Visible = false;
                grvDataGrid.Columns["customer_id"].Visible = false;
                foreach (DataGridViewRow row in grvDataGrid.Rows)
                {
                    if (!row.IsNewRow && row.Cells["total_taxable_amount"].Value != null)
                    {
                        decTotalTaxableAmountBeforeGST += (decimal)row.Cells["total_taxable_amount"].Value;
                    }
                    if (!row.IsNewRow && row.Cells["cgst_amount"].Value != null)
                    {
                        decTotalCGSTAmount += (decimal)row.Cells["cgst_amount"].Value;
                    }
                    if (!row.IsNewRow && row.Cells["sgst_amount"].Value != null)
                    {
                        decTotalSGSTAmount += (decimal)row.Cells["sgst_amount"].Value;
                    }
                    if (!row.IsNewRow && row.Cells["igst_amount"].Value != null)
                    {
                        decTotalIGSTAmount += (decimal)row.Cells["igst_amount"].Value;
                    }
                    if (!row.IsNewRow && row.Cells["total_taxable_amount_including_GST"].Value != null)
                    {
                        decTotalTaxAmountIncludingGST += (decimal)row.Cells["total_taxable_amount_including_GST"].Value;
                    }
                }
                lblTotalAmountBeforeTaxValue.Text = decTotalTaxableAmountBeforeGST.ToString();
                lblTotalCGSTAmountValue.Text = decTotalCGSTAmount.ToString();
                lblTotalSGSTAmountValue.Text = decTotalSGSTAmount.ToString();
                lblTotalIGSTAmountValue.Text = decTotalIGSTAmount.ToString();
                lblTotalAmountIncludingTaxValue.Text = decTotalTaxAmountIncludingGST.ToString();
                decTotalTaxAmount = decTotalCGSTAmount + decTotalIGSTAmount + decTotalSGSTAmount;
                lblTotalTaxAmountValue.Text = decTotalTaxAmount.ToString();
                //logic of Reverse Charge--Rahul on 06/08/2107
                if (chkReverseCharge.Checked == true)
                {
                    decTotalReverseCharge = decTotalTaxAmount;
                    lblTotalReverseChargeValue.Text = Convert.ToString(decTotalCGSTAmount + decTotalIGSTAmount + decTotalSGSTAmount);
                    lblTotalAmountIncludingTaxValue.Text = Convert.ToString(decTotalTaxAmountIncludingGST - decTotalTaxAmount);
                    AllTaxInformation.flag_reverse_Charge = 'Y';
                    blnReverseChargeSuccessful = prodbl.UpdateReverseChargeInformation(AllTaxInformation.flag_reverse_Charge, decTotalReverseCharge, strInvoiceNumber);
                    if (blnReverseChargeSuccessful == true)
                    {
                        MessageBox.Show("Reverse Charge applied successfully to this Invoice");
                        clearControls();
                    }
                    else if (blnReverseChargeSuccessful == false)
                    {
                        MessageBox.Show("Reverse Charge not applied successfully.Please Check again");
                    }
                }
                else if (chkReverseCharge.Checked == false && blnIsRequired == true)
                {
                    AllTaxInformation.flag_reverse_Charge = 'N';
                    decTotalReverseCharge = 0;
                    blnReverseChargeSuccessful = prodbl.UpdateReverseChargeInformation(AllTaxInformation.flag_reverse_Charge, decTotalReverseCharge, strInvoiceNumber);
                    if (blnReverseChargeSuccessful == true)
                    {
                        MessageBox.Show("Reverse Charge reverted successfully to this Invoice");
                        clearControls();
                    }
                    else if (blnReverseChargeSuccessful == false)
                    {
                        MessageBox.Show("Reverse Charge not reverted successfully.Please Check again");
                    }
                    lblTotalReverseChargeValue.Text = "NA";
                    lblTotalAmountIncludingTaxValue.Text = decTotalTaxAmountIncludingGST.ToString();
                }
                grvDataGrid.Columns["description"].HeaderText = "Item Description";
                grvDataGrid.Columns["item_type"].HeaderText = "Item Type";
                grvDataGrid.Columns["hsn_code"].HeaderText = "HSN Code";
                grvDataGrid.Columns["item_quantity"].HeaderText = "Item Quantity";
                grvDataGrid.Columns["item_price"].HeaderText = "Item Price";
                grvDataGrid.Columns["item_discount"].HeaderText = "Item Discount";
                grvDataGrid.Columns["total_taxable_amount"].HeaderText = "Total Taxable Amount";
                grvDataGrid.Columns["cgst_rate"].HeaderText = "CGST (%)";
                grvDataGrid.Columns["cgst_amount"].HeaderText = "CGST Amount";
                grvDataGrid.Columns["sgst_rate"].HeaderText = "SGST (%)";
                grvDataGrid.Columns["sgst_amount"].HeaderText = "SGST Amount";
                grvDataGrid.Columns["igst_rate"].HeaderText = "IGST (%)";
                grvDataGrid.Columns["igst_amount"].HeaderText = "IGST Amount";
                grvDataGrid.Columns["total_taxable_amount_including_GST"].HeaderText = "Total Amount Including GST";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtItemName.TextLength >= 5)

                {
                    DataRow[] drProductId = dtProductTable.Select("description = " + "'" + txtItemName.Text + "'");
                    if (drProductId.Length > 0)
                    {
                        txtItemName.Tag = drProductId[0]["product_id"].ToString();
                    }
                    if (txtItemName.Tag != null && txtItemName.Text != string.Empty)
                    {
                        DataRow[] drProductDetails = dtProductTable.Select("product_id = " + txtItemName.Tag.ToString());
                        if (drProductDetails.Length > 0)
                        {
                            cboItemType.Text = drProductDetails[0]["item_type"].ToString();
                            txtHSNCode.Text = drProductDetails[0]["hsn_number"].ToString();
                            txtPrice.Text = drProductDetails[0]["item_sale_price"].ToString();
                            txtDiscount.Text = drProductDetails[0]["discount"].ToString();
                            cboCGSTRate.Text = drProductDetails[0]["cgst_rate"].ToString();
                            cboSGSTRate.Text = drProductDetails[0]["sgst_rate"].ToString();
                            cboIGSTRate.Text = drProductDetails[0]["igst_rate"].ToString();
                            cboItemType.Enabled = false;
                            txtHSNCode.Enabled = false;
                            cboCGSTRate.Enabled = false;
                            cboIGSTRate.Enabled = false;
                            cboSGSTRate.Enabled = false;
                        }
                    }
                }
                else
                {
                    txtHSNCode.Text = "";
                    txtPrice.Text = "";
                    txtDiscount.Text = "";
                    txtQuantity.Text = "";
                    txtTotalAmount.Text = "";
                    txtTaxableAmount.Text = "";
                    cboItemType.Text = "Select";
                    cboSGSTRate.Text = "Select";
                    cboIGSTRate.Text = "Select";
                    cboCGSTRate.Text = "Select";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void clearControls()
        {
            try
            {
                //txtCustomerName.Text = string.Empty;
                txtDiscount.Text = string.Empty;
                //txtGSTIN.Text = string.Empty;
                txtHSNCode.Text = string.Empty;
                txtIGSTAmount.Text = string.Empty;
                txtItemName.Text = string.Empty;
                txtPrice.Text = string.Empty;
                txtQuantity.Text = string.Empty;
                txtReference.Text = string.Empty;
                txtSGSTAmount.Text = string.Empty;
                txtTaxableAmount.Text = string.Empty;
                txtTotalAmount.Text = string.Empty;
                txtCGSTAmount.Text = string.Empty;
                txtIGSTAmount.Text = string.Empty;
                cboCGSTRate.Text = "Select";
                cboIGSTRate.Text = "Select";
                cboSGSTRate.Text = "Select";
                //cboPlaceofSupply.Text = "Select";
                cboItemType.Text = "Select";
                cboSGSTRate.Enabled = true;
                cboIGSTRate.Enabled = true;
                cboCGSTRate.Enabled = true;
                txtHSNCode.Enabled = true;
                txtCustomerName.Enabled = true;
                //cboItemType.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        class Validation
        {
            public static bool hasValidationErrors(System.Windows.Forms.Control.ControlCollection controls)
            {
                bool hasError = false;

                // Now we need to loop through the controls and deterime if any of them have errors
                foreach (Control control in controls)
                {
                    // check the control and see what it returns
                    bool validControl = IsValid(control);
                    // If it's not valid then set the flag and keep going.  We want to get through all
                    // the validators so they will display on the screen if errorProviders were used.
                    if (!validControl)
                        hasError = true;

                    // If its a container control then it may have children that need to be checked
                    if (control.HasChildren)
                    {
                        if (hasValidationErrors(control.Controls))
                            hasError = true;
                    }
                }
                return hasError;
            }

            // Here, let's determine if the control has a validating method attached to it
            // and if it does, let's execute it and return the result
            private static bool IsValid(object eventSource)
            {
                string name = "EventValidating";

                Type targetType = eventSource.GetType();

                do
                {
                    FieldInfo[] fields = targetType.GetFields(
                         BindingFlags.Static |
                         BindingFlags.Instance |
                         BindingFlags.NonPublic);

                    foreach (FieldInfo field in fields)
                    {
                        if (field.Name == name)
                        {
                            EventHandlerList eventHandlers = ((EventHandlerList)(eventSource.GetType().GetProperty("Events",
                                (BindingFlags.FlattenHierarchy |
                                (BindingFlags.NonPublic | BindingFlags.Instance))).GetValue(eventSource, null)));

                            Delegate d = eventHandlers[field.GetValue(eventSource)];

                            if ((!(d == null)))
                            {
                                Delegate[] subscribers = d.GetInvocationList();

                                // ok we found the validation event,  let's get the event method and call it
                                foreach (Delegate d1 in subscribers)
                                {
                                    // create the parameters
                                    object sender = eventSource;
                                    CancelEventArgs eventArgs = new CancelEventArgs();
                                    eventArgs.Cancel = false;
                                    object[] parameters = new object[2];
                                    parameters[0] = sender;
                                    parameters[1] = eventArgs;
                                    // call the method
                                    d1.DynamicInvoke(parameters);
                                    // if the validation failed we need to return that failure
                                    if (eventArgs.Cancel)
                                        return false;
                                    else
                                        return true;
                                }
                            }
                        }
                    }

                    targetType = targetType.BaseType;

                } while (targetType != null);

                return true;
            }
        }
        private bool ValidateControls()
        {
            bool result = true;

            return result;
        }
        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {

            try
            {
                bool bValidName = ValidateQuantity();
                if (bValidName)
                {
                    TaxInformationDetails AllTaxInformation = new TaxInformationDetails();
                    AllTaxInformation.Invoice_iD = "GM201701";//companyname+year+companyid
                    AllTaxInformation.invoice_number = txtInvoiceNumber.Text;
                    AllTaxInformation.invoice_date = Convert.ToDateTime(dtInvoiceDate.Text);
                    AllTaxInformation.invoice_due_terms = txtReference.Text;
                    AllTaxInformation.invoice_due_date = Convert.ToDateTime(dtInvoiceDueDate.Text);
                    AllTaxInformation.customer_id = Convert.ToInt32(txtCustomerName.Tag);
                    AllTaxInformation.product_id = Convert.ToInt32(txtItemName.Tag);
                    AllTaxInformation.hsn_code = txtHSNCode.Text;
                    AllTaxInformation.item_quantity = Convert.ToInt32(txtQuantity.Text);
                    AllTaxInformation.item_price = Convert.ToDecimal(txtPrice.Text);
                    AllTaxInformation.item_discount = Convert.ToDecimal(txtDiscount.Text);
                    AllTaxInformation.total_amount_before_discount = (AllTaxInformation.item_price * AllTaxInformation.item_quantity);
                    AllTaxInformation.total_taxable_amount = Convert.ToDecimal(txtTaxableAmount.Text);
                    AllTaxInformation.cgst_rate = Convert.ToDecimal(cboCGSTRate.Text);
                    AllTaxInformation.cgst_amount = Convert.ToDecimal(txtCGSTAmount.Text);
                    AllTaxInformation.sgst_rate = Convert.ToDecimal(cboSGSTRate.Text);
                    if (txtSGSTAmount.Text != string.Empty)
                        AllTaxInformation.sgst_amount = Convert.ToDecimal(txtSGSTAmount.Text);
                    AllTaxInformation.igst_rate = Convert.ToDecimal(cboIGSTRate.Text);
                    if (txtIGSTAmount.Text != string.Empty)
                        AllTaxInformation.igst_amount = Convert.ToDecimal(txtIGSTAmount.Text);
                    if (cboItemType.Text.Equals("G"))
                        AllTaxInformation.supply_type = 'G';
                    else if (cboItemType.Text.Equals("S"))
                        AllTaxInformation.supply_type = 'S';
                    AllTaxInformation.total_taxable_amount_includig_GST = Convert.ToDecimal(txtTotalAmount.Text);
                    AllTaxInformation.flag_reverse_Charge = 'N';
                    AllTaxInformation.reverse_charge_rate = Convert.ToDecimal("0");
                    AllTaxInformation.invoice_category = 'S'; //For sales


                    AllTaxInformation.last_updated_by = "USER";
                    AllTaxInformation.last_updated_date = DateTime.Now;
                    AllTaxInformation.company_id = 1;//taken from Global parameter
                    if (btnSaveInvoice.Text.Equals("Save Invoice"))
                    {
                        AllTaxInformation.created_by = "USER";
                        AllTaxInformation.created_date = DateTime.Now;
                        int a = prodbl.insertTaxInformation(AllTaxInformation);
                        if (a == 1)
                        {
                            txtInvoiceNumber.Enabled = false;
                            MessageBox.Show("One Product saved successfully to this Invoice");
                            clearControls();
                        }
                    }
                    else if (btnSaveInvoice.Text.Equals("Update"))
                    {
                        AllTaxInformation.product_id = Convert.ToInt32(txtItemName.Tag);
                        AllTaxInformation.item_quantity = Convert.ToInt32(txtQuantity.Text);
                        AllTaxInformation.item_discount = Convert.ToDecimal(txtDiscount.Text);
                        AllTaxInformation.total_amount_before_discount = (AllTaxInformation.item_price * AllTaxInformation.item_quantity);
                        AllTaxInformation.total_taxable_amount = Convert.ToDecimal(txtTaxableAmount.Text);
                        AllTaxInformation.cgst_rate = Convert.ToDecimal(cboCGSTRate.Text);
                        AllTaxInformation.cgst_amount = Convert.ToDecimal(txtCGSTAmount.Text);
                        AllTaxInformation.sgst_rate = Convert.ToDecimal(cboSGSTRate.Text);
                        if (txtSGSTAmount.Text != string.Empty)
                            AllTaxInformation.sgst_amount = Convert.ToDecimal(txtSGSTAmount.Text);
                        AllTaxInformation.igst_rate = Convert.ToDecimal(cboIGSTRate.Text);
                        if (txtIGSTAmount.Text != string.Empty)
                            AllTaxInformation.igst_amount = Convert.ToDecimal(txtIGSTAmount.Text);
                        if (cboItemType.Text.Equals("G"))
                            AllTaxInformation.supply_type = 'G';
                        else if (cboItemType.Text.Equals("S"))
                            AllTaxInformation.supply_type = 'S';
                        AllTaxInformation.total_taxable_amount_includig_GST = Convert.ToDecimal(txtTotalAmount.Text);
                        AllTaxInformation.flag_reverse_Charge = 'N';
                        AllTaxInformation.reverse_charge_rate = Convert.ToDecimal("0");
                        AllTaxInformation.invoice_category = 'S'; //For sales


                        AllTaxInformation.last_updated_by = "USER";
                        AllTaxInformation.last_updated_date = DateTime.Now;
                        AllTaxInformation.company_id = 1;//taken from Global parameter
                        string strHSNCode = strOldHSN;
                        int iOldProductId = Convert.ToInt32(cboItemType.Tag);
                        int a = prodbl.UpdateProductInformation(AllTaxInformation, strHSNCode);
                        if (a == 1)
                        {
                            MessageBox.Show("One Product updated successfully to this Invoice");
                            clearControls();
                            AllTaxInformation.cgst_amount = 0;
                            AllTaxInformation.cgst_rate = 0;
                            AllTaxInformation.igst_amount = 0;
                            AllTaxInformation.igst_rate = 0;
                            AllTaxInformation.sgst_amount = 0;
                            AllTaxInformation.sgst_rate = 0;
                            AllTaxInformation.item_discount = 0;
                            AllTaxInformation.item_price = 0;
                            AllTaxInformation.item_quantity = 0;
                            AllTaxInformation.reverse_charge_rate = 0;
                            AllTaxInformation.flag_reverse_Charge = 'N';
                            AllTaxInformation.supply_type = 'G';
                            AllTaxInformation.total_amount_before_discount = 0;
                            AllTaxInformation.total_taxable_amount = 0;
                            AllTaxInformation.total_taxable_amount_includig_GST = 0;
                            AllTaxInformation.invoice_due_terms = "";
                            AllTaxInformation.invoice_date = Convert.ToDateTime(DateTime.Now);
                            AllTaxInformation.invoice_due_date = Convert.ToDateTime(DateTime.Now);
                            AllTaxInformation.customer_id = 0;
                            AllTaxInformation.product_id = 0;
                            btnSaveInvoice.Text = "Save Invoice";
                        }
                    }
                }
                ViewData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Calculation();
                if (txtQuantity.Text == string.Empty || txtPrice.Text == string.Empty)
                {
                    txtTaxableAmount.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Calculation()
        {
            int iTaxableAmount = 0;
            int iCGSTAmount = 0;
            int iSGSTAmount = 0;
            int iIGSTAmount = 0;
            try
            {
                if (txtPrice.Text != string.Empty && txtQuantity.Text != string.Empty)
                {
                    iTaxableAmount = Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(txtPrice.Text);
                    txtTaxableAmount.Text = iTaxableAmount.ToString();
                    if (txtDiscount.Text != string.Empty)
                    {
                        iTaxableAmount = iTaxableAmount - Convert.ToInt32(txtDiscount.Text);
                        txtTaxableAmount.Text = iTaxableAmount.ToString();
                    }
                    if (cboCGSTRate.Text != string.Empty)
                    {
                        iCGSTAmount = (iTaxableAmount * Convert.ToInt32(cboCGSTRate.Text)) / 100;
                        txtCGSTAmount.Text = iCGSTAmount.ToString();
                    }
                    if (cboSGSTRate.Text != string.Empty && txtSGSTAmount.Enabled == true)
                    {
                        iSGSTAmount = (iTaxableAmount * Convert.ToInt32(cboSGSTRate.Text)) / 100;
                        txtSGSTAmount.Text = iSGSTAmount.ToString();
                    }
                    if (cboIGSTRate.Text != string.Empty && txtIGSTAmount.Enabled == true)
                    {
                        iIGSTAmount = (iTaxableAmount * Convert.ToInt32(cboIGSTRate.Text)) / 100;
                        txtIGSTAmount.Text = iIGSTAmount.ToString();
                    }
                    if (txtTaxableAmount.Text != string.Empty && txtSGSTAmount.Enabled == true)
                    {
                        txtTotalAmount.Text = (iTaxableAmount + iCGSTAmount + iSGSTAmount).ToString();
                    }
                    if (txtTaxableAmount.Text != string.Empty && txtIGSTAmount.Enabled == true)
                    {
                        txtTotalAmount.Text = (iTaxableAmount + iCGSTAmount + iIGSTAmount).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Calculation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            try
            {
                bool bValidName = ValidateInvoiceNumber();
                if (bValidName)
                    ViewData();
                else
                    MessageBox.Show("Please enter valid Invoice Number");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void chkReverseCharge_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkReverseCharge.Checked == false)
                {
                    blnIsRequired = true;
                }
                ViewData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtQuantity_Validated(object sender, EventArgs e)
        {
            try
            {
                this.errorProvider1.SetError(txtQuantity, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                ValidateQuantity();
                //if (string.IsNullOrWhiteSpace(txtQuantity.Text))
                //{
                //    // Cancel the event and select the text to be corrected by the user.
                //    e.Cancel = true;
                //    txtQuantity.Select(0, txtQuantity.Text.Length);
                //    // Set the ErrorProvider error with the text to display. 
                //    this.errorProvider1.SetError(txtQuantity, "Enter the Valid Quantity");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtInvoiceNumber_Validated(object sender, EventArgs e)
        {
            try
            {
                this.errorProvider1.SetError(txtInvoiceNumber, "Enter the Valid Invoice Number");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool ValidateInvoiceNumber()
        {
            bool bStatus = true;
            bool IsSameInvoiceNumber = false;
            DataTable dtAllInvoiceNumber = null;
            if (txtInvoiceNumber.Text != string.Empty)
            {
                dtAllInvoiceNumber = prodbl.GetAllInvoiceRecords();
                for (int i = 0; i < dtAllInvoiceNumber.Rows.Count; i++)
                {
                    string strInvoiceNumber = dtAllInvoiceNumber.Rows[i]["Invoice_number"].ToString();
                    if (strInvoiceNumber == txtInvoiceNumber.Text)
                    {
                        IsSameInvoiceNumber = true;
                    }
                }
                if (IsSameInvoiceNumber == false)
                {
                    errorProvider1.SetError(txtInvoiceNumber, "Enter the Invalid Invoice Number");
                    txtInvoiceNumber.Focus();
                    bStatus = false;
                }
            }
            else
                errorProvider1.SetError(txtInvoiceNumber, "");
            return bStatus;
        }
        private bool ValidateQuantity()
        {
            bool bStatus = true;

            if (txtInvoiceNumber.Text == string.Empty)
            {
                errorProvider1.SetError(txtQuantity, "Enter the Quantity");
                txtQuantity.Focus();
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtQuantity, "");
            return bStatus;
        }

        private void txtInvoiceNumber_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                ValidateInvoiceNumber();
                //TextBox tb = sender as TextBox;
                //if (tb != null)
                //{
                //    if (tb.Text == String.Empty)
                //    {
                //        errorProvider1.SetError(tb, "Enter the Valid Invoice Number");
                //        e.Cancel = true;
                //    }
                //    else
                //        errorProvider1.SetError(tb, "");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddNewSaleInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void grvDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string strInvoiceNumber = Convert.ToString(grvDataGrid.Rows[e.RowIndex].Cells["Invoice_number"].Value);

                if (e.ColumnIndex == 0)
                {
                    txtCustomerName.Enabled = true;
                    txtItemName.Text = grvDataGrid.Rows[e.RowIndex].Cells["description"].Value.ToString();
                    strOldHSN = grvDataGrid.Rows[e.RowIndex].Cells["hsn_code"].Value.ToString();
                    txtHSNCode.Text = grvDataGrid.Rows[e.RowIndex].Cells["hsn_code"].Value.ToString();
                    txtQuantity.Text = grvDataGrid.Rows[e.RowIndex].Cells["item_quantity"].Value.ToString();
                    txtDiscount.Text = Convert.ToString(Convert.ToInt32(grvDataGrid.Rows[e.RowIndex].Cells["item_discount"].Value));
                    btnSaveInvoice.Text = "Update";
                }
                else if (e.ColumnIndex == 1)
                {
                    //Delete
                    int productID = Convert.ToInt32(grvDataGrid.Rows[e.RowIndex].Cells["product_id"].Value);
                    DialogResult result = MessageBox.Show("Do you want to delete the product having product ID = " + productID, "Confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        ProductBL prodbl = new ProductBL();
                        int a = prodbl.deleteProductInformation(productID, strInvoiceNumber);
                        if (a == 1)
                        {
                            MessageBox.Show("Record deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong.");
                        }
                    }
                    ViewData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            DataTable dtAllInvoiceNumberFromTotal = null;
            bool IsOnlyProceed = false;
            try
            {

                if (txtInvoiceNumber.Text != string.Empty)
                {
                    dtAllInvoiceNumberFromTotal = prodbl.GetAllInvoiceRecordsFromTotal();
                    for (int i = 0; i < dtAllInvoiceNumberFromTotal.Rows.Count; i++)
                    {
                        string strInvoiceNumber = dtAllInvoiceNumberFromTotal.Rows[i]["Invoice_number"].ToString();
                        if (strInvoiceNumber == txtInvoiceNumber.Text)
                        {
                            IsOnlyProceed = true;
                            btnProceed.Text = "Proceed";
                            MessageBox.Show("This Sales Invoice is already saved.Kindly Add new Invoice");
                            clearControls();
                            tbSalesInvoice.SelectedTab = tbPreviewSalesInvoice;
                        }
                        else if (strInvoiceNumber != txtInvoiceNumber.Text)
                        {
                            IsOnlyProceed = false;
                        }
                    }
                    if (IsOnlyProceed == false)
                    {
                        TotalTaxInformation TotalTaxInformation = new TotalTaxInformation();
                        TotalTaxInformation.Invoice_Id = "GM201701";//companyname+year+companyid
                        TotalTaxInformation.Invoice_number = txtInvoiceNumber.Text;
                        TotalTaxInformation.customer_id = Convert.ToInt32(txtCustomerName.Tag);
                        TotalTaxInformation.Invoice_created_date = Convert.ToDateTime(dtInvoiceDate.Text);
                        TotalTaxInformation.Total_amount_including_GST = Convert.ToDecimal(lblTotalAmountIncludingTaxValue.Text);
                        if (chkReverseCharge.Checked == false)
                            TotalTaxInformation.Flag_reverse_charge = 'N';
                        else if (chkReverseCharge.Checked == true)
                            TotalTaxInformation.Flag_reverse_charge = 'Y';
                        if (lblTotalReverseChargeValue.Text == string.Empty || lblTotalReverseChargeValue.Text == "NA")
                            TotalTaxInformation.Total_reverse_charge = 0;
                        else
                            TotalTaxInformation.Total_reverse_charge = Convert.ToDecimal(lblTotalReverseChargeValue.Text);
                        TotalTaxInformation.last_updated_by = "USER";
                        TotalTaxInformation.last_updated_date = DateTime.Now;
                        TotalTaxInformation.company_id = 1;//taken from Global parameter
                        TotalTaxInformation.created_by = "USER";
                        TotalTaxInformation.created_date = DateTime.Now;
                        DialogResult result = MessageBox.Show("Do you want to confirm the Sales Invoice having Invoice Number = " + TotalTaxInformation.Invoice_number, "Confirm", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            int a = prodbl.insertTotalTaxInformation(TotalTaxInformation);
                            if (a == 1)
                            {
                                txtInvoiceNumber.Enabled = false;
                                MessageBox.Show("Sales Invoice Saved Successfully");
                                clearControls();
                                tbSalesInvoice.SelectedTab = tbPreviewSalesInvoice;
                            }
                        }
                    }
                }
                else
                {
                    ValidateInvoiceNumber();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                // only allow one decimal point
                if (e.KeyChar == '.'
                    && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                // only allow one decimal point
                if (e.KeyChar == '.'
                    && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtInvoiceNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtInvoiceNumber.Text != string.Empty)
                {
                    btnViewData.Visible = true;
                }
                else if (txtInvoiceNumber.Text == string.Empty)
                {
                    btnViewData.Visible = false;
                    grvDataGrid.DataSource = null;
                    clearControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddNewSaleInvoice_Click_1(object sender, EventArgs e)
        {
            try
            {
                clearControls();
                txtInvoiceNumber.Text = string.Empty;
                txtCustomerName.Text = string.Empty;
                grvDataGrid.DataSource = null;
                txtItemName.Text = string.Empty;
                lblTotalAmountBeforeTaxValue.Text = string.Empty;
                lblTotalAmountIncludingTaxValue.Text = string.Empty;
                lblTotalCGSTAmountValue.Text = string.Empty;
                lblTotalIGSTAmountValue.Text = string.Empty;
                lblTotalReverseChargeValue.Text = string.Empty;
                lblTotalTaxAmountValue.Text = string.Empty;
                lblTotalSGSTAmountValue.Text = string.Empty;
                tbSalesInvoice.SelectedTab = tbCreateSalesInvoice;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
