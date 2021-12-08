import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { View4Component } from '../view4/view4.component';

import { ChRouteService } from 'src/service/ch-route.service';

import { MatDialog } from '@angular/material/dialog';
import { DmxpopComponent } from '../dmxpop/dmxpop.component';
import { SelectorFlags } from '@angular/compiler/src/core';
import { templateJitUrl } from '@angular/compiler';
import { RamptimeComponent } from '../ramptime/ramptime.component';
import { SettimeComponent } from '../settime/settime.component';

declare var CrComLib: any;


export interface Event {
  name: string;
  days: string;
  time: string;
}
@Component({
  selector: 'app-view5',
  templateUrl: './view5.component.html',
  styleUrls: ['./view5.component.scss'],

})
export class View5Component implements OnInit {
  constructor(public dialog: MatDialog, public rout: ChRouteService) { }


  Su0 : boolean;
  Events: Event[] = [
    { time: '6:30pm', days: '', name: 'white' },
    { time: '6:30pm', days: 'Mo Su', name: 'black' },
    { time: '6:30pm', days: 'Mo Su', name: 'black' },
    { time: '6:30pm', days: 'Mo Su Sa', name: 'black' },
    { time: '6:30pm', days: 'Mo Su Sa', name: 'lightblue' },
    { time: '6:30pm', days: 'Mo Su Sa', name: 'lightgreen' },
    { time: '6:30pm', days: 'Mo Su Sa', name: 'lightpink' },
    { time: '6:30pm', days: 'Mo Su Sa', name: 'lightpink' },
  ];


  Event: Event[] = [
    { time: '6:30pm', days: 'M-S-S', name: 'white' },
    { time: '6:30pm', days: 'MSST-F', name: 'black' },
    { time: '6:30pm', days: 'Mo Su', name: 'black' },
    { time: '6:30pm', days: 'Mo Su Sa', name: 'black' },
    { time: '6:30pm', days: 'Mo Su Sa', name: 'lightblue' },
    { time: '6:30pm', days: 'Mo Su Sa', name: 'lightgreen' },
    { time: '6:30pm', days: 'Mo Su Sa', name: 'lightpink' },
    { time: '6:30pm', days: 'Mo Su Sa', name: 'lightpink' },
  ];
  evt: string[]; evtf: string[];

  newTime:string[];
  value: string;
  

  ngOnInit(): void {
    let self = this;
    let items = ["Sch.ET0", "Sch.ET1", "Sch.ET2", "Sch.ET3", "Sch.ET4", "Sch.ET5", "Sch.ET6", "Sch.ET7"];
    let itemsf = ["Sch.ETF0", "Sch.ETF1", "Sch.ETF2", "Sch.ETF3", "Sch.ETF4", "Sch.ETF5", "Sch.ETF6", "Sch.ETF7",];
    this.newTime = ["1,Sensor Override ON,0,22,-XXXXX-,XXXXXXXXXXXX,0,,11152021:002105,", "1", "2", "3", "4", "5", "6", "7"];
    self.evt = items;
    self.evtf = itemsf;

    const sig1SubKey = CrComLib.subscribeState('s', 'Sch.EN0', function (value) {
      var evstring = value;
      var a = evstring.split(",");
      self.Events[0].name = a[1];
      //self.newTime[0] = value;

      var ampm;
      if (a[2] == "0") {
        ampm = "am";
      }
      if (a[2] == "1") {
        ampm = "pm";
      }
      if (a[2] == "2") {
        ampm = " Sunrise";
      }
      if (a[2] == "3") {
        ampm = " Sunset";
      }

      let time1 = parseInt(a[3], 10) / 60;
      var time3 = Math.floor(time1);
      var time2 = parseInt(a[3], 10) % 60;
      var formattedNumber = ("0" + time2).slice(-2);
      if (a[2] == "2" || a[2] == "3") {
        self.Events[0].time = ampm + " " + time3.toString() + ":" + formattedNumber.toString();
      }
      if (a[2] == "0" || a[2] == "1") {
        self.Events[0].time = time3.toString() + ":" + formattedNumber.toString() + ampm;
      }
      self.Events[0].days = a[4];


      // Days
      //  if (a[4].charAt(0) === 'X') {
      //   self.Events[0].days = ;
      // }
      //  if (a[4].charAt(1) === "X") {
      //   self.Events[0].days = ;
      // }
      //  if (a[4].charAt(2) === "X") {
      //   self.Events[0].days =  ;
      // } if (a[4].charAt(3) === "X") {
      //   days = days + "We ";
      // } if (a[4].charAt(4) === "X") {
      //   days = days + "Th ";
      // } if (a[4].charAt(5) === "X") {
      //   days = days + "Fr ";
      // } if (a[4].charAt(6) === "X") {
      //   days = days + "Sa ";
      // }     


    });
    const sig2SubKey = CrComLib.subscribeState('s', 'Sch.EN1', function (value) {
      var evstring = value;
      var a = evstring.split(",");
      self.Events[1].name = a[1];
      self.newTime[1] = value;

      var ampm;
      if (a[2] == "0") {
        ampm = "am";
      }
      if (a[2] == "1") {
        ampm = "pm";
      }
      if (a[2] == "2") {
        ampm = "Sunrise";
      }
      if (a[2] == "3") {
        ampm = "Sunset";
      }

      let time1 = parseInt(a[3], 10) / 60;
      var time3 = Math.floor(time1);
      var time2 = parseInt(a[3], 10) % 60;
      var formattedNumber = ("0" + time2).slice(-2);

      if (a[2] == "2" || a[2] == "3") {
        self.Events[1].time = ampm + " " + time3.toString() + ":" + formattedNumber.toString();
      }
      if (a[2] == "0" || a[2] == "1") {
        self.Events[1].time = time3.toString() + ":" + formattedNumber.toString() + ampm;
      }

      self.Events[1].days = a[4];
    });
    const sig3SubKey = CrComLib.subscribeState('s', 'Sch.EN2', function (value) {
      var evstring = value;
      var a = evstring.split(",");
      self.Events[2].name = a[1];

      self.newTime[2] = value;
      var ampm;
      if (a[2] == "0") {
        ampm = "am";
      }
      if (a[2] == "1") {
        ampm = "pm";
      }
      if (a[2] == "2") {
        ampm = "Sunrise";
      }
      if (a[2] == "3") {
        ampm = "Sunset";
      }

      let time1 = parseInt(a[3], 10) / 60;
      var time3 = Math.floor(time1);
      var time2 = parseInt(a[3], 10) % 60;
      var formattedNumber = ("0" + time2).slice(-2);

      if (a[2] == "2" || a[2] == "3") {
        self.Events[2].time = ampm + " " + time3.toString() + ":" + formattedNumber.toString();
      }
      if (a[2] == "0" || a[2] == "1") {
        self.Events[2].time = time3.toString() + ":" + formattedNumber.toString() + ampm;
      }
      self.Events[2].days = a[4];
    });
    const sig4SubKey = CrComLib.subscribeState('s', 'Sch.EN3', function (value) {
      var evstring = value;
      var a = evstring.split(",");
      self.Events[3].name = a[1];
      self.newTime[3] = value;

      var ampm;
      if (a[2] == "0") {
        ampm = "am";
      }
      if (a[2] == "1") {
        ampm = "pm";
      }
      if (a[2] == "2") {
        ampm = "Sunrise";
      }
      if (a[2] == "3") {
        ampm = "Sunset";
      }

      let time1 = parseInt(a[3], 10) / 60;
      var time3 = Math.floor(time1);
      var time2 = parseInt(a[3], 10) % 60;
      var formattedNumber = ("0" + time2).slice(-2);

      if (a[2] == "2" || a[2] == "3") {
        self.Events[3].time = ampm + " " + time3.toString() + ":" + formattedNumber.toString();
      }
      if (a[2] == "0" || a[2] == "1") {
        self.Events[3].time = time3.toString() + ":" + formattedNumber.toString() + ampm;
      }
      self.Events[3].days = a[4];
    });
    const sig5SubKey = CrComLib.subscribeState('s', 'Sch.EN4', function (value) {
      var evstring = value;
      var a = evstring.split(",");
      self.Events[4].name = a[1];
      self.newTime[4] = value;

      var ampm;
      if (a[2] == "0") {
        ampm = "am";
      }
      if (a[2] == "1") {
        ampm = "pm";
      }
      if (a[2] == "2") {
        ampm = "Sunrise";
      }
      if (a[2] == "3") {
        ampm = "Sunset";
      }

      let time1 = parseInt(a[3], 10) / 60;
      var time3 = Math.floor(time1);
      var time2 = parseInt(a[3], 10) % 60;
      var formattedNumber = ("0" + time2).slice(-2);

      if (a[2] == "2" || a[2] == "3") {
        self.Events[4].time = ampm + " " + time3.toString() + ":" + formattedNumber.toString();
      }
      if (a[2] == "0" || a[2] == "1") {
        self.Events[4].time = time3.toString() + ":" + formattedNumber.toString() + ampm;
      }
      self.Events[4].days = a[4];
    });
    const sig6SubKey = CrComLib.subscribeState('s', 'Sch.EN5', function (value) {
      var evstring = value;
      var a = evstring.split(",");
      self.Events[5].name = a[1];
      self.newTime[5] = value;


      var ampm;
      if (a[2] == "0") {
        ampm = "am";
      }
      if (a[2] == "1") {
        ampm = "pm";
      }
      if (a[2] == "2") {
        ampm = "Sunrise";
      }
      if (a[2] == "3") {
        ampm = "Sunset";
      }

      let time1 = parseInt(a[3], 10) / 60;
      var time3 = Math.floor(time1);
      var time2 = parseInt(a[3], 10) % 60;
      var formattedNumber = ("0" + time2).slice(-2);

      if (a[2] == "2" || a[2] == "3") {
        self.Events[5].time = ampm + " " + time3.toString() + ":" + formattedNumber.toString();
      }
      if (a[2] == "0" || a[2] == "1") {
        self.Events[5].time = time3.toString() + ":" + formattedNumber.toString() + ampm;
      }

      self.Events[5].days = a[4];
    });
    const sig7SubKey = CrComLib.subscribeState('s', 'Sch.EN6', function (value) {
      var evstring = value;
      var a = evstring.split(",");
      self.Events[6].name = a[1];

      self.newTime[6] = value;
      var ampm;
      if (a[2] == "0") {
        ampm = "am";
      }
      if (a[2] == "1") {
        ampm = "pm";
      }
      if (a[2] == "2") {
        ampm = "Sunrise";
      }
      if (a[2] == "3") {
        ampm = "Sunset";
      }

      let time1 = parseInt(a[3], 10) / 60;
      var time3 = Math.floor(time1);
      var time2 = parseInt(a[3], 10) % 60;
      var formattedNumber = ("0" + time2).slice(-2);

      if (a[2] == "2" || a[2] == "3") {
        self.Events[6].time = ampm + " " + time3.toString() + ":" + formattedNumber.toString();
      }
      if (a[2] == "0" || a[2] == "1") {
        self.Events[6].time = time3.toString() + ":" + formattedNumber.toString() + ampm;
      }

      self.Events[6].days = a[4];
    });
    const sig8SubKey = CrComLib.subscribeState('s', 'Sch.EN7', function (value) {
      var evstring = value;
      var a = evstring.split(",");
      self.Events[7].name = a[1];
      self.newTime[7] = value;

      var ampm;
      if (a[2] == "0") {
        ampm = "am";
      }
      if (a[2] == "1") {
        ampm = "pm";
      }
      if (a[2] == "2") {
        ampm = "Sunrise";
      }
      if (a[2] == "3") {
        ampm = "Sunset";
      }

      let time1 = parseInt(a[3], 10) / 60;
      var time3 = Math.floor(time1);
      var time2 = parseInt(a[3], 10) % 60;
      var formattedNumber = ("0" + time2).slice(-2);

      if (a[2] == "2" || a[2] == "3") {
        self.Events[7].time = ampm + " " + time3.toString() + ":" + formattedNumber.toString();
      }
      if (a[2] == "0" || a[2] == "1") {
        self.Events[7].time = time3.toString() + ":" + formattedNumber.toString() + ampm;
      }

      self.Events[7].days = a[4];
    });

    setInterval(function () { }, 1000);

  }

  parseEvt(a, b) {

    let self = this;
    self.Events[b].name = a[1];
    var ampm;
    if (a[2] == "0") {
      ampm = "am";
    }
    if (a[2] == "1") {
      ampm = "pm";
    }
    if (a[2] == "2") {
      ampm = "Sunrise";
    }
    if (a[2] == "3") {
      ampm = "Sunset";
    }
    let time1 = parseInt(a[3], 10) / 60;
    var time3 = Math.floor(time1);
    var time2 = parseInt(a[3], 10) % 60;
    var formattedNumber = ("0" + time2).slice(-2);
    self.Events[b].time = time3.toString() + ":" + formattedNumber.toString() + ampm;



    /*
           if (a[4].charAt(0) === 'X') {
               days = 'Su';
             }
          if (a[4].charAt(1) === "X") {
            days = 'Mo';
          }
              if (a[4].charAt(2) === "X") {
               days = days + "Tu ";
             } if (a[4].charAt(3) === "X") {
               days = days + "We ";
             } if (a[4].charAt(4) === "X") {
               days = days + "Th ";
             } if (a[4].charAt(5) === "X") {
               days = days + "Fr ";
             } if (a[4].charAt(6) === "X") {
               days = days + "Sa ";
             }     */



  }


  // onClick() {

  //   const dialogRef = this.dialog.open(SettimeComponent, {
  //   });
  // }
  clicked()

  {
    this.rout.active = 3;
  }


  public mon1($event)
  {
    console.log(event);
  }

  setTime($event,idx)
  { 

    var index = idx +1;
    var ampm,tod;
    var a = $event.split(" ");
    
    if(a[1] === "AM")
    {
     ampm = "0"; 
    }
    if(a[1] === "PM")
    {
     ampm = "1"; 
    }
    var b = a[0].split(':');
    tod = Number(b[0]) *60;
    tod = tod + Number(b[1]);


    
  var timesplit = this.newTime[idx].split(",");
  timesplit[2] = ampm;
  timesplit[3] = tod;
  this.newTime[idx] = "";
  for (let index = 0; index < timesplit.length-1; index++) {
  this.newTime[idx] = this.newTime[idx]+timesplit[index]+",";
  
  }
  
  switch(idx)
{
 case 0: 
 CrComLib.publishEvent('s', 'Sch.e1set', this.newTime[idx] );
 break;
 
 case 1: CrComLib.publishEvent('s', 'Sch.e2set', this.newTime[idx] );
 break;
 
 case 2: CrComLib.publishEvent('s', 'Sch.e3set', this.newTime[idx] );
 break;
 

 case 3: CrComLib.publishEvent('s', 'Sch.e4set', this.newTime[idx] );
 break;
 
 case 4: CrComLib.publishEvent('s', 'Sch.e5set', this.newTime[idx] );
 break;
 
 case 5: CrComLib.publishEvent('s', 'Sch.e6set', this.newTime[idx] );
 break;
 
 case 6: CrComLib.publishEvent('s', 'Sch.e7set', this.newTime[idx] );
 break;
 
 case 7: CrComLib.publishEvent('s', 'Sch.e8set', this.newTime[idx] );
 break;
} 
CrComLib.publishEvent('b', 'Sch.Save', true );
CrComLib.publishEvent('b', 'Sch.Save', false);

  }


}

