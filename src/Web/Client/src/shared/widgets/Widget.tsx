import React, { PropsWithChildren } from 'react';

export const Widget: React.FC<any> = (props: PropsWithChildren<{}>) => {
    return (
        <div {...props} className='widget-wrapper'>
            {props.children}
        </div>
    )
};