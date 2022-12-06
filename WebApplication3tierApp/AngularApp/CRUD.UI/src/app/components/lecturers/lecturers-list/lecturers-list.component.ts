import { Component, OnInit } from '@angular/core';
import { Lecturer } from 'app/models/lecturer.model';
import { LecturersService } from 'app/services/lecturers.service';


@Component({
  selector: 'app-lecturers-list',
  templateUrl: './lecturers-list.component.html',
  styleUrls: ['./lecturers-list.component.css']
})
export class LecturersListComponent implements OnInit {

  lecturers: Lecturer[] = [];
  constructor(private lecturersService: LecturersService) { }

  ngOnInit(): void {
    this.lecturersService.getAllLecturers()
    .subscribe({
      next: (lecturers) => {
        this.lecturers = lecturers;
      },
      error: (response) => {
        console.log(response);
      }
    });
    
  }

}
