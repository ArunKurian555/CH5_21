import { Component, OnInit } from '@angular/core';
import { ChRouteService } from 'src/service/ch-route.service';

@Component({
  selector: 'app-zumfh',
  templateUrl: './zumfh.component.html',
  styleUrls: ['./zumfh.component.scss']
})
export class ZumfhComponent implements OnInit {

  constructor(public rout: ChRouteService) { }

  ngOnInit(): void {
    let self = this;
  setTimeout(function () {


 
    self.rout.active = 3;

  },6200);
  }

}
