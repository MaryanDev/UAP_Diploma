import { Component } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Http, Response } from '@angular/http';
import { SearchService } from '../../services/searchAjax.service'
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/startWith';
import 'rxjs/add/operator/map';

@Component({
        selector: 'search-field',
        templateUrl: './searchField.component.html',
        styleUrls: ['./searchField.css']
    })
export class SearchFieldComponent {
    //factoryCtrl: FormControl;
    filteredFactories: any;
    hideAutocomplete: boolean;

    //factories: any[] = [];

    constructor(private searchService: SearchService) {
        //this.factoryCtrl = new FormControl();
        //this.filteredFactories = this.factoryCtrl.valueChanges
        //    .startWith(null)
        //    .map(fact => this.filterFactories(fact));
    }

    onSearchChange(name: string) {
        this.hideAutocomplete = false;
        console.log(name);
        this.searchService.getFactoriesForAutocomplete(name).subscribe((data: Response) => {
            console.log(data.text());
            this.filteredFactories = data.text();
        });

    }
}
