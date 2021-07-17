import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CourseContent } from 'src/app/models/course-content.model';
import { SubjectContent } from 'src/app/models/subject-content.model';

@Injectable({
  providedIn: 'root'
})
export class CoursesService {

  constructor(private http: HttpClient) { }
  
  getCourses(): Observable<any> {
    return this.http.get("https://localhost:5001/api/Course");
  }

  getCourseByCode(code: string): Observable<any> {
    return this.http.get(`https://localhost:5001/api/course/${code}`);
  }

  getCourseContent(fileName: string): Observable<Array<CourseContent>> {
    return this.http.get<Array<CourseContent>>(`https://localhost:5001/api/course/courseContent/${fileName}`);
  }

  getSubjectContent(fileName: string): Observable<Array<SubjectContent>> {
    return this.http.get<Array<SubjectContent>>(`https://localhost:5001/api/course/subjectContent/${fileName}`);
  }

}
