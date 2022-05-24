import React, { PropsWithChildren } from 'react';

export const Widget: React.FC<any> = ({ children }: PropsWithChildren<{}>) => {
    return (
        <div className='widget-wrapper'>
            {children}
        </div>
    )
};