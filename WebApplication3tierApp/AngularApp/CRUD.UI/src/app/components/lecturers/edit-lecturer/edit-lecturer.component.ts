import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Lecturer } from 'app/models/lecturer.model';
import { LecturersService } from 'app/services/lecturers.service';


@Component({
  selector: 'app-edit-lecturer',
  templateUrl: './edit-lecturer.component.html',
  styleUrls: ['./edit-lecturer.component.css']
})
export class EditLecturerComponent implements OnInit {
  
  lecturerDetails: Lecturer = {
    id: '',
    name: '',
    email: '',
    phone: 0,
  };

  constructor(private route: ActivatedRoute, private lecturerService: LecturersService, private router: Router) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const id = params.get('id');

        if (id) {
          this.lecturerService.getLecturer(id)
          .subscribe({
            next: (response) => {
              this.lecturerDetails = response;
            }
          });
        }
      }
    })
  }

  updateLecturer() {
    this.lecturerService.updateLecturer(this.lecturerDetails.id, this.lecturerDetails)
    .subscribe({
      next: (response) => {
        this.router.navigate(['lecturers']);
      }
    });
  }

  deleteLecturer(id: string) {
    this.lecturerService.deleteLecturer(id)
    .subscribe({
      next: (response) => {
        this.router.navigate(['lecturers']);
      }
    });
  }

}
