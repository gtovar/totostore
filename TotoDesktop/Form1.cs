using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BussinesLogicLayer;

namespace TotoDesktop
{
    public partial class Form1 : Form
    {
        EProduct product = new EProduct();
        BOProduct Product = new BOProduct();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string result;
            try
            {
                product.Name = txtNameProduct.Text;
                product.Description = txtDescriptionProduct.Text;
                product.Price = numBox.Value;
                product.Demand = chkDemand.Checked;
                result = Product.Create(product);
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                UpdateFormAfterCreate();
            }
        }

        private void UpdateFormAfterCreate()
        {
            txtNameProduct.Clear();
            txtDescriptionProduct.Clear();
            numBox.Value = numBox.Minimum;
            chkDemand.Checked = false;
            FillComboBox(Product.ReadAllProducts(),cmbProducts,"Name","IdProduct");
            FillComboBox(Product.GetAllProducts(),cmbProducts2,"Name","IdProduct");
            txtNameProduct.Focus();
        }

        private ComboBox FillComboBox(DataTable dataTable, ComboBox comboBox, string displayMember,string valueMember)
        {
            comboBox.DataSource = dataTable;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            return comboBox;
        }

        private void cmbProducts_DataSourceChanged(object sender, EventArgs e)
        {
            txtTest.Text = Convert.ToString(Product.CountAllProducts());
            MessageBox.Show("Products Updates");
        }



    }
}
