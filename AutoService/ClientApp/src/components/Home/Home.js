import React, {Component} from 'react';
import '../Reset.css';
import '../Fonts.css';
import './Home.css';
import home from "../../img/home-content.png";

export class Home extends Component {
    static displayName = Home.name;

    render() {
        return (
            <div className="main-content">
                <img src={home} alt="Home"/>
            </div>
        );
    }
}
