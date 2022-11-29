using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicalIdRomanianLibrary
{
    public class UnicalIdRomanianClass
    {
        public static string UnicalIdRomanian(string LastName, bool gender, DateTime birthday,bool resident,int city)
        {
            string id = "";
            if (birthday.Year > 1900 && birthday.Year < 1949)
            {
                id += "1";
            }
            if (birthday.Year > 1950 && birthday.Year < 1999)
            {
                id += "2";
            }
            if (birthday.Year > 1800 && birthday.Year < 1849)
            {
                id += "3";
            }
            if (birthday.Year > 1850 && birthday.Year < 1899)
            {
                id += "4";
            }
            if (birthday.Year > 2000 && birthday.Year < 2049)
            {
                id += "5";
            }
            if (birthday.Year > 2050 && birthday.Year < 2099)
            {
                id += "6";
            }
            if (resident!=true)
            {
                var rand = new Random();
                id+= rand.Next(7, 9);
            }
            var data = birthday.Year % 100;
            id += data;
            data = birthday.Month;
            id += data;
            data = birthday.Day;
            id += data;
            return id;
            var region = new Dictionary<int, string>()
{
    { 01, "Алба (Алба-Юлия)"},
    { 02, "Арджеш (Питешти)"},
    { 03, "Арад (Арад)"},
    { 04, "Бухарест"},
    { 05, "Бакэу (Бакэу)"},
    { 06, "Бихор (Орадя)"},
    { 07, "Бистрица-Нэсэуд (Бистрица)"},
    { 08, "Брэила (Брэила)"},
    { 09, "Ботошани (Ботошани)"},
    { 10, "Брашов (Брашов)"},
    { 11, "Бузэу (Бузэу)"},
    { 12, "Клуж (Клуж-Напока)"},
    { 13, "Кэлэраши (Кэлэраши)"},
    { 14, "Караш-Северин (Решица)"},
    { 15, "Констанца (Констанца)"},
     { 16, "Ковасна (Сфынту-Георге)"},
      { 17, "Дымбовица (Тырговиште)"},
       { 18, "Долж (Крайова)"},
        { 19, "Горж (Тыргу-Жиу)"},
         { 20, "Галац (Галац)"},
          { 21, "Джурджу (Джурджу)"},
           { 22, "Хунедоара (Дева)"},
            { 23, "Харгита (Меркуря-Чук)"},
             { 24, "Илфов (Буфтя)"},
              { 25, "Яломица (Слобозия)"},
               { 26, "Яссы (Яссы)"},
                { 27, "Мехединци (Дробета-Турну-Северин)"},
                 { 28, "Марамуреш (Бая-Маре)"},
                  { 29, "Муреш (Тыргу-Муреш)"},
                   { 30, "Нямц (Пятра-Нямц)"},
                    { 31, "Олт (Слатина)"},
                     { 32, "Прахова (Плоешти)"},
                      { 33, "Сибиу (Сибиу)"},
                       { 34, "Сэлаж (Залэу)"},
                        { 35, "Сату-Маре (Сату-Маре)"},
                         { 36, "Сучава (Сучава)"},
                          { 37, "Тулча (Тулча)"},
                           { 38, "Тимиш (Тимишоара)"},
                            { 39, "Телеорман (Александрия)"},
                             { 40, "Вылча (Рымнику-Вылча)"},
                              { 41, "Вранча (Фокшаны)"},
                               { 42, "Васлуй (Васлуй)"},
};
            id+= region[city];
            if(gender==true)
            {
                id += 1;
            }
            else
            {
                id += 2;
            }
           int name= Convert.ToInt32(LastName);
            id += name;
        }
        
    }
}
