import { CircularProgress, Container } from "@mui/material";
import React, { useEffect, useState } from "react";
import { useParams } from "react-router-dom";

function QuizPage() {
    const { id } = useParams();
    const [quiz, setQuiz] = useState(null);

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
                        
                    </>
                )}
            </Container>
        </>
    );
}

export default QuizPage;