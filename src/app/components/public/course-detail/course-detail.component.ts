import { JsonpClientBackend } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Course } from 'src/app/models/course.model';

@Component({
  selector: 'app-course-detail',
  templateUrl: './course-detail.component.html',
  styleUrls: ['./course-detail.component.css']
})
export class CourseDetailComponent implements OnInit {

  @Input() courseCode: number;
  course: Course;

  constructor(private route:ActivatedRoute) { }

  ngOnInit(): void {
    this.course = this.route.snapshot.data["course"];
    console.log("Curso en detail: " + JSON.stringify(this.course));
  }

}
