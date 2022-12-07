import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Client } from 'app/models/client.model';
import { ClientsService } from 'app/services/clients.service';

@Component({
  selector: 'app-add-client',
  templateUrl: './add-client.component.html',
  styleUrls: ['./add-client.component.css']
})
export class AddClientComponent implements OnInit {

  addClientRequest: Client = {
    id: '',
    name: '',
    email: '',
    phone: 0,
    behaviour: ''
  };

  constructor(private clientService: ClientsService, private router: Router) { }

  ngOnInit(): void {
  }

  addClient() {
    this.clientService.addClient(this.addClientRequest)
    .subscribe({
      next: (client) => {
        this.router.navigate(['clients']);
      }
    });
  }

}
