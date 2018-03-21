import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { of } from 'rxjs/observable/of';
import { Instruction } from '../models/instruction';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class InstructionService {

    instruction: Instruction;

    constructor(private http: HttpClient) { }

    getMainInstruction(): Observable<Instruction> {
        return this.http.get<Instruction>('/api/Instructions/');
    }
}