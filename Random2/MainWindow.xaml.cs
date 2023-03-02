using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Random2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            
            Random rnd = new Random();
            string[] a = { "Анн Эльвира", "Береснев Некита", "Бровкина Злата", "Бунчуков Леонид", "Воспищева Мария", "Козлов Матвей", "Косякин Денис", "Крымов Евгений", "Пролыгин Даниил", "Поддельщиков Роман", "Бондарев Даниил", "Сильянова Елизовета", "Кузнецова Ульяна", "Тарасова Кристина", "Черенков Владимир", "Чванов Артем", "Зуйков Иван Максимович", "Зубарев Максим", "Сазонов Станислав", "Рыжиков Дмитрий", "Степанов Артем", "Рогожин Кирилл", "Колюжный Даниил", "Федосеев Даниил", "Лукьянчиков Ричард" };
            int b = rnd.Next(0, 25);
            for (int i = 0; i < a.Length; i++)
            {
                if (i == b)
                {
                    TextBlock1.Text ="Счастливчик найден: " + a[i];
                }
            }
        }
    }
}