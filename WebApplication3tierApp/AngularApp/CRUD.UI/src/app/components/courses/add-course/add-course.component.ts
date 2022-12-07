import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Course } from 'app/models/course.model';
import { CoursesService } from 'app/services/courses.service';


@Component({
  selector: 'app-add-course',
  templateUrl: './add-course.component.html',
  styleUrls: ['./add-course.component.css']
})
export class AddCourseComponent implements OnInit {

  addCourseRequest: Course = {
    id: '',
    name: '',
    duration: 0,
  };

  constructor(private courseService: CoursesService, private router: Router) { }

  ngOnInit(): void {
  }

  addCourse() {
    this.courseService.addCourse(this.addCourseRequest)
    .subscribe({
      next: (course) => {
        this.router.navigate(['courses']);
      }
    });
  }

}
