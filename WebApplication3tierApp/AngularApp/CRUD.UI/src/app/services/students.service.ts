import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'environments/environment';
import { Observable } from 'rxjs';
import { Student } from '../models/student.model';

@Injectable({
  providedIn: 'root'
})
export class StudentsService {

  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }


  getAllStudents(): Observable<Student[]> {
    return this.http.get<Student[]>(this.baseApiUrl + '/api/student');
  }

  addStudent(addStudentRequest: Student): Observable<Student> {
    addStudentRequest.id = '0';
    return this.http.post<Student>(this.baseApiUrl + '/api/student', addStudentRequest);
  }

  getStudent(id: string): Observable<Student> {
    return this.http.get<Student>(this.baseApiUrl + '/api/student/' + id);
  }

  updateStudent(id: string, updateStudentRequest: Student): Observable<Student> {
    return this.http.put<Student>(this.baseApiUrl + '/api/student/update' + id, updateStudentRequest);
  }

  deleteStudent(id: string): Observable<Student> {
    return this.http.delete<Student>(this.baseApiUrl + '/api/student/' + id);
  }

}
