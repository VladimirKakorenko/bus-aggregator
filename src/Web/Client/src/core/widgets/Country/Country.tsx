import { Company } from 'core/infastructure/models/backend/Company';
import React from 'react';
import { Map } from 'shared/components/Map/Map';


export type CountryProps = {
    companies?: Company[];
}

export type CountryState = {

}

export class Country extends React.PureComponent<CountryProps, CountryState> {
    render() {
        return (
            <div>
                <Map />
            </div>
        )
    }
}