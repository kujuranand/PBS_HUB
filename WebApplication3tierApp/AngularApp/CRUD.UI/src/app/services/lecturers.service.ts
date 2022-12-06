import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'environments/environment';
import { Observable } from 'rxjs';
import { Lecturer } from '../models/lecturer.model';

@Injectable({
  providedIn: 'root'
})
export class LecturersService {

  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }


  getAllLecturers(): Observable<Lecturer[]> {
    return this.http.get<Lecturer[]>(this.baseApiUrl + '/api/lecturer');
  }

  addLecturer(addLecturerRequest: Lecturer): Observable<Lecturer> {
    addLecturerRequest.id = '0';
    return this.http.post<Lecturer>(this.baseApiUrl + '/api/lecturer', addLecturerRequest);
  }

  getLecturer(id: string): Observable<Lecturer> {
    return this.http.get<Lecturer>(this.baseApiUrl + '/api/lecturer/' + id);
  }

  updateLecturer(id: string, updateLecturerRequest: Lecturer): Observable<Lecturer> {
    return this.http.put<Lecturer>(this.baseApiUrl + '/api/lecturer/' + id, updateLecturerRequest);
  }

  deleteLecturer(id: string): Observable<Lecturer> {
    return this.http.delete<Lecturer>(this.baseApiUrl + '/api/lecturer/' + id);
  }

}
