import { Component, Input } from '@angular/core';
import { SearchFactory } from "../../models/searchFactory";

@Component({
    selector: 'map-result',
    templateUrl: './mapResult.component.html',
    styleUrls: ['./mapResult.css']
})
export class MapResultComponent {
    //positions: number[][];

    @Input()
    factories: SearchFactory[];

    //showRandomMarkers() {
    //    let randomLat: number, randomLng: number;
    //    this.positions = [];
    //    for (let i = 0; i < 9; i++) {
    //        randomLat = Math.random() * 0.0099 + 43.7250;
    //        randomLng = Math.random() * 0.0099 + -79.7699;
    //        this.positions.push([randomLat, randomLng]);
    //    }
    //}

    constructor() {
        //this.showRandomMarkers();
    }
}


