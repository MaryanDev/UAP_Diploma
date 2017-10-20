import { Component, OnInit } from "@angular/core";
import { Http, Response } from '@angular/http';
import { ActivatedRoute } from '@angular/router'
import { FactoryService } from '../../services/factoryAjax.service'
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/startWith';
import 'rxjs/add/operator/map';

import { Factory } from "../../models/factory"
import { SearchFactory } from "../../models/searchFactory";

@Component({
    selector: "company-details",
    templateUrl: "./companyDetails.component.html",
    providers:[FactoryService]
})
export class CompanyDetailsComponent {
    factoryId: number;

    factory: Factory;

    factoriesForMap: SearchFactory[];
    constructor(private factoryService: FactoryService, private route: ActivatedRoute) {
        
    }

    ngOnInit() {
        this.route.params.subscribe(
            (param: any) => {
                this.factoryId = param['factoryId'] || 1;
                console.log(this.factoryId);
                this.factoryService.getFactory(this.factoryId).subscribe((data: Response) => {
                    console.log(data.json());
                    this.factory = data.json();
                    this.factoriesForMap = [this.factory];
                });
            });
    }
}