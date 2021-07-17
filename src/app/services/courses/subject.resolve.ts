import { CoursesService } from './courses.service';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, Resolve, RouterStateSnapshot } from "@angular/router";
import { SubjectContent } from 'src/app/models/subject-content.model';

@Injectable()
export class SubjectResolver implements Resolve<SubjectContent>{

    constructor(private service: CoursesService) {

    }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<SubjectContent> {
        const code = route.paramMap.get("subject-detail");
        return this.service.getCourseByCode(code);
    }
}