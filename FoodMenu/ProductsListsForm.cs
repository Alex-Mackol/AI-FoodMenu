using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodMenu
{
    public partial class ProductsListsForm : Form
    {
        ItemsForm itemsForm;
        List<string> productsList = new List<string>();
        public ProductsListsForm()
        {
            InitializeComponent();

            productsList.Clear();
            checkedProductsListBox.CheckOnClick = true;
        }

        private void ProductsListsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            productsList.Clear();
            for (int i = 0; i < checkedProductsListBox.CheckedItems.Count; i++)
            {
                productsList.Add(checkedProductsListBox.CheckedItems[i].ToString());
            }
            var itemList = itemsForm.ProductsList.Items.Cast<String>().ToList();
            foreach (string item in productsList)
            {
                if (!itemList.Contains(item))
                {
                    itemsForm.ProductsList.Items.Add(item);
                }
            }
        }

        private void ProductsListsForm_Load(object sender, EventArgs e)
        {
            itemsForm = (ItemsForm)this.Owner;
            if (itemsForm.ProductsList.Items.Count > 0)
            {
                var itemList = itemsForm.ProductsList.Items.Cast<String>().ToList();
                foreach (string item in itemList)
                {
                    int index = checkedProductsListBox.FindString(item);
                    if (index != -1)
                        checkedProductsListBox.SetItemChecked(index, true);
                }
            }
        }
    }
}
