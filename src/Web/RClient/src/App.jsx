import { Country } from './core/widgets/Country/Country.jsx';
import { Widget } from './core/widgets/Widget.jsx';
import React from 'react';

export const App = () => {
    return (
        <div className="map-wrapper">
            <Widget>
            <Country />
            </Widget>
        </div>
    );
}
