import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Practitioner } from 'app/models/practitioner.model';
import { PractitionersService } from 'app/services/practitioners.service';

@Component({
  selector: 'app-add-practitioner',
  templateUrl: './add-practitioner.component.html',
  styleUrls: ['./add-practitioner.component.css']
})
export class AddPractitionerComponent implements OnInit {

  addPractitionerRequest: Practitioner = {
    id: '',
    name: '',
    email: '',
    phone: 0,
    department: ''
  };

  constructor(private practitionerService: PractitionersService, private router: Router) { }

  ngOnInit(): void {
  }

  addPractitioner() {
    this.practitionerService.addPractitioner(this.addPractitionerRequest)
    .subscribe({
      next: (practitioner) => {
        this.router.navigate(['practitioners']);
      }
    });
  }

}
