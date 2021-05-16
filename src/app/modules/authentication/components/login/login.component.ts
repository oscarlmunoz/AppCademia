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

  constructor(public usersService: UsersService) {}

  login() {
    const user = {email: this.email, password: this.password};
    this.usersService.login(user).subscribe( data => {
      if (data.status == "ok") 
      {
        console.log(data);
      }
    })
  }


  
}
