using System;
using Exam_System.Models;
using Exam_System.Models.Exams;
using Exam_System.Models.Questions;
using System.Collections.Generic;
namespace Exam_System
{
    public class Program
    {
        static void Main()
        {
            #region Templates For Testing
            // Create Exams
            Exam practiceExam = new PracticeExam("Math", TimeSpan.FromMinutes(60));
            Exam finalExam = new FinalExam("Physics", TimeSpan.FromMinutes(90));

            // =============================
            // True/False Questions
            // =============================
            AnswerList tf1Answers = new AnswerList();
            tf1Answers.Add("True", true);
            tf1Answers.Add("False", false);
            practiceExam.AddQuestion(new TrueFalseQuestion("Programming Basics", "C# is a case-sensitive programming language.", 2), tf1Answers);

            AnswerList tf2Answers = new AnswerList();
            tf2Answers.Add("True", false);
            tf2Answers.Add("False", true);
            finalExam.AddQuestion(new TrueFalseQuestion("Databases", "In SQL, DELETE removes both the data and the table structure.", 2), tf2Answers);

            // =============================
            // Choose One Questions
            // =============================
            AnswerList co1Answers = new AnswerList();
            co1Answers.Add("Inheritance", false);
            co1Answers.Add("Polymorphism", false);
            co1Answers.Add("Encapsulation", true);
            co1Answers.Add("Abstraction", false);
            practiceExam.AddQuestion(new ChooseOneQuestion("OOP Concepts", "Which principle ensures that a class hides its implementation details and only exposes necessary parts?", 3), co1Answers);

            AnswerList co2Answers = new AnswerList();
            co2Answers.Add("HTTP", false);
            co2Answers.Add("SMTP", true);
            co2Answers.Add("FTP", false);
            co2Answers.Add("TCP", false);
            finalExam.AddQuestion(new ChooseOneQuestion("Networks", "Which protocol is used to send emails?", 3), co2Answers);

            // =============================
            // Choose All Questions
            // =============================
            AnswerList ca1Answers = new AnswerList();
            ca1Answers.Add("Scrum", true);
            ca1Answers.Add("Waterfall", false);
            ca1Answers.Add("Kanban", true);
            ca1Answers.Add("Extreme Programming (XP)", true);
            practiceExam.AddQuestion(new ChooseAllQuestion("Software Development", "Which of the following are Agile methodologies?", 4), ca1Answers);

            AnswerList ca2Answers = new AnswerList();
            ca2Answers.Add("WHERE", true);
            ca2Answers.Add("ORDER BY", true);
            ca2Answers.Add("GROUP BY", true);
            ca2Answers.Add("UPDATE", false);
            finalExam.AddQuestion(new ChooseAllQuestion("Databases", "Which SQL clauses are used in SELECT statements?", 4), ca2Answers);
            #endregion
            bool MainMenu = true;

            while (MainMenu)
            {
                Console.Clear();
                Console.WriteLine("=========================================================");
                Console.WriteLine("1. Take Practice Exam");
                Console.WriteLine("2. Take Final Exam");
                Console.WriteLine("3. Add Question To Exam");
                Console.WriteLine("4. Remove Question From Exam");
                Console.WriteLine("5. Display Practice Exam");
                Console.WriteLine("6. Display Final Exam");
                Console.WriteLine("7. Exit");
                Console.WriteLine("=========================================================");
                var UserInput = SafeInputReader.SafeReadString("Choose an option: ");

                switch (UserInput)
                {
                    case "1":
                        practiceExam.TakeExam();
                        break;

                    case "2":
                        finalExam.TakeExam();
                        break;

                    case "3":
                        AddQuestionMenu(practiceExam, finalExam);
                        break;

                    case "4":
                        RemoveQuestionMenu(practiceExam, finalExam);
                        break;

                    case "5":
                        practiceExam.DisplayExam();
                        break;

                    case "6":
                        finalExam.DisplayExam();
                        break;

                    case "7":
                        MainMenu = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        #region Functions for Adding and Removing Questions
        static void AddQuestionMenu(Exam practiceExam, Exam finalExam)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Which exam do you want to add to? (1.Practice 2.Final)");
                string examChoice = Console.ReadLine();
                Exam selectedExam = examChoice == "1" ? practiceExam : finalExam;

                Console.WriteLine("Choose Question Type: 1=True/False, 2=Choose One, 3=Choose All");
                string typeChoice = Console.ReadLine();

                string header = SafeInputReader.SafeReadString("Enter Question Header: ");
                string body = SafeInputReader.SafeReadString("Enter Question Body: ");
                int marks = SafeInputReader.SafeReadInt("Enter Marks: ", 1, 1000);

                Question q = new TrueFalseQuestion();

                switch (typeChoice)
                {
                    case "1":
                        q = new TrueFalseQuestion(header, body, marks);
                        break;
                    case "2":
                        q = new ChooseOneQuestion(header, body, marks);
                        break;
                    case "3":
                        q = new ChooseAllQuestion(header, body, marks);
                        break;
                    default:
                        Console.WriteLine("Invalid question type!");
                        return;
                }

                if (typeChoice == "1")
                {
                    q.Answers.Add("True", false);
                    q.Answers.Add("False", false);
                    int correct = SafeInputReader.SafeReadInt("Which is correct? (1=True 2=False): ", 1, 2);
                    q.Answers[correct - 1].IsCorrect = true;
                }
                else
                {
                    int count = SafeInputReader.SafeReadInt("How many answers? ", 2, 10);

                    for (int i = 0; i < count; i++)
                    {
                        string Text = SafeInputReader.SafeReadString($"Answer {i + 1} Text: ");
                        bool IsCorrect = SafeInputReader.SafeReadString($"Is Answer {i + 1} Correct? (y/n): ").Trim().ToLower() == "y";
                        q.Answers.Add(Text, IsCorrect);
                    }
                }

                selectedExam.AddQuestion(q, q.Answers);
                Console.WriteLine("Question added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding question: {ex.Message}");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }


        static void RemoveQuestionMenu(Exam practiceExam, Exam finalExam)
        {
            Console.Clear();
            Console.WriteLine("Which exam do you want to remove from? (1.Practice 2.Final)");
            string examChoice = Console.ReadLine();
            Exam selectedExam = examChoice == "1" ? practiceExam : finalExam;

            Console.WriteLine("Questions:");
            int index = 1;
            List<Question> keys = new List<Question>(selectedExam.QA.Keys);
            foreach (var question in keys)
            {
                Console.WriteLine($"{index}. {question.Body}");
                index++;
            }

            Console.Write("Enter question number to remove: ");
            int removeIndex = int.Parse(Console.ReadLine()) - 1;
            if (removeIndex >= 0 && removeIndex < keys.Count)
            {
                selectedExam.RemoveQuestion(keys[removeIndex]);
                Console.WriteLine("Question removed successfully!");
            }
            else
            {
                Console.WriteLine("Invalid index!");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        #endregion
    }
}
