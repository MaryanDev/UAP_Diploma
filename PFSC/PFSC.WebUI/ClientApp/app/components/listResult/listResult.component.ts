//declare var localStorage: any;

import { Component, Input, AfterViewChecked } from '@angular/core';
import {SearchFactory} from "../../models/searchFactory";

@Component({
    selector: 'list-result',
    templateUrl: './listResult.component.html'
})
export class ListResultComponent  {
    @Input()
    factories: SearchFactory[];
    @Input()
    allPages: number[];
    @Input()
    currentPage: number;

    constructor() {
    }

}
