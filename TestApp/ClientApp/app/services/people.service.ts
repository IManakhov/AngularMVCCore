import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { of } from 'rxjs/observable/of';
import { People } from '../models/people';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class PeopleService {

    url: '/Peoples';

    instruction: People;

    constructor(private http: HttpClient) { }

    getAll(): Observable<People[]> {
        return this.http.get<People[]>('/api/Peoples');
    }
}
