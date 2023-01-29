using System;
using System.Threading.Tasks;

namespace HomeTasksCS5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Car car1 = new Car();

            car1.AddFuel(65);
            Console.WriteLine(car1.CurrentFuel);
            #endregion


            #region Tests
            //Human hm1 = new Human("Huseyn Rasulov");
            //Human hm2 = new Human("Faiq Imanov");
            //Human hm3 = new Human("Zamin Afiqov");
            //Human hm4 = new Human("Raqif Suleymanov");
            //Human hm5 = new Human("Elsen Orucov");

            //hm3.ShowFullname();


            //Student[] st1= new Student[0];
            //for(int i=0;i<st1.Length;i++)
            //{
            //    string groupno;
            //    string fullname;
            //    do
            //    {
            //        Console.WriteLine("Studentin adi: ");
            //        fullname= Console.ReadLine();

            //        Console.WriteLine("Studentin Group nomresi: ");
            //        groupno= Console.ReadLine();
            //    }while (string.IsNullOrWhiteSpace(groupno));



            //    Student st = new Student
            //    {
            //        GroupNo = groupno,
            //        Fullname = fullname
            //    };
            //    st1[i]= st;

            //    {
            //        Console.WriteLine("1. Butun telebelere bax");
            //        Console.WriteLine("2. Telebeler uzre axtaris et");
            //        Console.WriteLine("3. Telebe elave et");
            #endregion












            #region Task 2(Yarimciq test)
            //Student[] st1 = new Student[0];
            //for (int i = 0; i < st1.Length; i++)
            //{

            //    string fullname;
            //    do
            //    {
            //        Console.WriteLine("Fullname: ");
            //        fullname = Console.ReadLine();
            //    } while (string.IsNullOrWhiteSpace(fullname));

            //    string groupno;
            //    do
            //    {
            //        Console.WriteLine("Model: ");
            //        groupno = Console.ReadLine();
            //    } while (string.IsNullOrWhiteSpace(groupno));


            //    Student bc = new Student
            //    {
            //        Fullname = fullname,
            //        GroupNo = groupno
            //    };

            //    st1[i] = bc;
            //}

            //Console.WriteLine("1. BUTUN TELEBELERE BAX");
            //Console.WriteLine("2. TELEBELER UZRE AXTARIS ET");
            //Console.WriteLine("3. TELEBE ELAVE ET");
            //Console.WriteLine("0. MENUDAN CIX");

            //Console.WriteLine("Emeliyyat secin:");
            //string opr = Console.ReadLine();

            //if (opr == "1")
            //{
            //    foreach (var item in st1)
            //    {
            //        Console.WriteLine($"Fullname: {item.Fullname} - GroupNo: {item.GroupNo}");
            //    }
            //}
            //else if (opr == "2")
            //{
            //    Console.WriteLine("Telebenin adini daxil edin:");
            //    string wantedModel = Console.ReadLine();

            //    foreach (var item in st1)
            //    {
            //        if (item.Fullname.Contains(wantedModel))
            //            Console.WriteLine($"Fullname: {item.Fullname} - GroupNo: {item.GroupNo}");
            //    }

            //}
            //if (opr == "3")
            //{
            //    Console.WriteLine("Telebenin infosunu daxil edin");
            //    string newStudent=Console.ReadLine();

            //}
            #endregion





            #region Task 2 (Isleyen test)
            Student[] students = new Student[0];
            string option;
            do
            {
                Console.WriteLine("1.Butun telebelere bax \n2.Telebeler uzre axtaris etmek \n3.Telebe elave etmek \n0.Menudan cixmaq");
                Console.WriteLine("Emeliyyat secin : ");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        if (students.Length == 0)
                        {
                            Console.WriteLine("Telebe yoxdur");
                        }
                        else
                        {
                            for (int i = 0; i < students.Length; i++)
                            {
                                Console.WriteLine($"FullName : {students[i].Fullname}\nGroupNo : {students[i].GroupNo}");
                            }
                        }

                        break;
                    case "2":
                        Console.WriteLine("Axtarmaq istediyini telebeni daxil edin :");
                        string getInfo = Console.ReadLine();
                        if (students.Length == 0)
                        {
                            Console.WriteLine("Telebe yoxdur");
                        }
                        else
                        {
                            int count = 0;
                            for (int i = 0; i < students.Length; i++)
                            {
                                if (students[i].Fullname.Contains(getInfo) || students[i].GroupNo.Contains(getInfo))
                                {
                                    Console.WriteLine($"FullName : {students[i].Fullname}");
                                    count++;
                                }

                            }
                            if (count == 0)
                            {

                                Console.WriteLine("Axtardiginiz telebe yoxdur");

                            }
                        }

                        break;
                    case "3":
                        string fullName;
                        bool isAlright = true;
                        do
                        {
                            if (isAlright == false)
                            {
                                Console.WriteLine("Zehmet olmasa adinizin ve soyadinizin bas herflerini boyuk yazin");

                            }
                            Console.Write("Telebenin ad ve soyadini daxil edin : ");
                            fullName = Console.ReadLine();
                            isAlright = false;

                        } while (CorrectFullname(fullName) == false);
                        bool isOk = true;
                        string groupNo;
                        do
                        {
                            if (isOk == false)
                            {
                                Console.WriteLine("Uzunluq 4 olmalidir.(Qrup nomresi boyuk herfle baslamali ve 3 reqemle davam etmelidir)");
                            }
                            Console.Write("Telebenin qrup nomresini daxil edin : ");
                            groupNo = Console.ReadLine();
                            isOk = false;
                        } while (CorrectGroup(groupNo) == false);

                        Student student = new Student()
                        {
                            Fullname = fullName,
                            GroupNo = groupNo
                        };

                        Array.Resize(ref students, students.Length + 1);
                        for (int i = 0; i < students.Length; i++)
                        {

                            students[students.Length - 1] = student;
                        }
                        break;


                    case "0":
                        Console.WriteLine("Cixmaq istediyinizden eminsiz ? \nBeli\nXeyr");
                        var yesorno = Console.ReadLine();
                        option = yesorno;
                        break;

                    default:
                        Console.WriteLine("Zehmet olmasa duzgun secimi edin");
                        break;

                }

            } while (option != "Beli");
            #endregion




        }




        static bool CorrectName(string str)
        {
            if (!char.IsUpper(str[0]))
            {
                return false;
            }
            for (int i = 1; i < str.Length; i++)
            {
                if (!char.IsLower(str[i]))
                {
                    return false;
                }
            }
            return true;

        }

        static bool CorrectGroup(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }
            if (str.Length < 5)
            {
                if (!char.IsUpper(str[0]))
                {
                    return false;
                }
                for (int i = 1; i < str.Length; i++)
                {
                    if (!char.IsDigit(str[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CorrectFullname(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }
            else
            {
                var nameAndSurname = str.Split(' ');
                var noSpaceNameAndSurname = new string[0];
                int j = 0;
                for (int i = 0; i < nameAndSurname.Length; i++)
                {
                    if (nameAndSurname[i] != "")
                    {
                        Array.Resize(ref noSpaceNameAndSurname, noSpaceNameAndSurname.Length + 1);
                        noSpaceNameAndSurname[j] = nameAndSurname[i];
                        j++;
                    }
                }
                if (noSpaceNameAndSurname.Length <= 3)
                {
                    int count = 0;
                    for (int i = 0; i < noSpaceNameAndSurname.Length; i++)
                    {
                        if (CorrectName(noSpaceNameAndSurname[i]))
                        {
                            count++;
                        }
                    }
                    if (noSpaceNameAndSurname.Length == count)
                    {
                        return true;
                    }


                    return false;

                }
                return false;
            }


        }
    }
}
