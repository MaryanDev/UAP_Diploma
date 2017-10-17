import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector: 'mode-switcher',
    templateUrl: './modeSwitcher.component.html',
    styleUrls: ['./modeSwitcher.css']
})
export class ModeSwitcherComponent {
    isListLinkActive: boolean = true;
    isMapLinkActive: boolean = false;

    onListClick() {
        this.isListLinkActive = true;
        this.isMapLinkActive = false;
    }

    onMapClick() {
        this.isListLinkActive = false;
        this.isMapLinkActive = true;
    }
}
