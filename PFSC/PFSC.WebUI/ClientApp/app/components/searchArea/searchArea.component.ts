import { Component } from '@angular/core';
import { Http, Response } from '@angular/http';
import { ActivatedRoute } from '@angular/router'

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

    page:number = 1;

    allPages: number[];
    currentPage:number;

    constructor(private searchService: SearchService, private route: ActivatedRoute) {
        console.log();
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

        this.route.params.subscribe(
            (param: any) => {
                this.page = param['page'] || 1;
                console.log(this.page);
                this.loadFactories();
            });

        this.loadFactories();
    }

    private loadFactories() {
        this.searchService.searchFactories(this.page).subscribe((data: Response) => {
            console.log(data.json());
            let rawResponse = data.json();
            this.factories = rawResponse.factories;
            this.currentPage = rawResponse.currentPage;
            this.allPages = new Array<number>(rawResponse.allPages);
            for (let i = 0; i < this.allPages.length; i++) {
                this.allPages[i] = i + 1;
            }
        });
    }
}
