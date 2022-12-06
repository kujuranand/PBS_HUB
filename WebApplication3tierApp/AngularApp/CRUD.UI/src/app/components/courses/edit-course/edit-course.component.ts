import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Course } from 'app/models/course.model';
import { CoursesService } from 'app/services/courses.service';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-edit-course',
  templateUrl: './edit-course.component.html',
  styleUrls: ['./edit-course.component.css']
})
export class EditCourseComponent implements OnInit {
  
  courseDetails: Course = {
    id: '',
    name: '',
    duration: 0,
  };

  constructor(private route: ActivatedRoute, private courseService: CoursesService, private router: Router, private toastr: ToastrService) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const id = params.get('id');

        if (id) {
          this.courseService.getCourse(id)
          .subscribe({
            next: (response) => {
              this.courseDetails = response;
            }
          });
        }
      }
    })
  }

  updateCourse() {
    this.courseService.updateCourse(this.courseDetails.id, this.courseDetails)
    .subscribe({
      next: (response) => {
        this.router.navigate(['courses']);
        this.toastr.success("You Updated Successfully")
      }
    });
  }

  deleteCourse(id: string) {
    this.courseService.deleteCourse(id)
    .subscribe({
      next: (response) => {
        this.router.navigate(['courses']);
        this.toastr.success("You Deleted Successfully")
      }
    });
  }

}
