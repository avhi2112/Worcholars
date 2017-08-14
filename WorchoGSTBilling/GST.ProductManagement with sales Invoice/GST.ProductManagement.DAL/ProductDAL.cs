using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace GST.ProductManagement.DAL
{
    public class ProductDAL
    {
        //string connectionString = ;
        MySqlConnection con = new MySqlConnection("SERVER=" + "127.0.0.1" + ";" + "DATABASE=" + "worcholars_gst" + ";" + "UID=" + "root" + ";" + "PASSWORD=" + "" + ";");

        public int insertProduct(ProductFull productFull)
        {
            con.Open();
            string sql = "INSERT INTO `worc_product` (`description`, `item_type`, `hsn_number`, "
                + "`item_unit`, `item_sale_price`, `item_purchase_price`, `discount`, `cgst_rate`, " +
                "`sgst_rate`, `igst_rate`, `created_by`, `created_date`, `last_updated_by`, `last_updated_date`, `company_id`) " +
                "VALUES ('" + productFull.description + "', '" + productFull.item_type + "', '" + productFull.hsn_number + "', " +
                "'" + productFull.item_unit + "', '" + productFull.item_sale_price + "', '" + productFull.item_purchase_price + "', " +
                "'" + productFull.discount + "', '" + productFull.cgst_rate + "', '" + productFull.sgst_rate + "', '" + productFull.igst_rate + "'," +
                " '" + productFull.created_by + "', CURRENT_DATE(), '" + productFull.last_updated_by + "', CURRENT_DATE(), '" + productFull.company_id + "');";
            MySqlCommand comm = con.CreateCommand();
            comm.CommandText = sql;
            int a = comm.ExecuteNonQuery();
            con.Close();
            return a;
        }

        public int insertTaxInformation(TaxInformationDetails AllTaxInformation)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            MySqlCommand comm = con.CreateCommand();

            comm.CommandText = "INSERT INTO worc_taxinformation(Invoice_id,Invoice_number,product_id,customer_id,invoice_date,invoice_due_terms,invoice_due_date,invoice_category,supply_type,hsn_code,item_quantity,item_price,total_amount_before_discount,item_discount,cgst_rate,cgst_amount,sgst_rate,sgst_amount,igst_rate,igst_amount,total_taxable_amount,total_taxable_amount_including_GST,flag_reverse_Charge,reverse_charge_rate,created_by,created_date,last_updated_by,last_updated_date,company_id) " +
"VALUES(@Invoice_id, @Invoice_number,@product_id,@customer_id,@invoice_date,@invoice_due_terms,@invoice_due_date,@invoice_category,@supply_type,@hsn_code,@item_quantity,@item_price,@total_amount_before_discount,@item_discount,@cgst_rate,@cgst_amount,@sgst_rate,@sgst_amount,@igst_rate,@igst_amount,@total_taxable_amount,@total_taxable_amount_including_GST,@flag_reverse_Charge,@reverse_charge_rate,@created_by,@created_date,@last_updated_by,@last_updated_date,@company_id)";
            comm.Parameters.AddWithValue("@Invoice_id", AllTaxInformation.Invoice_iD);
            comm.Parameters.AddWithValue("@Invoice_number", AllTaxInformation.invoice_number);
            comm.Parameters.AddWithValue("@product_id", AllTaxInformation.product_id);
            comm.Parameters.AddWithValue("@customer_id", AllTaxInformation.customer_id);
            comm.Parameters.AddWithValue("@invoice_date", AllTaxInformation.invoice_date);
            comm.Parameters.AddWithValue("@invoice_due_terms", AllTaxInformation.invoice_due_terms);
            comm.Parameters.AddWithValue("@invoice_due_date", AllTaxInformation.invoice_due_date);
            comm.Parameters.AddWithValue("@invoice_category", AllTaxInformation.invoice_category);
            comm.Parameters.AddWithValue("@supply_type", AllTaxInformation.supply_type);
            comm.Parameters.AddWithValue("@hsn_code", AllTaxInformation.hsn_code);
            comm.Parameters.AddWithValue("@item_quantity", AllTaxInformation.item_quantity);
            comm.Parameters.AddWithValue("@item_price", AllTaxInformation.item_price);
            comm.Parameters.AddWithValue("@total_amount_before_discount", AllTaxInformation.total_amount_before_discount);
            comm.Parameters.AddWithValue("@item_discount", AllTaxInformation.item_discount);
            comm.Parameters.AddWithValue("@cgst_rate", AllTaxInformation.cgst_rate);
            comm.Parameters.AddWithValue("@cgst_amount", AllTaxInformation.cgst_amount);
            comm.Parameters.AddWithValue("@sgst_rate", AllTaxInformation.sgst_rate);
            comm.Parameters.AddWithValue("@sgst_amount", AllTaxInformation.sgst_amount);
            comm.Parameters.AddWithValue("@igst_rate", AllTaxInformation.igst_rate);
            comm.Parameters.AddWithValue("@igst_amount", AllTaxInformation.igst_amount);
            comm.Parameters.AddWithValue("@total_taxable_amount", AllTaxInformation.total_taxable_amount);
            comm.Parameters.AddWithValue("@total_taxable_amount_including_GST", AllTaxInformation.total_taxable_amount_includig_GST);
            comm.Parameters.AddWithValue("@flag_reverse_Charge", AllTaxInformation.flag_reverse_Charge);
            comm.Parameters.AddWithValue("@reverse_charge_rate", AllTaxInformation.reverse_charge_rate);
            comm.Parameters.AddWithValue("@created_by", AllTaxInformation.created_by);
            comm.Parameters.AddWithValue("@created_date", AllTaxInformation.created_date);
            comm.Parameters.AddWithValue("@last_updated_by", AllTaxInformation.last_updated_by);
            comm.Parameters.AddWithValue("@last_updated_date", AllTaxInformation.last_updated_date);
            comm.Parameters.AddWithValue("@company_id", AllTaxInformation.company_id);
            int a = comm.ExecuteNonQuery();
            con.Close();
            return a;
        }
        public int insertTotalTaxInformation(TotalTaxInformation TotalTaxInformation)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            MySqlCommand comm = con.CreateCommand();

            comm.CommandText = "INSERT INTO worc_totaltaxinformationinvoicewise(Invoice_id,Invoice_number,Customer_id,Invoice_created_date,Total_amount_including_GST,Flag_reverse_charge,Total_reverse_charge,created_by,created_date,last_updated_by,last_updated_date,company_id) " +
"VALUES(@Invoice_id, @Invoice_number,@Customer_id,@Invoice_created_date,@Total_amount_including_GST,@Flag_reverse_charge,@Total_reverse_charge,@created_by,@created_date,@last_updated_by,@last_updated_date,@company_id)";
            comm.Parameters.AddWithValue("@Invoice_id", TotalTaxInformation.Invoice_Id);
            comm.Parameters.AddWithValue("@Invoice_number", TotalTaxInformation.Invoice_number);
            comm.Parameters.AddWithValue("@Customer_id", TotalTaxInformation.customer_id);
            comm.Parameters.AddWithValue("@Invoice_created_date", TotalTaxInformation.Invoice_created_date);
            comm.Parameters.AddWithValue("@Total_amount_including_GST", TotalTaxInformation.Total_amount_including_GST);
            comm.Parameters.AddWithValue("@Flag_reverse_charge", TotalTaxInformation.Flag_reverse_charge);
            comm.Parameters.AddWithValue("@Total_reverse_charge", TotalTaxInformation.Total_reverse_charge);
            comm.Parameters.AddWithValue("@created_by", TotalTaxInformation.created_by);
            comm.Parameters.AddWithValue("@created_date", TotalTaxInformation.created_date);
            comm.Parameters.AddWithValue("@last_updated_by", TotalTaxInformation.last_updated_by);
            comm.Parameters.AddWithValue("@last_updated_date", TotalTaxInformation.last_updated_date);
            comm.Parameters.AddWithValue("@company_id", TotalTaxInformation.company_id);
            int a = comm.ExecuteNonQuery();
            con.Close();
            return a;
        }
        public bool UpdateReverseCharge(char cReverseChargeFlag, string strInvoiceNumber, decimal decReverseChargeRate)
        {
            string sql = string.Empty;
            try
            {
                con.Open();

                sql = "UPDATE worc_taxinformation set flag_reverse_Charge = ?rc, reverse_charge_rate=?rcr where Invoice_number = ?in;";
                //sql = "UPDATE worc_customer SET billing_address = '" + strBillingAdress +
                //        "' WHERE customer_id = " + strwhereCondition + ";";
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("?rc", cReverseChargeFlag);
                comm.Parameters.AddWithValue("?rcr", decReverseChargeRate);
                comm.Parameters.AddWithValue("?in", strInvoiceNumber);
                comm.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int UpdateProductInformation(TaxInformationDetails AllTaxInformation, string strHSNCode)
        {
            string sql = string.Empty;
            try
            {
                con.Open();
                sql = "UPDATE worc_taxinformation set product_id = ?pi,invoice_date=?id,invoice_due_terms=?idt,invoice_due_date=?idd," +
                    " item_quantity=?iq,item_price=?ip,total_amount_before_discount=?tabd,cgst_rate=?cgstrate,cgst_amount=?cgstamount,sgst_rate=?sgstrate,sgst_amount=?sgstamount,igst_rate=?igstrate, igst_amount=?igstamount ,item_discount=?iid," +
                    "total_taxable_amount=?tta,total_taxable_amount_including_GST=?ttaiGST,flag_reverse_Charge=?frc,reverse_charge_rate=?rcr,last_updated_by=?lub,last_updated_date=?lud where hsn_code = ?hsn ;";

                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = sql;

                comm.Parameters.AddWithValue("?pi", AllTaxInformation.product_id);
                comm.Parameters.AddWithValue("?id", AllTaxInformation.invoice_date);
                comm.Parameters.AddWithValue("?idt", AllTaxInformation.invoice_due_terms);
                comm.Parameters.AddWithValue("?idd", AllTaxInformation.invoice_due_date);

                // comm.Parameters.AddWithValue("@hsn_code", AllTaxInformation.hsn_code);
                comm.Parameters.AddWithValue("?iq", AllTaxInformation.item_quantity);
                comm.Parameters.AddWithValue("?ip", AllTaxInformation.item_price);
                comm.Parameters.AddWithValue("?tabd", AllTaxInformation.total_amount_before_discount);
                comm.Parameters.AddWithValue("?iid", AllTaxInformation.item_discount);
                comm.Parameters.AddWithValue("?cgstrate", AllTaxInformation.cgst_rate);
                comm.Parameters.AddWithValue("?cgstamount", AllTaxInformation.cgst_amount);
                comm.Parameters.AddWithValue("?sgstrate", AllTaxInformation.sgst_rate);
                comm.Parameters.AddWithValue("?sgstamount", AllTaxInformation.sgst_amount);
                comm.Parameters.AddWithValue("?igstrate", AllTaxInformation.igst_rate);
                comm.Parameters.AddWithValue("?igstamount", AllTaxInformation.igst_amount);
                comm.Parameters.AddWithValue("?tta", AllTaxInformation.total_taxable_amount);
                comm.Parameters.AddWithValue("?ttaiGST", AllTaxInformation.total_taxable_amount_includig_GST);
                comm.Parameters.AddWithValue("?frc", AllTaxInformation.flag_reverse_Charge);
                comm.Parameters.AddWithValue("?rcr", AllTaxInformation.reverse_charge_rate);

                comm.Parameters.AddWithValue("?lub", AllTaxInformation.last_updated_by);
                comm.Parameters.AddWithValue("?lud", AllTaxInformation.last_updated_date);
                //comm.Parameters.AddWithValue("@company_id", AllTaxInformation.company_id);
                comm.Parameters.AddWithValue("?hsn", strHSNCode);

                //sql = "UPDATE worc_taxinformation set product_id = ?pi, item_quantity=?iq, item_discount=?id where hsn_code = ?hsn ;";
                //sql = "UPDATE worc_customer SET billing_address = '" + strBillingAdress +
                //        "' WHERE customer_id = " + strwhereCondition + ";";
                //MySqlCommand comm = con.CreateCommand();
                //comm.CommandText = sql;
                //comm.Parameters.AddWithValue("?pi", iProductId);
                //comm.Parameters.AddWithValue("?iq", iQuantity);
                //comm.Parameters.AddWithValue("?id", decDiscount);

                int a = comm.ExecuteNonQuery();
                con.Close();
                return a;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int deleteProductInformation(int productID, string strInvoiceNumber)
        {
            string sql = string.Empty;
            con.Open();
            if (productID != -1)
            {
                sql = "DELETE FROM `worc_taxinformation` WHERE product_id=" + productID + " and Invoice_number='" + strInvoiceNumber + "'";
            }

            else
            {
                sql = "DELETE FROM `worc_taxinformation`";
            }

            MySqlCommand comm = con.CreateCommand();
            comm.CommandText = sql;
            int a = comm.ExecuteNonQuery();
            con.Close();
            return a;
        }
        public void UpdateAddress(string strBillingAdress, string strShippingAddress, string strwhereCondition)
        {
            string sql = string.Empty;
            try
            {
                con.Open();

                sql = "UPDATE worc_customer set billing_address = ?ba, shipping_address=?sa where customer_id = ?ci;";
                //sql = "UPDATE worc_customer SET billing_address = '" + strBillingAdress +
                //        "' WHERE customer_id = " + strwhereCondition + ";";
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("?ba", strBillingAdress);
                comm.Parameters.AddWithValue("?sa", strShippingAddress);
                comm.Parameters.AddWithValue("?ci", strwhereCondition);
                comm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        public List<Product> getProducts()
        {
            List<Product> products = new List<Product>();
            con.Open();
            string sql = "Select * from worc_product";
            MySqlCommand comm = con.CreateCommand();
            comm.CommandText = sql;
            using (MySqlDataAdapter sda = new MySqlDataAdapter(comm))
            {
                using (DataTable dt = new DataTable())
                {
                    sda.Fill(dt);
                    products = ConvertToList(dt);
                }
            }
            con.Close();
            return products;
        }

        public DataTable GetTaxInformation()
        {
            DataTable dtTaxInformation = new DataTable();
            try
            {
                //Display query
                string Query = "SELECT prod.description,prod.item_type,tax.hsn_code,tax.item_quantity,tax.item_price,tax.item_discount,tax.total_taxable_amount,tax.cgst_rate,tax.cgst_amount,tax.sgst_rate,tax.sgst_amount,tax.igst_rate,tax.igst_amount,tax.total_taxable_amount_including_GST,tax.Invoice_number,tax.product_id,tax.customer_id FROM worc_taxinformation tax LEFT JOIN worc_product prod on tax.product_id = prod.product_id";
                //coMySqlConnection MyConn2 = new MySqlConnection(connectionString);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, con);
                con.Open();
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;

                MyAdapter.Fill(dtTaxInformation);
                con.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            return dtTaxInformation;
        }

        public DataTable GetAllInvoiceNumber()
        {
            DataTable dtAllInvoiceNumber = new DataTable();
            try
            {
                //Display query
                string Query = "SELECT distinct Invoice_number FROM worc_taxinformation";
                //coMySqlConnection MyConn2 = new MySqlConnection(connectionString);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, con);
                con.Open();
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;

                MyAdapter.Fill(dtAllInvoiceNumber);
                con.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            return dtAllInvoiceNumber;
        }
        public DataTable GetAllInvoiceNumberFromTotal()
        {
            DataTable dtAllInvoiceNumberFromTotal = new DataTable();
            try
            {
                //Display query
                string Query = "SELECT distinct Invoice_number FROM worc_totaltaxinformationinvoicewise";
                //coMySqlConnection MyConn2 = new MySqlConnection(connectionString);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, con);
                con.Open();
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;

                MyAdapter.Fill(dtAllInvoiceNumberFromTotal);
                con.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            return dtAllInvoiceNumberFromTotal;
        }
        private List<Product> ConvertToList(DataTable dt)
        {
            List<Product> products = new List<Product>();
            products = (from DataRow row in dt.Rows

                        select new Product
                        {
                            product_iD = Convert.ToInt32(row["product_id"]),
                            description = row["description"].ToString(),
                            item_type = row["item_type"].ToString(),
                            hsn_number = row["hsn_number"].ToString(),
                            item_unit = Convert.ToInt32(row["item_unit"]),
                            item_purchase_price = Convert.ToInt32(row["item_purchase_price"]),
                            item_sale_price = Convert.ToInt32(row["item_sale_price"]),
                            discount = Convert.ToInt32(row["discount"]),
                            cgst_rate = Convert.ToInt32(row["cgst_rate"]),
                            sgst_rate = Convert.ToInt32(row["sgst_rate"]),
                            igst_rate = Convert.ToInt32(row["igst_rate"]),

                        }).ToList();

            return products;
        }

        public DataTable GetCustomerDataTable()
        {
            DataTable dTable = new DataTable();
            try
            {
                //Display query
                string Query = "select * from worc_customer";
                con.Open();
                //coMySqlConnection MyConn2 = new MySqlConnection(connectionString);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, con);
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;

                MyAdapter.Fill(dTable);
                con.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            return dTable;
        }
        public DataTable GetProductDataTable()
        {
            DataTable dTable = new DataTable();
            try
            {
                //Display query
                string Query = "select * from worc_product";
                con.Open();
                MySqlCommand MyCommand2 = new MySqlCommand(Query, con);
                //For offline connection we weill use  MySqlDataAdapter class. 

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                MyAdapter.Fill(dTable);
                con.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            return dTable;
        }
    }
}

