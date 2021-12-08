import { Component, OnInit } from '@angular/core';
import { ChRouteService } from 'src/service/ch-route.service';
import { UserIdleService } from 'angular-user-idle';

declare var CrComLib: any;

@Component({
  selector: 'app-view3',
  templateUrl: './view3.component.html',
  styleUrls: ['./view3.component.scss']
})
export class View3Component implements OnInit {

  constructor(

    public rout: ChRouteService,

    private userIdle: UserIdleService
  ) { }
  ngOnInit(): void {// Javascript is used to set the clock to your computer time.
  }
  
  click1()
  {
  CrComLib.publishEvent('b', "3702", true);
  CrComLib.publishEvent('b', "3702", false);
  
  }
  
click2()
{
CrComLib.publishEvent('b', "3703", true);
CrComLib.publishEvent('b', "3703", false);

}

}
