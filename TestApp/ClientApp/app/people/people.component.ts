import { Component, OnInit } from '@angular/core';
import { PeopleService } from '../services/people.service';
import { People } from '../models/people';

@Component({
    selector: 'app-people',
    templateUrl: './people.component.html',
    styleUrls: ['./people.component.css']
})
export class PeopleComponent implements OnInit {

    peoples: People[];

    constructor(private peopleService: PeopleService) { }

    ngOnInit() {
        this.getPeoples();
    }

    getPeoples(): void {
        this.peopleService.getAll().subscribe(peops => this.peoples = peops);
    }
}
