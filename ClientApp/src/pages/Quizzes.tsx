import React from "react";
import { useState } from "react";
import { Container, IconButton, List, ListItem, ListItemSecondaryAction, ListItemText, Paper, Typography } from "@mui/material";
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
                    <Paper
                        elevation={3}
                    >
                    <ListItem
                        key={quiz.id}
                    >
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

                    </Paper>
                ))}

            </List>
        </Container>
    );
}