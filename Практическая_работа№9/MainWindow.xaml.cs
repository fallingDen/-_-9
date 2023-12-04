using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;
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
using Структура;

namespace Практическая_работа_9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Записать(object sender, RoutedEventArgs e)
        {
            if (!(TbТипПроцессора.Text != "" &&
             !string.IsNullOrWhiteSpace(TbТипПроцессора.Text)
            && TbВидео.Text != "" &&
             !string.IsNullOrWhiteSpace(TbВидео.Text)
                && int.TryParse(TbПамять.Text, out int b)
                && int.TryParse(TbHdd.Text, out int c)
                && b > 0
                && c > 0))
            {
                MessageBox.Show("Давай всё правильно вводи");
                return;
            }

            PC pC = new PC(TbТипПроцессора.Text, b, c, TbВидео.Text);
            pC.N = List.Items.Count + 1;
            List.Items.Add(pC);
        }

        private void MenuItem_Click_О_программе(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("\"Автор: Соколов Даниил \n  Заполнить таблицу с аппаратными средствами на 5 компьютеров с полями: тип \r\nпроцессор, память, HDD, видео. Вывести результат на экран. Вывести средний \r\nобъем памяти.\r\n");
        }

        private void MenuItem_Click_Выход(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click_Анекдот(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Мастерство программиста не в том, чтобы писать программы, работающие без ошибок, \n а в том, чтобы писать программы, работающие при любом количестве ошибок.");
        }

        private void Button_Click_Средний_общий_объём_памяти(object sender, RoutedEventArgs e )
        {
            double content = 0;

            for (int i = 0; i < List.Items.Count; i++)
            {
                content += ((PC)List.Items[i]).Memory;
            }

            double res = content / List.Items.Count;
            TbСреднееЗначение.Text =  res.ToString();
        }
    }
}
