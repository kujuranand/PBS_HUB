import { Component, OnInit } from '@angular/core';
import { Practitioner } from 'app/models/practitioner.model';
import { PractitionersService } from 'app/services/practitioners.service';


@Component({
  selector: 'app-practitioners-list',
  templateUrl: './practitioners-list.component.html',
  styleUrls: ['./practitioners-list.component.css']
})
export class PractitionersListComponent implements OnInit {

  practitioners: Practitioner[] = [];
  constructor(private practitionersService: PractitionersService) { }

  ngOnInit(): void {
    this.practitionersService.getAllPractitioners()
    .subscribe({
      next: (practitioners) => {
        this.practitioners = practitioners;
      },
      error: (response) => {
        console.log(response);
      }
    });

  }
  
}
 