import { Component, OnInit } from '@angular/core';
import { Card } from 'src/app/models/card.model';


@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {

  card: Card = new Card();
  
  constructor() { 
  }

  ngOnInit(): void {
    this.card = {
      title: "Titulo",
      altMainImage: "Imagen de shiba inu",
      mainImage: "https://material.angular.io/assets/img/examples/shiba2.jpg",
      description: "Descripción del curso",
      subtitle: "Subtitulo"
    };
    
  }

}
