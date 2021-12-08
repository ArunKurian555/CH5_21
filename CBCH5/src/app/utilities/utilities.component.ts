import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';

@Component({
  selector: 'app-utilities',
  templateUrl: './utilities.component.html',
  styleUrls: ['./utilities.component.scss']
})
export class UtilitiesComponent implements OnInit {

  @ViewChild('draggable') private draggableElement: ElementRef;
  items = [1, 2, 3, 4, 5, 6, 7];
  constructor() { }

  ngOnInit(): void {
  }

}
