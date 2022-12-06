import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'environments/environment';
import { Observable } from 'rxjs';
import { Course } from '../models/course.model';

@Injectable({
  providedIn: 'root'
})
export class CoursesService {

  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }


  getAllCourses(): Observable<Course[]> {
    return this.http.get<Course[]>(this.baseApiUrl + '/api/course');
  }

  addCourse(addCourseRequest: Course): Observable<Course> {
    addCourseRequest.id = '0';
    return this.http.post<Course>(this.baseApiUrl + '/api/course', addCourseRequest);
  }

  getCourse(id: string): Observable<Course> {
    return this.http.get<Course>(this.baseApiUrl + '/api/course/' + id);
  }

  updateCourse(id: string, updateCourseRequest: Course): Observable<Course> {
    return this.http.put<Course>(this.baseApiUrl + '/api/course/' + id, updateCourseRequest);
  }

  deleteCourse(id: string): Observable<Course> {
    return this.http.delete<Course>(this.baseApiUrl + '/api/course/' + id);
  }

}
