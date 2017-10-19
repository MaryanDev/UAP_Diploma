import { Component, EventEmitter, Input, Output } from '@angular/core';

@
Component({
    selector: 'pagination',
    templateUrl: './pagination.component.html'
})
export class PaginationComponent {
    @Input()
    allPages: number[];
    @Input()
    currentPage: number;

    @Output() onPageClick = new EventEmitter<number>();

    navigateToPage(page: number) {
        this.onPageClick.emit(page);
    }
}