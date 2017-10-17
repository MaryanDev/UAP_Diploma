import { Component } from '@angular/core';

@Component({
    selector: 'search-sidebar',
    templateUrl: './searchSidebar.component.html'
})
export class SearchSidebarComponent {
    checked = false;
    indeterminate = false;
    align = 'start';
    disabled = false;
}
