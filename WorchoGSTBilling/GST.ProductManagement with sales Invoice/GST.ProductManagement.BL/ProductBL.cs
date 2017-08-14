using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GST.ProductManagement.DAL;
using System.Data;

namespace GST.ProductManagement.BL
{
    public class ProductBL
    {
        ProductManagement.DAL.ProductDAL productDAL = new ProductManagement.DAL.ProductDAL();

        public int insertProduct(ProductFull productFull)
        {
            int a = productDAL.insertProduct(productFull);
            return a;
        }

        public int insertTaxInformation(TaxInformationDetails AllTaxInformation)
        {
            try
            {
                int a = productDAL.insertTaxInformation(AllTaxInformation);
                return a;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int insertTotalTaxInformation(TotalTaxInformation TotalTaxInformation)
        {
            try
            {
                int a = productDAL.insertTotalTaxInformation(TotalTaxInformation);
                return a;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool UpdateReverseChargeInformation(char chFlagReverseCharge, decimal decReverseChargeRate, string strInvoiceNumber)
        {
            try
            {
                productDAL.UpdateReverseCharge(chFlagReverseCharge, strInvoiceNumber, decReverseChargeRate);
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int UpdateProductInformation(TaxInformationDetails AllTaxInformation, string strHSNCode)
        {
            try
            {
                int a = productDAL.UpdateProductInformation(AllTaxInformation, strHSNCode);
                return a;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int deleteProductInformation(int productID,string strInvoiceNumber)
        {
            try
            {
                int a = productDAL.deleteProductInformation(productID,strInvoiceNumber);
                return a;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<Product> getProducts()
        {
            List<Product> products = new List<Product>();
            products = productDAL.getProducts();
            return products;
        }

        public DataTable GetCustomerDetails()
        {
            try
            {
                DataTable dtCustomerDetails = new DataTable();
                dtCustomerDetails = productDAL.GetCustomerDataTable();
                return dtCustomerDetails;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataTable GetTaxInformationDetails()
        {
            try
            {
                DataTable dtTaxInformationDetails = new DataTable();
                dtTaxInformationDetails = productDAL.GetTaxInformation();
                return dtTaxInformationDetails;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataTable GetAllInvoiceRecords()
        {
            try
            {
                DataTable dtAllInvoiceNumber = new DataTable();
                dtAllInvoiceNumber = productDAL.GetAllInvoiceNumber();
                return dtAllInvoiceNumber;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataTable GetAllInvoiceRecordsFromTotal()
        {
            try
            {
                DataTable dtAllInvoiceNumberFromTotal = new DataTable();
                dtAllInvoiceNumberFromTotal = productDAL.GetAllInvoiceNumberFromTotal();
                return dtAllInvoiceNumberFromTotal;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataTable GetProductDetails()
        {
            try
            {
                DataTable dtProductDetails = new DataTable();
                dtProductDetails = productDAL.GetProductDataTable();
                return dtProductDetails;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void UpdateAdress(string strBillingAdress, string strShippingAddress, string strwhereCondition)
        {
            try
            {
                productDAL.UpdateAddress(strBillingAdress, strShippingAddress, strwhereCondition);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}

