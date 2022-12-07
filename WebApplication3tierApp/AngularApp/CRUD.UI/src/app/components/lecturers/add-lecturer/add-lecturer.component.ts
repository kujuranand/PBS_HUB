import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Lecturer } from 'app/models/lecturer.model';
import { LecturersService } from 'app/services/lecturers.service';


@Component({
  selector: 'app-add-lecturer',
  templateUrl: './add-lecturer.component.html',
  styleUrls: ['./add-lecturer.component.css']
})
export class AddLecturerComponent implements OnInit {

  addLecturerRequest: Lecturer = {
    id: '',
    name: '',
    email: '',
    phone: 0,
  };

  constructor(private lecturerService: LecturersService, private router: Router) { }

  ngOnInit(): void {
  }

  addLecturer() {
    this.lecturerService.addLecturer(this.addLecturerRequest)
    .subscribe({
      next: (lecturer) => {
        this.router.navigate(['lecturers']);
      }
    });
  }

}
