import { CoursesService } from './courses.service';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, Resolve, RouterStateSnapshot } from "@angular/router";
import { Course } from "src/app/models/course.model";

@Injectable()
export class CourseResolver implements Resolve<Course>{

    constructor(private service: CoursesService) {

    }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Course> {
        const code = route.paramMap.get("course-detail");
        console.log("CODE in resolver: " + code);
        return this.service.getCourseByCode(code);
    }
}