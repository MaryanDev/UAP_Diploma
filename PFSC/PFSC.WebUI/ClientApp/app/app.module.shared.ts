import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
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
    MatStepperModule} from '@angular/material';
import { CdkTableModule } from '@angular/cdk/table';

import { AppComponent } from './components/app/app.component';
import { SearchSidebarComponent } from "./components/searchSidebar/searchSidebar.component";
import { PaginationComponent } from "./components/pagination/pagination.component";
import { SearchFieldComponent } from "./components/searchField/searchField.component";
import { ModeSwitcherComponent } from "./components/modeSwitcher/modeSwitcher.component";
import { SearchItemComponent } from "./components/searchItem/searchItem.component";
import { ListResultComponent } from "./components/listResult/listResult.component";
import { MapResultComponent } from "./components/mapResult/mapResult.component";
import { SearchAreaComponent } from "./components/searchArea/searchArea.component";
//import { NavMenuComponent } from './components/navmenu/navmenu.component';
//import { HomeComponent } from './components/home/home.component';
//import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
//import { CounterComponent } from './components/counter/counter.component';


@NgModule({
    declarations: [
        AppComponent,
        SearchSidebarComponent,
        PaginationComponent,
        SearchFieldComponent,
        ModeSwitcherComponent,
        SearchItemComponent,
        ListResultComponent,
        MapResultComponent,
        SearchAreaComponent
    ],
    imports: [
        CommonModule,
        //BrowserAnimationsModule,
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
        MatStepperModule
        //RouterModule.forRoot([
        //    { path: '', redirectTo: 'home', pathMatch: 'full' },
        //    { path: 'home', component: HomeComponent },
        //    { path: 'counter', component: CounterComponent },
        //    { path: 'fetch-data', component: FetchDataComponent },
        //    { path: '**', redirectTo: 'home' }
        //])
    ]
})
export class AppModuleShared {
}
