using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBClient
{
    public partial class info_QueryBuilder : Form
    {
        public info_QueryBuilder()
        {
            InitializeComponent();
            infoText.Text = @"            
            Добро пожаловать в мастер запросов DBClient!

            Конструктор запросов позволяет вам получать данные, исходя из выбранных параметров и условий. Вы можете как выбрать все данные из определенной таблицы, так и получить конкретные, выбрав поле в соответствующем окне выбора
            Выполнение запросов происходит в 2 этапа: Проектирование запроса и непосредственно его выполнение

            Проектирование запроса:
        1.  Выберите сущность (объект), к которой вы будете обращаться;
        2.  Укажите искомые данные (это может быть как конкретное поле таблицы, так и все данные);
        3.  Задайте условие поиска, заполнив поля 'в случае', 'знак' и 'значение';
        4.  При необходимости вы можете конкретизировать запрос и указать дополнительные условия
            Для этого:
           4.1.    Выберите запрос, который хотите конкретизировать, нажав на ключевое поле слева;
           4.2.    Добавьте новое условие, выбрав параметр 'AND' или 'OR';
           4.3.    В окне запросов появится дополнительное условие;
    
           Выполнение запроса:
        1.  Выберите запрос, который хотите выполнить, нажав на ключевое поле слева;
        2.  При необходимости также выберите дополнительные условия, если они были созданы;
        3.  Нажмите на кнопку 'Выполнить';
        4.  Результат выполнения запроса отобразится в окне 'Результат выполнения запроса'.

           Вы можете создавать одновременно несколько запросов, однако выполнять их следует поэтапно, в соответствие с синтаксисом языка MS SQL. Если запрос составлен некорректно, будет показано соответствующее уведомление.

";
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ChangeStyle()                                                                     //Changing application style
        {
            foreach (Control item in Controls)
            {
                if (item is Panel && item.Name.Contains("Header"))
                {
                    item.BackColor = MainForm.appColor;
                    if (MainForm.appColor == Color.FromArgb(228, 231, 235)) { minimizeButton.Image = Properties.Resources.darkMinimizeIcon; exitButton.Image = Properties.Resources.darkCloseIcon; appName.ForeColor = Color.FromArgb(37, 46, 59); appLogo.Image = Properties.Resources.promekzLogoGray; }
                    else { minimizeButton.Image = Properties.Resources.minimizeIcon; exitButton.Image = Properties.Resources.closeIcon; appName.ForeColor = Color.White; appLogo.Image = Properties.Resources.promekzAppLogo; }
                }
                if (item is PictureBox)
                    item.BackColor = MainForm.appColor;
            }
        }

        private void info_QueryBuilder_VisibleChanged(object sender, EventArgs e)
        {
            ChangeStyle();
        }
    }
}
