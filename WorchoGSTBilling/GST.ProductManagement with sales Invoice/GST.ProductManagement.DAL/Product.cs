using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GST.ProductManagement.DAL
{
    public class Product
    {
        public int product_iD { get; set; }
        public string description { get; set; }
        public string item_type { get; set; }
        public string hsn_number { get; set; }
        public int item_unit { get; set; }
        public decimal item_sale_price { get; set; }
        public decimal item_purchase_price	 { get; set; }
        public decimal discount { get; set; }
        public decimal cgst_rate { get; set; }
        public decimal sgst_rate { get; set; }
        public decimal igst_rate { get; set; }
        //public string created_by { get; set; }
        //public DateTime created_date { get; set; }
        //public string last_updated_by { get; set; }
        //public DateTime last_updated_date { get; set; }
        //public int company_id { get; set; }
        
    }

    public class ProductFull
    {
        public int product_iD { get; set; }
        public string description { get; set; }
        public string item_type { get; set; }
        public string hsn_number { get; set; }
        public int item_unit { get; set; }
        public decimal item_sale_price { get; set; }
        public decimal item_purchase_price { get; set; }
        public decimal discount { get; set; }
        public decimal cgst_rate { get; set; }
        public decimal sgst_rate { get; set; }
        public decimal igst_rate { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string last_updated_by { get; set; }
        public DateTime last_updated_date { get; set; }
        public int company_id { get; set; }

    }

    public class TaxInformationDetails
    {
        public string Invoice_iD { get; set; }
        public string invoice_number { get; set; }
        public string hsn_code { get; set; }
        public int product_id { get; set; }
        public int customer_id { get; set; }
        public DateTime invoice_date { get; set; }
        public string invoice_due_terms { get; set; }
        public DateTime invoice_due_date { get; set; }
        public char supply_type { get; set; }
        public int item_quantity { get; set; }
        public decimal item_price { get; set; }
        public decimal total_amount_before_discount { get; set; }
        public decimal item_discount { get; set; }
        public decimal cgst_rate { get; set; }
        public decimal cgst_amount { get; set; }
        public decimal sgst_rate { get; set; }
        public decimal sgst_amount { get; set; }
        public decimal igst_rate { get; set; }
        public decimal igst_amount { get; set; }
        public decimal total_taxable_amount { get; set; }
        public decimal total_taxable_amount_includig_GST { get; set; }
        public char flag_reverse_Charge { get; set; }
        public char invoice_category { get; set; }
        public decimal reverse_charge_rate { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string last_updated_by { get; set; }
        public DateTime last_updated_date { get; set; }
        public int company_id { get; set; }
    }

    public class TotalTaxInformation
    {
        public string Invoice_Id { get; set; }
        public string Invoice_number { get; set; }
        public int customer_id { get; set; }
        public DateTime Invoice_created_date { get; set; }
        public decimal Total_amount_including_GST { get; set; }
        public char Flag_reverse_charge { get; set; }
        public decimal Total_reverse_charge { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string last_updated_by { get; set; }
        public DateTime last_updated_date { get; set; }
        public int company_id { get; set; }

    }


}
