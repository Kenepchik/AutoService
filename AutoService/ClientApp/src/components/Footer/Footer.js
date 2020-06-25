import React, {Component} from 'react';
import '../Reset.css';
import '../Fonts.css';
import './Footer.css';

export class Footer extends Component {
    static displayName = Footer.name;

    render() {
        return (
            <footer>
                <div className="footer-text">Copyright 2020</div>
                <div className="footer-background"/>
            </footer>
        );
    }
}
