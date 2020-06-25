import React, {Component} from 'react';
import '../Reset.css';
import '../Fonts.css';
import './Record.css';
import RecordPic from '../../img/Record.png';

export class Record extends Component {
    static displayName = Record.name;

    render() {
        return (
            <div className="background"><img className="Record" src={RecordPic} alt="Record"/></div>
        );
    }
}
