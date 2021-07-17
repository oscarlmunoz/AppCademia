import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { Course } from 'src/app/models/course.model';
import { SubjectContent } from 'src/app/models/subject-content.model';
import { CoursesService } from 'src/app/services/courses/courses.service';
import { YoutubeService } from 'src/app/services/media/youtube.service';

@Component({
  selector: 'app-subject-detail',
  templateUrl: './subject-detail.component.html',
  styleUrls: ['./subject-detail.component.css']
})
export class SubjectDetailComponent implements OnInit {

  course: Course;
  syllabus$: Observable<SubjectContent[]>;
  showSyllabus: boolean = true; // will be used/modified when securing the app
  showingSubject: SubjectContent;
  player: any;
  video: any;

  constructor(
    private route:ActivatedRoute,
    public courseService: CoursesService,
    public youtubeService: YoutubeService
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

  showSubject(subject: SubjectContent) {
    this.showSyllabus = false;
    this.showingSubject = subject;
    this.youtubeService
      .getVideo(subject.video)
      .subscribe(video => {
        if (video != null && video.items.length > 0) {
          this.video = video.items[0]
        }
      });
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
