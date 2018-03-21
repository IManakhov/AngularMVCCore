import { Component, OnInit } from '@angular/core';
import { InstructionService } from '../services/instruction.service';
import { Instruction } from '../models/instruction';

@Component({
    selector: 'app-instruction',
    templateUrl: './instruction.component.html',
    styleUrls: ['./instruction.component.css']
})
export class InstructionComponent implements OnInit {

    constructor(private instructionService: InstructionService) { }

    instruction: Instruction;

    ngOnInit() {
        this.setInstructionInfo()
    }

    setInstructionInfo() {
        this.instructionService.getMainInstruction().subscribe(instr => this.instruction = instr);
    }
}
