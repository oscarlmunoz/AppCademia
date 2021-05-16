import { CoursesService } from './../../../services/courses/courses.service';
import { Component, OnInit } from '@angular/core';
import { Course } from 'src/app/models/course.model';
import { Router } from '@angular/router';


@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {

  cards: Array<Course> = new Array<Course>();
  constructor(
    public courseService: CoursesService,
    private router: Router
    ) { 
  }

  ngOnInit(): void {

    this.courseService.getCourses().subscribe( data => {
      data.forEach(element => {
        let card: Course = new Course();
        card = {
          id: element.id,
          code: element.code,
          title: element.title,
          altMainImage: "Imagen de " + element.title,
          mainImage: element.image,
          description: element.description,
          subtitle: element.subtitle
        }; 
        this.cards.push(card)
      });
    }
  )
  }

  detailEvent(code: string) {
    console.log("CODE from main: " + code);
    this.router.navigateByUrl(code);
  }

}
