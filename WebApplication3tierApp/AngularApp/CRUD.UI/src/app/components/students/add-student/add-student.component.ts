import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Student } from 'app/models/student.model';
import { StudentsService } from 'app/services/students.service';


@Component({
  selector: 'app-add-student',
  templateUrl: './add-student.component.html',
  styleUrls: ['./add-student.component.css']
})
export class AddStudentComponent implements OnInit {

  addStudentRequest: Student = {
    id: '',
    name: '',
    email: '',
    phone: 0,
    course: ''
  };

  constructor(private studentService: StudentsService, private router: Router) { }

  ngOnInit(): void {
  }

  addStudent() {
    this.studentService.addStudent(this.addStudentRequest)
    .subscribe({
      next: (student) => {
        this.router.navigate(['students']);
      }
    });
  }

}
