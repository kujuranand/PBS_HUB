import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'environments/environment';
import { Observable } from 'rxjs';
import { Subject } from '../models/subject.model';

@Injectable({
  providedIn: 'root'
})
export class SubjectsService {

  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }


  getAllSubjects(): Observable<Subject[]> {
    return this.http.get<Subject[]>(this.baseApiUrl + '/api/subject');
  }

  addSubject(addSubjectRequest: Subject): Observable<Subject> {
    addSubjectRequest.id = '0';
    return this.http.post<Subject>(this.baseApiUrl + '/api/subject', addSubjectRequest);
  }

  getSubject(id: string): Observable<Subject> {
    return this.http.get<Subject>(this.baseApiUrl + '/api/subject/' + id);
  }

  updateSubject(id: string, updateSubjectRequest: Subject): Observable<Subject> {
    return this.http.put<Subject>(this.baseApiUrl + '/api/subject/update' + id, updateSubjectRequest);
  }

  deleteSubject(id: string): Observable<Subject> {
    return this.http.delete<Subject>(this.baseApiUrl + '/api/subject/' + id);
  }

}
