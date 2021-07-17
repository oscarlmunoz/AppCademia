import { CourseContent } from 'src/app/models/course-content.model';
import { YoutubeService } from './../../../services/media/youtube.service';
import { CoursesService } from './../../../services/courses/courses.service';
import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Course } from 'src/app/models/course.model';
import { takeUntil } from 'rxjs/operators';
import { Observable } from 'rxjs/internal/Observable';

@Component({
  selector: 'app-course-detail',
  templateUrl: './course-detail.component.html',
  styleUrls: ['./course-detail.component.css']
})
export class CourseDetailComponent implements OnInit {

  course: Course;
  syllabus$: Observable<CourseContent[]>;
  showSyllabus: boolean = true; // will be used/modified when securing the app
  showingSubject: CourseContent;
  player: any;
  video: any;

  constructor(
    private route:ActivatedRoute,
    public courseService: CoursesService,
    public youtubeService: YoutubeService,
    private router: Router
    ) { }

  ngOnInit(): void {
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
        if (this.showSyllabus) {
          this.syllabus$ = this.courseService.getCourseContent(this.course.syllabus);
        }
  }

  // showSubject(subject: Subject) {
  //   this.showSyllabus = false;
  //   this.showingSubject = subject;
  //   this.youtubeService
  //     .getVideo(subject.video)
  //     .subscribe(video => {
  //       if (video != null && video.items.length > 0) {
  //         this.video = video.items[0]
  //       }
  //     });
  // }

  showSubject(subject: CourseContent) {
    this.router.navigateByUrl("/subject/" + subject.name);
  }

  hideSubject() {
    this.showSyllabus = true;
    this.showingSubject = null;
  }

  getVideoIframe(id: string): string {
    //                            [src]="getVideoIframe(video?.id)"
    return `https://www.youtube.com/embed/${id}`
  }


}
