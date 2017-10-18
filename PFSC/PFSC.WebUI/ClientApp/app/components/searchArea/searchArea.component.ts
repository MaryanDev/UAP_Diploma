import { Component, Input } from '@angular/core';
import {Factory} from "../../models/factory";
@Component({
    selector: 'search-area',
    templateUrl: './searchArea.component.html'
})
export class SearchAreaComponent {
    @Input()
    factories: Factory[];
}
