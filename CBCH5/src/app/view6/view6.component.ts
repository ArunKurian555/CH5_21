import { Component, OnInit } from '@angular/core';
import Patternlock from 'patternlock';
import { ChRouteService } from 'src/service/ch-route.service';

@Component({
  selector: 'app-view6',
  templateUrl: './view6.component.html',
  styleUrls: ['./view6.component.scss']
})
export class View6Component implements OnInit {

  constructor(public rout: ChRouteService) { }

  ngOnInit(): void {
    let self = this;

    let validatePattern: any = new Patternlock('#patterninput',
      {
        onDraw(pattern) {
          if (pattern == 3214789) {
            self.rout.active = 2;

            validatePattern.reset();

          }
          else {
            validatePattern.reset();


          }
        }

      });
    validatePattern.option('margin', 50);

  }

}
