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
    // return this.http.post("https://servicio_de_login_pendiente", user);
    respuesta = { Token: 'Token_example' };
    return of(respuesta);
  }
  register(user: any): Observable<any> {
    return this.http.post("https://servicio_de_registro_pendiente", user);
  }
}
