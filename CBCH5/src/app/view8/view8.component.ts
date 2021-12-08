import { Component, OnInit } from '@angular/core';
import { ChRouteService } from 'src/service/ch-route.service';

declare var CrComLib: any;


@Component({
  selector: 'app-view8',
  templateUrl: './view8.component.html',
  styleUrls: ['./view8.component.scss']
})
export class View8Component implements OnInit {

  constructor(public rout: ChRouteService) { }

  ngOnInit(): void {
    let self = this;


    


    const sig2SubKey = CrComLib.subscribeState('b', 'Pinpad.User', function (value) {
      if(value)
      self.rout.active = 2;
    });

    const sig3SubKey = CrComLib.subscribeState('b', 'Pinpad.Admin', function (value) {
      if(value)
      self.rout.active = 3;
    });


  }


  number = ["1",2,3,4,5,6,7,8,9,0];
}
