using Lab_8;
using System.Diagnostics;

namespace Lab_8
{
    public partial class Form1 : Form
    {
        private int MIN_PRICE = 100;
        private int MAX_PRICE = 10000;

        private int MAX_CNT = 100;
        private int MIN_CNT = 1;

        private Presenter _presenter;

        public Form1()
        {
            InitializeComponent();
            _presenter = new Presenter(this);
        }
        //Функция, обрабатывающая нажатие кнопки "Редактировать"
        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                String inputData = nameSelector.Text + " " + newPrice.Value.ToString() + " " +
                newCntUsers.Value.ToString();
                _presenter.update(inputData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Функция, обрабатывающая нажатие кнопки "Удалить"
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                String name = nameSelector.Text;
                _presenter.remove(name);
                nameSelector.Items.RemoveAt(0);
                clearAllFields(nameSelector, newPrice, newCntUsers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Функция для очистки полей цены и кол-ва пользователей
        public void clearPriceAndCnt(NumericUpDown price, NumericUpDown cntUsers)
        {
            price.Value = MIN_PRICE;
            cntUsers.Value = MIN_CNT;
        }

        //Функция для очистки всех полей
        public void clearAllFields(TextBox name, NumericUpDown price, NumericUpDown cntUsers)
        {
            name.Text = "";
            clearPriceAndCnt(price, cntUsers);
        }

        public void clearAllFields(ComboBox name, NumericUpDown price, NumericUpDown cntUsers)
        {
            name.SelectedIndex = -1;
            name.Text = "";
            clearPriceAndCnt(price, cntUsers);
        }

        //Функция для обработки выбора из списка интернет операторов
        private void nameSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            var answer = _presenter.get(nameSelector.Text);
            newPrice.Value = answer.Item1;
            newCntUsers.Value = answer.Item2;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                String inputData = nameBox.Text + " " + price.Value.ToString() + " " +
                    cntUsers.Value.ToString();
                _presenter.add(inputData);
                clearAllFields(nameBox, price, cntUsers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateData(InternerOperatorList dataBase)
        {
            clearAllFields(nameSelector, newPrice, newCntUsers);
            nameSelector.Items.Clear();
            foreach (var element in dataBase)
            {
                nameSelector.Items.Add(element.NameOperator);
            }
        }

    }
}

