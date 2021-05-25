import { CourseContent } from './../../../models/course-content.model';
import { CoursesService } from './../../../services/courses/courses.service';
import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Course } from 'src/app/models/course.model';

@Component({
  selector: 'app-course-detail',
  templateUrl: './course-detail.component.html',
  styleUrls: ['./course-detail.component.css']
})
export class CourseDetailComponent implements OnInit {

  course: Course;
  syllabus: CourseContent[] = [];

  constructor(
    private route:ActivatedRoute,
    public courseService: CoursesService
    ) { }

  ngOnInit(): void {
    //this.course = this.route.snapshot.data["course"];
    const element = this.route.snapshot.data["course"];
    this.course = new Course();

        this.course = {
          id: element.id,
          code: element.code,
          title: element.title,
          altMainImage: "Imagen de " + element.title,
          mainImage: element.image,
          description: element.description,
          subtitle: element.subtitle,
          syllabus: element.syllabus
        }; 

        this.courseService.getCourseContent(this.course.syllabus).subscribe(
          data => {
            data.forEach(element => {
              let subject: CourseContent = new CourseContent();
              subject = {
                id: element.id,
                image: element.image,
                name: element.name,
                text: element.text,
                video: element.video
              };
              this.syllabus.push(subject);
            });
          }
        )

        console.log(this.syllabus);
  }

}
