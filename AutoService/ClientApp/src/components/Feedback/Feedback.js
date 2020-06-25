import React, {Component} from 'react';
import '../Reset.css';
import '../Fonts.css';
import './Feedback.css';
import FeedbackPic from '../../img/Feedback.png';

export class Feedback extends Component {
    static displayName = Feedback.name;

    render() {
        return (
            <div className="background"><img className="Feedback" src={FeedbackPic} alt="Feedback"/></div>
        );
    }
}
