import React from 'react';

import { Country } from '@core/widgets/Country/Country';
import { Widget } from '@core/widgets/Widget';

export const App = () => {
    return (
        <div className="map-wrapper">
            <Widget>
            <Country />
            </Widget>
        </div>
    );
}
