import React from "react";
import { useState } from "react";
import { Container, IconButton, List, ListItem, ListItemSecondaryAction, ListItemText, Typography } from "@mui/material";
import PlayArrowIcon from '@mui/icons-material/PlayArrow';

export default function Quizzes() {
    const [quizzes, setQuizzes] = useState([]);

    function fetchQuizzes() {
        fetch("https://localhost:44482/api/quiz")
            .then(response => response.json())
            .then(data => setQuizzes(data));
    }

    fetchQuizzes();

    return (
        <Container>
            <Typography variant="h1">Quizzes</Typography>

            <List>
                {quizzes.map(quiz => (
                    <ListItem key={quiz.id}>
                        <ListItemText
                            primary={quiz.title}
                            secondary={quiz.description}
                        />
                        <ListItemSecondaryAction>
                            <IconButton aria-label="go-to-quiz"
                                href={`/quiz/${quiz.id.toString()}`}
                            >
                                <PlayArrowIcon />
                            </IconButton>
                        </ListItemSecondaryAction>
                    </ListItem>
                ))}

            </List>
        </Container>
    );
}