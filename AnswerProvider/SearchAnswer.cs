using System;

namespace AnswerProvider
{
    public class SearchAnswer
    {
        public int Category { get; set; }
        public int QuestionType { get; set; }
        public string GetAnswer(int Category, int QuestionType)
        {
            string answer = string.Empty;
            if(Category == 0 && QuestionType == 0)
            {
                answer = @"Please Entert Category and Question Type.
                                For Personal Finace : Category  - 1, Question Type - 1
                                For Mutual Funds : Categoty - 2, Question Type - 1
                                For Stock Markets : Categoty - 3, Question Type - 1
                                For Bonds : Categoty - 4, Question Type - 1
                                For Others : Categoty - 5, Question Type - 1";
                return answer;
            }
            else if(Category == 1 && QuestionType == 1)
            {
                answer =  @"Personal Finance is the first step towrads financial knowledge. 
                            Keep an eye on your expenses. 
                            You should save first and then plan your expensens of what is left out.
                            People ususally do opposite of it.";
                return answer;
            }
            else if (Category == 2 && QuestionType == 1)
            {
                answer = @"Mutual Funds are usueful when you have a goal and want to save for it.
                            Like buying a Car, Home or a vacation.
                            But there is market risk also involved.";
                return answer;
            }
            else if (Category == 3 && QuestionType == 1)
            {
                answer = @"Stock Market is a place where you can buy a stock 
                            and become a partner of the company whoes share you buy.
                            It will help you generate a secondary income in form of dividends.";
                return answer;
            }
            else
            {
                answer = @"Please enter a valid category and question type.";
                return answer;
            }           
            
        }
    }
}
