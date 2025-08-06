using System;

namespace MethodTest {
    class Program {
        static void Main() {
            const float MATH_GRADE          = 80.0f;
            const float BIOLOGY_GRADE       = 80.0f;
            const float PROGRAMMING_GRADE   = 92.0f;
            const string STUDENT_NAME       = "G. Treele";
            //call CalculateAverage() to calculate the average grade.
            float average = CalculateAverage(MATH_GRADE, BIOLOGY_GRADE,PROGRAMMING_GRADE);

            // Call ShowAverage() to display the student name & overall average.
            ShowAverage(STUDENT_NAME, average);
            Console.ReadLine();
        }
        //Method to calculate the average of 3 course grades
        static float CalculateAverage(float MATH_GRADE, float BIOLOGY_GRADE, float PROGRAMMING_GRADE) {
            float total = MATH_GRADE + BIOLOGY_GRADE + PROGRAMMING_GRADE;
            return total / 3;
        }

        //Method to display the student's name and average
        static void ShowAverage(string STUDENT_NAME, float average) {
            Console.WriteLine($"{STUDENT_NAME} average: {average}");
        }
    
    }
}
