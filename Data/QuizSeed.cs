﻿using CuriosityFind.Models;

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

        public static List<Option> OptionsSeed()
        {
            var options = new List<Option>
            {
                OptionSeed("Choice 1"),
                OptionSeed("Choice 2"),
                OptionSeed("Choice 3"),
                OptionSeed("Choice 4")
            };
            return options;
        }

        public static List<Question> QuestionsTemplate()
        {
            var questions = new List<Question>
            { 
                QuestionSeed("Question 1", "Choice 1", OptionsSeed()),
                QuestionSeed("Question 2", "Choice 2", OptionsSeed()),
                QuestionSeed("Question 3", "Choice 3", OptionsSeed()),
                QuestionSeed("Question 4", "Choice 4", OptionsSeed())
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
