import { Observable, of } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  constructor(private http: HttpClient) { }

  login(user: any): Observable<any> {
    let respuesta: object;
    
    var a = this.http.post("https://localhost:5001/api/student/login", user);
    return a;
  }
  register(user: any): Observable<any> {
    return this.http.post("https://servicio_de_registro_pendiente", user);
  }
}
