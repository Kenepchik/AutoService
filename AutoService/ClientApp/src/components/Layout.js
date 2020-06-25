import React, {Component} from 'react';
import {Header} from './Header/Header';
import {Navigation} from './Navigation/Navigation';
import {Footer} from './Footer/Footer';
import {Route} from "react-router-dom";
import {Home} from "./Home/Home";
import {Services} from "./Services/Services";
import {Catalogs} from "./Catalogs/Catalogs";
import {News} from "./News/News";
import {AboutUs} from "./AboutUs/AboutUs";
import {Feedback} from "./Feedback/Feedback";
import {Contacts} from "./Contacts/Contacts";
import {Record} from "./Record/Record";
import {SignUp} from "./SignUp/SignUp";

export class Layout extends Component {
    static displayName = Layout.name;

    render() {
        return (
            <div>
                <Header/>
                <Navigation/>
                <div>
                    <Route exact path='/' component={Home}/>
                    <Route exact path='/signup' component={SignUp}/>
                    <Route exact path='/record' component={Record}/>
                    <Route exact path='/services' component={Services}/>
                    <Route exact path='/catalogs' component={Catalogs}/>
                    <Route exact path='/news' component={News}/>
                    <Route exact path='/aboutus' component={AboutUs}/>
                    <Route exact path='/feedback' component={Feedback}/>
                    <Route exact path='/contacts' component={Contacts}/>
                </div>
                <Footer/>
            </div>
        );
    }
}
