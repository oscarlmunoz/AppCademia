import { CourseResolver } from './services/courses/course.resolver';
import { PageNotFoundComponent } from './components/public/page-not-found/page-not-found.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutComponent } from './components/public/about/about.component';
import { CourseDetailComponent } from './components/public/course-detail/course-detail.component';
import { MainComponent } from "./components/public/main/main.component";

const routes: Routes = [
  { path: "", component: MainComponent, pathMatch: "full"},
  { path: "about", component: AboutComponent},
  { 
    path: ":course-detail", 
    component: CourseDetailComponent,
    resolve: {
      course: CourseResolver
    }
  },
  { path: "**", component: PageNotFoundComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  providers: [
    CourseResolver
  ]
})
export class AppRoutingModule {
 }
