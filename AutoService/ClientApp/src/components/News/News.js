import React, {Component} from 'react';
import '../Reset.css';
import '../Fonts.css';
import './News.css';
import NewsPic from '../../img/News.png';

export class News extends Component {
    static displayName = News.name;

    render() {
        return (
            <div className="background"><img className="News" src={NewsPic} alt="News"/></div>
        );
    }
}
