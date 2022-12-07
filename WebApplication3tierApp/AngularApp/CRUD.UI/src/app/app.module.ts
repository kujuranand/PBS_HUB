import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { EmployeesListComponent } from './components/employees/employees-list/employees-list.component';
import { AddEmployeeComponent } from './components/employees/add-employee/add-employee.component';
import { EditEmployeeComponent } from './components/employees/edit-employee/edit-employee.component';
import { StudentsListComponent } from './components/students/students-list/students-list.component';
import { AddStudentComponent } from './components/students/add-student/add-student.component';
import { EditStudentComponent } from './components/students/edit-student/edit-student.component';
import { CoursesListComponent } from './components/courses/courses-list/courses-list.component';
import { AddCourseComponent } from './components/courses/add-course/add-course.component';
import { EditCourseComponent } from './components/courses/edit-course/edit-course.component';
import { LecturersListComponent } from './components/lecturers/lecturers-list/lecturers-list.component';
import { AddLecturerComponent } from './components/lecturers/add-lecturer/add-lecturer.component';
import { EditLecturerComponent } from './components/lecturers/edit-lecturer/edit-lecturer.component';
import { SubjectsListComponent } from './components/subjects/subjects-list/subjects-list.component';
import { AddSubjectComponent } from './components/subjects/add-subject/add-subject.component';
import { EditSubjectComponent } from './components/subjects/edit-subject/edit-subject.component';
import { HomeComponent } from './components/home/home.component';

@NgModule({
  declarations: [
    AppComponent,
    EmployeesListComponent,
    AddEmployeeComponent,
    EditEmployeeComponent,
    StudentsListComponent,
    AddStudentComponent,
    EditStudentComponent,
    CoursesListComponent,
    AddCourseComponent,
    EditCourseComponent,
    LecturersListComponent,
    AddLecturerComponent,
    EditLecturerComponent,
    SubjectsListComponent,
    AddSubjectComponent,
    EditSubjectComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
