using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Students
{
    class Program
    {
        
        /*  struct student
          {
              public string surname;
              public int birthYear;
              public string group;
              public string faculty;
          }*/

        static void Main(string[] args)
        {
            /*  student[] students = new student[5];
              string[] order = { "first", "second", "third", "fourth", "fifth" };
              bool parse = false;

              for (int i = 0; i < students.Length; i++)
              {
                  Console.Write("Enter the surname of the {0} student: ", order[i]);
                  students[i].surname = Console.ReadLine();
                  Console.Write("Enter the year of birth of the {0} student: ", order[i]);
                  parse = int.TryParse(Console.ReadLine(), out students[i].birthYear);

                  while (!parse)
                  {
                      Console.WriteLine("Use NUMBERS!");
                      Console.Write("Enter the year of birth of the {0} student: ", order[i]);
                      parse = int.TryParse(Console.ReadLine(), out students[i].birthYear);
                  } 

                  Console.Write("Enter the group of the {0} student: ", order[i]);
                  students[i].group = Console.ReadLine();
                  Console.Write("Enter the faculty of the {0} student: ", order[i]);
                  students[i].faculty = Console.ReadLine();
                  Console.WriteLine();
              }

              int currentYear = 2017;
              int[] age = new int[students.Length];
              for (int i = 0; i < age.Length; i++)
              {
                  age[i] = currentYear - students[i].birthYear;
              }


              Console.WriteLine("Press 1 to see the list of the students");
              Console.WriteLine("Press 2 to see the average age of the students");
              Console.WriteLine("Press 3 to know about the youngest student");
              Console.WriteLine("Press 4 to know about the oldest student");
              Console.WriteLine("Press 5 to see the list of the students sorted by the surname");
              Console.WriteLine("Press 6 to see the list of the students sorted by the year of birth");
              Console.WriteLine("Press 7 to see the list of the students sorted by the group");
              Console.WriteLine("Press 8 to see the list of the students sorted by the faculty");
              Console.WriteLine("Press 0 to exit");
              bool repeat = true;
              do
              {
                  Console.WriteLine();
                  Console.Write("Your menu option: ");

                  int menuButton;
                  parse = int.TryParse(Console.ReadLine(), out menuButton);

                  while (!parse)
                  {
                      Console.WriteLine("Use NUMBERS!");
                      Console.Write("Your menu option: ");
                      parse = int.TryParse(Console.ReadLine(), out menuButton);
                  }

                  Console.WriteLine();

                  switch (menuButton)
                  {
                      case 1:
                          for (int i = 0; i < students.Length; i++)
                          {
                              Console.WriteLine(students[i].surname);
                          }
                          break;

                      case 2:
                          int sum = 0;
                          for (int i = 0; i < age.Length; i++)
                          {
                              sum += age[i];
                          }
                          Console.WriteLine("The average age is {0} years old", sum / age.Length);
                          break;

                      case 3:
                          int min = age[0];
                          int num = 0;
                          for (int i = 1; i < age.Length; i++)
                          {
                              if (age[i] < min)
                              {
                                  min = age[i];
                                  num = i;
                              }     
                          }
                          Console.WriteLine
                              ("The youngest student is {0}. He is {1} years old", students[num].surname, min);
                          break;

                      case 4:
                          int max = age[0];
                          num = 0;
                          for (int i = 1; i < age.Length; i++)
                          {
                              if (age[i] > max)
                              {
                                  max = age[i];
                                  num = i;
                              }
                          }
                          Console.WriteLine
                              ("The oldest student is {0}. He is {1} years old", students[num].surname, max);
                          break;

                      case 5:
                          Console.WriteLine("Surname\tBirthYear\tGroup\tFaculty");
                          string[] checkStr = new string[students.Length];

                          for (int i = 0; i < checkStr.Length; i++)
                          {
                              checkStr[i] = students[i].surname;
                          }

                          for (int i = 0; i < students.Length;i++)
                          {
                              int index = GetSorted(checkStr)[i];
                              Console.WriteLine(students[index].surname + "\t" +
                                 students[index].birthYear + "\t" + "\t" +
                                 students[index].group + "\t" +
                                 students[index].faculty);
                          }
                          break;

                      case 6:
                          Console.WriteLine("Surname\tBirthYear\tGroup\tFaculty");
                          int[] checkInt = new int[students.Length];
                          for (int i = 0; i < checkInt.Length; i++)
                          {
                              checkInt[i] = students[i].birthYear;
                          }

                          for (int i = 0; i < checkInt.Length; i++)
                          {
                              int index = GetSorted(checkInt)[i];
                              Console.WriteLine(students[index].surname + "\t" +
                                   students[index].birthYear + "\t" + "\t" +
                                   students[index].group + "\t" +
                                   students[index].faculty);
                          }

                          break;

                      case 7:
                          Console.WriteLine("Surname\tBirthYear\tGroup\tFaculty");
                          checkStr = new string[students.Length];

                          for (int i = 0; i < checkStr.Length; i++)
                          {
                              checkStr[i] = students[i].group;
                          }

                          for (int i = 0; i < students.Length; i++)
                          {
                              int index = GetSorted(checkStr)[i];
                              Console.WriteLine(students[index].surname + "\t" +
                                 students[index].birthYear + "\t" + "\t" +
                                 students[index].group + "\t" +
                                 students[index].faculty);
                          }
                          break;

                      case 8:
                          Console.WriteLine("Surname\tBirthYear\tGroup\tFaculty");
                          checkStr = new string[students.Length];

                          for (int i = 0; i < checkStr.Length; i++)
                          {
                              checkStr[i] = students[i].faculty;
                          }

                          for (int i = 0; i < students.Length; i++)
                          {
                              int index = GetSorted(checkStr)[i];
                              Console.WriteLine(students[index].surname + "\t" +
                                 students[index].birthYear + "\t" + "\t" +
                                 students[index].group + "\t" +
                                 students[index].faculty);
                          }
                          break;

                      case 0:
                          repeat = false;
                          Environment.Exit(0);
                          break;

                      default:
                          Console.WriteLine("You've pressed wrong number, try again");
                          break;
                  }

              } while (repeat);*/

            List<Student> studList = new List<Student>();
            StreamReader sr;
            bool repeat = false;
            string answer;
            string surname;
            int birthYear = 0;
            string group;
            string faculty;
            int menuButton = 0;
            bool readFromFile = false;
            bool saved = false;

            if (System.IO.File.Exists("data.txt"))
            {
                sr = new StreamReader("data.txt");

                if (sr.Peek() != -1)
                {
                    do
                    {
                        Console.WriteLine("Do you wish to load data from file?");
                        answer = Console.ReadLine();

                        try
                        {
                            checkAnswer(answer);
                            repeat = false;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Enter yes or no");
                            repeat = true;
                        }

                    } while (repeat);

                    if (answer.Equals("yes"))
                    {
                        readFromFile = true;
                        do
                        {
                            Student stud = new Student();
                            stud.surname = sr.ReadLine();
                            stud.birthYear = int.Parse(sr.ReadLine());
                            stud.group = sr.ReadLine();
                            stud.faculty = sr.ReadLine();
                            studList.Add(stud);
                        } while (sr.Peek() != -1);

                    } else
                    {
                        readFromFile = false;
                        StreamWriter sw = new StreamWriter("data.txt");
                        sw.Write("");
                        sw.Close();
                    } 
                }
                sr.Close();
            }

            if (!readFromFile)
            {
                do
                {
                    Console.Write("Enter the surname of the next student: ");
                    surname = Console.ReadLine();

                    do
                    {
                        Console.Write("Enter the year of birth of the next student: ");
                        try
                        {
                            birthYear = int.Parse(Console.ReadLine());
                            repeat = false;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Enter NUMBERS!!!");
                            repeat = true;
                        }
                    } while (repeat);

                    Console.Write("Enter the group of the next student: ");
                    group = Console.ReadLine();
                    Console.Write("Enter the faculty of the next student: ");
                    faculty = Console.ReadLine();

                    studList.Add(new Student(surname, birthYear, group, faculty));


                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter 1 to add one more student to the list");
                        Console.WriteLine("Enter 0 to finish the list and transit to the next menu");
                        try
                        {
                            menuButton = int.Parse(Console.ReadLine());
                            repeat = false;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Enter NUMBERS!!!");
                            repeat = true;
                        }
                    } while (repeat);
                } while (menuButton == 1);
            }

            




            Console.WriteLine("Press 1 to see the list of the students");
            Console.WriteLine("Press 2 to see the average age of the students");
            Console.WriteLine("Press 3 to know about the youngest student");
            Console.WriteLine("Press 4 to know about the oldest student");
            Console.WriteLine("Press 5 to see the list of the students sorted by the surname");
            Console.WriteLine("Press 6 to see the list of the students sorted by the year of birth");
            Console.WriteLine("Press 7 to see the list of the students sorted by the group");
            Console.WriteLine("Press 8 to see the list of the students sorted by the faculty");
            Console.WriteLine("Press 9 to save the data");
            Console.WriteLine("Press 0 to exit");
            bool repeatMenu = true;

            do
            {
                Console.WriteLine();

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Your menu option: ");
                    try
                    {
                        menuButton = int.Parse(Console.ReadLine());
                        repeat = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter NUMBERS!!!");
                        repeat = true;
                    }
                } while (repeat);

                switch (menuButton)
                {
                    case 1://list

                        Console.WriteLine("Surname\tBirthYear\tGroup\tFaculty");
                        foreach (Student stud in studList)
                        {
                            Console.WriteLine(stud.surname + "\t" +
                                stud.birthYear + "\t" + "\t" +
                                stud.group + "\t" + 
                                stud.faculty);
                        }
                        break;

                    case 2://average age

                            foreach (Student stud in studList)
                            {
                                Counting.numList.Add(stud.age);
                            }
                            Console.WriteLine("Average age of the students is " + Counting.average);
                        break;

                    case 3://youngest

                        int min;
                        int indexMin;

                        foreach (Student stud in studList)
                        {
                            Counting.numList.Add(stud.age);
                        }

                        min = Counting.min;

                        foreach (Student stud in studList)
                        {
                            Counting.numList.Add(stud.age);
                        }

                        indexMin = Counting.indexMin;

                        Console.WriteLine("The youngest student is {0}. He is {1} years old.",
                            studList[indexMin].surname, min);
                        break;

                    case 4://oldest

                        int max;
                        int indexMax;

                        foreach (Student stud in studList)
                        {
                            Counting.numList.Add(stud.age);
                        }

                        max = Counting.max;

                        foreach (Student stud in studList)
                        {
                            Counting.numList.Add(stud.age);
                        }

                        indexMax = Counting.indexMax;

                        Console.WriteLine("The oldest student is {0}. He is {1} years old.", 
                            studList[indexMax].surname, max);
                        break;

                    case 5://sort by surname

                        Console.WriteLine("Surname\tBirthYear\tGroup\tFaculty");

                        for (int i = 0; i < studList.Count; i++)
                        {
                            foreach (Student stud in studList)
                            {
                                Counting.strList.Add(stud.surname);
                            }

                            int index = Counting.strSortIndex()[i];
                            Console.WriteLine(studList[index].surname + "\t" +
                               studList[index].birthYear + "\t" + "\t" +
                               studList[index].group + "\t" +
                               studList[index].faculty);
                        }
                        break;

                    case 6://sort by birthYear

                        Console.WriteLine("Surname\tBirthYear\tGroup\tFaculty");

                        for (int i = 0; i < studList.Count; i++)
                        {
                            foreach (Student stud in studList)
                            {
                                Counting.numList.Add(stud.birthYear);
                            }

                            int index = Counting.numSortIndex()[i];
                            Console.WriteLine(studList[index].surname + "\t" +
                               studList[index].birthYear + "\t" + "\t" +
                               studList[index].group + "\t" +
                               studList[index].faculty);
                        }
                        break;

                    case 7://sort by group

                        Console.WriteLine("Surname\tBirthYear\tGroup\tFaculty");

                        for (int i = 0; i < studList.Count; i++)
                        {
                            foreach (Student stud in studList)
                            {
                                Counting.strList.Add(stud.group);
                            }

                            int index = Counting.strSortIndex()[i];
                            Console.WriteLine(studList[index].surname + "\t" +
                               studList[index].birthYear + "\t" + "\t" +
                               studList[index].group + "\t" +
                               studList[index].faculty);
                        }
                        break;

                    case 8://sort by faculty

                        Console.WriteLine("Surname\tBirthYear\tGroup\tFaculty");

                        for (int i = 0; i < studList.Count; i++)
                        {
                            foreach (Student stud in studList)
                            {
                                Counting.strList.Add(stud.faculty);
                            }

                            int index = Counting.strSortIndex()[i];
                            Console.WriteLine(studList[index].surname + "\t" +
                               studList[index].birthYear + "\t" + "\t" +
                               studList[index].group + "\t" +
                               studList[index].faculty);
                        }
                        break;

                    case 9://save

                        writeToFile(studList);
                        Console.WriteLine("Data have been saved");
                        saved = true;
                        break;

                    case 0://exit

                        repeat = false;
                        
                        if (!saved)
                        {
                            do
                            {
                                Console.WriteLine("Do you wish to save data?");
                                answer = Console.ReadLine();

                                try
                                {
                                    checkAnswer(answer);
                                    repeat = false;
                                }
                                catch
                                {
                                    Console.WriteLine("Enter yes or no");
                                    repeat = true;
                                }
                            } while (repeat);
                            
                            if (answer.Equals("yes"))
                            {
                                writeToFile(studList);
                                Console.WriteLine("Data have been saved");
                            }
                            else
                            {
                                StreamWriter sw = new StreamWriter("data.txt");
                                sw.Write("");
                                sw.Close();
                            }
                        }

                        Environment.Exit(0);
                        break;

                    default:

                        Console.WriteLine("You've pressed wrong number, try again");
                        break;
                }

            } while (repeatMenu);


            Console.ReadLine();
        }

        static void checkAnswer(string answer)
        {
            if (answer.CompareTo("yes") != 0 && answer.CompareTo("no") != 0)
            {
                throw new FormatException();
            }
        }

        static void writeToFile(List<Student> list)
        {
            StreamWriter sw = new StreamWriter("data.txt");

            foreach (Student stud in list)
            {
                sw.WriteLine(stud.surname);
                sw.WriteLine(stud.birthYear);
                sw.WriteLine(stud.group);
                sw.WriteLine(stud.faculty);
            }

            sw.Close();
            
        }

      /*  static int[] GetSorted(int[] intArray)
        {
            int[] result = new int[intArray.Length];
            int[] num = new int[intArray.Length];
            int[] numToSort = new int[intArray.Length];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = intArray[i];
                numToSort[i] = intArray[i];
            }

            Array.Sort(numToSort);

            int count = 0;
            for (int i = 0; i < numToSort.Length; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    if (numToSort[i] == num[j])
                    {
                        result[count] = j;
                        bool coincide = false;
                        int k = 0;
                        while (k < count)
                        {
                            if (result[k] == result[count]) coincide = true;
                            k++;
                        }
                        if (!coincide)
                        {
                            count++;
                            break;
                        }
                    }
                }
            }

            return result;
        }

        static int[] GetSorted(string[] strArray)
        {
            int[] result = new int [strArray.Length];
            string[] str = new string[strArray.Length];
            string[] strToSort = new string[strArray.Length];

            for (int i = 0; i < str.Length; i++)
            {
                str[i] = strArray[i];
                strToSort[i] = strArray[i];
            }

            Array.Sort(strToSort);

            int count = 0;
            for (int i = 0; i < strToSort.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (strToSort[i] == str[j])
                    {
                        result[count] = j;
                        bool coincide = false;
                        int k = 0;
                        while (k < count)
                        {
                            if (result[k] == result[count]) coincide = true;
                            k++;
                        }
                        if (!coincide)
                        {
                            count++;
                            break;
                        }
                    }
                }
            }

            return result;
        }*/

        

        
    }

    class Student
    {
        const int currentYear = 2017;
        private string _surname;
        private int _birthYear;
        private string _group;
        private string _faculty;


        public Student()
        {

        }
        public Student(string surname, int yearOfBirth, string group, string faculty)
        {
            this._surname = surname;
            this._birthYear = yearOfBirth;
            this._group = group;
            this._faculty = faculty;
        }


        public string surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public int birthYear
        {
            get { return _birthYear; }
            set { _birthYear = value; }
        }

        public string group
        {
            get { return _group; }
            set { _group = value; }
        }

        public string faculty
        {
            get { return _faculty; }
            set { _faculty = value; }
        }

        public int age
        {
            get { return currentYear - _birthYear; }
        }
    }

    static class Counting
    {
        static public List<int> numList = new List<int>();
        static public List<string> strList = new List<string>();

        static public int average
        {
            get
            {
                int result = numList.Sum() / numList.Count();
                numList.Clear();
                return result;
            }
        }

        static public int min
        {
            get
            {
                int result = numList.Min();
                numList.Clear();
                return result;
            }
        }

        static public int max
        {
            get
            {
                int result = numList.Max();
                numList.Clear();
                return result;
            }
        }


        static public int indexMin
        {
            get
            {
                int result = 0;
                for (int i = 0; i < numList.Count; i++)
                {
                    if (numList[i] == numList.Min()) result = i;
                }
                numList.Clear();
                return result;
            }
        }

        static public int indexMax
        {
            get
            {
                int result = 0;
                for (int i = 0; i < numList.Count; i++)
                {
                    if (numList[i] == numList.Max()) result = i;
                }
                numList.Clear();
                return result;
            }
        }


        static public List<int> numSortIndex()
        {
            List<int> result = new List<int>();
            List<int> oldList = new List<int>();


            foreach (int num in numList)
            {
                oldList.Add(num);
            }

            numList.Sort();

            int count = 0;
            bool rewrite = false;

            for (int i = 0; i < numList.Count; i++)
            {
                for (int j = 0; j < oldList.Count; j++)
                {
                    if (numList[i] == oldList[j])
                    {
                        if (rewrite) result[count] = j;
                        else result.Add(j);

                        bool coincide = false;
                        int k = 0;
                        while (k < count)
                        {
                            if (result[k] == result[count]) coincide = true;
                            k++;
                        }
                        if (coincide)
                        {
                            rewrite = true;
                        }
                        else
                        {
                            rewrite = false;
                            count++;
                            break;
                        }
                    }
                }
            }

            numList.Clear();

            return result;
        }

        static public List<int> strSortIndex()
        {
            List<int> result = new List<int>();
            List<string> oldList = new List<string>();


            foreach (string str in strList)
            {
                oldList.Add(str);
            }

            strList.Sort();

            int count = 0;
            bool rewrite = false;

            for (int i = 0; i < strList.Count; i++)
            {
                for (int j = 0; j < oldList.Count; j++)
                {
                    if (strList[i].Equals(oldList[j]))
                    {
                        if (rewrite) result[count] = j;
                        else result.Add(j);

                        bool coincide = false;
                        int k = 0;
                        while (k < count)
                        {
                            if (result[k] == result[count]) coincide = true;
                            k++;
                        }
                        if (coincide)
                        {
                            rewrite = true;
                        }
                        else
                        {
                            rewrite = false;
                            count++;
                            break;
                        }
                    }
                }
            }

            strList.Clear();

            return result;
        }
    }
}
