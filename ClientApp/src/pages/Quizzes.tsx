import React from "react";
import { useState } from "react";
import { Container, List, ListItem, ListItemText, Typography } from "@mui/material";

export default function Quizzes() {
    const [quizzes, setQuizzes] = useState([]);

    function fetchQuizzes() {
        fetch("https://localhost:44482/api/quiz")
            .then(response => response.json())
            .then(data => setQuizzes(data));
    }


    return (
        <Container>
            <Typography variant="h1">Quizzes</Typography>

            <button onClick={fetchQuizzes}>Fetch Quizzes</button>

            <List>
                {quizzes.map(quiz => (
                    <ListItem key="quiz.id">
                        <ListItemText
                            primary={quiz.title}
                            secondary={quiz.description}
                        />
                    </ListItem>
                ))}

            </List>
        </Container>
    );
}