import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CoursesService {

  constructor(private http: HttpClient) { }
  
  getCourses(): Observable<any> {
    return this.http.get("https://localhost:5001/api/Course");
  }

  getCourseByCode(code: string): Observable<any> {
    console.log("CODE in service: " + code);
    return this.http.get(`https://localhost:5001/api/course/${code}`);
  }

}
