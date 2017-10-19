import { Injectable, InjectionToken } from '@angular/core';
import { Http } from '@angular/http';
import { PrintingProduction } from "../models/printingProduction";
import { PrintingTechnology } from "../models/printingTechnology";



@Injectable()
export class SearchService {
    constructor(private http: Http) { }

    getProduction() {
        return this.http.get('getProduction');
        //    .map((response) => {
        //    return response.json()
        //});
    }
    getTechnologies() {
        return this.http.get('getTechnologies');
        //    .map((response) => {
        //    return response.json()
        //});
    }

    getFactoriesForAutocomplete(searchCriteria: string) {
        return this.http.get(`factoriesForAutocomplete/${searchCriteria}`);
    }

    searchFactories(page:number) {
        return this.http.get(`searchFactories/${page}`);
    }


}