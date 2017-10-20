import { AutocompleteFactory } from "./autocompleteFactory"
import { Location } from "./location";

export class SearchFactory extends AutocompleteFactory{
    description: string;
    rating: number;
    location:Location;
}