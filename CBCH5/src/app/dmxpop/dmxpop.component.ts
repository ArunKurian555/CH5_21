import { ColorEvent } from 'ngx-color';
import { Component, OnInit } from '@angular/core';

declare var CrComLib: any;

@Component({
  selector: 'app-dmxpop',
  templateUrl: './dmxpop.component.html',
  styleUrls: ['./dmxpop.component.scss']
})
export class DmxpopComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  handleChange($event: ColorEvent) {
    CrComLib.publishEvent('n', '251', $event.color.rgb.r);
    CrComLib.publishEvent('n', '252', $event.color.rgb.g);
    CrComLib.publishEvent('n', '253', $event.color.rgb.b);
  }


}
