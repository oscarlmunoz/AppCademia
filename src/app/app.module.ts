import { AuthenticationModule } from './modules/authentication/authentication.module';
import { environment } from './../environments/environment.prod';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from "@angular/common/http";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AngularFireModule } from '@angular/fire';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { MainComponent } from './components/public/main/main.component';
import { HeaderComponent } from './components/shared/header/header.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialCdkModule } from './material-cdk/material-cdk.module';
import { CardComponent } from './components/shared/card/card.component';
import { AboutComponent } from './components/public/about/about.component';
import { CourseDetailComponent } from './components/public/course-detail/course-detail.component';
import { PageNotFoundComponent } from './components/public/page-not-found/page-not-found.component';
import { SafePipe } from './pipes/safe-pipe.pipe';


@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    HeaderComponent,
    CardComponent,
    AboutComponent,
    CourseDetailComponent,
    PageNotFoundComponent,
    SafePipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AngularFireModule.initializeApp(environment.firebase),
    AngularFireModule,
    NgbModule,
    AuthenticationModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MaterialCdkModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
