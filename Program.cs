using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day;
            string name;
            string surname;

            Console.Write("Введи день своего рождения"+" ");

            day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введи свое имя"+" ");

            name = Console.ReadLine();

            Console.Write("Введи свою фамилию"+" ");

            surname = Console.ReadLine();

            string getWord1(int n)
            {

                string word;

                switch (n)
                {
                    case 1:
                        {
                            word = "Взрывной";
                            break;
                        }
                    case 2:
                        {
                            word = "Худой";
                            break;
                        }
                    case 3:
                        {
                            word = "Рыжий";
                            break;
                        }
                    case 4:
                        {
                            word = "Страсный";
                            break;
                        }
                    case 5:
                        {
                            word = "Высокий";
                            break;
                        }
                    case 6:
                        {
                            word = "Мохнатый";
                            break;
                        }
                    case 7:
                        {
                            word = "Круглый";
                            break;
                        }
                    case 8:
                        {
                            word = "Красивый";
                            break;
                        }
                    case 9:
                        {
                            word = "Конопатый";
                            break;
                        }
                    case 10:
                        {
                            word = "Импортный";
                            break;
                        }
                    case 11:
                        {
                            word = "Мягкий";
                            break;
                        }
                    case 12:
                        {
                            word = "Рогатый";
                            break;
                        }
                    case 13:
                        {
                            word = "Ужасный";
                            break;
                        }
                    case 14:
                        {
                            word = "Находчивый";
                            break;
                        }
                    case 15:
                        {
                            word = "Грустный";
                            break;
                        }
                    case 16:
                        {
                            word = "Непонятный";
                            break;
                        }
                    case 17:
                        {
                            word = "Веселый";
                            break;
                        }
                    case 18:
                        {
                            word = "Лысый";
                            break;
                        }
                    case 19:
                        {
                            word = "Угрюмый";
                            break;
                        }
                    case 20:
                        {
                            word = "Синий";
                            break;
                        }
                    case 21:
                        {
                            word = "Скользкий";
                            break;
                        }
                    case 22:
                        {
                            word = "Бородатый";
                            break;
                        }
                    case 23:
                        {
                            word = "Беззубый";
                            break;
                        }
                    case 24:
                        {
                            word = "Стройный";
                            break;
                        }
                    case 25:
                        {
                            word = "Сонный";
                            break;
                        }
                    case 26:
                        {
                            word = "Курносый";
                            break;
                        }
                    case 27:
                        {
                            word = "Мерзкий";
                            break;
                        }
                    case 28:
                        {
                            word = "Музыкальный";
                            break;
                        }
                    case 29:
                        {
                            word = "Накачанный";
                            break;
                        }
                    case 30:
                        {
                            word = "Ничтожный";
                            break;
                        }
                    case 31:
                        {
                            word = "Гордый";
                            break;
                        }
                    default:
                        {
                            word = "Not valid option";
                            break;
                        }
                }

                return word;
            }

            Console.Write(getWord1(day));


            string i = name[0].ToString();

            string getWord2(string j)
            {
                string word;
                
                switch (j)

                {

                    case "а":
                        {
                            word = " " + "цезарь" + " ";
                            break;
                        }
                    case "б":
                        {
                            word = " " + "огурец" + " ";
                            break;
                        }
                    case "в":
                        {
                            word = " " + "рыцарь" + " ";
                            break;
                        }
                    case "г":
                        {
                            word = " " + "паркет" + " ";
                            break;
                        }
                    case "д":
                        {
                            word = " " + "планктон" + " ";
                            break;
                        }
                    case "е":
                        {
                            word = " " + "страус" + " ";
                            break;
                        }
                    case "ж":
                        {
                            word = " " + "жираф" + " ";
                            break;
                        }
                    case "з":
                        {
                            word = " " + "единорог" + " ";
                            break;
                        }
                    case "и":
                        {
                            word = " " + "купидон" + " ";
                            break;
                        }
                    case "к":
                        {
                            word = " " + "ковер" + " ";
                            break;
                        }
                    case "л":
                        {
                            word = " " + "разбойник" + " ";
                            break;
                        }
                    case "м":
                        {
                            word = " " + "кит" + " ";
                            break;
                        }
                    case "н":
                        {
                            word = " " + "заяц" + " ";
                            break;
                        }
                    case "о":
                        {
                            word = " " + "полицейский" + " ";
                            break;
                        }
                    case "п":
                        {
                            word = " " + "череп" + " ";
                            break;
                        }
                    case "р":
                        {
                            word = " " + "матрос" + " ";
                            break;
                        }
                    case "с":
                        {
                            word = " " + "дед" + " ";
                            break;
                        }
                    case "т":
                        {
                            word = " " + "тапок" + " ";
                            break;
                        }
                    case "у":
                        {
                            word = " " + "банан" + " ";
                            break;
                        }
                    case "ф":
                        {
                            word = " " + "кокос" + " ";
                            break;
                        }
                    case "х":
                        {
                            word = " " + "колумб" + " ";
                            break;
                        }
                    case "ц":
                        {
                            word = " " + "какаду" + " ";
                            break;
                        }
                    case "ч":
                        {
                            word = " " + "дуб" + " ";
                            break;
                        }
                    case "ш":
                        {
                            word = " " + "кактус" + " ";
                            break;
                        }
                    case "щ":
                        {
                            word = " " + "кентавр" + " ";
                            break;
                        }
                    case "э":
                        {
                            word = " " + "ворон" + " ";
                            break;
                        }
                    case "ю":
                        {
                            word = " " + "ковбой" + " ";
                            break;
                        }
                    case "я":
                        {
                            word = " " + "тигр" + " ";
                            break;
                        }

                    default:
                        {
                            word = "Not valid option";
                            break;
                        }
                }

                return word;
            }

            Console.Write(getWord2(i));


            string l = surname[0].ToString();

            string getWord3(string b)
            {

                string word;

                switch (b)
                {
                    case "а":
                        {
                            word = "с пластырем" + " ";
                            break;
                        }
                    case "б":
                        {
                            word = "на окне" + " ";
                            break;
                        }
                    case "в":
                        {
                            word = "в седле" + " ";
                            break;
                        }
                    case "г":
                        {
                            word = "на коне" + " ";
                            break;
                        }
                    case "д":
                        {
                            word = "на асфальте" + " ";
                            break;
                        }
                    case "е":
                        {
                            word = "на огороде" + " ";
                            break;
                        }
                    case "ж":
                        {
                            word = "в ракете" + " ";
                            break;
                        }
                    case "з":
                        {
                            word = "в бункере" + " ";
                            break;
                        }
                    case "и":
                        {
                            word = "на дискотеке" + " ";
                            break;
                        }
                    case "к":
                        {
                            word = "на шашлыках" + " ";
                            break;
                        }
                    case "л":
                        {
                            word = "под забором" + " ";
                            break;
                        }
                    case "м":
                        {
                            word = "с пистолетом" + " ";
                            break;
                        }
                    case "н":
                        {
                            word = "на свободе" + " ";
                            break;
                        }
                    case "о":
                        {
                            word = "в тракторе" + " ";
                            break;
                        }
                    case "п":
                        {
                            word = "в танке" + " ";
                            break;
                        }
                    case "р":
                        {
                            word = "на Мальдивах" + " ";
                            break;
                        }
                    case "с":
                        {
                            word = "под куполом цирка" + " ";
                            break;
                        }
                    case "т":
                        {
                            word = "при деньгах" + " ";
                            break;
                        }
                    case "у":
                        {
                            word = "с ведром" + " ";
                            break;
                        }
                    case "ф":
                        {
                            word = "в пещере" + " ";
                            break;
                        }
                    case "х":
                        {
                            word = "в костюме Бэтмена" + " ";
                            break;
                        }
                    case "ц":
                        {
                            word = "в стразах" + " ";
                            break;
                        }
                    case "ч":
                        {
                            word = "без тормозов" + " ";
                            break;
                        }
                    case "ш":
                        {
                            word = "на корабле" + " ";
                            break;
                        }
                    case "щ":
                        {
                            word = "без штанов" + " ";
                            break;
                        }
                    case "э":
                        {
                            word = "с копытами" + " ";
                            break;
                        }
                    case "ю":
                        {
                            word = "в Польше" + " ";
                            break;
                        }
                    case "я":
                        {
                            word = "в Якутии" + " ";
                            break;
                        }

                    default:
                        {
                            word = "Not valid option";
                            break;
                        }
                }

                return word;
            }

            Console.Write(getWord3(l));

        }
    }
}
