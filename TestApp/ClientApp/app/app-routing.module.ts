import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { InstructionComponent } from './instruction/instruction.component';
import { PeopleComponent } from './people/people.component';

const routes: Routes = [
    { path: 'instruction', component: InstructionComponent },
    { path: 'people', component: PeopleComponent }
];

@NgModule({
  exports: [ RouterModule ],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  declarations: []
})
export class AppRoutingModule { }