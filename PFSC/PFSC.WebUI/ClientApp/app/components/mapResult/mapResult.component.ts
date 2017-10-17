import { Component } from '@angular/core';

@Component({
    selector: 'map-result',
    templateUrl: './mapResult.component.html',
    styleUrls: ['./mapResult.css']
})
export class MapResultComponent {
    positions: Number[][];

    showRandomMarkers() {
        let randomLat: number, randomLng: number;
        this.positions = [];
        for (let i = 0; i < 9; i++) {
            randomLat = Math.random() * 0.0099 + 43.7250;
            randomLng = Math.random() * 0.0099 + -79.7699;
            this.positions.push([randomLat, randomLng]);
        }
    }

    constructor() {
        this.showRandomMarkers();
    }
}

class Location {
    Lattitude: number;
    Longittude: number;
    constructor(lat: number, lon: number) {
        this.Lattitude = lat;
        this.Longittude = lon;
    }
}
