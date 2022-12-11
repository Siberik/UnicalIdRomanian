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
using UnicalIdRomanianLibrary;
namespace UniCalIdRomaniaApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 0;
        public MainWindow()
        {
            var region = new Dictionary<int, string>()
            {
                [1] = "Алба (Алба-Юлия)",
                [2] = "Арджеш (Питешти)",
                [3] = "Арад (Арад)",
                [4] = "Бухарест",
                [5] = "Бакэу (Бакэу)",
                [6] = "Бихор (Орадя)",
                [7] = "Бистрица-Нэсэуд (Бистрица)",
                [8] = "Брэила (Брэила)",
                [9] = "Ботошани (Ботошани)",
                [10] = "Брашов (Брашов)",
                [11] = "Бузэу (Бузэу)",
                [12] = "Клуж (Клуж-Напока)",
                [13] = "Кэлэраши (Кэлэраши)",
                [14] = "Караш-Северин (Решица)",
                [15] = "Констанца (Констанца)",
                [16] = "Ковасна (Сфынту-Георге)",
                [17] = "Дымбовица (Тырговиште)",
                [18] = "Долж (Крайова)",
                [19] = "Горж (Тыргу-Жиу)",
                [20] = "Галац (Галац)",
                [21] = "Джурджу (Джурджу)",
                [22] = "Хунедоара (Дева)",
                [23] = "Харгита (Меркуря-Чук)",
                [24] = "Илфов (Буфтя)",
                [25] = "Яломица (Слобозия)",
                [26] = "Яссы (Яссы)",
                [27] = "Мехединци (Дробета-Турну-Северин)",
                [28] = "Марамуреш (Бая-Маре)",
                [29] = "Муреш (Тыргу-Муреш)",
                [30] = "Нямц (Пятра-Нямц)",
                [31] = "Олт (Слатина)",
                [32] = "Прахова (Плоешти)",
                [33] = "Сибиу (Сибиу)",
                [34] = "Сэлаж (Залэу)",
                [35] = "Сату-Маре (Сату-Маре)",
                [36] = "Сучава (Сучава)",
                [37] = "Тулча (Тулча)",
                [38] = "Тимиш (Тимишоара)",
                [39] = "Телеорман (Александрия)",
                [40] = "Вылча (Рымнику-Вылча)",
                [41] = "Вранча (Фокшаны)",
                [42] = "Васлуй (Васлуй)",
            };
            
            InitializeComponent();
            for (int i = 1; i < region.Count+1; i++)
            {
                CityComboBox.Items.Add(region[i]);
            }
            
        }
        
        private void GenerateButtonClick(object sender, RoutedEventArgs e)
        {
            DateTime Birthday = Convert.ToDateTime(BirdtdayCalendar.Text);
            bool resident=false;
            bool gender=false;
            if(ManRadioButton.IsChecked == true)
            {
                gender = true;
            }
            if(YesResidentRadioButton.IsChecked == true)
            {
                resident=true;
            }
            count = CityComboBox.SelectedIndex;
            Console.WriteLine(count);
            Console.WriteLine(UnicalIdRomanianClass.UnicalIdRomanian(LastNameTextBox.Text, gender, Birthday, resident, count+1));
            
        }
    }
    }

