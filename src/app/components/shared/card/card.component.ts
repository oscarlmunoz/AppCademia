import { EventEmitter } from '@angular/core';
import { Component, Input, OnInit, Output } from '@angular/core';
import { Course } from 'src/app/models/course.model';


@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.css']
})
export class CardComponent implements OnInit {
  
  @Input() card: Course;
  @Output() detailEvent = new EventEmitter<string>();
  constructor() { }

  ngOnInit(): void {
  }

  showDetail(value: string) {
    this.detailEvent.emit(value);
  }

}
