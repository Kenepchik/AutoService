import React, {Component} from 'react';
import '../Reset.css';
import '../Fonts.css';
import './Catalogs.css';
import CatalogsPic from '../../img/Catalogs.png';

export class Catalogs extends Component {
    static displayName = Catalogs.name;

    render() {
        return (
            <div className="background"><img className="Catalogs" src={CatalogsPic} alt="Catalogs"/></div>
        );
    }
}
