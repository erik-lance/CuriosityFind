using CuriosityFind.Models;

namespace CuriosityFind.Data
{
    public class QuizSeed
    {
        public static Quiz Quiz1()
        {
            var quizQuestions = new List<Question>
            {
                new Question
                {
                    QuestionTitle = "Question 1",
                    Choices = new List<string> { "Choice 1", "Choice 2", "Choice 3", "Choice 4" },
                    Answer = "Choice 1"
                },
                new Question
                {
                    QuestionTitle = "Question 2",
                    Choices = new List<string> { "Choice 1", "Choice 2", "Choice 3", "Choice 4" },
                    Answer = "Choice 2"
                },
                new Question
                {
                    QuestionTitle = "Question 3",
                    Choices = new List<string> { "Choice 1", "Choice 2", "Choice 3", "Choice 4" },
                    Answer = "Choice 3"
                },
                new Question
                {
                    QuestionTitle = "Question 4",
                    Choices = new List<string> { "Choice 1", "Choice 2", "Choice 3", "Choice 4" },
                    Answer = "Choice 4"
                },
                new Question
                {
                    QuestionTitle = "Question 5",
                    Choices = new List<string> { "Choice 1", "Choice 2", "Choice 3", "Choice 4" },
                    Answer = "Choice 1"
                }
            };

            return new Quiz
            {
                Title = "Quiz 1",
                Description = "Quiz 1 Description",
                Questions = quizQuestions
            };
        }

        public static Quiz Quiz2()
        {
            var quizQuestions = new List<Question>
            {
                new Question
                {
                    QuestionTitle = "Question 1",
                    Choices = new List<string> { "Choice 1", "Choice 2", "Choice 3", "Choice 4" },
                    Answer = "Choice 1"
                },
                new Question
                {
                    QuestionTitle = "Question 2",
                    Choices = new List<string> { "Choice 1", "Choice 2", "Choice 3", "Choice 4" },
                    Answer = "Choice 2"
                },
                new Question
                {
                    QuestionTitle = "Question 3",
                    Choices = new List<string> { "Choice 1", "Choice 2", "Choice 3", "Choice 4" },
                    Answer = "Choice 3"
                },
                new Question
                {
                    QuestionTitle = "Question 4",
                    Choices = new List<string> { "Choice 1", "Choice 2", "Choice 3", "Choice 4" },
                    Answer = "Choice 4"
                },
                new Question
                {
                    QuestionTitle = "Question 5",
                    Choices = new List<string> { "Choice 1", "Choice 2", "Choice 3", "Choice 4" },
                    Answer = "Choice 1"
                }
            };
            return new Quiz
            {
                Title = "Quiz 2",
                Description = "Quiz 2 Description",
                Questions = quizQuestions
            };
        }
    }
}
