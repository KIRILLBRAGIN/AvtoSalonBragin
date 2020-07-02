using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvtoSalon
{
    public partial class FormCars : Form
    {

        void ShowCars()
        {
            //Предварительно очищаем listView
            listViewCars.Items.Clear();
            //Проходимся по коллекции фирм, которые находятся в базе с помощью foreach
            foreach (CarsSet carSet in Program.avtosalon.CarsSet)
            {
                //создаем новый элемент в listView
                //для этого создаем новый массив строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    carSet.IdCar.ToString(),
                    carSet.Model,
                    carSet.Color,
                    carSet.Price.ToString(),
                    carSet.GosNumber,
                    carSet.Release_Year.ToString()
                });
                //указываем по какому тегу будем брать элементы
                item.Tag = carSet;
                //добавляем элементы в listView для отображения
                listViewCars.Items.Add(item);
            }
            listViewCars.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public FormCars()
        {
            InitializeComponent();
            ShowCars();
        }

        private void FormCars_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //Создаем новый экземпляр класса автомобили
                CarsSet carSet = new CarsSet();
                //Делаем ссылку на объект, который хранится в textBox-ax
                carSet.Model = textBoxModel.Text;
                carSet.Color = comboBoxColor.Text;
                carSet.Price = Convert.ToInt64(textBoxPrice.Text);
                carSet.GosNumber = maskedTextBoxGosNumber.Text;
                carSet.Release_Year = Convert.ToInt32(maskedTextBoxYearRelase.Text);
                //Добавляем в таблицу CarsSet новый автомобиль carSet
                Program.avtosalon.CarsSet.Add(carSet);
                //Сохраняем изменения в модели avtosalon (экземпляр которой был создан ранее)
                Program.avtosalon.SaveChanges();
                ShowCars();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //условие, если в listView выбран 1 элемент
                if (listViewCars.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    CarsSet carSet = listViewCars.SelectedItems[0].Tag as CarsSet;
                    //указываем, что может быть изменено
                    carSet.Model = textBoxModel.Text;
                    carSet.Color = comboBoxColor.Text;
                    carSet.Price = Convert.ToInt64(textBoxPrice.Text);
                    carSet.GosNumber = maskedTextBoxGosNumber.Text;
                    carSet.Release_Year = Convert.ToInt32(maskedTextBoxYearRelase.Text);
                    //Сохраняем изменения в модели avtosalon (экземпляр которой был создан ранее)
                    Program.avtosalon.SaveChanges();
                    ShowCars();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                //если выбран 1 элемент из listView
                if (listViewCars.SelectedItems.Count == 1)
                {
                    //ищем этот элемент
                    CarsSet carSet = listViewCars.SelectedItems[0].Tag as CarsSet;
                    //удаляем из модели и базы данных
                    Program.avtosalon.CarsSet.Remove(carSet);
                    //сохраняем изменения
                    Program.avtosalon.SaveChanges();
                    //отображаем обновленный список
                    ShowCars();
                }
                //очищаем textBox-ы
                textBoxModel.Text = "";
                comboBoxColor.Text = "";
                textBoxPrice.Text = "";
                maskedTextBoxGosNumber.Text = "";
                maskedTextBoxYearRelase.Text = "";
            }
            catch
            {
                //вызываем метод для всплывающего окна, в котором указываем текст, заголовок, кнопку и иконку
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            //условие, если выбран 1 элемент
            if (listViewCars.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                CarsSet carSet = listViewCars.SelectedItems[0].Tag as CarsSet;
                //указываем, что может быть изменено
                textBoxModel.Text = carSet.Model;
                comboBoxColor.Text = carSet.Color;
                textBoxPrice.Text = carSet.Price.ToString();
                maskedTextBoxGosNumber.Text = carSet.GosNumber;
                maskedTextBoxYearRelase.Text = carSet.Release_Year.ToString();
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                textBoxModel.Text = "";
                comboBoxColor.Text = "";
                textBoxPrice.Text = "";
                maskedTextBoxGosNumber.Text = "";
                maskedTextBoxYearRelase.Text = "";
            }
        }

        private void textBoxPrice_TextChanged(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace 
            {
                e.Handled = true;
            }
        }
    }
}
