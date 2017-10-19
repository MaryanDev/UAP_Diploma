//declare var localStorage: any;

import { Component, Input } from '@angular/core';
import {Factory} from "../../models/factory";

@Component({
    selector: 'list-result',
    templateUrl: './listResult.component.html'
})
export class ListResultComponent {
    @Input()
    factories: Factory[];

    constructor() {
        //this.factories =JSON.parse(localStorage.getItem("factories").toString());
        //console.log("factories in list view - ", this.factories);
    }
}
