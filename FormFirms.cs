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
    public partial class FormFirms : Form
    {
        void ShowFirms()
        {
            //Предварительно очищаем listView
            listViewFirms.Items.Clear();
            //Проходимся по коллекции фирм, которые находятся в базе с помощью foreach
            foreach (FirmsSet firmSet in Program.avtosalon.FirmsSet)
            {
                //создаем новый элемент в listView
                //для этого создаем новый массив строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    firmSet.IdFirm.ToString(),
                    firmSet.NameFirm,
                    firmSet.Address_StreetHome + ", г." + firmSet.Adress_City,
                    firmSet.Phone,
                });
                //указываем по какому тегу будем брать элементы
                item.Tag = firmSet;
                //добавляем элементы в listView для отображения
                listViewFirms.Items.Add(item);
            }
            listViewFirms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public FormFirms()
        {
            InitializeComponent();
            ShowFirms();
        }

        private void FormFirms_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //Создаем новый экземпляр класса Фирмы
                FirmsSet firmsSet = new FirmsSet();
                //Делаем ссылку на объект, который хранится в textBox-ax
                firmsSet.NameFirm = textBoxNameFirm.Text;
                firmsSet.Address_StreetHome = textBoxAddress.Text;
                firmsSet.Adress_City = textBoxCity.Text;
                firmsSet.Phone = textBoxPhone.Text;
                //Добавляем в таблицу FirmsSet новую фирму firmsSet
                Program.avtosalon.FirmsSet.Add(firmsSet);
                //Сохраняем изменения в модели avtosalon (экземпляр которой был создан ранее)
                Program.avtosalon.SaveChanges();
                ShowFirms();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //условие, если в listView выбран 1 элемент
                if (listViewFirms.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    FirmsSet firmsSet = listViewFirms.SelectedItems[0].Tag as FirmsSet;
                    //указываем, что может быть изменено
                    firmsSet.NameFirm = textBoxNameFirm.Text;
                    firmsSet.Address_StreetHome = textBoxAddress.Text;
                    firmsSet.Adress_City = textBoxCity.Text;
                    firmsSet.Phone = textBoxPhone.Text;
                    //Сохраняем изменения в модели avtosalon (экземпляр которой был создан ранее)
                    Program.avtosalon.SaveChanges();
                    ShowFirms();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                //если выбран 1 элемент из listView
                if (listViewFirms.SelectedItems.Count == 1)
                {
                    //ищем этот элемент
                    FirmsSet firmSet = listViewFirms.SelectedItems[0].Tag as FirmsSet;
                    //удаляем из модели и базы данных
                    Program.avtosalon.FirmsSet.Remove(firmSet);
                    //сохраняем изменения
                    Program.avtosalon.SaveChanges();
                    //отображаем обновленный список
                    ShowFirms();
                }
                //очищаем textBox-ы
                textBoxNameFirm.Text = "";
                textBoxAddress.Text = "";
                textBoxCity.Text = "";
                textBoxPhone.Text = "";
            }
            catch
            {
                //вызываем метод для всплывающего окна, в котором указываем текст, заголовок, кнопку и иконку
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewFirms_SelectedIndexChanged(object sender, EventArgs e)
        {
            //условие, если выбран 1 элемент
            if (listViewFirms.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                FirmsSet firmsSet = listViewFirms.SelectedItems[0].Tag as FirmsSet;
                //указываем, что может быть изменено
                textBoxNameFirm.Text = firmsSet.NameFirm;
                textBoxAddress.Text = firmsSet.Address_StreetHome;
                textBoxCity.Text = firmsSet.Adress_City;
                textBoxPhone.Text = firmsSet.Phone;
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                textBoxNameFirm.Text = "";
                textBoxAddress.Text = "";
                textBoxCity.Text = "";
                textBoxPhone.Text = "";
            }
        }
    }
}
