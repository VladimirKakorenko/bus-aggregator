import { CityPoint } from '@shared/infastructure/Map';

export const cities = [
    {
        id: 'hrodna',
        caption: 'Hrodna',

        captionPosition: {
            x: -100,
            y: 280,
        },

        indicatorPosition: {
            cx: 50,
            cy: 250,
        },
    }, {
        id: 'brest',
        caption: 'Brest',

        captionPosition: {
            x: -130,
            y: 870,
        },

        indicatorPosition: {
            cx: 45,
            cy: 380,
        },
    }, {
        id: 'gomel',
        caption: 'Gomel',

        captionPosition: {
            x: 1600,
            y: 645,
        },

        indicatorPosition: {
            cx: 400,
            cy: 355,
        },
    }, {
        id: 'mogilev',
        caption: 'Mogilev',

        captionPosition: {
            x: 1580,
            y: 235,
        },

        indicatorPosition: {
            cx: 370,
            cy: 220,
        },
    }, {
        id: 'vitebsk',
        caption: 'Vitebsk',

        captionPosition: {
            x: 1300,
            y: -330,
        },

        indicatorPosition: {
            cx: 360,
            cy: 115,
        },
    }, {
        id: 'minsk',
        caption: 'Minsk',

        captionPosition: {
            x: 690,
            y: 255,
        },

        indicatorPosition: {
            cx: 230,
            cy: 225,
        },
    },
] as CityPoint[];