import React, {Component} from 'react';
import '../Reset.css';
import '../Fonts.css';
import './Service.css';

export class Service extends Component {
    constructor(props) {
        super(props);
    }

    static displayName = Service.name;

    render() {
        console.log(this.props.data)
        return (
            <div className="block">
                <div className="number">{this.props.data.id}</div>
                <div className="separator-horizontal"/>
                <div className="separator-vertical sv1"/>
                <div className="separator-vertical sv2"/>
                <div className="separator-vertical sv3"/>
                <div className="separator-vertical sv4"/>
                <div className="name verh">{this.props.data.name}</div>
                <div className="complexity verh">Сложность</div>
                <div className="price verh">Цена</div>
                <div className="guarantee verh">Гарантия</div>
                <div className="master verh">Мастер</div>
                <div className="description niz">{this.props.data.description}</div>
                <div className="complexity-value niz">{this.props.data.complexity}</div>
                <div className="price-value niz">{this.props.data.price}</div>
                <div className="guarantee-value niz">{this.props.data.guarantee}</div>
                <div className="master-value niz">{this.props.data.masters.fio}</div>
            </div>
        );
    }
}
