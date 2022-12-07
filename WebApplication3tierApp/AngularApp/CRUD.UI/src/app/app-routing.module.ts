import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';
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


const routes: Routes = [
  {
    path: '',
    component: HomeComponent
  },
  {
    path: 'employees',
    component: EmployeesListComponent
  },
  {
    path: 'employees/add',
    component: AddEmployeeComponent 
  },
  {
    path: 'employees/edit/:id',
    component: EditEmployeeComponent 
  },
  {
    path: 'students',
    component: StudentsListComponent
  },
  {
    path: 'students/add',
    component: AddStudentComponent 
  },
  {
    path: 'students/edit/:id',
    component: EditStudentComponent 
  },
  {
    path: 'courses',
    component: CoursesListComponent
  },
  {
    path: 'courses/add',
    component: AddCourseComponent 
  },
  {
    path: 'courses/edit/:id',
    component: EditCourseComponent 
  },
  {
    path: 'lecturers',
    component: LecturersListComponent
  },
  {
    path: 'lecturers/add',
    component: AddLecturerComponent 
  },
  {
    path: 'lecturers/edit/:id',
    component: EditLecturerComponent 
  },
  {
    path: 'subjects',
    component: SubjectsListComponent
  },
  {
    path: 'subjects/add',
    component: AddSubjectComponent 
  },
  {
    path: 'subjects/edit/:id',
    component: EditSubjectComponent 
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes), BrowserModule, CommonModule],
  exports: [RouterModule]
})
export class AppRoutingModule { }

