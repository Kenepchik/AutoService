import React, {Component} from 'react';
import '../Reset.css';
import '../Fonts.css';
import './Navigation.css';
import Link from "react-router-dom/Link";

export class Navigation extends Component {
    static displayName = Navigation.name;

    render() {
        return (
            <div className="navigation">
                <div className="sign-up"><Link className="navigation-a" to="/record">Записаться</Link></div>
                <div className="services"><Link className="navigation-a" to="/services">Услуги</Link></div>
                <div className="catalogs"><Link className="navigation-a" to="/catalogs">Каталоги</Link></div>
                <div className="news"><Link className="navigation-a" to="/news">Новости</Link></div>
                <div className="about-us"><Link className="navigation-a" to="/aboutus">О нас</Link></div>
                <div className="feedback"><Link className="navigation-a" to="/feedback">Обратная связь</Link></div>
                <div className="contacts"><Link className="navigation-a" to="/contacts">Контакты</Link></div>
                <div className="navigation-background"/>
            </div>
        );
    }
}
