import { Component, Input } from '@angular/core';
import { SearchFactory } from "../../models/searchFactory";

@Component({
    selector: 'search-item',
    templateUrl: './searchItem.component.html'
})
export class SearchItemComponent {
    @Input()
    factory : SearchFactory;
}
