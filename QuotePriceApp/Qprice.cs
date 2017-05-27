using Aspose.Words;
using Aspose.Words.Reporting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfirmationApp
{
    public partial class Qprice : Form
    {

        public string QuoteCurrentName = string.Empty;
   
        public Qprice()
        {
            InitializeComponent();

            var data = QuoteNames.GetNames();
            cmbQuoteNames.DataSource = data;
            cmbQuoteNames.DisplayMember = "Name";
            cmbQuoteNames.ValueMember = "Tel";
        }


        private void btnConfir_Click(object sender, EventArgs e)
        {

            var isCheck = CheckTxt();
            if (!isCheck)
            {
                return;
            }

            var isWork = DoWork();
            if (!isWork)
            {
                MessageBox.Show("很遗憾，生成失败，联系管理员");
                return;
            }

            MessageBox.Show("恭喜您,已生成！");
        }

        /// <summary>
        /// 验证填写
        /// </summary>
        /// <returns></returns>
        private bool CheckTxt()
        {
            if (string.IsNullOrEmpty(txtCustomerName.Text.Trim()))
            {
                MessageBox.Show("报价单位不为空！");
                return false;
            }
            if (string.IsNullOrEmpty(txtUnits.Text.Trim()))
            {
                MessageBox.Show("报价单位不为空！");
                return false;
            }

            if (string.IsNullOrEmpty(rtbOrderRecord.Text.Trim()))
            {
                MessageBox.Show("预定记录不为空！");
                return false;
            }
            if (string.IsNullOrEmpty(rtbPrice.Text.Trim()))
            {
                MessageBox.Show("机票价格不为空！");
                return false;
            }

            if (string.IsNullOrEmpty(rtbLimiting.Text.Trim()))
            {
                MessageBox.Show("限制条件不为空！");
                return false;
            }
            
            if (string.IsNullOrEmpty(txtQuoteTel.Text.Trim()))
            {

                MessageBox.Show("报价人电话不为空！");
                return false;
            }
            return true;
        }

        private bool DoWork()
        {
            try
            {
                string tempPath = AppDomain.CurrentDomain.BaseDirectory + "tools\\temp\\";               
           string outFilePath = AppDomain.CurrentDomain.BaseDirectory + "tools\\pdf\\";
                Document doc = new Document(tempPath + "\\QuotePrice.doc");

                String[] partInfoNames = new String[]
                    {
                        "CustomerName","Data","EnterpriseName","Record","TicketPrice","Limit","Contacts","Telephone"
                    };
                Object[] partInfoValues = new Object[]
                    {
                         txtCustomerName.Text.Trim(), DateTime.Now.ToString("yyyy-MM-dd HH:mm"),txtUnits.Text.Trim(),rtbOrderRecord.Text.Trim(),
                          rtbPrice.Text.Trim(),rtbLimiting.Text.Trim(),cmbQuoteNames.Text,txtQuoteTel.Text.Trim()
                    };

                //替换模板参数
                doc.MailMerge.Execute(partInfoNames, partInfoValues);
                doc.MailMerge.CleanupOptions = MailMergeCleanupOptions.RemoveEmptyParagraphs;
                string fileName = String.Concat(outFilePath+cmbQuoteNames.Text,"_",txtCustomerName.Text.Trim(), DateTime.Now.ToString("yyyyMMddHHmmss"), ".pdf");
               
                doc.Save(fileName, SaveFormat.Pdf);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void cmbQuoteNames_SelectedValueChanged(object sender, EventArgs e)
        {

            txtQuoteTel.Text = cmbQuoteNames.SelectedValue.ToString();
           // QuoteCurrentName = cmbQuoteNames.Text;
        }
    }
}
