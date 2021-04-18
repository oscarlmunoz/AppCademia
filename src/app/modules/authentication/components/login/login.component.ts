import { UsersService } from './../../services/users.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  email: string;
  password: string;

  constructor(public UsersService: UsersService) {}

  login() {
    const user = {email: this.email, password: this.password};
    this.UsersService.login(user).subscribe( data => {
      console.log(data);
    })
  }
}
