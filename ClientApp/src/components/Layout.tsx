import { ThemeProvider } from '@mui/material';
import React, { Component, ReactNode } from 'react';
import { Container } from 'reactstrap';
import theme from '../styles/theme';
import { NavMenu } from './NavMenu';

interface LayoutProps {
    children: ReactNode;
}

export class Layout extends Component<LayoutProps> {
    static displayName = Layout.name;

    render() {
        return (
            <div>
                <ThemeProvider theme={theme}>
                    <NavMenu />
                    <Container>
                        {this.props.children}
                    </Container>
                </ThemeProvider>
            </div>
        );
    }
}
