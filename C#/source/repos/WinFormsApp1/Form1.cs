using System.Globalization;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
            string title = "Расписание ";
            Text = title;
            DateTime curtime = DateTime.Now;
            Text = title + (curtime.ToLongTimeString());
            int i = 0;
            while (i==0)
            {

             Text = title + (curtime.ToLongTimeString());

            }
            */
        }











        private void button1_MouseUp(object sender, MouseEventArgs e)
        {






            DateTime datetest = DateTime.Now;
            int i = 0;

            int day1;
            string day2;
            DateTime ClockInfoFromSystem = DateTime.Now;
            /// it is not working
            //day2 = ClockInfoFromSystem.DayOfWeek.ToString(); /// it gives me string
            day1 = (int)ClockInfoFromSystem.DayOfWeek; /// it gives me int


            //richTextBox1.Text = day1+"";
            //richTextBox1.Text = day1 + "";


            /*
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            DateTime date1 = DateTime.Now;
            Calendar cal = dfi.Calendar;

            //Console.WriteLine("{0:d}: Week {1} ({2})", date1,cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, dfi.FirstDayOfWeek),cal.ToString().Substring(cal.ToString().LastIndexOf(".") + 1));


            richTextBox1.Text = "{0:d}: Week {1} ({2})"+date1+cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, dfi.FirstDayOfWeek)+cal.ToString().Substring(cal.ToString().LastIndexOf(".") + 1);






            */











            Calendar Calendar = CultureInfo.InvariantCulture.Calendar;
            int weekNumber = Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            Console.WriteLine(weekNumber);

            int NumWeekOfYear = weekNumber;

            NumWeekOfYear = NumWeekOfYear % 2;






            //richTextBox1.Text = day1 + "";

            //richTextBox1.Text = day1 + "NumWeekOfYear";


            if (day1 == 1)
            {
                if (NumWeekOfYear == 1)
                {


                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3321 ";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3320";



                }
                else
                {

                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3321 ";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3320";


                }


                //richTextBox1.Text = /*day1+*/ "9:00-9:45\r\n9:55-10:40\r\n";

                // инструкции, которые выполняются, если условие-1 истинно.
            }
            else if (day1 == 2)
            {
                if (NumWeekOfYear == 1)
                {

                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Математическое моделирование"; richTextBox1.Text = richTextBox1.Text + " Малахова Т.А. "; richTextBox1.Text = richTextBox1.Text + "3320";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Физическая культура"; richTextBox1.Text = richTextBox1.Text + " Иванов С.С. "; richTextBox1.Text = richTextBox1.Text + "Спорт.зал ";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Безопасность жизнедеятельности"; richTextBox1.Text = richTextBox1.Text + " Маршева Ю.И. "; richTextBox1.Text = richTextBox1.Text + "3311";





                }
                else
                {

                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Математическое моделирование"; richTextBox1.Text = richTextBox1.Text + " Малахова Т.А. "; richTextBox1.Text = richTextBox1.Text + "3320";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Физическая культура"; richTextBox1.Text = richTextBox1.Text + " Иванов С.С. "; richTextBox1.Text = richTextBox1.Text + "Спорт.зал ";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Безопасность жизнедеятельности"; richTextBox1.Text = richTextBox1.Text + " Маршева Ю.И. "; richTextBox1.Text = richTextBox1.Text + "3311";



                }




                // инструкции, которые выполняются, если условие-2 истинно.
            }
            else if (day1 == 3)
            {
                if (NumWeekOfYear == 1)
                {




                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Математическое моделирование"; richTextBox1.Text = richTextBox1.Text + " Малахова Т.А. "; richTextBox1.Text = richTextBox1.Text + "3318 ";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Безопасность жизнедеятельности"; richTextBox1.Text = richTextBox1.Text + " Маршева Ю.И. "; richTextBox1.Text = richTextBox1.Text + "7106 ";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы  проектирования баз данных"; richTextBox1.Text = richTextBox1.Text + " Цикина Т.И "; richTextBox1.Text = richTextBox1.Text + "1420";
                    richTextBox1.Text = richTextBox1.Text + "\n9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы  проектирования баз данных"; richTextBox1.Text = richTextBox1.Text + "  Цикина Т.И "; richTextBox1.Text = richTextBox1.Text + "1420";



                }
                else
                {


                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Математическое моделирование"; richTextBox1.Text = richTextBox1.Text + " Малахова Т.А. "; richTextBox1.Text = richTextBox1.Text + "3318 ";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Безопасность жизнедеятельности"; richTextBox1.Text = richTextBox1.Text + " Маршева Ю.И. "; richTextBox1.Text = richTextBox1.Text + "7106 ";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы  проектирования баз данных"; richTextBox1.Text = richTextBox1.Text + " Цикина Т.И "; richTextBox1.Text = richTextBox1.Text + "1420";
                    richTextBox1.Text = richTextBox1.Text + "\n9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы  проектирования баз данных"; richTextBox1.Text = richTextBox1.Text + "  Цикина Т.И "; richTextBox1.Text = richTextBox1.Text + "1420";



                }




                // инструкции, которые выполняются, если условие-3 истинно.
            }
            else if (day1 == 4)
            {
                if (NumWeekOfYear == 1)
                {





                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Технология разработки  программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Толокольников С.Н. "; richTextBox1.Text = richTextBox1.Text + "3312";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения "; richTextBox1.Text = richTextBox1.Text + " Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "1409,1420";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Технология разработки  программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Толокольников С.Н. "; richTextBox1.Text = richTextBox1.Text + "1417";
                    richTextBox1.Text = richTextBox1.Text + "\n9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Дискретная математика с элементами математической логики"; richTextBox1.Text = richTextBox1.Text + " Дерябина А.В. "; richTextBox1.Text = richTextBox1.Text + "3103";


                }
                else
                {



                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Технология разработки  программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Толокольников С.Н. "; richTextBox1.Text = richTextBox1.Text + "3312";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения "; richTextBox1.Text = richTextBox1.Text + " Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "1409,1420";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Технология разработки  программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Толокольников С.Н. "; richTextBox1.Text = richTextBox1.Text + "1417";
                    richTextBox1.Text = richTextBox1.Text + "\n9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Физическая культура"; richTextBox1.Text = richTextBox1.Text + " Иванов С.С "; richTextBox1.Text = richTextBox1.Text + "Спорт.зал";



                }


                // инструкции, которые выполняются, если условие-1 истинно.
            }
            else if (day1 == 5)
            {


                if (NumWeekOfYear == 1)
                {


                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Дискретная математика и математическая логика "; richTextBox1.Text = richTextBox1.Text + " Дерябина А.В "; richTextBox1.Text = richTextBox1.Text + "3302 ";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Иностранный язык в профессиональной деятельности"; richTextBox1.Text = richTextBox1.Text + " Фетисов Л.С. "; richTextBox1.Text = richTextBox1.Text + "3509 ";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "1402";
                    richTextBox1.Text = richTextBox1.Text + "\n9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения"; richTextBox1.Text = richTextBox1.Text + "  Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "3320 ";


                    //richTextBox1.Text = "9:00-10:40\r\n";

                }
                else
                {
                    richTextBox1.Text = "";


                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Иностранный язык в профессиональной деятельности"; richTextBox1.Text = richTextBox1.Text + " Фетисов Л.С. "; richTextBox1.Text = richTextBox1.Text + " 3302 ";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Иностранный язык в профессиональной деятельности"; richTextBox1.Text = richTextBox1.Text + " Фетисов Л.С. "; richTextBox1.Text = richTextBox1.Text + " 3509 ";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "1402";
                    richTextBox1.Text = richTextBox1.Text + "\n9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения"; richTextBox1.Text = richTextBox1.Text + "  Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "3320 ";



                }


                // инструкции, которые выполняются, если условие-2 истинно.


                // richTextBox1.Text = cal.ToString().Substring(cal.ToString().LastIndexOf(".") + 1);
                //  int date3 = 0;
                //  DateTime ClockInfoFromSystem2 = DateTime.Now;
                //  date3 = (int)ClockInfoFromSystem2.DayOfWeek;
                //richTextBox1.Text = weekNumber + "";

                //  richTextBox1.Text = NumWeekOfYear + "";

            }
            else if (day1 == 6)
            {
                richTextBox1.Text = /*day1+*/ "Сегодня выходной";
                // инструкции, которые выполняются, если условие-3 истинно.
            }
            else if (day1 == 7)
            {
                richTextBox1.Text = /*day1+*/ "Сегодня выходной";
                // инструкции, которые выполняются, если условие-3 истинно.
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {


            richTextBox1.Text = "Пока в разработке...";



        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string title = "Расписание ";
            Text = title;
            DateTime curtime = DateTime.Now;
            //  string TimeInfoFromSystem = null;
            //   Text = TimeInfoFromSystem;
            Text = title + (curtime.ToLongTimeString());




        }


        

    }
}
