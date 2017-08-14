namespace GST.ProductManagement.UI
{
    partial class frmSalesInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.pnlInvoice = new System.Windows.Forms.Panel();
            this.tbSalesInvoice = new System.Windows.Forms.TabControl();
            this.tbCreateSalesInvoice = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalAmountBeforeTax = new System.Windows.Forms.Label();
            this.lblTotalCGSTAmount = new System.Windows.Forms.Label();
            this.lblTotalSGSTAmount = new System.Windows.Forms.Label();
            this.lblTotalIGSTAmount = new System.Windows.Forms.Label();
            this.lblTotalTaxAmount = new System.Windows.Forms.Label();
            this.lblTotalAmountIncludingGST = new System.Windows.Forms.Label();
            this.lblTotalReverseCharge = new System.Windows.Forms.Label();
            this.lblTotalAmountBeforeTaxValue = new System.Windows.Forms.Label();
            this.lblTotalCGSTAmountValue = new System.Windows.Forms.Label();
            this.lblTotalSGSTAmountValue = new System.Windows.Forms.Label();
            this.lblTotalIGSTAmountValue = new System.Windows.Forms.Label();
            this.lblTotalTaxAmountValue = new System.Windows.Forms.Label();
            this.lblTotalAmountIncludingTaxValue = new System.Windows.Forms.Label();
            this.lblTotalReverseChargeValue = new System.Windows.Forms.Label();
            this.chkReverseCharge = new System.Windows.Forms.CheckBox();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.grvDataGrid = new System.Windows.Forms.DataGridView();
            this.lnkUpdate = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnViewData = new System.Windows.Forms.Button();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.pnlTotalAmount = new System.Windows.Forms.Panel();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.pnlIGSTAmount = new System.Windows.Forms.Panel();
            this.txtIGSTAmount = new System.Windows.Forms.TextBox();
            this.lblIGSTAmount = new System.Windows.Forms.Label();
            this.pnlIGST = new System.Windows.Forms.Panel();
            this.cboIGSTRate = new System.Windows.Forms.ComboBox();
            this.lblIGSTRate = new System.Windows.Forms.Label();
            this.pnlISGSTAmount = new System.Windows.Forms.Panel();
            this.txtSGSTAmount = new System.Windows.Forms.TextBox();
            this.lblSGSTAmount = new System.Windows.Forms.Label();
            this.pnlSGST = new System.Windows.Forms.Panel();
            this.cboSGSTRate = new System.Windows.Forms.ComboBox();
            this.lblSGSTRate = new System.Windows.Forms.Label();
            this.pnlCGSTAmount = new System.Windows.Forms.Panel();
            this.txtCGSTAmount = new System.Windows.Forms.TextBox();
            this.lblCGSTAmount = new System.Windows.Forms.Label();
            this.pnlCGST = new System.Windows.Forms.Panel();
            this.cboCGSTRate = new System.Windows.Forms.ComboBox();
            this.lblCGSTRate = new System.Windows.Forms.Label();
            this.pnlTaxableAmount = new System.Windows.Forms.Panel();
            this.txtTaxableAmount = new System.Windows.Forms.TextBox();
            this.lblTaxableAmount = new System.Windows.Forms.Label();
            this.pnlDiscount = new System.Windows.Forms.Panel();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.pnlPrice = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pnlQuantity = new System.Windows.Forms.Panel();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.pnlHSNCode = new System.Windows.Forms.Panel();
            this.txtHSNCode = new System.Windows.Forms.TextBox();
            this.lblHSNCode = new System.Windows.Forms.Label();
            this.pnlItemType = new System.Windows.Forms.Panel();
            this.cboItemType = new System.Windows.Forms.ComboBox();
            this.lblItemType = new System.Windows.Forms.Label();
            this.pnlItemName = new System.Windows.Forms.Panel();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.pnlPlaceofSupply = new System.Windows.Forms.Panel();
            this.cboPlaceofSupply = new System.Windows.Forms.ComboBox();
            this.lblPlaceofSupply = new System.Windows.Forms.Label();
            this.pnlGSTIN = new System.Windows.Forms.Panel();
            this.txtGSTIN = new System.Windows.Forms.TextBox();
            this.lblGSTIN = new System.Windows.Forms.Label();
            this.pnlShippingAddress = new System.Windows.Forms.Panel();
            this.txtShippingAddress = new System.Windows.Forms.TextBox();
            this.lblShippingAddress = new System.Windows.Forms.Label();
            this.pnlBilllingAddress = new System.Windows.Forms.Panel();
            this.chkSame = new System.Windows.Forms.CheckBox();
            this.lnkSave = new System.Windows.Forms.LinkLabel();
            this.txtBillingAddress = new System.Windows.Forms.TextBox();
            this.lkEdit = new System.Windows.Forms.LinkLabel();
            this.lblBillingAddress = new System.Windows.Forms.Label();
            this.pnlCustomerName = new System.Windows.Forms.Panel();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.pnlDueDate = new System.Windows.Forms.Panel();
            this.dtInvoiceDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.pnlReference = new System.Windows.Forms.Panel();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.lblReference = new System.Windows.Forms.Label();
            this.pnlInvoiceDate = new System.Windows.Forms.Panel();
            this.dtInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.pnlInvoiceSerialNo = new System.Windows.Forms.Panel();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.lblInvoiceSerialNo = new System.Windows.Forms.Label();
            this.tbPreviewSalesInvoice = new System.Windows.Forms.TabPage();
            this.tbViewSalesInvoice = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddNewSaleInvoice = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlInvoice.SuspendLayout();
            this.tbSalesInvoice.SuspendLayout();
            this.tbCreateSalesInvoice.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDataGrid)).BeginInit();
            this.pnlProduct.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlTotalAmount.SuspendLayout();
            this.pnlIGSTAmount.SuspendLayout();
            this.pnlIGST.SuspendLayout();
            this.pnlISGSTAmount.SuspendLayout();
            this.pnlSGST.SuspendLayout();
            this.pnlCGSTAmount.SuspendLayout();
            this.pnlCGST.SuspendLayout();
            this.pnlTaxableAmount.SuspendLayout();
            this.pnlDiscount.SuspendLayout();
            this.pnlPrice.SuspendLayout();
            this.pnlQuantity.SuspendLayout();
            this.pnlHSNCode.SuspendLayout();
            this.pnlItemType.SuspendLayout();
            this.pnlItemName.SuspendLayout();
            this.pnlPlaceofSupply.SuspendLayout();
            this.pnlGSTIN.SuspendLayout();
            this.pnlShippingAddress.SuspendLayout();
            this.pnlBilllingAddress.SuspendLayout();
            this.pnlCustomerName.SuspendLayout();
            this.pnlDueDate.SuspendLayout();
            this.pnlReference.SuspendLayout();
            this.pnlInvoiceDate.SuspendLayout();
            this.pnlInvoiceSerialNo.SuspendLayout();
            this.tbPreviewSalesInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ControlText;
            this.pnlHeader.Controls.Add(this.lblHeaderText);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1224, 29);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.AutoSize = true;
            this.lblHeaderText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblHeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderText.Location = new System.Drawing.Point(7, 6);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(137, 17);
            this.lblHeaderText.TabIndex = 0;
            this.lblHeaderText.Text = "Create Sales Invoice";
            // 
            // pnlInvoice
            // 
            this.pnlInvoice.Controls.Add(this.tbSalesInvoice);
            this.pnlInvoice.Location = new System.Drawing.Point(0, 29);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Size = new System.Drawing.Size(1231, 549);
            this.pnlInvoice.TabIndex = 1;
            // 
            // tbSalesInvoice
            // 
            this.tbSalesInvoice.Controls.Add(this.tbCreateSalesInvoice);
            this.tbSalesInvoice.Controls.Add(this.tbPreviewSalesInvoice);
            this.tbSalesInvoice.Controls.Add(this.tbViewSalesInvoice);
            this.tbSalesInvoice.Location = new System.Drawing.Point(3, 2);
            this.tbSalesInvoice.Name = "tbSalesInvoice";
            this.tbSalesInvoice.SelectedIndex = 0;
            this.tbSalesInvoice.Size = new System.Drawing.Size(1228, 544);
            this.tbSalesInvoice.TabIndex = 0;
            // 
            // tbCreateSalesInvoice
            // 
            this.tbCreateSalesInvoice.Controls.Add(this.panel1);
            this.tbCreateSalesInvoice.Controls.Add(this.panel2);
            this.tbCreateSalesInvoice.Controls.Add(this.pnlGrid);
            this.tbCreateSalesInvoice.Controls.Add(this.pnlProduct);
            this.tbCreateSalesInvoice.Controls.Add(this.pnlPlaceofSupply);
            this.tbCreateSalesInvoice.Controls.Add(this.pnlGSTIN);
            this.tbCreateSalesInvoice.Controls.Add(this.pnlShippingAddress);
            this.tbCreateSalesInvoice.Controls.Add(this.pnlBilllingAddress);
            this.tbCreateSalesInvoice.Controls.Add(this.pnlCustomerName);
            this.tbCreateSalesInvoice.Controls.Add(this.pnlDueDate);
            this.tbCreateSalesInvoice.Controls.Add(this.pnlReference);
            this.tbCreateSalesInvoice.Controls.Add(this.pnlInvoiceDate);
            this.tbCreateSalesInvoice.Controls.Add(this.pnlInvoiceSerialNo);
            this.tbCreateSalesInvoice.Location = new System.Drawing.Point(4, 22);
            this.tbCreateSalesInvoice.Name = "tbCreateSalesInvoice";
            this.tbCreateSalesInvoice.Size = new System.Drawing.Size(1220, 518);
            this.tbCreateSalesInvoice.TabIndex = 0;
            this.tbCreateSalesInvoice.Text = "Create Sales Invoice";
            this.tbCreateSalesInvoice.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProceed);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(5, 476);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 29);
            this.panel1.TabIndex = 20;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.YellowGreen;
            this.btnProceed.Location = new System.Drawing.Point(933, 3);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(171, 23);
            this.btnProceed.TabIndex = 2;
            this.btnProceed.Text = "Confirm and Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(1107, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.chkReverseCharge);
            this.panel2.Location = new System.Drawing.Point(5, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1207, 62);
            this.panel2.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.lblTotalAmountBeforeTax, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalCGSTAmount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalSGSTAmount, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalIGSTAmount, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalTaxAmount, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalAmountIncludingGST, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalReverseCharge, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalAmountBeforeTaxValue, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalCGSTAmountValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalSGSTAmountValue, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalIGSTAmountValue, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalTaxAmountValue, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalAmountIncludingTaxValue, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalReverseChargeValue, 6, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(116, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1080, 55);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // lblTotalAmountBeforeTax
            // 
            this.lblTotalAmountBeforeTax.AutoSize = true;
            this.lblTotalAmountBeforeTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountBeforeTax.Location = new System.Drawing.Point(3, 0);
            this.lblTotalAmountBeforeTax.Name = "lblTotalAmountBeforeTax";
            this.lblTotalAmountBeforeTax.Size = new System.Drawing.Size(148, 13);
            this.lblTotalAmountBeforeTax.TabIndex = 4;
            this.lblTotalAmountBeforeTax.Text = "Total Amount Before Tax";
            // 
            // lblTotalCGSTAmount
            // 
            this.lblTotalCGSTAmount.AutoSize = true;
            this.lblTotalCGSTAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCGSTAmount.Location = new System.Drawing.Point(157, 0);
            this.lblTotalCGSTAmount.Name = "lblTotalCGSTAmount";
            this.lblTotalCGSTAmount.Size = new System.Drawing.Size(119, 13);
            this.lblTotalCGSTAmount.TabIndex = 5;
            this.lblTotalCGSTAmount.Text = "Total CGST Amount";
            // 
            // lblTotalSGSTAmount
            // 
            this.lblTotalSGSTAmount.AutoSize = true;
            this.lblTotalSGSTAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSGSTAmount.Location = new System.Drawing.Point(311, 0);
            this.lblTotalSGSTAmount.Name = "lblTotalSGSTAmount";
            this.lblTotalSGSTAmount.Size = new System.Drawing.Size(119, 13);
            this.lblTotalSGSTAmount.TabIndex = 6;
            this.lblTotalSGSTAmount.Text = "Total SGST Amount";
            // 
            // lblTotalIGSTAmount
            // 
            this.lblTotalIGSTAmount.AutoSize = true;
            this.lblTotalIGSTAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIGSTAmount.Location = new System.Drawing.Point(465, 0);
            this.lblTotalIGSTAmount.Name = "lblTotalIGSTAmount";
            this.lblTotalIGSTAmount.Size = new System.Drawing.Size(115, 13);
            this.lblTotalIGSTAmount.TabIndex = 7;
            this.lblTotalIGSTAmount.Text = "Total IGST Amount";
            // 
            // lblTotalTaxAmount
            // 
            this.lblTotalTaxAmount.AutoSize = true;
            this.lblTotalTaxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTaxAmount.Location = new System.Drawing.Point(619, 0);
            this.lblTotalTaxAmount.Name = "lblTotalTaxAmount";
            this.lblTotalTaxAmount.Size = new System.Drawing.Size(107, 13);
            this.lblTotalTaxAmount.TabIndex = 8;
            this.lblTotalTaxAmount.Text = "Total Tax Amount";
            // 
            // lblTotalAmountIncludingGST
            // 
            this.lblTotalAmountIncludingGST.AutoSize = true;
            this.lblTotalAmountIncludingGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountIncludingGST.Location = new System.Drawing.Point(773, 0);
            this.lblTotalAmountIncludingGST.Name = "lblTotalAmountIncludingGST";
            this.lblTotalAmountIncludingGST.Size = new System.Drawing.Size(142, 26);
            this.lblTotalAmountIncludingGST.TabIndex = 9;
            this.lblTotalAmountIncludingGST.Text = "Total Amount Including Tax";
            // 
            // lblTotalReverseCharge
            // 
            this.lblTotalReverseCharge.AutoSize = true;
            this.lblTotalReverseCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReverseCharge.Location = new System.Drawing.Point(927, 0);
            this.lblTotalReverseCharge.Name = "lblTotalReverseCharge";
            this.lblTotalReverseCharge.Size = new System.Drawing.Size(131, 13);
            this.lblTotalReverseCharge.TabIndex = 10;
            this.lblTotalReverseCharge.Text = "Total Reverse Charge";
            // 
            // lblTotalAmountBeforeTaxValue
            // 
            this.lblTotalAmountBeforeTaxValue.AutoSize = true;
            this.lblTotalAmountBeforeTaxValue.Location = new System.Drawing.Point(3, 27);
            this.lblTotalAmountBeforeTaxValue.Name = "lblTotalAmountBeforeTaxValue";
            this.lblTotalAmountBeforeTaxValue.Size = new System.Drawing.Size(0, 13);
            this.lblTotalAmountBeforeTaxValue.TabIndex = 11;
            // 
            // lblTotalCGSTAmountValue
            // 
            this.lblTotalCGSTAmountValue.AutoSize = true;
            this.lblTotalCGSTAmountValue.Location = new System.Drawing.Point(157, 27);
            this.lblTotalCGSTAmountValue.Name = "lblTotalCGSTAmountValue";
            this.lblTotalCGSTAmountValue.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCGSTAmountValue.TabIndex = 12;
            // 
            // lblTotalSGSTAmountValue
            // 
            this.lblTotalSGSTAmountValue.AutoSize = true;
            this.lblTotalSGSTAmountValue.Location = new System.Drawing.Point(311, 27);
            this.lblTotalSGSTAmountValue.Name = "lblTotalSGSTAmountValue";
            this.lblTotalSGSTAmountValue.Size = new System.Drawing.Size(0, 13);
            this.lblTotalSGSTAmountValue.TabIndex = 13;
            // 
            // lblTotalIGSTAmountValue
            // 
            this.lblTotalIGSTAmountValue.AutoSize = true;
            this.lblTotalIGSTAmountValue.Location = new System.Drawing.Point(465, 27);
            this.lblTotalIGSTAmountValue.Name = "lblTotalIGSTAmountValue";
            this.lblTotalIGSTAmountValue.Size = new System.Drawing.Size(0, 13);
            this.lblTotalIGSTAmountValue.TabIndex = 14;
            // 
            // lblTotalTaxAmountValue
            // 
            this.lblTotalTaxAmountValue.AutoSize = true;
            this.lblTotalTaxAmountValue.Location = new System.Drawing.Point(619, 27);
            this.lblTotalTaxAmountValue.Name = "lblTotalTaxAmountValue";
            this.lblTotalTaxAmountValue.Size = new System.Drawing.Size(0, 13);
            this.lblTotalTaxAmountValue.TabIndex = 15;
            // 
            // lblTotalAmountIncludingTaxValue
            // 
            this.lblTotalAmountIncludingTaxValue.AutoSize = true;
            this.lblTotalAmountIncludingTaxValue.Location = new System.Drawing.Point(773, 27);
            this.lblTotalAmountIncludingTaxValue.Name = "lblTotalAmountIncludingTaxValue";
            this.lblTotalAmountIncludingTaxValue.Size = new System.Drawing.Size(0, 13);
            this.lblTotalAmountIncludingTaxValue.TabIndex = 16;
            // 
            // lblTotalReverseChargeValue
            // 
            this.lblTotalReverseChargeValue.AutoSize = true;
            this.lblTotalReverseChargeValue.Location = new System.Drawing.Point(927, 27);
            this.lblTotalReverseChargeValue.Name = "lblTotalReverseChargeValue";
            this.lblTotalReverseChargeValue.Size = new System.Drawing.Size(0, 13);
            this.lblTotalReverseChargeValue.TabIndex = 17;
            // 
            // chkReverseCharge
            // 
            this.chkReverseCharge.AutoSize = true;
            this.chkReverseCharge.Location = new System.Drawing.Point(7, 8);
            this.chkReverseCharge.Name = "chkReverseCharge";
            this.chkReverseCharge.Size = new System.Drawing.Size(103, 17);
            this.chkReverseCharge.TabIndex = 8;
            this.chkReverseCharge.Text = "Reverse Charge";
            this.chkReverseCharge.UseVisualStyleBackColor = true;
            this.chkReverseCharge.CheckedChanged += new System.EventHandler(this.chkReverseCharge_CheckedChanged);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.grvDataGrid);
            this.pnlGrid.Location = new System.Drawing.Point(5, 278);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1202, 131);
            this.pnlGrid.TabIndex = 14;
            // 
            // grvDataGrid
            // 
            this.grvDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lnkUpdate,
            this.Delete});
            this.grvDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDataGrid.Location = new System.Drawing.Point(0, 0);
            this.grvDataGrid.Name = "grvDataGrid";
            this.grvDataGrid.Size = new System.Drawing.Size(1202, 131);
            this.grvDataGrid.TabIndex = 1;
            this.grvDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDataGrid_CellContentClick);
            this.grvDataGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // lnkUpdate
            // 
            this.lnkUpdate.HeaderText = "Update";
            this.lnkUpdate.Name = "lnkUpdate";
            this.lnkUpdate.Text = "Update";
            this.lnkUpdate.ToolTipText = "Update";
            this.lnkUpdate.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // pnlProduct
            // 
            this.pnlProduct.Controls.Add(this.pnlButtons);
            this.pnlProduct.Controls.Add(this.pnlTotalAmount);
            this.pnlProduct.Controls.Add(this.pnlIGSTAmount);
            this.pnlProduct.Controls.Add(this.pnlIGST);
            this.pnlProduct.Controls.Add(this.pnlISGSTAmount);
            this.pnlProduct.Controls.Add(this.pnlSGST);
            this.pnlProduct.Controls.Add(this.pnlCGSTAmount);
            this.pnlProduct.Controls.Add(this.pnlCGST);
            this.pnlProduct.Controls.Add(this.pnlTaxableAmount);
            this.pnlProduct.Controls.Add(this.pnlDiscount);
            this.pnlProduct.Controls.Add(this.pnlPrice);
            this.pnlProduct.Controls.Add(this.pnlQuantity);
            this.pnlProduct.Controls.Add(this.pnlHSNCode);
            this.pnlProduct.Controls.Add(this.pnlItemType);
            this.pnlProduct.Controls.Add(this.pnlItemName);
            this.pnlProduct.Location = new System.Drawing.Point(5, 133);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(1202, 143);
            this.pnlProduct.TabIndex = 13;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnViewData);
            this.pnlButtons.Controls.Add(this.btnSaveInvoice);
            this.pnlButtons.Location = new System.Drawing.Point(-5, 110);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1207, 29);
            this.pnlButtons.TabIndex = 17;
            // 
            // btnViewData
            // 
            this.btnViewData.Location = new System.Drawing.Point(1009, 3);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(95, 23);
            this.btnViewData.TabIndex = 2;
            this.btnViewData.Text = "View Data";
            this.btnViewData.UseVisualStyleBackColor = true;
            this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click);
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.Location = new System.Drawing.Point(1107, 2);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(95, 23);
            this.btnSaveInvoice.TabIndex = 0;
            this.btnSaveInvoice.Text = "Save Invoice";
            this.btnSaveInvoice.UseVisualStyleBackColor = true;
            this.btnSaveInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click);
            // 
            // pnlTotalAmount
            // 
            this.pnlTotalAmount.Controls.Add(this.txtTotalAmount);
            this.pnlTotalAmount.Controls.Add(this.lblTotalAmount);
            this.pnlTotalAmount.Location = new System.Drawing.Point(1040, 58);
            this.pnlTotalAmount.Name = "pnlTotalAmount";
            this.pnlTotalAmount.Size = new System.Drawing.Size(155, 49);
            this.pnlTotalAmount.TabIndex = 16;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTotalAmount.Location = new System.Drawing.Point(0, 29);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(155, 20);
            this.txtTotalAmount.TabIndex = 5;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(3, 5);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(70, 13);
            this.lblTotalAmount.TabIndex = 3;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // pnlIGSTAmount
            // 
            this.pnlIGSTAmount.Controls.Add(this.txtIGSTAmount);
            this.pnlIGSTAmount.Controls.Add(this.lblIGSTAmount);
            this.pnlIGSTAmount.Location = new System.Drawing.Point(881, 58);
            this.pnlIGSTAmount.Name = "pnlIGSTAmount";
            this.pnlIGSTAmount.Size = new System.Drawing.Size(155, 49);
            this.pnlIGSTAmount.TabIndex = 15;
            // 
            // txtIGSTAmount
            // 
            this.txtIGSTAmount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtIGSTAmount.Enabled = false;
            this.txtIGSTAmount.Location = new System.Drawing.Point(0, 29);
            this.txtIGSTAmount.Name = "txtIGSTAmount";
            this.txtIGSTAmount.Size = new System.Drawing.Size(155, 20);
            this.txtIGSTAmount.TabIndex = 5;
            // 
            // lblIGSTAmount
            // 
            this.lblIGSTAmount.AutoSize = true;
            this.lblIGSTAmount.Location = new System.Drawing.Point(3, 5);
            this.lblIGSTAmount.Name = "lblIGSTAmount";
            this.lblIGSTAmount.Size = new System.Drawing.Size(71, 13);
            this.lblIGSTAmount.TabIndex = 3;
            this.lblIGSTAmount.Text = "IGST Amount";
            // 
            // pnlIGST
            // 
            this.pnlIGST.Controls.Add(this.cboIGSTRate);
            this.pnlIGST.Controls.Add(this.lblIGSTRate);
            this.pnlIGST.Location = new System.Drawing.Point(723, 58);
            this.pnlIGST.Name = "pnlIGST";
            this.pnlIGST.Size = new System.Drawing.Size(155, 49);
            this.pnlIGST.TabIndex = 14;
            // 
            // cboIGSTRate
            // 
            this.cboIGSTRate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboIGSTRate.Enabled = false;
            this.cboIGSTRate.FormattingEnabled = true;
            this.cboIGSTRate.Items.AddRange(new object[] {
            "Select"});
            this.cboIGSTRate.Location = new System.Drawing.Point(0, 28);
            this.cboIGSTRate.Name = "cboIGSTRate";
            this.cboIGSTRate.Size = new System.Drawing.Size(155, 21);
            this.cboIGSTRate.TabIndex = 5;
            // 
            // lblIGSTRate
            // 
            this.lblIGSTRate.AutoSize = true;
            this.lblIGSTRate.Location = new System.Drawing.Point(3, 5);
            this.lblIGSTRate.Name = "lblIGSTRate";
            this.lblIGSTRate.Size = new System.Drawing.Size(75, 13);
            this.lblIGSTRate.TabIndex = 3;
            this.lblIGSTRate.Text = "IGST Rate (%)";
            // 
            // pnlISGSTAmount
            // 
            this.pnlISGSTAmount.Controls.Add(this.txtSGSTAmount);
            this.pnlISGSTAmount.Controls.Add(this.lblSGSTAmount);
            this.pnlISGSTAmount.Location = new System.Drawing.Point(564, 58);
            this.pnlISGSTAmount.Name = "pnlISGSTAmount";
            this.pnlISGSTAmount.Size = new System.Drawing.Size(155, 49);
            this.pnlISGSTAmount.TabIndex = 13;
            // 
            // txtSGSTAmount
            // 
            this.txtSGSTAmount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSGSTAmount.Enabled = false;
            this.txtSGSTAmount.Location = new System.Drawing.Point(0, 29);
            this.txtSGSTAmount.Name = "txtSGSTAmount";
            this.txtSGSTAmount.Size = new System.Drawing.Size(155, 20);
            this.txtSGSTAmount.TabIndex = 6;
            // 
            // lblSGSTAmount
            // 
            this.lblSGSTAmount.AutoSize = true;
            this.lblSGSTAmount.Location = new System.Drawing.Point(3, 5);
            this.lblSGSTAmount.Name = "lblSGSTAmount";
            this.lblSGSTAmount.Size = new System.Drawing.Size(75, 13);
            this.lblSGSTAmount.TabIndex = 3;
            this.lblSGSTAmount.Text = "SGST Amount";
            // 
            // pnlSGST
            // 
            this.pnlSGST.Controls.Add(this.cboSGSTRate);
            this.pnlSGST.Controls.Add(this.lblSGSTRate);
            this.pnlSGST.Location = new System.Drawing.Point(403, 58);
            this.pnlSGST.Name = "pnlSGST";
            this.pnlSGST.Size = new System.Drawing.Size(155, 49);
            this.pnlSGST.TabIndex = 12;
            // 
            // cboSGSTRate
            // 
            this.cboSGSTRate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboSGSTRate.Enabled = false;
            this.cboSGSTRate.FormattingEnabled = true;
            this.cboSGSTRate.Items.AddRange(new object[] {
            "Select"});
            this.cboSGSTRate.Location = new System.Drawing.Point(0, 28);
            this.cboSGSTRate.Name = "cboSGSTRate";
            this.cboSGSTRate.Size = new System.Drawing.Size(155, 21);
            this.cboSGSTRate.TabIndex = 5;
            // 
            // lblSGSTRate
            // 
            this.lblSGSTRate.AutoSize = true;
            this.lblSGSTRate.Location = new System.Drawing.Point(3, 5);
            this.lblSGSTRate.Name = "lblSGSTRate";
            this.lblSGSTRate.Size = new System.Drawing.Size(79, 13);
            this.lblSGSTRate.TabIndex = 3;
            this.lblSGSTRate.Text = "SGST Rate (%)";
            // 
            // pnlCGSTAmount
            // 
            this.pnlCGSTAmount.Controls.Add(this.txtCGSTAmount);
            this.pnlCGSTAmount.Controls.Add(this.lblCGSTAmount);
            this.pnlCGSTAmount.Location = new System.Drawing.Point(245, 58);
            this.pnlCGSTAmount.Name = "pnlCGSTAmount";
            this.pnlCGSTAmount.Size = new System.Drawing.Size(155, 49);
            this.pnlCGSTAmount.TabIndex = 11;
            // 
            // txtCGSTAmount
            // 
            this.txtCGSTAmount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtCGSTAmount.Enabled = false;
            this.txtCGSTAmount.Location = new System.Drawing.Point(0, 29);
            this.txtCGSTAmount.Name = "txtCGSTAmount";
            this.txtCGSTAmount.Size = new System.Drawing.Size(155, 20);
            this.txtCGSTAmount.TabIndex = 5;
            // 
            // lblCGSTAmount
            // 
            this.lblCGSTAmount.AutoSize = true;
            this.lblCGSTAmount.Location = new System.Drawing.Point(3, 5);
            this.lblCGSTAmount.Name = "lblCGSTAmount";
            this.lblCGSTAmount.Size = new System.Drawing.Size(75, 13);
            this.lblCGSTAmount.TabIndex = 3;
            this.lblCGSTAmount.Text = "CGST Amount";
            // 
            // pnlCGST
            // 
            this.pnlCGST.Controls.Add(this.cboCGSTRate);
            this.pnlCGST.Controls.Add(this.lblCGSTRate);
            this.pnlCGST.Location = new System.Drawing.Point(6, 58);
            this.pnlCGST.Name = "pnlCGST";
            this.pnlCGST.Size = new System.Drawing.Size(230, 49);
            this.pnlCGST.TabIndex = 6;
            // 
            // cboCGSTRate
            // 
            this.cboCGSTRate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboCGSTRate.Enabled = false;
            this.cboCGSTRate.FormattingEnabled = true;
            this.cboCGSTRate.Items.AddRange(new object[] {
            "Select"});
            this.cboCGSTRate.Location = new System.Drawing.Point(0, 28);
            this.cboCGSTRate.Name = "cboCGSTRate";
            this.cboCGSTRate.Size = new System.Drawing.Size(230, 21);
            this.cboCGSTRate.TabIndex = 5;
            // 
            // lblCGSTRate
            // 
            this.lblCGSTRate.AutoSize = true;
            this.lblCGSTRate.Location = new System.Drawing.Point(3, 5);
            this.lblCGSTRate.Name = "lblCGSTRate";
            this.lblCGSTRate.Size = new System.Drawing.Size(79, 13);
            this.lblCGSTRate.TabIndex = 3;
            this.lblCGSTRate.Text = "CGST Rate (%)";
            // 
            // pnlTaxableAmount
            // 
            this.pnlTaxableAmount.Controls.Add(this.txtTaxableAmount);
            this.pnlTaxableAmount.Controls.Add(this.lblTaxableAmount);
            this.pnlTaxableAmount.Location = new System.Drawing.Point(1041, 3);
            this.pnlTaxableAmount.Name = "pnlTaxableAmount";
            this.pnlTaxableAmount.Size = new System.Drawing.Size(155, 49);
            this.pnlTaxableAmount.TabIndex = 10;
            // 
            // txtTaxableAmount
            // 
            this.txtTaxableAmount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTaxableAmount.Location = new System.Drawing.Point(0, 29);
            this.txtTaxableAmount.Name = "txtTaxableAmount";
            this.txtTaxableAmount.Size = new System.Drawing.Size(155, 20);
            this.txtTaxableAmount.TabIndex = 4;
            // 
            // lblTaxableAmount
            // 
            this.lblTaxableAmount.AutoSize = true;
            this.lblTaxableAmount.Location = new System.Drawing.Point(3, 5);
            this.lblTaxableAmount.Name = "lblTaxableAmount";
            this.lblTaxableAmount.Size = new System.Drawing.Size(84, 13);
            this.lblTaxableAmount.TabIndex = 3;
            this.lblTaxableAmount.Text = "Taxable Amount";
            // 
            // pnlDiscount
            // 
            this.pnlDiscount.Controls.Add(this.txtDiscount);
            this.pnlDiscount.Controls.Add(this.lblDiscount);
            this.pnlDiscount.Location = new System.Drawing.Point(882, 3);
            this.pnlDiscount.Name = "pnlDiscount";
            this.pnlDiscount.Size = new System.Drawing.Size(155, 49);
            this.pnlDiscount.TabIndex = 9;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDiscount.Location = new System.Drawing.Point(0, 29);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(155, 20);
            this.txtDiscount.TabIndex = 4;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(3, 3);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 26);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "Discount\r\n(Rs.)\r\n";
            // 
            // pnlPrice
            // 
            this.pnlPrice.Controls.Add(this.txtPrice);
            this.pnlPrice.Controls.Add(this.lblPrice);
            this.pnlPrice.Location = new System.Drawing.Point(723, 3);
            this.pnlPrice.Name = "pnlPrice";
            this.pnlPrice.Size = new System.Drawing.Size(155, 49);
            this.pnlPrice.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPrice.Location = new System.Drawing.Point(0, 29);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(155, 20);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(3, 3);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 26);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price/Item \r\n(Rs.)";
            // 
            // pnlQuantity
            // 
            this.pnlQuantity.Controls.Add(this.txtQuantity);
            this.pnlQuantity.Controls.Add(this.lblQuantity);
            this.pnlQuantity.Location = new System.Drawing.Point(564, 3);
            this.pnlQuantity.Name = "pnlQuantity";
            this.pnlQuantity.Size = new System.Drawing.Size(155, 49);
            this.pnlQuantity.TabIndex = 7;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtQuantity.Location = new System.Drawing.Point(0, 29);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(155, 20);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuantity_Validating);
            this.txtQuantity.Validated += new System.EventHandler(this.txtQuantity_Validated);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(3, 5);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // pnlHSNCode
            // 
            this.pnlHSNCode.Controls.Add(this.txtHSNCode);
            this.pnlHSNCode.Controls.Add(this.lblHSNCode);
            this.pnlHSNCode.Location = new System.Drawing.Point(405, 3);
            this.pnlHSNCode.Name = "pnlHSNCode";
            this.pnlHSNCode.Size = new System.Drawing.Size(155, 49);
            this.pnlHSNCode.TabIndex = 6;
            // 
            // txtHSNCode
            // 
            this.txtHSNCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtHSNCode.Location = new System.Drawing.Point(0, 29);
            this.txtHSNCode.Name = "txtHSNCode";
            this.txtHSNCode.Size = new System.Drawing.Size(155, 20);
            this.txtHSNCode.TabIndex = 4;
            // 
            // lblHSNCode
            // 
            this.lblHSNCode.AutoSize = true;
            this.lblHSNCode.Location = new System.Drawing.Point(3, 5);
            this.lblHSNCode.Name = "lblHSNCode";
            this.lblHSNCode.Size = new System.Drawing.Size(84, 13);
            this.lblHSNCode.TabIndex = 3;
            this.lblHSNCode.Text = "HSN/SAC Code";
            // 
            // pnlItemType
            // 
            this.pnlItemType.Controls.Add(this.cboItemType);
            this.pnlItemType.Controls.Add(this.lblItemType);
            this.pnlItemType.Location = new System.Drawing.Point(245, 3);
            this.pnlItemType.Name = "pnlItemType";
            this.pnlItemType.Size = new System.Drawing.Size(155, 49);
            this.pnlItemType.TabIndex = 5;
            // 
            // cboItemType
            // 
            this.cboItemType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboItemType.Enabled = false;
            this.cboItemType.FormattingEnabled = true;
            this.cboItemType.Items.AddRange(new object[] {
            "UTTAR PRADESH",
            "ASSAM",
            "MAHARASTRA",
            "HARYANA",
            "DELHI",
            "GOA"});
            this.cboItemType.Location = new System.Drawing.Point(0, 28);
            this.cboItemType.Name = "cboItemType";
            this.cboItemType.Size = new System.Drawing.Size(155, 21);
            this.cboItemType.TabIndex = 5;
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.Location = new System.Drawing.Point(3, 5);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(54, 13);
            this.lblItemType.TabIndex = 3;
            this.lblItemType.Text = "Item Type";
            // 
            // pnlItemName
            // 
            this.pnlItemName.Controls.Add(this.txtItemName);
            this.pnlItemName.Controls.Add(this.lblItemName);
            this.pnlItemName.Location = new System.Drawing.Point(4, 3);
            this.pnlItemName.Name = "pnlItemName";
            this.pnlItemName.Size = new System.Drawing.Size(232, 49);
            this.pnlItemName.TabIndex = 5;
            // 
            // txtItemName
            // 
            this.txtItemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItemName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtItemName.Location = new System.Drawing.Point(0, 29);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(232, 20);
            this.txtItemName.TabIndex = 4;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(3, 5);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(58, 13);
            this.lblItemName.TabIndex = 3;
            this.lblItemName.Text = "Item Name";
            // 
            // pnlPlaceofSupply
            // 
            this.pnlPlaceofSupply.Controls.Add(this.cboPlaceofSupply);
            this.pnlPlaceofSupply.Controls.Add(this.lblPlaceofSupply);
            this.pnlPlaceofSupply.Location = new System.Drawing.Point(1026, 78);
            this.pnlPlaceofSupply.Name = "pnlPlaceofSupply";
            this.pnlPlaceofSupply.Size = new System.Drawing.Size(181, 49);
            this.pnlPlaceofSupply.TabIndex = 12;
            // 
            // cboPlaceofSupply
            // 
            this.cboPlaceofSupply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboPlaceofSupply.Enabled = false;
            this.cboPlaceofSupply.FormattingEnabled = true;
            this.cboPlaceofSupply.Items.AddRange(new object[] {
            "UTTAR PRADESH",
            "ASSAM",
            "MAHARASTRA",
            "HARYANA",
            "DELHI",
            "GOA"});
            this.cboPlaceofSupply.Location = new System.Drawing.Point(0, 28);
            this.cboPlaceofSupply.Name = "cboPlaceofSupply";
            this.cboPlaceofSupply.Size = new System.Drawing.Size(181, 21);
            this.cboPlaceofSupply.TabIndex = 4;
            // 
            // lblPlaceofSupply
            // 
            this.lblPlaceofSupply.AutoSize = true;
            this.lblPlaceofSupply.Location = new System.Drawing.Point(3, 5);
            this.lblPlaceofSupply.Name = "lblPlaceofSupply";
            this.lblPlaceofSupply.Size = new System.Drawing.Size(81, 13);
            this.lblPlaceofSupply.TabIndex = 3;
            this.lblPlaceofSupply.Text = "Place of Supply";
            // 
            // pnlGSTIN
            // 
            this.pnlGSTIN.Controls.Add(this.txtGSTIN);
            this.pnlGSTIN.Controls.Add(this.lblGSTIN);
            this.pnlGSTIN.Location = new System.Drawing.Point(884, 78);
            this.pnlGSTIN.Name = "pnlGSTIN";
            this.pnlGSTIN.Size = new System.Drawing.Size(137, 49);
            this.pnlGSTIN.TabIndex = 11;
            // 
            // txtGSTIN
            // 
            this.txtGSTIN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtGSTIN.Enabled = false;
            this.txtGSTIN.Location = new System.Drawing.Point(0, 29);
            this.txtGSTIN.Name = "txtGSTIN";
            this.txtGSTIN.Size = new System.Drawing.Size(137, 20);
            this.txtGSTIN.TabIndex = 4;
            // 
            // lblGSTIN
            // 
            this.lblGSTIN.AutoSize = true;
            this.lblGSTIN.Location = new System.Drawing.Point(3, 5);
            this.lblGSTIN.Name = "lblGSTIN";
            this.lblGSTIN.Size = new System.Drawing.Size(40, 13);
            this.lblGSTIN.TabIndex = 3;
            this.lblGSTIN.Text = "GSTIN";
            // 
            // pnlShippingAddress
            // 
            this.pnlShippingAddress.Controls.Add(this.txtShippingAddress);
            this.pnlShippingAddress.Controls.Add(this.lblShippingAddress);
            this.pnlShippingAddress.Location = new System.Drawing.Point(568, 78);
            this.pnlShippingAddress.Name = "pnlShippingAddress";
            this.pnlShippingAddress.Size = new System.Drawing.Size(310, 49);
            this.pnlShippingAddress.TabIndex = 10;
            // 
            // txtShippingAddress
            // 
            this.txtShippingAddress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtShippingAddress.Enabled = false;
            this.txtShippingAddress.Location = new System.Drawing.Point(0, 29);
            this.txtShippingAddress.Name = "txtShippingAddress";
            this.txtShippingAddress.Size = new System.Drawing.Size(310, 20);
            this.txtShippingAddress.TabIndex = 7;
            // 
            // lblShippingAddress
            // 
            this.lblShippingAddress.AutoSize = true;
            this.lblShippingAddress.Location = new System.Drawing.Point(3, 5);
            this.lblShippingAddress.Name = "lblShippingAddress";
            this.lblShippingAddress.Size = new System.Drawing.Size(89, 13);
            this.lblShippingAddress.TabIndex = 3;
            this.lblShippingAddress.Text = "Shipping Address";
            // 
            // pnlBilllingAddress
            // 
            this.pnlBilllingAddress.Controls.Add(this.chkSame);
            this.pnlBilllingAddress.Controls.Add(this.lnkSave);
            this.pnlBilllingAddress.Controls.Add(this.txtBillingAddress);
            this.pnlBilllingAddress.Controls.Add(this.lkEdit);
            this.pnlBilllingAddress.Controls.Add(this.lblBillingAddress);
            this.pnlBilllingAddress.Location = new System.Drawing.Point(249, 78);
            this.pnlBilllingAddress.Name = "pnlBilllingAddress";
            this.pnlBilllingAddress.Size = new System.Drawing.Size(310, 49);
            this.pnlBilllingAddress.TabIndex = 9;
            // 
            // chkSame
            // 
            this.chkSame.AutoSize = true;
            this.chkSame.Checked = true;
            this.chkSame.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSame.Location = new System.Drawing.Point(169, 4);
            this.chkSame.Name = "chkSame";
            this.chkSame.Size = new System.Drawing.Size(138, 17);
            this.chkSame.TabIndex = 5;
            this.chkSame.Text = "Same as Billing Address";
            this.chkSame.UseVisualStyleBackColor = true;
            this.chkSame.CheckedChanged += new System.EventHandler(this.chkSame_CheckedChanged);
            // 
            // lnkSave
            // 
            this.lnkSave.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.lnkSave.AutoSize = true;
            this.lnkSave.Location = new System.Drawing.Point(89, 4);
            this.lnkSave.Name = "lnkSave";
            this.lnkSave.Size = new System.Drawing.Size(32, 13);
            this.lnkSave.TabIndex = 7;
            this.lnkSave.TabStop = true;
            this.lnkSave.Text = "Save";
            this.lnkSave.Visible = false;
            this.lnkSave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSave_LinkClicked);
            // 
            // txtBillingAddress
            // 
            this.txtBillingAddress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBillingAddress.Enabled = false;
            this.txtBillingAddress.Location = new System.Drawing.Point(0, 29);
            this.txtBillingAddress.Name = "txtBillingAddress";
            this.txtBillingAddress.Size = new System.Drawing.Size(310, 20);
            this.txtBillingAddress.TabIndex = 6;
            // 
            // lkEdit
            // 
            this.lkEdit.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.lkEdit.AutoSize = true;
            this.lkEdit.Location = new System.Drawing.Point(122, 4);
            this.lkEdit.Name = "lkEdit";
            this.lkEdit.Size = new System.Drawing.Size(25, 13);
            this.lkEdit.TabIndex = 5;
            this.lkEdit.TabStop = true;
            this.lkEdit.Text = "Edit";
            this.lkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkEdit_LinkClicked);
            // 
            // lblBillingAddress
            // 
            this.lblBillingAddress.AutoSize = true;
            this.lblBillingAddress.Location = new System.Drawing.Point(3, 5);
            this.lblBillingAddress.Name = "lblBillingAddress";
            this.lblBillingAddress.Size = new System.Drawing.Size(75, 13);
            this.lblBillingAddress.TabIndex = 3;
            this.lblBillingAddress.Text = "Billing Address";
            // 
            // pnlCustomerName
            // 
            this.pnlCustomerName.Controls.Add(this.txtCustomerName);
            this.pnlCustomerName.Controls.Add(this.lblCustomerName);
            this.pnlCustomerName.Location = new System.Drawing.Point(5, 78);
            this.pnlCustomerName.Name = "pnlCustomerName";
            this.pnlCustomerName.Size = new System.Drawing.Size(238, 49);
            this.pnlCustomerName.TabIndex = 8;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AutoCompleteCustomSource.AddRange(new string[] {
            "Rahul",
            "Avhi",
            "Alok",
            "Shashank"});
            this.txtCustomerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtCustomerName.Location = new System.Drawing.Point(0, 29);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(238, 20);
            this.txtCustomerName.TabIndex = 4;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            this.txtCustomerName.Enter += new System.EventHandler(this.txtCustomerName_Enter);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(3, 5);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // pnlDueDate
            // 
            this.pnlDueDate.Controls.Add(this.dtInvoiceDueDate);
            this.pnlDueDate.Controls.Add(this.lblDueDate);
            this.pnlDueDate.Location = new System.Drawing.Point(678, 3);
            this.pnlDueDate.Name = "pnlDueDate";
            this.pnlDueDate.Size = new System.Drawing.Size(200, 49);
            this.pnlDueDate.TabIndex = 7;
            // 
            // dtInvoiceDueDate
            // 
            this.dtInvoiceDueDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtInvoiceDueDate.Location = new System.Drawing.Point(0, 29);
            this.dtInvoiceDueDate.Name = "dtInvoiceDueDate";
            this.dtInvoiceDueDate.Size = new System.Drawing.Size(200, 20);
            this.dtInvoiceDueDate.TabIndex = 5;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(3, 5);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(53, 13);
            this.lblDueDate.TabIndex = 3;
            this.lblDueDate.Text = "Due Date";
            // 
            // pnlReference
            // 
            this.pnlReference.Controls.Add(this.txtReference);
            this.pnlReference.Controls.Add(this.lblReference);
            this.pnlReference.Location = new System.Drawing.Point(458, 3);
            this.pnlReference.Name = "pnlReference";
            this.pnlReference.Size = new System.Drawing.Size(200, 49);
            this.pnlReference.TabIndex = 6;
            // 
            // txtReference
            // 
            this.txtReference.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReference.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtReference.Location = new System.Drawing.Point(0, 29);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(200, 20);
            this.txtReference.TabIndex = 4;
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Location = new System.Drawing.Point(3, 5);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(57, 13);
            this.lblReference.TabIndex = 3;
            this.lblReference.Text = "Reference";
            // 
            // pnlInvoiceDate
            // 
            this.pnlInvoiceDate.Controls.Add(this.dtInvoiceDate);
            this.pnlInvoiceDate.Controls.Add(this.lblInvoiceDate);
            this.pnlInvoiceDate.Location = new System.Drawing.Point(222, 3);
            this.pnlInvoiceDate.Name = "pnlInvoiceDate";
            this.pnlInvoiceDate.Size = new System.Drawing.Size(200, 49);
            this.pnlInvoiceDate.TabIndex = 5;
            this.pnlInvoiceDate.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dtInvoiceDate
            // 
            this.dtInvoiceDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtInvoiceDate.Location = new System.Drawing.Point(0, 29);
            this.dtInvoiceDate.Name = "dtInvoiceDate";
            this.dtInvoiceDate.Size = new System.Drawing.Size(200, 20);
            this.dtInvoiceDate.TabIndex = 4;
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(3, 5);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(68, 13);
            this.lblInvoiceDate.TabIndex = 3;
            this.lblInvoiceDate.Text = "Invoice Date";
            // 
            // pnlInvoiceSerialNo
            // 
            this.pnlInvoiceSerialNo.Controls.Add(this.txtInvoiceNumber);
            this.pnlInvoiceSerialNo.Controls.Add(this.lblInvoiceSerialNo);
            this.pnlInvoiceSerialNo.Location = new System.Drawing.Point(5, 3);
            this.pnlInvoiceSerialNo.Name = "pnlInvoiceSerialNo";
            this.pnlInvoiceSerialNo.Size = new System.Drawing.Size(200, 49);
            this.pnlInvoiceSerialNo.TabIndex = 4;
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInvoiceNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtInvoiceNumber.Location = new System.Drawing.Point(0, 29);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(200, 20);
            this.txtInvoiceNumber.TabIndex = 4;
            this.txtInvoiceNumber.TextChanged += new System.EventHandler(this.txtInvoiceNumber_TextChanged);
            this.txtInvoiceNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtInvoiceNumber_Validating);
            this.txtInvoiceNumber.Validated += new System.EventHandler(this.txtInvoiceNumber_Validated);
            // 
            // lblInvoiceSerialNo
            // 
            this.lblInvoiceSerialNo.AutoSize = true;
            this.lblInvoiceSerialNo.Location = new System.Drawing.Point(3, 5);
            this.lblInvoiceSerialNo.Name = "lblInvoiceSerialNo";
            this.lblInvoiceSerialNo.Size = new System.Drawing.Size(111, 13);
            this.lblInvoiceSerialNo.TabIndex = 3;
            this.lblInvoiceSerialNo.Text = "Invoice Serial Number";
            // 
            // tbPreviewSalesInvoice
            // 
            this.tbPreviewSalesInvoice.Controls.Add(this.btnAddNewSaleInvoice);
            this.tbPreviewSalesInvoice.Location = new System.Drawing.Point(4, 22);
            this.tbPreviewSalesInvoice.Name = "tbPreviewSalesInvoice";
            this.tbPreviewSalesInvoice.Size = new System.Drawing.Size(1220, 518);
            this.tbPreviewSalesInvoice.TabIndex = 0;
            this.tbPreviewSalesInvoice.Text = "Preview Sales Invoice";
            this.tbPreviewSalesInvoice.UseVisualStyleBackColor = true;
            // 
            // tbViewSalesInvoice
            // 
            this.tbViewSalesInvoice.Location = new System.Drawing.Point(4, 22);
            this.tbViewSalesInvoice.Name = "tbViewSalesInvoice";
            this.tbViewSalesInvoice.Size = new System.Drawing.Size(1220, 518);
            this.tbViewSalesInvoice.TabIndex = 1;
            this.tbViewSalesInvoice.Text = "View Sales Invoice";
            this.tbViewSalesInvoice.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAddNewSaleInvoice
            // 
            this.btnAddNewSaleInvoice.Location = new System.Drawing.Point(1086, 3);
            this.btnAddNewSaleInvoice.Name = "btnAddNewSaleInvoice";
            this.btnAddNewSaleInvoice.Size = new System.Drawing.Size(128, 23);
            this.btnAddNewSaleInvoice.TabIndex = 22;
            this.btnAddNewSaleInvoice.Text = "Add Sale Invoice";
            this.btnAddNewSaleInvoice.UseVisualStyleBackColor = true;
            this.btnAddNewSaleInvoice.Click += new System.EventHandler(this.btnAddNewSaleInvoice_Click_1);
            // 
            // frmSalesInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1224, 582);
            this.Controls.Add(this.pnlInvoice);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmSalesInvoice";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSalesInvoice_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlInvoice.ResumeLayout(false);
            this.tbSalesInvoice.ResumeLayout(false);
            this.tbCreateSalesInvoice.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvDataGrid)).EndInit();
            this.pnlProduct.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlTotalAmount.ResumeLayout(false);
            this.pnlTotalAmount.PerformLayout();
            this.pnlIGSTAmount.ResumeLayout(false);
            this.pnlIGSTAmount.PerformLayout();
            this.pnlIGST.ResumeLayout(false);
            this.pnlIGST.PerformLayout();
            this.pnlISGSTAmount.ResumeLayout(false);
            this.pnlISGSTAmount.PerformLayout();
            this.pnlSGST.ResumeLayout(false);
            this.pnlSGST.PerformLayout();
            this.pnlCGSTAmount.ResumeLayout(false);
            this.pnlCGSTAmount.PerformLayout();
            this.pnlCGST.ResumeLayout(false);
            this.pnlCGST.PerformLayout();
            this.pnlTaxableAmount.ResumeLayout(false);
            this.pnlTaxableAmount.PerformLayout();
            this.pnlDiscount.ResumeLayout(false);
            this.pnlDiscount.PerformLayout();
            this.pnlPrice.ResumeLayout(false);
            this.pnlPrice.PerformLayout();
            this.pnlQuantity.ResumeLayout(false);
            this.pnlQuantity.PerformLayout();
            this.pnlHSNCode.ResumeLayout(false);
            this.pnlHSNCode.PerformLayout();
            this.pnlItemType.ResumeLayout(false);
            this.pnlItemType.PerformLayout();
            this.pnlItemName.ResumeLayout(false);
            this.pnlItemName.PerformLayout();
            this.pnlPlaceofSupply.ResumeLayout(false);
            this.pnlPlaceofSupply.PerformLayout();
            this.pnlGSTIN.ResumeLayout(false);
            this.pnlGSTIN.PerformLayout();
            this.pnlShippingAddress.ResumeLayout(false);
            this.pnlShippingAddress.PerformLayout();
            this.pnlBilllingAddress.ResumeLayout(false);
            this.pnlBilllingAddress.PerformLayout();
            this.pnlCustomerName.ResumeLayout(false);
            this.pnlCustomerName.PerformLayout();
            this.pnlDueDate.ResumeLayout(false);
            this.pnlDueDate.PerformLayout();
            this.pnlReference.ResumeLayout(false);
            this.pnlReference.PerformLayout();
            this.pnlInvoiceDate.ResumeLayout(false);
            this.pnlInvoiceDate.PerformLayout();
            this.pnlInvoiceSerialNo.ResumeLayout(false);
            this.pnlInvoiceSerialNo.PerformLayout();
            this.tbPreviewSalesInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.Panel pnlInvoice;
        private System.Windows.Forms.TabControl tbSalesInvoice;
        private System.Windows.Forms.TabPage tbCreateSalesInvoice;
        private System.Windows.Forms.TabPage tbPreviewSalesInvoice;
        private System.Windows.Forms.TabPage tbViewSalesInvoice;
        private System.Windows.Forms.Label lblInvoiceSerialNo;
        private System.Windows.Forms.Panel pnlInvoiceSerialNo;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.Panel pnlInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Panel pnlDueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Panel pnlReference;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.DateTimePicker dtInvoiceDate;
        private System.Windows.Forms.DateTimePicker dtInvoiceDueDate;
        private System.Windows.Forms.Panel pnlCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Panel pnlBilllingAddress;
        private System.Windows.Forms.Label lblBillingAddress;
        private System.Windows.Forms.Panel pnlShippingAddress;
        private System.Windows.Forms.Label lblShippingAddress;
        private System.Windows.Forms.LinkLabel lkEdit;
        private System.Windows.Forms.Panel pnlPlaceofSupply;
        private System.Windows.Forms.Label lblPlaceofSupply;
        private System.Windows.Forms.Panel pnlGSTIN;
        private System.Windows.Forms.TextBox txtGSTIN;
        private System.Windows.Forms.Label lblGSTIN;
        private System.Windows.Forms.ComboBox cboPlaceofSupply;
        private System.Windows.Forms.TextBox txtBillingAddress;
        private System.Windows.Forms.TextBox txtShippingAddress;
        private System.Windows.Forms.CheckBox chkSame;
        private System.Windows.Forms.LinkLabel lnkSave;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnViewData;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.Panel pnlTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Panel pnlIGSTAmount;
        private System.Windows.Forms.TextBox txtIGSTAmount;
        private System.Windows.Forms.Label lblIGSTAmount;
        private System.Windows.Forms.Panel pnlIGST;
        private System.Windows.Forms.ComboBox cboIGSTRate;
        private System.Windows.Forms.Label lblIGSTRate;
        private System.Windows.Forms.Panel pnlISGSTAmount;
        private System.Windows.Forms.TextBox txtSGSTAmount;
        private System.Windows.Forms.Label lblSGSTAmount;
        private System.Windows.Forms.Panel pnlSGST;
        private System.Windows.Forms.ComboBox cboSGSTRate;
        private System.Windows.Forms.Label lblSGSTRate;
        private System.Windows.Forms.Panel pnlCGSTAmount;
        private System.Windows.Forms.TextBox txtCGSTAmount;
        private System.Windows.Forms.Label lblCGSTAmount;
        private System.Windows.Forms.Panel pnlCGST;
        private System.Windows.Forms.ComboBox cboCGSTRate;
        private System.Windows.Forms.Label lblCGSTRate;
        private System.Windows.Forms.Panel pnlTaxableAmount;
        private System.Windows.Forms.TextBox txtTaxableAmount;
        private System.Windows.Forms.Label lblTaxableAmount;
        private System.Windows.Forms.Panel pnlDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Panel pnlPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel pnlQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Panel pnlHSNCode;
        private System.Windows.Forms.TextBox txtHSNCode;
        private System.Windows.Forms.Label lblHSNCode;
        private System.Windows.Forms.Panel pnlItemType;
        private System.Windows.Forms.ComboBox cboItemType;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.Panel pnlItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.DataGridView grvDataGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkReverseCharge;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTotalAmountBeforeTax;
        private System.Windows.Forms.Label lblTotalCGSTAmount;
        private System.Windows.Forms.Label lblTotalSGSTAmount;
        private System.Windows.Forms.Label lblTotalIGSTAmount;
        private System.Windows.Forms.Label lblTotalTaxAmount;
        private System.Windows.Forms.Label lblTotalAmountIncludingGST;
        private System.Windows.Forms.Label lblTotalReverseCharge;
        private System.Windows.Forms.Label lblTotalAmountBeforeTaxValue;
        private System.Windows.Forms.Label lblTotalCGSTAmountValue;
        private System.Windows.Forms.Label lblTotalSGSTAmountValue;
        private System.Windows.Forms.Label lblTotalIGSTAmountValue;
        private System.Windows.Forms.Label lblTotalTaxAmountValue;
        private System.Windows.Forms.Label lblTotalAmountIncludingTaxValue;
        private System.Windows.Forms.Label lblTotalReverseChargeValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewLinkColumn lnkUpdate;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.Button btnAddNewSaleInvoice;
    }
}

