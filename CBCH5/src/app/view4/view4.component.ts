import { Component, OnInit, EventEmitter, Output } from '@angular/core';

import { MatDialog } from '@angular/material/dialog';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';
import { ChRouteService } from 'src/service/ch-route.service';
import { AreapopComponent } from '../areapop/areapop.component';
import { EditnameComponent } from '../editname/editname.component';
import { RamptimeComponent } from '../ramptime/ramptime.component';
import { TimeDelayService } from '../time-delay.service';
import { View3Component } from '../view3/view3.component';
import { View5Component } from '../view5/view5.component';
import {MatSnackBar} from '@angular/material/snack-bar';

declare var CrComLib: any;
@Component({
  selector: 'app-view4',
  templateUrl: './view4.component.html',
  styleUrls: ['./view4.component.scss']
})


export class View4Component implements OnInit {
  constructor(public dialog: MatDialog,private _snackBar: MatSnackBar,
    public rout: ChRouteService, public tdelay: TimeDelayService) { }

  ngOnInit(): void {


  }
  
  onClick(id: number) {
    let self = this;
    this.rout.active = id - 1;

  }



  editname() {
    const dialogRef = this.dialog.open(EditnameComponent, {
      height: '80vh',
      width: '80vw',
    });
    CrComLib.publishEvent('b', "3069", true);
    CrComLib.publishEvent('b', "3069", false);
  }

  clicked2(event) {

    this._snackBar.open("Saved", "OK", {
      horizontalPosition: 'center',
      verticalPosition: 'top',
    });
    CrComLib.publishEvent('b', "3071", true);
    CrComLib.publishEvent('b', "3071", false);
  }


  ramptime() {
    const dialogRef = this.dialog.open(RamptimeComponent, {

    });
  }

  Scheduler() {
this.rout.active=4  }

  
  Passcode() {
    const dialogRef = this.dialog.open(View3Component, {

    });
  }
  onclick() {
    this.rout.active = 5;}

    floorplan() {
      this.rout.active = 2;
    }

      public useDefault = false;

      public toggle(event: MatSlideToggleChange) {
          
         // this.useDefault = event.checked;
          if (event.checked==true) {
            this.tdelay.active = 10;
          } 
          else {
            this.tdelay.active = 100000;
            
          } 
          
      }
      public toggle1()
      {
        this.useDefault =!this.useDefault;
        if (this.useDefault==true) {
          this.tdelay.active = 10;
        } 
        else {
          this.tdelay.active = 100000;
          
        } 
      }
}