import { AutocompleteFactory } from "./autocompleteFactory"
import { Location } from "./location";

export class Factory extends AutocompleteFactory{
    description: string;
    rating: number;
    location:Location;
}