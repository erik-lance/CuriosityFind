import React, { Component } from 'react';
import { AppBar, Box, Typography, Link, Toolbar, Stack } from '@mui/material';
import '../styles/NavMenu.css';

interface NavMenuState {
    collapsed: boolean;
}

export class NavMenu extends Component<{}, NavMenuState> {
    static displayName = NavMenu.name;

    constructor(props) {
        super(props);

        this.toggleNavbar = this.toggleNavbar.bind(this);
        this.state = {
            collapsed: true
        };
    }

    toggleNavbar() {
        this.setState({
            collapsed: !this.state.collapsed
        });
    }

    render() {
        return (
            <header>
                <Box sx={{ flexGrow: 1 }}>
                    <AppBar position="static"
                        sx={{
                            backgroundColor: "background.paper",
                            color: "text.secondary"
                        } }
                    >
                        <Toolbar>
                            <Typography
                                variant="h6" component="div" sx={{ flexGrow: 1 }}>
                                CuriosityFind
                            </Typography>
                            <Box sx={{ flexGrow: 1 }} />
                            <Stack
                                direction="row"
                                spacing={2}
                            >
                                <Link href="/" underline="none" color="white">Home</Link>
                                <Link href="/counter" underline="none" color="white">Counter</Link>
                                <Link href="/fetch-data" underline="none" color="white">Fetch data</Link>
                            </Stack>
                        </Toolbar>
                    </AppBar>
                </Box>
            </header>
        );
    }
}
