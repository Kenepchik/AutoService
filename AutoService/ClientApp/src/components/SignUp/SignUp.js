import React, {Component} from 'react';
import '../Reset.css';
import '../Fonts.css';
import './SignUp.css';
import SignUpPic from '../../img/SignUp.png';

export class SignUp extends Component {
    static displayName = SignUp.name;

    render() {
        return (
            <div className="background"><img className="SignUp" src={SignUpPic} alt="SignUp"/></div>
        );
    }
}
