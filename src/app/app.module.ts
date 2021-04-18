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

@NgModule({
  declarations: [
    AppComponent,
    MainComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AngularFireModule.initializeApp(environment.firebase),
    AngularFireModule,
    NgbModule,
    AuthenticationModule,
    HttpClientModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
