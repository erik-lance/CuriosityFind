import { createTheme } from "@mui/material";

const theme = createTheme({
    palette: {
        primary: {
            light: "#F4D06F",
            main: "#FF8811",
        },
        secondary: {
            main: "#9DD9D2"
        },
        background: {
            default: "#FFF8F0",
            paper: "#392F5A"
        },
        text: {
            primary: "#000000",
            secondary: "#FFFFFF",
        },
    },
})

export default theme;
