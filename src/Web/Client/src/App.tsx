import React from 'react';

import { Widget } from '@core/widgets/Widget';
import { Country } from '@core/widgets/Country/Country';
import './App.css';

export const App = () => {
    return (
        <div className="map-wrapper">
            <Widget>
                <Country />
            </Widget>
        </div>
    );
}
