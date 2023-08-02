import { Box, Button, CircularProgress, Container, Typography } from "@mui/material";
import React, { useEffect, useState } from "react";
import { useParams } from "react-router-dom";

interface Quiz {
    id: number;
    title: string;
    description: string;
    questions: Question[];
}

interface Question {
    id: number;
    questionTitle: string;
    answer: string;
}

function QuizPage() {
    const { id } = useParams();
    const [quiz, setQuiz] = useState(null as Quiz);
    const [currentQuestion, setCurrentQuestion] = useState(0);

    const nextQuestion = () => {
        setCurrentQuestion(currentQuestion + 1);
    }

    useEffect(() => {
        // Fetch the quiz from the server
        fetch(`/api/quiz/${id}`)
            .then(response => response.json())
            .then(data => setQuiz(data))
            .catch(error => console.log(error));
    }, [id]);

    return (
        <>
            <Container>
                {!quiz && <CircularProgress />}
                {quiz && (
                    <>
                        <Typography
                            variant="h3"
                        >
                            {quiz.title}
                        </Typography>

                        <Typography
                            variant="subtitle1"
                        >
                            {quiz.description}
                        </Typography>

                        {/* Load Start, else load questions */}
                        {currentQuestion == 0 ? (<>
                            <Box
                                display="flex"
                                flexDirection="column"
                                gap={5}
                                justifyContent="center"
                                alignItems="center"
                                minHeight="50vh"
                            >
                                <Typography variant="h3">Are you ready to begin?</Typography>
                                <Button
                                    variant="contained"
                                    onClick={() => setCurrentQuestion(1)}
                                >
                                    Begin!
                                </Button>
                            </Box>
                        </>) : (<>

                            {/* If reached max question, else */}
                            {currentQuestion === quiz.questions.length ? (<>
                                <Typography variant="h3">You have completed the quiz!</Typography>
                            </>) : (<>
                                {/* Displays each question one at a time */}
                                {/* Question is based on questionnumber set */}
                                <Typography
                                    variant="h4"
                                >
                                    {quiz.questions[currentQuestion].questionTitle}
                                </Typography>

                                {/* Displays each answer for the question */}
                            </>)}
                        </>)}





                    </>
                )}
            </Container>
        </>
    );
}

export default QuizPage;