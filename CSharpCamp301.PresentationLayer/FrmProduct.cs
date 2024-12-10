using CSharpCamp301.BusinessLayer.Abstract;
using CSharpCamp301.BusinessLayer.Concrete;
using CSharpCamp301.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCamp301.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        public FrmProduct()
        {            
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProcutId.Text);
            var product = _productService.TGetById(id);
            _productService.TDelete(product);
        }

        private void btnlist2_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource = values;
        }
    }
}
