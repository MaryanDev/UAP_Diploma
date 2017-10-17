import { Component, OnInit } from '@angular/core';
import { Http, Response } from '@angular/http';
import { PrintingProduction } from "../../models/printingProduction";
import { PrintingTechnology } from "../../models/printingTechnology";
import { SearchService } from '../../services/searchAjax.service'

@Component({
    selector: 'search-sidebar',
    templateUrl: './searchSidebar.component.html',
    providers: [SearchService]
})
export class SearchSidebarComponent {
    checked = false;
    indeterminate = false;
    align = 'start';
    disabled = false;

    production: PrintingProduction[];
    technologies: PrintingTechnology[];

    constructor(private searchService: SearchService) {

    }

    ngOnInit() {
        this.searchService.getProduction().subscribe((data: Response) => {
            console.log(data.json());
            this.production = data.json();
        });

        this.searchService.getTechnologies().subscribe((data: Response) => {
            console.log(data.json());
            this.technologies = data.json();
        });
    }
}
