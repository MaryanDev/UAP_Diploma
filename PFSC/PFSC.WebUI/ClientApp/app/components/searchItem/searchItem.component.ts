import { Component, Input } from '@angular/core';
import { Factory } from "../../models/factory";

@Component({
    selector: 'search-item',
    templateUrl: './searchItem.component.html'
})
export class SearchItemComponent {
    @Input()
    factory : Factory;
}
