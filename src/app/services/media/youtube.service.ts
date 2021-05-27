import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class YoutubeService {

  apiKey : string = 'AIzaSyB5ZvHuw729CVZfZbNVBWG9qG-kLt_6K9o';

  constructor(private http: HttpClient) { }
  
  getVideo(videoId: string): Observable<any> {
    return this.http.get(`https://content-youtube.googleapis.com/youtube/v3/videos?id=${videoId}&key=${this.apiKey}&part=snippet`)
    .pipe(map((res) => {
      return res;
    }))
  }

}
