import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HomeComponent } from './components/home/home.component';
import { PractitionersListComponent } from './components/practitioners/practitioners-list/practitioners-list.component';
import { AddPractitionerComponent } from './components/practitioners/add-practitioner/add-practitioner.component';
import { EditPractitionerComponent } from './components/practitioners/edit-practitioner/edit-practitioner.component';
import { ClientsListComponent } from './components/clients/clients-list/clients-list.component';
import { AddClientComponent } from './components/clients/add-client/add-client.component';
import { EditClientComponent } from './components/clients/edit-client/edit-client.component';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';

@NgModule({
  declarations: [
    AppComponent,
    PractitionersListComponent,
    AddPractitionerComponent,
    EditPractitionerComponent,
    ClientsListComponent,
    AddClientComponent,
    EditClientComponent,
    HomeComponent,
    LoginComponent,
    RegisterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
