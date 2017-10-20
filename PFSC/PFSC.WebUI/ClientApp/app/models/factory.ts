import { SearchFactory } from "./searchFactory";
import { Rating } from "./rating";
import {Review} from "./review";
import {PrintingProduction} from"./printingProduction";
import { PrintingTechnology } from "./printingTechnology";
import {Machine} from"./machine";
import { WorkingHours } from "./workingHours";

export class Factory extends SearchFactory {
    dateCreated:Date;
    countOfEmployees:string;
    siteUrl:string;
    district:string;
    factoryImages:string[];
    reviews:Review[];
    technologies:PrintingTechnology[];
    production:PrintingProduction[];
    machines:Machine[];
    workingHours:WorkingHours[];
}