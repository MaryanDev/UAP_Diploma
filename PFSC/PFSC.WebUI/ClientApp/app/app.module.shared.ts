import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule, Routes } from '@angular/router';
import { HashLocationStrategy, LocationStrategy } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import {
    MatAutocompleteModule,
    MatButtonModule,
    MatButtonToggleModule,
    MatCardModule,
    MatCheckboxModule,
    MatChipsModule,
    MatDatepickerModule,
    MatDialogModule,
    MatExpansionModule,
    MatGridListModule,
    MatIconModule,
    MatInputModule,
    MatListModule,
    MatMenuModule,
    MatNativeDateModule,
    MatPaginatorModule,
    MatProgressBarModule,
    MatRadioModule,
    MatRippleModule,
    MatSelectModule,
    MatSidenavModule,
    MatSliderModule,
    MatSlideToggleModule,
    MatSnackBarModule,
    MatSortModule,
    MatTableModule,
    MatTabsModule,
    MatToolbarModule,
    MatTooltipModule,
    MatStepperModule
} from '@angular/material';
import { CdkTableModule } from '@angular/cdk/table';

import { NguiMapModule } from '@ngui/map';

import { AppComponent } from './components/app/app.component';
import { SearchSidebarComponent } from "./components/searchSidebar/searchSidebar.component";
import { PaginationComponent } from "./components/pagination/pagination.component";
import { SearchFieldComponent } from "./components/searchField/searchField.component";
//import { ModeSwitcherComponent } from "./components/modeSwitcher/modeSwitcher.component";
import { SearchItemComponent } from "./components/searchItem/searchItem.component";
import { ListResultComponent } from "./components/listResult/listResult.component";
import { MapResultComponent } from "./components/mapResult/mapResult.component";
import { SearchAreaComponent } from "./components/searchArea/searchArea.component";


@NgModule({
    declarations: [
        AppComponent,
        SearchSidebarComponent,
        PaginationComponent,
        SearchFieldComponent,
        //ModeSwitcherComponent,
        SearchItemComponent,
        ListResultComponent,
        MapResultComponent,
        SearchAreaComponent
    ],
    imports: [
        CommonModule,
        //BrowserAnimationsModule,
        NoopAnimationsModule,
        HttpModule,
        FormsModule,
        ReactiveFormsModule,

        MatAutocompleteModule,
        MatButtonModule,
        MatButtonToggleModule,
        MatCardModule,
        MatCheckboxModule,
        MatChipsModule,
        MatDatepickerModule,
        MatDialogModule,
        MatExpansionModule,
        MatGridListModule,
        MatIconModule,
        MatInputModule,
        MatListModule,
        MatMenuModule,
        MatNativeDateModule,
        MatPaginatorModule,
        MatProgressBarModule,
        MatRadioModule,
        MatRippleModule,
        MatSelectModule,
        MatSidenavModule,
        MatSliderModule,
        MatSlideToggleModule,
        MatSnackBarModule,
        MatSortModule,
        MatTableModule,
        MatTabsModule,
        MatToolbarModule,
        MatTooltipModule,
        MatStepperModule,

        //RouterModule.forRoot([
        //    { path: 'factories', component: SearchAreaComponent, pathMatch: 'full' },
        //    //{ path: 'mapView', component: MapResultComponent },
        //    { path: '', redirectTo: 'factories', pathMatch: 'full' }
        //]),

        RouterModule.forRoot([

            { path: 'companies', component: SearchAreaComponent },
            { path: '', component: SearchAreaComponent },
            { path: '**', component: SearchAreaComponent }
        ]),
        NguiMapModule.forRoot({ apiUrl: 'https://maps.google.com/maps/api/js?key=AIzaSyDggJ-GvvJXNII9jccODZ3fKI5cIyW7BMs' })
    ],
    //providers: [
    //    { provide: LocationStrategy, useClass: HashLocationStrategy }
    //]
})
export class AppModuleShared {
}
