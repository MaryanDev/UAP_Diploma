import { Injectable, InjectionToken } from '@angular/core';
import { Http } from '@angular/http';


@Injectable()
export class FactoryService {
    constructor(private http: Http) {}

    getFactory(factoryId: number) {
        return this.http.get(`getFactoryInfo/${factoryId}`);
    }
}
