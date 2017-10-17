export class PrintingProduction {
    id: number;
    title: string;
    description: string;
    isChecked: boolean;

    constructor(id: number, title:string, desc:string ) {
        this.id = id;
        this.title = title;
        this.description = desc;
    }
}