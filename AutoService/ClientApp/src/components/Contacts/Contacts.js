import React, {Component} from 'react';
import '../Reset.css';
import '../Fonts.css';
import './Contacts.css';
import ContactsPic from '../../img/Contacts.png';

export class Contacts extends Component {
    static displayName = Contacts.name;

    render() {
        return (
            <div className="background"><img className="Contacts" src={ContactsPic} alt="Contacts"/></div>
        );
    }
}
