using System.Text;

namespace FoodMenu
{
    public partial class StartForm : Form
    {
        private StringBuilder typeMan;
        private StringBuilder typeMeal;
        
        public string TypeMan
        {
            get { return typeMan.ToString(); }
        }
        public  string TypeMeal
        {
            get { return typeMeal.ToString(); }
        }
        public StartForm() => InitializeComponent();
        private void StartForm_Load(object sender, EventArgs e)
        {
            typeMan = new StringBuilder();
            typeMeal = new StringBuilder();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(typeMan.ToString()) || string.IsNullOrEmpty(typeMeal.ToString()))
            {
                MessageBox.Show("Оберіть дані у двох колонках!", "Помилка!");
            }
            else
            {
                Form itemsForm = new ItemsForm();
                itemsForm.Owner = this;
                itemsForm.Show();
                this.Hide();
            }
        }

        private void radBtnMeat_CheckedChanged(object sender, EventArgs e)
        {
            typeMan.Clear();
            typeMan.Append(radBtnMeat.Text);
        }

        private void radBtnVegetar_CheckedChanged(object sender, EventArgs e)
        {
            typeMan.Clear();
            typeMan.Append(radBtnVegetar.Text);
        }

        private void radBtnVegan_CheckedChanged(object sender, EventArgs e)
        {
            typeMan.Clear();
            typeMan.Append(radBtnVegetar.Text);
        }

        private void radBtnBreakf_CheckedChanged(object sender, EventArgs e)
        {
            typeMeal.Clear();
            typeMeal.Append(radBtnBreakf.Text);
        }

        private void radBtnLunch_CheckedChanged(object sender, EventArgs e)
        {
            typeMeal.Clear();
            typeMeal.Append(radBtnLunch.Text);
        }

        private void radBtnDinner_CheckedChanged(object sender, EventArgs e)
        {
            typeMeal.Clear();
            typeMeal.Append(radBtnDinner.Text);
        }

        private void radBtnSnack_CheckedChanged(object sender, EventArgs e)
        {
            typeMeal.Clear();
            typeMeal.Append(radBtnSnack.Text);
        }
    }
}