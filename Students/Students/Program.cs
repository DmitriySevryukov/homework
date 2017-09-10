using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        struct student
        {
            public string surname;
            public int birthYear;
            public string group;
            public string faculty;
        }

        static void Main(string[] args)
        {
              student[] students = new student[5];
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

              } while (repeat);

            
            

            Console.ReadLine();
        }

        static int[] GetSorted(int[] intArray)
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
        }
    }
}
