import { Component } from '@angular/core';
import { Http, Response } from '@angular/http';
import { PrintingProduction } from "../../models/printingProduction";
import { PrintingTechnology } from "../../models/printingTechnology";
import { SearchService } from '../../services/searchAjax.service'
import { SearchFactory } from "../../models/searchFactory";


@Component({
    selector: 'app',
    templateUrl: './app.component.html',

})
export class AppComponent {
}
