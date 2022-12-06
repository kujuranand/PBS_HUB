import { Component, OnInit } from '@angular/core';
import { Subject } from 'app/models/subject.model';
import { SubjectsService } from 'app/services/subjects.service';


@Component({
  selector: 'app-subjects-list',
  templateUrl: './subjects-list.component.html',
  styleUrls: ['./subjects-list.component.css']
})
export class SubjectsListComponent implements OnInit {

  subjects: Subject[] = [];
  constructor(private subjectsService: SubjectsService) { }

  ngOnInit(): void {
    this.subjectsService.getAllSubjects()
    .subscribe({
      next: (subjects) => {
        this.subjects = subjects;
      },
      error: (response) => {
        console.log(response);
      }
    });
    
  }

}
