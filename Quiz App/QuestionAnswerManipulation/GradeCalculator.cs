using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Quiz_App
{
    class GradeCalculator
    {
        private static int howManyCorrect = 0;
        private int arrayIndex;

        public GradeCalculator(int arrayIndex)
        {
            this.arrayIndex = arrayIndex;
        }

        public void FindHowManyCorrectAnswers(object parameter)
        {
            switch(arrayIndex)
            {
                case 0:
                    if((string)parameter == "Answer4")
                    {
                        ++howManyCorrect;
                    }
                    break;
                case 1:
                    if((string)parameter == "Answer3")
                    {
                        ++howManyCorrect;
                    }
                    break;
                case 2:
                    if ((string)parameter == "Answer4")
                    {
                        ++howManyCorrect;
                    }
                    break;
                case 3: 
                    if((string)parameter == "Answer2")
                    {
                        ++howManyCorrect;
                    }
                    break;
                case 4:
                    if((string)parameter == "Answer1")
                    {
                        ++howManyCorrect;
                    }
                    break;
                case 5:
                    if((string)parameter == "Answer3")
                    {
                        ++howManyCorrect;
                    }
                    break;
                case 6:
                    if((string)parameter == "Answer4")
                    {
                        ++howManyCorrect;
                    }
                    break;
                case 7:
                    if((string)parameter == "Answer2")
                    {
                        ++howManyCorrect;
                    }
                    break;
                case 8: 
                    if((string)parameter == "Answer4")
                    {
                        ++howManyCorrect;
                    }
                    break;
                case 9: 
                    if((string)parameter == "Answer1")
                    {
                        ++howManyCorrect;
                    }
                    string howManyCorrectMessageBox = howManyCorrect.ToString();
                    double gradePercentage = (howManyCorrect/ViewModel.Questions.Length) * 100;
                    string gradePercentageMessageBox = gradePercentage.ToString();
                    MessageBox.Show("You got " + howManyCorrectMessageBox + " correct. Your grade is %" + 
                        gradePercentageMessageBox + ". You may now exit the test.");
                    break;

            }
        }
    }
}
