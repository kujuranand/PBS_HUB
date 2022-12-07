import { Component, OnInit } from '@angular/core';
import { Client } from 'app/models/client.model';
import { ClientsService } from 'app/services/clients.service';



@Component({
  selector: 'app-clients-list',
  templateUrl: './clients-list.component.html',
  styleUrls: ['./clients-list.component.css']
})
export class ClientsListComponent implements OnInit {

  clients: Client[] = [];
  constructor(private clientsService: ClientsService) { }

  ngOnInit(): void {
    this.clientsService.getAllClients()
    .subscribe({
      next: (clients) => {
        this.clients = clients;
      },
      error: (response) => {
        console.log(response);
      }
    });

  }
  
}
 