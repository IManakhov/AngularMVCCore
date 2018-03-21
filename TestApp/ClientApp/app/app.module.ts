import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { InstructionComponent } from './instruction/instruction.component';
import { PeopleComponent } from './people/people.component';
import { NavmenuComponent } from './navmenu/navmenu.component';
import { AppRoutingModule } from './/app-routing.module';
import { InstructionService } from './services/instruction.service';
import { PeopleService } from './services/people.service';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        HttpClientModule ,
        AppRoutingModule
    ],
    declarations: [
        AppComponent,
        InstructionComponent,
        PeopleComponent,
        NavmenuComponent
    ],
    providers: [InstructionService, PeopleService],
    bootstrap: [AppComponent]
})
export class AppModule { }