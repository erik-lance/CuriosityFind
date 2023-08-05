using CuriosityFind.Models;

namespace CuriosityFind.Data
{
    public class QuizSeed
    {
        public static Question QuestionSeed(string title, string answer, List<Option> options)
        {
            return new Question
            {
                QuestionTitle = title,
                Answer = answer,
                Options = options
            };
        }

        public static Option OptionSeed(string title)
        {
            return new Option
            {
                OptionText = title
            };
        }

        public static List<Question> QuestionsTemplate()
        {
            var options = new List<Option>
            {
                OptionSeed("Choice 1"),
                OptionSeed("Choice 2"),
                OptionSeed("Choice 3"),
                OptionSeed("Choice 4")
            };

            var questions = new List<Question>
            {
                QuestionSeed("Question 1", "Choice 1", options),
                QuestionSeed("Question 2", "Choice 2", options),
                QuestionSeed("Question 3", "Choice 3", options),
                QuestionSeed("Question 4", "Choice 4", options),
                QuestionSeed("Question 5", "Choice 1", options)
            };

            return questions;
        }

        public static Quiz Quiz1()
        {
            var quizQuestions = QuestionsTemplate();

            return new Quiz
            {
                Title = "Quiz 1",
                Description = "Quiz 1 Description",
                Questions = quizQuestions
            };
        }

        public static Quiz Quiz2()
        {
            var quizQuestions = QuestionsTemplate();

            return new Quiz
            {
                Title = "Quiz 2",
                Description = "Quiz 2 Description",
                Questions = quizQuestions
            };
        }
    }
}
