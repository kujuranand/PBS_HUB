import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'environments/environment';
import { Observable } from 'rxjs';

import { Practitioner } from '../models/practitioner.model';

@Injectable({
  providedIn: 'root'
})
export class PractitionersService {

  baseApiUrl: string = environment.baseApiUrl;
  constructor(private http: HttpClient) { }

  getAllPractitioners(): Observable<Practitioner[]> {
    return this.http.get<Practitioner[]>(this.baseApiUrl + '/api/practitioner');
  }

  addPractitioner(addPractitionerRequest: Practitioner): Observable<Practitioner> {
    addPractitionerRequest.id = '0';
    return this.http.post<Practitioner>(this.baseApiUrl + '/api/practitioner', addPractitionerRequest);
  }

  getPractitioner(id: string): Observable<Practitioner> {
    return this.http.get<Practitioner>(this.baseApiUrl + '/api/practitioner/' + id);
  }

  updatePractitioner(id: string, updatePractitionerRequest: Practitioner): Observable<Practitioner> {
    return this.http.put<Practitioner>(this.baseApiUrl + '/api/practitioner/' + id, updatePractitionerRequest);
  }

  deletePractitioner(id: string): Observable<Practitioner> {
    return this.http.delete<Practitioner>(this.baseApiUrl + '/api/practitioner/' + id);
  }
}
