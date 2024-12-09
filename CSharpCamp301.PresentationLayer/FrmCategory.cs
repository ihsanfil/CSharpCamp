﻿using CSharpCamp301.BusinessLayer.Abstract;
using CSharpCamp301.BusinessLayer.Concrete;
using CSharpCamp301.DataAccessLayer.EntityFramework;
using CSharpCamp301.EntityLayer.Concrete;
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
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCateogryName.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
            MessageBox.Show("Ekleme başarılı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtKategorId.Text);
            var daletedValue = _categoryService.TGetById(id);
            _categoryService.TDelete(daletedValue);
            MessageBox.Show("Silme başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updatedId = int.Parse(txtKategorId.Text);
            var updatedValue = _categoryService.TGetById(updatedId);
            updatedValue.CategoryName = txtCateogryName.Text;
            updatedValue.CategoryStatus = true;
            _categoryService.TUpdate(updatedValue);
            MessageBox.Show("Güncelleme başarılı");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtKategorId.Text);
            var value = _categoryService.TGetById(id);
            dataGridView1.DataSource = value;
        }
    }
}
