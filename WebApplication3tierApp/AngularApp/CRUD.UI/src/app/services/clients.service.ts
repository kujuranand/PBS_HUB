import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'environments/environment';
import { Observable } from 'rxjs';

import { Client } from '../models/client.model';

@Injectable({
  providedIn: 'root'
})
export class ClientsService {

  baseApiUrl: string = environment.baseApiUrl;
  constructor(private http: HttpClient) { }

  getAllClients(): Observable<Client[]> {
    return this.http.get<Client[]>(this.baseApiUrl + '/api/client');
  }

  addClient(addClientRequest: Client): Observable<Client> {
    addClientRequest.id = '0';
    return this.http.post<Client>(this.baseApiUrl + '/api/client', addClientRequest);
  }

  getClient(id: string): Observable<Client> {
    return this.http.get<Client>(this.baseApiUrl + '/api/client/' + id);
  }

  updateClient(id: string, updateClientRequest: Client): Observable<Client> {
    return this.http.put<Client>(this.baseApiUrl + '/api/client/' + id, updateClientRequest);
  }

  deleteClient(id: string): Observable<Client> {
    return this.http.delete<Client>(this.baseApiUrl + '/api/client/' + id);
  }
}
