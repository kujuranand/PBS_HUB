import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subject } from 'app/models/subject.model';
import { SubjectsService } from 'app/services/subjects.service';


@Component({
  selector: 'app-edit-subject',
  templateUrl: './edit-subject.component.html',
  styleUrls: ['./edit-subject.component.css']
})
export class EditSubjectComponent implements OnInit {
  
  subjectDetails: Subject = {
    id: '',
    code: '',
    name: '',
    semester: 0,
  };

  constructor(private route: ActivatedRoute, private subjectService: SubjectsService, private router: Router) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const id = params.get('id');

        if (id) {
          this.subjectService.getSubject(id)
          .subscribe({
            next: (response) => {
              this.subjectDetails = response;
            }
          });
        }
      }
    })
  }

  updateSubject() {
    this.subjectService.updateSubject(this.subjectDetails.id, this.subjectDetails)
    .subscribe({
      next: (response) => {
        this.router.navigate(['subjects']);
      }
    });
  }

  deleteSubject(id: string) {
    this.subjectService.deleteSubject(id)
    .subscribe({
      next: (response) => {
        this.router.navigate(['subjects']);
      }
    });
  }

}
