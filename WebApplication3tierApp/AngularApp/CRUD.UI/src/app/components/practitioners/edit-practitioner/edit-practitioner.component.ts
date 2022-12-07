import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Practitioner } from 'app/models/practitioner.model';
import { PractitionersService } from 'app/services/practitioners.service';

@Component({
  selector: 'app-edit-practitioner',
  templateUrl: './edit-practitioner.component.html',
  styleUrls: ['./edit-practitioner.component.css']
})
export class EditPractitionerComponent implements OnInit {
  
  practitionerDetails: Practitioner = {
    id: '',
    name: '',
    email: '',
    phone: 0,
    department: ''
  };

  constructor(private route: ActivatedRoute, private practitionerService: PractitionersService, private router: Router) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const id = params.get('id');

        if (id) {
          this.practitionerService.getPractitioner(id)
          .subscribe({
            next: (response) => {
              this.practitionerDetails = response;
            }
          });
        }
      }
    })
  }

  updatePractitioner() {
    this.practitionerService.updatePractitioner(this.practitionerDetails.id, this.practitionerDetails)
    .subscribe({
      next: (response) => {
        this.router.navigate(['practitioners']);
      }
    });
  }

  deletePractitioner(id: string) {
    this.practitionerService.deletePractitioner(id)
    .subscribe({
      next: (response) => {
        this.router.navigate(['practitioners']);
      }
    });
  }

}
