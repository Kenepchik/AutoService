import React, {Component} from 'react';
import '../Reset.css';
import '../Fonts.css';
import './Services.css';
import {Service} from "../Service/Service";

export class Services extends Component {
    static displayName = Services.name;
    constructor(props) {
        super(props);
        this.state = {services: [], loading: true};
    }

    componentDidMount() {
        this.populateServicesData();
    }

    static renderServices(services) {
        return (
            services.map(service => <Service data={service} key={service.id}/>
            )
        );
    }

    render() {
        console.log(this.state.services);
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Services.renderServices(this.state.services);

        return (
            <div className="background-services">
                <div className="news-label">Услуги</div>
                {contents}
            </div>
        );
    }

    async populateServicesData() {
        const response = await fetch('api/services/');
        const data = await response.json();
        this.setState({services: data, loading: false});
    }
}
