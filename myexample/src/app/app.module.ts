import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule, JsonpModule } from '@angular/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { app_routing } from './app.routing';


@NgModule({
    declarations: [AppComponent, app_routing.components],
    providers: [],
    imports: [BrowserModule, HttpModule, FormsModule, JsonpModule, ReactiveFormsModule, app_routing.routes],
bootstrap: [AppComponent]
})
export class AppModule { }
