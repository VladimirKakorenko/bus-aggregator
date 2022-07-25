import React from 'react';

import { CityPicker } from '@shared/widgets/CityPicker/CityPicker';
import { DatePicker } from '@shared/widgets/DatePicker/DatePicker';

export const Main = () => {
    return (
        <>
            <DatePicker />
            <CityPicker />
        </>
    )
};