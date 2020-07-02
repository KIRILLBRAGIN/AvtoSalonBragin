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
    public partial class FormAvailability : Form
    {

        void ShowAvailability()
        {
            //Предварительно очищаем listView
            listViewAvailability.Items.Clear();
            //Проходимся по коллекции наличия, которые находятся в базе с помощью foreach
            foreach (AvailabilitySet availabilitySet in Program.avtosalon.AvailabilitySet)
            {
                //создаем новый элемент в listView
                //для этого создаем новый массив строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    availabilitySet.Id.ToString(),
                    availabilitySet.IdFirm.ToString(),
                    availabilitySet.FirmsSet.NameFirm,
                    availabilitySet.IdCar.ToString(),
                    availabilitySet.CarsSet.Model + " "  + availabilitySet.CarsSet.Color,
                });
                //указываем по какому тегу будем брать элементы
                item.Tag = availabilitySet;
                //добавляем элементы в listView для отображения
                listViewAvailability.Items.Add(item);
            }
            listViewAvailability.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void ShowFirms()
        {
            comboBoxFirms.Items.Clear();
            foreach (FirmsSet firms in Program.avtosalon.FirmsSet)
            {
                string[] item = { firms.IdFirm.ToString() + ". ", firms.NameFirm };
                comboBoxFirms.Items.Add(string.Join(" ", item));
            }
        }

        void ShowCars()
        {
            comboBoxCars.Items.Clear();
            foreach (CarsSet cars in Program.avtosalon.CarsSet)
            {
                string[] item = { cars.IdCar.ToString() + ". ", cars.Model + " " + cars.Color };
                comboBoxCars.Items.Add(string.Join(" ", item));
            }
        }

        public FormAvailability()
        {
            InitializeComponent();
            ShowAvailability();
            ShowFirms();
            ShowCars();
        }



        private void FormAvailability_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxFirms.SelectedItem != null && comboBoxCars.SelectedItem != null)
                {
                    //Создаем новый экземпляр класса автомобили
                    AvailabilitySet availabilitySet = new AvailabilitySet();
                    //Делаем ссылку на объект, который хранится в textBox-ax
                    availabilitySet.IdFirm = Convert.ToInt32(comboBoxFirms.SelectedItem.ToString().Split('.')[0]);
                    availabilitySet.IdCar = Convert.ToInt32(comboBoxCars.SelectedItem.ToString().Split('.')[0]);
                    //Добавляем в таблицу CarsSet новый автомобиль carSet
                    Program.avtosalon.AvailabilitySet.Add(availabilitySet);
                    //Сохраняем изменения в модели avtosalon (экземпляр которой был создан ранее)
                    Program.avtosalon.SaveChanges();
                    ShowAvailability();
                }
                else MessageBox.Show("Поля не заполнены! Проверьте и повторите попытку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //условие, если в listView выбран 1 элемент
                if (listViewAvailability.SelectedItems.Count == 1)
                {
                    if (comboBoxFirms.SelectedItem != null && comboBoxCars.SelectedItem != null)
                    { }
                    //ищем элемент из таблицы по тегу
                    AvailabilitySet availabilitySet = listViewAvailability.SelectedItems[0].Tag as AvailabilitySet;
                    //указываем, что может быть изменено
                    availabilitySet.IdFirm = Convert.ToInt32(comboBoxFirms.SelectedItem.ToString().Split('.')[0]);
                    availabilitySet.IdCar = Convert.ToInt32(comboBoxFirms.SelectedItem.ToString().Split('.')[0]);
                    //Сохраняем изменения в модели avtosalon (экземпляр которой был создан ранее)
                    Program.avtosalon.SaveChanges();
                    ShowAvailability();
                }
                else MessageBox.Show("Поля не заполнены! Проверьте и повторите попытку.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                //если выбран 1 элемент из listView
                if (listViewAvailability.SelectedItems.Count == 1)
                {
                    //ищем этот элемент
                    AvailabilitySet availabilitySet = listViewAvailability.SelectedItems[0].Tag as AvailabilitySet;
                    //удаляем из модели и базы данных
                    Program.avtosalon.AvailabilitySet.Remove(availabilitySet);
                    //сохраняем изменения
                    Program.avtosalon.SaveChanges();
                    //отображаем обновленный список
                    ShowAvailability();
                }
                //очищаем textBox-ы
                comboBoxFirms.SelectedItem = null;
                comboBoxCars.SelectedItem = null;
            }
            catch
            {
                //вызываем метод для всплывающего окна, в котором указываем текст, заголовок, кнопку и иконку
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewAvailability_SelectedIndexChanged(object sender, EventArgs e)
        {
            //условие, если выбран 1 элемент
            if (listViewAvailability.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                AvailabilitySet availabilitySet = listViewAvailability.SelectedItems[0].Tag as AvailabilitySet;
                //указываем, что может быть изменено
                comboBoxFirms.SelectedIndex = comboBoxFirms.FindString(availabilitySet.IdFirm.ToString());
                comboBoxCars.SelectedIndex = comboBoxCars.FindString(availabilitySet.IdCar.ToString());
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                comboBoxFirms.SelectedItem = null;
                comboBoxCars.SelectedItem = null;
            }
        }
    }
}
