export class AutocompleteFactory {
    id:number;
    title:string;
    avatar:string;
    address: string;

    constructor(id: number, title: string, avatar: string, address: string) {
        this.id = id;
        this.title = title;
        this.avatar = avatar;
        this.address = address;
    }
}