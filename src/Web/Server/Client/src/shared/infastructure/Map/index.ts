export type CaptionPosition = {
    x: number;
    y: number;
}

export type indicatorPosition = {
    cx: number;
    cy: number;
}

export type CityPoint = {
    id: string;
    caption: string;

    captionPosition: CaptionPosition;
    indicatorPosition: indicatorPosition;
}
