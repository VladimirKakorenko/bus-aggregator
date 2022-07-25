import React from 'react';
import { Widget } from '../Widget';
import './DatePicker.css'

export class DatePicker extends React.PureComponent {
    render() {
        return (
            <Widget>
                <div className='datePickerBlock'>
                    <div className='datePickerButtonGroup'>
                        <div className='datePickerButtonCalendar dateButton'>Calendar</div>
                        <div className='datePickerButtonToday dateButton' >Today</div>
                        <div className='datePickerButtonTomorrow dateButton'>Tomorrow</div>
                        <div className='datePickerButtonDayAfterTomorrow dateButton'>PosleTomorroww</div>
                    </div>
                </div>
            </Widget>
        )
    }
}