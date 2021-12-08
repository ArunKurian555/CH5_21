import { Component, OnInit } from '@angular/core';

declare var CrComLib: any;
@Component({
  selector: 'app-confirmation',
  templateUrl: './confirmation.component.html',
  styleUrls: ['./confirmation.component.scss']
})
export class ConfirmationComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  tick() {

    CrComLib.publishEvent('b', "3070", true);
    CrComLib.publishEvent('b', "3070", false);
  }

}
