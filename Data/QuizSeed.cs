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
                    Answer = "Answer 1"
                },
                new Question
                {
                    QuestionTitle = "Question 2",
                    Answer = "Answer 2"
                },
                new Question
                {
                    QuestionTitle = "Question 3",
                    Answer = "Answer 3"
                },
                new Question
                {
                    QuestionTitle = "Question 4",
                    Answer = "Answer 4"
                },
                new Question
                {
                    QuestionTitle = "Question 5",
                    Answer = "Answer 5"
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
                    Answer = "Answer 1"
                },
                new Question
                {
                    QuestionTitle = "Question 2",
                    Answer = "Answer 2"
                },
                new Question
                {
                    QuestionTitle = "Question 3",
                    Answer = "Answer 3"
                },
                new Question
                {
                    QuestionTitle = "Question 4",
                    Answer = "Answer 4"
                },
                new Question
                {
                    QuestionTitle = "Question 5",
                    Answer = "Answer 5"
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
