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
    public partial class ItemsForm : Form
    {
        StartForm startForm;
        private string typeMan;
        private string typeMeal;
        ProductsListsForm productsListsForm;
        private StringBuilder time;


        private string[] diaryPrList;
        private string[] cerealsList;
        private string[] meatList;
        private string[] vetFruitList;
        private string[] breadsList;
        private string[] spicesList;

        public ItemsForm()
        {
            InitializeComponent();

            productsListsForm = new ProductsListsForm();
            time = new StringBuilder();
        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            startForm = (StartForm)Owner;
            lblTypeMeal.Text = startForm.TypeMan;
            lblTypeMan.Text = startForm.TypeMeal;

            diaryPrList = new string[] { "Молоко", "Масло", "Кефір", "Сметана", "Творог" };
            cerealsList = new string[] { "Гречка", "Рис", "Ячня", "Пшоно", "Кукурзна каша", "Картопля" };
            meatList = new string[] { "Курка", "Індичка", "Яйця", "Свинина", "Телятина", "Судак", "Форель", "Скумбрія", "Дорада" };
            vetFruitList = new string[] { "Помідор","Огурок","Селера","Баклажан","Кабачок","Редиска","Морква","Капуста","Гарбуз",
                "Буряк", "Кріп","Листя салату","Петрушка","Яблуко","Банан","Груша","Вишня","Черешня","Цитрусові","Ананас","Диня",
                "Кавун","Полуниця","Чорниця","Ожина"};
            breadsList = new string[] { "Білий", "Чорний", "Хлібці" };
            spicesList = new string[] { "Сахар", "Перець", "Сіль", "Кориця", "Прованські трави" };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDiaryPr_Click(object sender, EventArgs e)
        {
            OpenProductListsForm(btnDiaryPr.Text, diaryPrList);
        }

        private void btnCereals_Click(object sender, EventArgs e)
        {
            OpenProductListsForm(btnCereals.Text, cerealsList);
        }

        private void btnMeat_Click(object sender, EventArgs e)
        {
            OpenProductListsForm(btnMeat.Text, meatList);
        }

        private void btnVetFruit_Click(object sender, EventArgs e)
        {
            OpenProductListsForm(btnVetFruit.Text, vetFruitList);
        }

        private void btnBread_Click(object sender, EventArgs e)
        {
            OpenProductListsForm(btnBread.Text, breadsList);
        }

        private void btnSpices_Click(object sender, EventArgs e)
        {
            OpenProductListsForm(btnSpices.Text, spicesList);
        }
        private void OpenProductListsForm(string productsGroup, string[] arrayProducts)
        {
            productsListsForm.Owner = this;
            productsListsForm.lblProducts.Text = productsGroup;
            productsListsForm.checkedProductsListBox.Items.Clear();
            productsListsForm.checkedProductsListBox.Items.AddRange(arrayProducts);
            productsListsForm.ShowDialog();
        }

        private void radBtnTime_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            time.Clear();
            time.Append(radioButton.Text);
        }

        private void ProductsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(ProductsList.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show("Бажаєте видалити продукт?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ProductsList.Items.Remove(ProductsList.SelectedItem);
                }
            }
        }
    }
}
