import { Component } from '@angular/core';
import { Http, Response } from '@angular/http';
import { PrintingProduction } from "../../models/printingProduction";
import { PrintingTechnology } from "../../models/printingTechnology";
import { SearchService } from '../../services/searchAjax.service'
import { Factory } from "../../models/factory";

@Component({
    selector: 'search-area',
    templateUrl: './searchArea.component.html',
    providers: [SearchService]
})
export class SearchAreaComponent {
    production: PrintingProduction[];
    technologies: PrintingTechnology[];

    selectedProduction: PrintingProduction[];
    selectedTechnology: PrintingTechnology[];

    factories: Factory[];

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

        this.searchService.searchFactories().subscribe((data: Response) => {
            console.log(data.json());
            this.factories = data.json();
        });
    }
}
