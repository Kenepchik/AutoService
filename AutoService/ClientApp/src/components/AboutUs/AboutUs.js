import React, {Component} from 'react';
import '../Reset.css';
import '../Fonts.css';
import './AboutUs.css';
import AboutUsPic from '../../img/AboutUs.png';

export class AboutUs extends Component {
    static displayName = AboutUs.name;

    render() {
        return (
            <div className="background"><img className="AboutUs" src={AboutUsPic} alt="AboutUs"/></div>
        );
    }
}
