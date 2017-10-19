import { Component } from "@angular/core";
import { Http, Response } from '@angular/http';
import { SearchService } from '../../services/searchAjax.service'
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/startWith';
import 'rxjs/add/operator/map';

@Component({
    selector: "company-details",
    templateUrl: "./companyDetails.component.html"
})
export class CompanyDetailsComponent {
    
}