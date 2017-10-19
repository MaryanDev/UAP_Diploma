//declare var localStorage: any;

import { Component, Input, AfterViewChecked } from '@angular/core';
import {Factory} from "../../models/factory";

@Component({
    selector: 'list-result',
    templateUrl: './listResult.component.html'
})
export class ListResultComponent  {
    @Input()
    factories: Factory[];
    @Input()
    allPages: number[];
    @Input()
    currentPage: number;

    constructor() {
    }

}
