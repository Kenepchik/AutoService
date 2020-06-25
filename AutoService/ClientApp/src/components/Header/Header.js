import React, {Component} from 'react';
import '../Reset.css';
import '../Fonts.css';
import './Header.css';
import icon from '../../img/profile-icon.png';
import {Link} from "react-router-dom";

export class Header extends Component {
    static displayName = Header.name;

    render() {
        return (
            <header>
                <div className="header-text"><Link className="header-a" to="/">AutoService</Link></div>
                <div><Link to="/signup"><img className="profile-icon" src={icon} alt="Icon"/></Link></div>
                <div className="header-background"/>
            </header>
        );
    }
}
