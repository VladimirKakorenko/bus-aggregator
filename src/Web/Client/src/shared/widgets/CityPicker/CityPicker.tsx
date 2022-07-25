import React from 'react';
import { Map } from '@shared/widgets/CityPicker/Map/Map';
import { Widget } from '../Widget';

export class CityPicker extends React.PureComponent {
    render() {
        return (
            <Widget>
                <Map styles={{ height: 500, width: 500 }} />
            </Widget>
        )
    }
}