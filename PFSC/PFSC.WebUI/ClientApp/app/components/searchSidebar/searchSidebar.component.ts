import { Component } from '@angular/core';
import { PrintingProduction } from "../../models/printingProduction";
import { PrintingTechnology } from "../../models/printingTechnology";

@Component({
    selector: 'search-sidebar',
    templateUrl: './searchSidebar.component.html'
})
export class SearchSidebarComponent {
    checked = false;
    indeterminate = false;
    align = 'start';
    disabled = false;

    production: PrintingProduction[];
    technologies: PrintingTechnology[];
}
