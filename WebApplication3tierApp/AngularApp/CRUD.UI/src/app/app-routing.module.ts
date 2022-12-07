import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './components/home/home.component';
import { PractitionersListComponent } from './components/practitioners/practitioners-list/practitioners-list.component';
import { AddPractitionerComponent } from './components/practitioners/add-practitioner/add-practitioner.component';
import { EditPractitionerComponent } from './components/practitioners/edit-practitioner/edit-practitioner.component';
import { ClientsListComponent } from './components/clients/clients-list/clients-list.component';
import { AddClientComponent } from './components/clients/add-client/add-client.component';
import { EditClientComponent } from './components/clients/edit-client/edit-client.component';


const routes: Routes = [
  {
    path: '',
    component: HomeComponent
  },
  {
    path: 'practitioners',
    component: PractitionersListComponent
  },
  {
    path: 'practitioners/add',
    component: AddPractitionerComponent 
  },
  {
    path: 'practitioners/edit/:id',
    component: EditPractitionerComponent 
  },
  {
    path: 'clients',
    component: ClientsListComponent
  },
  {
    path: 'clients/add',
    component: AddClientComponent 
  },
  {
    path: 'clients/edit/:id',
    component: EditClientComponent 
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes), BrowserModule, CommonModule],
  exports: [RouterModule]
})
export class AppRoutingModule { }

