import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { View4Component } from '../view4/view4.component';

import { ChRouteService } from 'src/service/ch-route.service';

import { MatDialog } from '@angular/material/dialog';
import { DmxpopComponent } from '../dmxpop/dmxpop.component';
import { SelectorFlags } from '@angular/compiler/src/core';
import { AreapopComponent } from '../areapop/areapop.component';
import { ScenepopComponent } from '../scenepop/scenepop.component';
import { ConfirmationComponent } from '../confirmation/confirmation.component';


declare var CrComLib: any;

@Component({
  selector: 'app-scenes',
  templateUrl: './scenes.component.html',
  styleUrls: ['./scenes.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class ScenesComponent implements OnInit {
  constructor(public dialog: MatDialog) { }
  /////////////// Angular Slider
  formatLabel(value: number) {
    if (value >= 1000) {
      return Math.round(value / 1000) + '%';
    }
    return value;
  }
  ////////////////////////init 
  dmxfb = [
  ];
  temp: number;
  value: string;
  numvalue: number;
  activeZones: number[];
  DMXactive: number[];
  htmlToAdd: string = '<div class = "dmxfb" >  </div>';
  activeZone = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120];
  activezonelabel = [];
  ngOnInit(): void {
    let self = this; //this statement binds the object that you want to self;
    this.DMXactive = [];



    /////////////// Active Zones
    const sig1SubKey = CrComLib.subscribeState('s', '1', function (value) {
      self.value = value;
      let items = [];
      for (let i = 0; i < self.value.length; i++) {
        if (self.value[i] === "1") {
          items.push(i / 2 + 1);
        }
      }
      self.activeZones = items;

    });











    ////////////////////////// Zone names

    for (let i = 0; i < 121; i++) {
      self.activezonelabel.push("NIL");
    }




    const Zone1SubKey = CrComLib.subscribeState('s', 'Zones.Zone1', function (value) { self.activezonelabel[1] = value; }); const Zone2SubKey = CrComLib.subscribeState('s', 'Zones.Zone2', function (value) { self.activezonelabel[2] = value; }); const Zone3SubKey = CrComLib.subscribeState('s', 'Zones.Zone3', function (value) { self.activezonelabel[3] = value; }); const Zone4SubKey = CrComLib.subscribeState('s', 'Zones.Zone4', function (value) { self.activezonelabel[4] = value; }); const Zone5SubKey = CrComLib.subscribeState('s', 'Zones.Zone5', function (value) { self.activezonelabel[5] = value; }); const Zone6SubKey = CrComLib.subscribeState('s', 'Zones.Zone6', function (value) { self.activezonelabel[6] = value; }); const Zone7SubKey = CrComLib.subscribeState('s', 'Zones.Zone7', function (value) { self.activezonelabel[7] = value; }); const Zone8SubKey = CrComLib.subscribeState('s', 'Zones.Zone8', function (value) { self.activezonelabel[8] = value; }); const Zone9SubKey = CrComLib.subscribeState('s', 'Zones.Zone9', function (value) { self.activezonelabel[9] = value; }); const Zone10SubKey = CrComLib.subscribeState('s', 'Zones.Zone10', function (value) { self.activezonelabel[10] = value; }); const Zone11SubKey = CrComLib.subscribeState('s', 'Zones.Zone11', function (value) { self.activezonelabel[11] = value; }); const Zone12SubKey = CrComLib.subscribeState('s', 'Zones.Zone12', function (value) { self.activezonelabel[12] = value; }); const Zone13SubKey = CrComLib.subscribeState('s', 'Zones.Zone13', function (value) { self.activezonelabel[13] = value; }); const Zone14SubKey = CrComLib.subscribeState('s', 'Zones.Zone14', function (value) { self.activezonelabel[14] = value; }); const Zone15SubKey = CrComLib.subscribeState('s', 'Zones.Zone15', function (value) { self.activezonelabel[15] = value; }); const Zone16SubKey = CrComLib.subscribeState('s', 'Zones.Zone16', function (value) { self.activezonelabel[16] = value; }); const Zone17SubKey = CrComLib.subscribeState('s', 'Zones.Zone17', function (value) { self.activezonelabel[17] = value; }); const Zone18SubKey = CrComLib.subscribeState('s', 'Zones.Zone18', function (value) { self.activezonelabel[18] = value; }); const Zone19SubKey = CrComLib.subscribeState('s', 'Zones.Zone19', function (value) { self.activezonelabel[19] = value; }); const Zone20SubKey = CrComLib.subscribeState('s', 'Zones.Zone20', function (value) { self.activezonelabel[20] = value; }); const Zone21SubKey = CrComLib.subscribeState('s', 'Zones.Zone21', function (value) { self.activezonelabel[21] = value; }); const Zone22SubKey = CrComLib.subscribeState('s', 'Zones.Zone22', function (value) { self.activezonelabel[22] = value; }); const Zone23SubKey = CrComLib.subscribeState('s', 'Zones.Zone23', function (value) { self.activezonelabel[23] = value; }); const Zone24SubKey = CrComLib.subscribeState('s', 'Zones.Zone24', function (value) { self.activezonelabel[24] = value; }); const Zone25SubKey = CrComLib.subscribeState('s', 'Zones.Zone25', function (value) { self.activezonelabel[25] = value; }); const Zone26SubKey = CrComLib.subscribeState('s', 'Zones.Zone26', function (value) { self.activezonelabel[26] = value; }); const Zone27SubKey = CrComLib.subscribeState('s', 'Zones.Zone27', function (value) { self.activezonelabel[27] = value; }); const Zone28SubKey = CrComLib.subscribeState('s', 'Zones.Zone28', function (value) { self.activezonelabel[28] = value; }); const Zone29SubKey = CrComLib.subscribeState('s', 'Zones.Zone29', function (value) { self.activezonelabel[29] = value; }); const Zone30SubKey = CrComLib.subscribeState('s', 'Zones.Zone30', function (value) { self.activezonelabel[30] = value; }); const Zone31SubKey = CrComLib.subscribeState('s', 'Zones.Zone31', function (value) { self.activezonelabel[31] = value; }); const Zone32SubKey = CrComLib.subscribeState('s', 'Zones.Zone32', function (value) { self.activezonelabel[32] = value; }); const Zone33SubKey = CrComLib.subscribeState('s', 'Zones.Zone33', function (value) { self.activezonelabel[33] = value; }); const Zone34SubKey = CrComLib.subscribeState('s', 'Zones.Zone34', function (value) { self.activezonelabel[34] = value; }); const Zone35SubKey = CrComLib.subscribeState('s', 'Zones.Zone35', function (value) { self.activezonelabel[35] = value; }); const Zone36SubKey = CrComLib.subscribeState('s', 'Zones.Zone36', function (value) { self.activezonelabel[36] = value; }); const Zone37SubKey = CrComLib.subscribeState('s', 'Zones.Zone37', function (value) { self.activezonelabel[37] = value; }); const Zone38SubKey = CrComLib.subscribeState('s', 'Zones.Zone38', function (value) { self.activezonelabel[38] = value; }); const Zone39SubKey = CrComLib.subscribeState('s', 'Zones.Zone39', function (value) { self.activezonelabel[39] = value; }); const Zone40SubKey = CrComLib.subscribeState('s', 'Zones.Zone40', function (value) { self.activezonelabel[40] = value; }); const Zone41SubKey = CrComLib.subscribeState('s', 'Zones.Zone41', function (value) { self.activezonelabel[41] = value; }); const Zone42SubKey = CrComLib.subscribeState('s', 'Zones.Zone42', function (value) { self.activezonelabel[42] = value; }); const Zone43SubKey = CrComLib.subscribeState('s', 'Zones.Zone43', function (value) { self.activezonelabel[43] = value; }); const Zone44SubKey = CrComLib.subscribeState('s', 'Zones.Zone44', function (value) { self.activezonelabel[44] = value; }); const Zone45SubKey = CrComLib.subscribeState('s', 'Zones.Zone45', function (value) { self.activezonelabel[45] = value; }); const Zone46SubKey = CrComLib.subscribeState('s', 'Zones.Zone46', function (value) { self.activezonelabel[46] = value; }); const Zone47SubKey = CrComLib.subscribeState('s', 'Zones.Zone47', function (value) { self.activezonelabel[47] = value; }); const Zone48SubKey = CrComLib.subscribeState('s', 'Zones.Zone48', function (value) { self.activezonelabel[48] = value; }); const Zone49SubKey = CrComLib.subscribeState('s', 'Zones.Zone49', function (value) { self.activezonelabel[49] = value; }); const Zone50SubKey = CrComLib.subscribeState('s', 'Zones.Zone50', function (value) { self.activezonelabel[50] = value; }); const Zone51SubKey = CrComLib.subscribeState('s', 'Zones.Zone51', function (value) { self.activezonelabel[51] = value; }); const Zone52SubKey = CrComLib.subscribeState('s', 'Zones.Zone52', function (value) { self.activezonelabel[52] = value; }); const Zone53SubKey = CrComLib.subscribeState('s', 'Zones.Zone53', function (value) { self.activezonelabel[53] = value; }); const Zone54SubKey = CrComLib.subscribeState('s', 'Zones.Zone54', function (value) { self.activezonelabel[54] = value; }); const Zone55SubKey = CrComLib.subscribeState('s', 'Zones.Zone55', function (value) { self.activezonelabel[55] = value; }); const Zone56SubKey = CrComLib.subscribeState('s', 'Zones.Zone56', function (value) { self.activezonelabel[56] = value; }); const Zone57SubKey = CrComLib.subscribeState('s', 'Zones.Zone57', function (value) { self.activezonelabel[57] = value; }); const Zone58SubKey = CrComLib.subscribeState('s', 'Zones.Zone58', function (value) { self.activezonelabel[58] = value; }); const Zone59SubKey = CrComLib.subscribeState('s', 'Zones.Zone59', function (value) { self.activezonelabel[59] = value; }); const Zone60SubKey = CrComLib.subscribeState('s', 'Zones.Zone60', function (value) { self.activezonelabel[60] = value; }); const Zone61SubKey = CrComLib.subscribeState('s', 'Zones.Zone61', function (value) { self.activezonelabel[61] = value; }); const Zone62SubKey = CrComLib.subscribeState('s', 'Zones.Zone62', function (value) { self.activezonelabel[62] = value; }); const Zone63SubKey = CrComLib.subscribeState('s', 'Zones.Zone63', function (value) { self.activezonelabel[63] = value; }); const Zone64SubKey = CrComLib.subscribeState('s', 'Zones.Zone64', function (value) { self.activezonelabel[64] = value; }); const Zone65SubKey = CrComLib.subscribeState('s', 'Zones.Zone65', function (value) { self.activezonelabel[65] = value; }); const Zone66SubKey = CrComLib.subscribeState('s', 'Zones.Zone66', function (value) { self.activezonelabel[66] = value; }); const Zone67SubKey = CrComLib.subscribeState('s', 'Zones.Zone67', function (value) { self.activezonelabel[67] = value; }); const Zone68SubKey = CrComLib.subscribeState('s', 'Zones.Zone68', function (value) { self.activezonelabel[68] = value; }); const Zone69SubKey = CrComLib.subscribeState('s', 'Zones.Zone69', function (value) { self.activezonelabel[69] = value; }); const Zone70SubKey = CrComLib.subscribeState('s', 'Zones.Zone70', function (value) { self.activezonelabel[70] = value; }); const Zone71SubKey = CrComLib.subscribeState('s', 'Zones.Zone71', function (value) { self.activezonelabel[71] = value; }); const Zone72SubKey = CrComLib.subscribeState('s', 'Zones.Zone72', function (value) { self.activezonelabel[72] = value; }); const Zone73SubKey = CrComLib.subscribeState('s', 'Zones.Zone73', function (value) { self.activezonelabel[73] = value; }); const Zone74SubKey = CrComLib.subscribeState('s', 'Zones.Zone74', function (value) { self.activezonelabel[74] = value; }); const Zone75SubKey = CrComLib.subscribeState('s', 'Zones.Zone75', function (value) { self.activezonelabel[75] = value; }); const Zone76SubKey = CrComLib.subscribeState('s', 'Zones.Zone76', function (value) { self.activezonelabel[76] = value; }); const Zone77SubKey = CrComLib.subscribeState('s', 'Zones.Zone77', function (value) { self.activezonelabel[77] = value; }); const Zone78SubKey = CrComLib.subscribeState('s', 'Zones.Zone78', function (value) { self.activezonelabel[78] = value; }); const Zone79SubKey = CrComLib.subscribeState('s', 'Zones.Zone79', function (value) { self.activezonelabel[79] = value; }); const Zone80SubKey = CrComLib.subscribeState('s', 'Zones.Zone80', function (value) { self.activezonelabel[80] = value; }); const Zone81SubKey = CrComLib.subscribeState('s', 'Zones.Zone81', function (value) { self.activezonelabel[81] = value; }); const Zone82SubKey = CrComLib.subscribeState('s', 'Zones.Zone82', function (value) { self.activezonelabel[82] = value; }); const Zone83SubKey = CrComLib.subscribeState('s', 'Zones.Zone83', function (value) { self.activezonelabel[83] = value; }); const Zone84SubKey = CrComLib.subscribeState('s', 'Zones.Zone84', function (value) { self.activezonelabel[84] = value; }); const Zone85SubKey = CrComLib.subscribeState('s', 'Zones.Zone85', function (value) { self.activezonelabel[85] = value; }); const Zone86SubKey = CrComLib.subscribeState('s', 'Zones.Zone86', function (value) { self.activezonelabel[86] = value; }); const Zone87SubKey = CrComLib.subscribeState('s', 'Zones.Zone87', function (value) { self.activezonelabel[87] = value; }); const Zone88SubKey = CrComLib.subscribeState('s', 'Zones.Zone88', function (value) { self.activezonelabel[88] = value; }); const Zone89SubKey = CrComLib.subscribeState('s', 'Zones.Zone89', function (value) { self.activezonelabel[89] = value; }); const Zone90SubKey = CrComLib.subscribeState('s', 'Zones.Zone90', function (value) { self.activezonelabel[90] = value; }); const Zone91SubKey = CrComLib.subscribeState('s', 'Zones.Zone91', function (value) { self.activezonelabel[91] = value; }); const Zone92SubKey = CrComLib.subscribeState('s', 'Zones.Zone92', function (value) { self.activezonelabel[92] = value; }); const Zone93SubKey = CrComLib.subscribeState('s', 'Zones.Zone93', function (value) { self.activezonelabel[93] = value; }); const Zone94SubKey = CrComLib.subscribeState('s', 'Zones.Zone94', function (value) { self.activezonelabel[94] = value; }); const Zone95SubKey = CrComLib.subscribeState('s', 'Zones.Zone95', function (value) { self.activezonelabel[95] = value; }); const Zone96SubKey = CrComLib.subscribeState('s', 'Zones.Zone96', function (value) { self.activezonelabel[96] = value; }); const Zone97SubKey = CrComLib.subscribeState('s', 'Zones.Zone97', function (value) { self.activezonelabel[97] = value; }); const Zone98SubKey = CrComLib.subscribeState('s', 'Zones.Zone98', function (value) { self.activezonelabel[98] = value; }); const Zone99SubKey = CrComLib.subscribeState('s', 'Zones.Zone99', function (value) { self.activezonelabel[99] = value; }); const Zone100SubKey = CrComLib.subscribeState('s', 'Zones.Zone100', function (value) { self.activezonelabel[100] = value; }); const Zone101SubKey = CrComLib.subscribeState('s', 'Zones.Zone101', function (value) { self.activezonelabel[101] = value; }); const Zone102SubKey = CrComLib.subscribeState('s', 'Zones.Zone102', function (value) { self.activezonelabel[102] = value; }); const Zone103SubKey = CrComLib.subscribeState('s', 'Zones.Zone103', function (value) { self.activezonelabel[103] = value; }); const Zone104SubKey = CrComLib.subscribeState('s', 'Zones.Zone104', function (value) { self.activezonelabel[104] = value; }); const Zone105SubKey = CrComLib.subscribeState('s', 'Zones.Zone105', function (value) { self.activezonelabel[105] = value; }); const Zone106SubKey = CrComLib.subscribeState('s', 'Zones.Zone106', function (value) { self.activezonelabel[106] = value; }); const Zone107SubKey = CrComLib.subscribeState('s', 'Zones.Zone107', function (value) { self.activezonelabel[107] = value; }); const Zone108SubKey = CrComLib.subscribeState('s', 'Zones.Zone108', function (value) { self.activezonelabel[108] = value; }); const Zone109SubKey = CrComLib.subscribeState('s', 'Zones.Zone109', function (value) { self.activezonelabel[109] = value; }); const Zone110SubKey = CrComLib.subscribeState('s', 'Zones.Zone110', function (value) { self.activezonelabel[110] = value; }); const Zone111SubKey = CrComLib.subscribeState('s', 'Zones.Zone111', function (value) { self.activezonelabel[111] = value; }); const Zone112SubKey = CrComLib.subscribeState('s', 'Zones.Zone112', function (value) { self.activezonelabel[112] = value; }); const Zone113SubKey = CrComLib.subscribeState('s', 'Zones.Zone113', function (value) { self.activezonelabel[113] = value; }); const Zone114SubKey = CrComLib.subscribeState('s', 'Zones.Zone114', function (value) { self.activezonelabel[114] = value; }); const Zone115SubKey = CrComLib.subscribeState('s', 'Zones.Zone115', function (value) { self.activezonelabel[115] = value; }); const Zone116SubKey = CrComLib.subscribeState('s', 'Zones.Zone116', function (value) { self.activezonelabel[116] = value; }); const Zone117SubKey = CrComLib.subscribeState('s', 'Zones.Zone117', function (value) { self.activezonelabel[117] = value; }); const Zone118SubKey = CrComLib.subscribeState('s', 'Zones.Zone118', function (value) { self.activezonelabel[118] = value; }); const Zone119SubKey = CrComLib.subscribeState('s', 'Zones.Zone119', function (value) { self.activezonelabel[119] = value; }); const Zone120SubKey = CrComLib.subscribeState('s', 'Zones.Zone120', function (value) { self.activezonelabel[120] = value; });








    ////////////////// Active DMX Zones
    const sig2SubKey = CrComLib.subscribeState('s', '2', function (value) {
      self.value = value;
      let items = [];
      for (let i = 0; i < self.value.length; i++) {
        if (self.value[i] === "1") {
          items.push(1);
        }
        if (self.value[i] === "0") {
          items.push(0);
        }
      }
      self.DMXactive = items;
    });








    //////// DMX FB array

    for (let i = 0; i < 120; i++) {
      self.dmxfb.push({
        'background-color': 'rgb(0,0,0)'
      })
    }

    const sig3SubKey = CrComLib.subscribeState('s', '3', function (value) { self.dmxfb[0]['background-color'] = value; });


    const sig4SubKey = CrComLib.subscribeState('s', '4', function (value) { self.dmxfb[1]['background-color'] = value; }); const sig5SubKey = CrComLib.subscribeState('s', '5', function (value) { self.dmxfb[2]['background-color'] = value; }); const sig6SubKey = CrComLib.subscribeState('s', '6', function (value) { self.dmxfb[3]['background-color'] = value; }); const sig7SubKey = CrComLib.subscribeState('s', '7', function (value) { self.dmxfb[4]['background-color'] = value; }); const sig8SubKey = CrComLib.subscribeState('s', '8', function (value) { self.dmxfb[5]['background-color'] = value; }); const sig9SubKey = CrComLib.subscribeState('s', '9', function (value) { self.dmxfb[6]['background-color'] = value; }); const sig10SubKey = CrComLib.subscribeState('s', '10', function (value) { self.dmxfb[7]['background-color'] = value; }); const sig11SubKey = CrComLib.subscribeState('s', '11', function (value) { self.dmxfb[8]['background-color'] = value; }); const sig12SubKey = CrComLib.subscribeState('s', '12', function (value) { self.dmxfb[9]['background-color'] = value; }); const sig13SubKey = CrComLib.subscribeState('s', '13', function (value) { self.dmxfb[10]['background-color'] = value; }); const sig14SubKey = CrComLib.subscribeState('s', '14', function (value) { self.dmxfb[11]['background-color'] = value; }); const sig15SubKey = CrComLib.subscribeState('s', '15', function (value) { self.dmxfb[12]['background-color'] = value; }); const sig16SubKey = CrComLib.subscribeState('s', '16', function (value) { self.dmxfb[13]['background-color'] = value; }); const sig17SubKey = CrComLib.subscribeState('s', '17', function (value) { self.dmxfb[14]['background-color'] = value; }); const sig18SubKey = CrComLib.subscribeState('s', '18', function (value) { self.dmxfb[15]['background-color'] = value; }); const sig19SubKey = CrComLib.subscribeState('s', '19', function (value) { self.dmxfb[16]['background-color'] = value; }); const sig20SubKey = CrComLib.subscribeState('s', '20', function (value) { self.dmxfb[17]['background-color'] = value; }); const sig21SubKey = CrComLib.subscribeState('s', '21', function (value) { self.dmxfb[18]['background-color'] = value; }); const sig22SubKey = CrComLib.subscribeState('s', '22', function (value) { self.dmxfb[19]['background-color'] = value; }); const sig23SubKey = CrComLib.subscribeState('s', '23', function (value) { self.dmxfb[20]['background-color'] = value; }); const sig24SubKey = CrComLib.subscribeState('s', '24', function (value) { self.dmxfb[21]['background-color'] = value; }); const sig25SubKey = CrComLib.subscribeState('s', '25', function (value) { self.dmxfb[22]['background-color'] = value; }); const sig26SubKey = CrComLib.subscribeState('s', '26', function (value) { self.dmxfb[23]['background-color'] = value; }); const sig27SubKey = CrComLib.subscribeState('s', '27', function (value) { self.dmxfb[24]['background-color'] = value; }); const sig28SubKey = CrComLib.subscribeState('s', '28', function (value) { self.dmxfb[25]['background-color'] = value; }); const sig29SubKey = CrComLib.subscribeState('s', '29', function (value) { self.dmxfb[26]['background-color'] = value; }); const sig30SubKey = CrComLib.subscribeState('s', '30', function (value) { self.dmxfb[27]['background-color'] = value; }); const sig31SubKey = CrComLib.subscribeState('s', '31', function (value) { self.dmxfb[28]['background-color'] = value; }); const sig32SubKey = CrComLib.subscribeState('s', '32', function (value) { self.dmxfb[29]['background-color'] = value; }); const sig33SubKey = CrComLib.subscribeState('s', '33', function (value) { self.dmxfb[30]['background-color'] = value; }); const sig34SubKey = CrComLib.subscribeState('s', '34', function (value) { self.dmxfb[31]['background-color'] = value; }); const sig35SubKey = CrComLib.subscribeState('s', '35', function (value) { self.dmxfb[32]['background-color'] = value; }); const sig36SubKey = CrComLib.subscribeState('s', '36', function (value) { self.dmxfb[33]['background-color'] = value; }); const sig37SubKey = CrComLib.subscribeState('s', '37', function (value) { self.dmxfb[34]['background-color'] = value; }); const sig38SubKey = CrComLib.subscribeState('s', '38', function (value) { self.dmxfb[35]['background-color'] = value; }); const sig39SubKey = CrComLib.subscribeState('s', '39', function (value) { self.dmxfb[36]['background-color'] = value; }); const sig40SubKey = CrComLib.subscribeState('s', '40', function (value) { self.dmxfb[37]['background-color'] = value; }); const sig41SubKey = CrComLib.subscribeState('s', '41', function (value) { self.dmxfb[38]['background-color'] = value; }); const sig42SubKey = CrComLib.subscribeState('s', '42', function (value) { self.dmxfb[39]['background-color'] = value; }); const sig43SubKey = CrComLib.subscribeState('s', '43', function (value) { self.dmxfb[40]['background-color'] = value; }); const sig44SubKey = CrComLib.subscribeState('s', '44', function (value) { self.dmxfb[41]['background-color'] = value; }); const sig45SubKey = CrComLib.subscribeState('s', '45', function (value) { self.dmxfb[42]['background-color'] = value; }); const sig46SubKey = CrComLib.subscribeState('s', '46', function (value) { self.dmxfb[43]['background-color'] = value; }); const sig47SubKey = CrComLib.subscribeState('s', '47', function (value) { self.dmxfb[44]['background-color'] = value; }); const sig48SubKey = CrComLib.subscribeState('s', '48', function (value) { self.dmxfb[45]['background-color'] = value; }); const sig49SubKey = CrComLib.subscribeState('s', '49', function (value) { self.dmxfb[46]['background-color'] = value; }); const sig50SubKey = CrComLib.subscribeState('s', '50', function (value) { self.dmxfb[47]['background-color'] = value; }); const sig51SubKey = CrComLib.subscribeState('s', '51', function (value) { self.dmxfb[48]['background-color'] = value; }); const sig52SubKey = CrComLib.subscribeState('s', '52', function (value) { self.dmxfb[49]['background-color'] = value; }); const sig53SubKey = CrComLib.subscribeState('s', '53', function (value) { self.dmxfb[50]['background-color'] = value; }); const sig54SubKey = CrComLib.subscribeState('s', '54', function (value) { self.dmxfb[51]['background-color'] = value; }); const sig55SubKey = CrComLib.subscribeState('s', '55', function (value) { self.dmxfb[52]['background-color'] = value; }); const sig56SubKey = CrComLib.subscribeState('s', '56', function (value) { self.dmxfb[53]['background-color'] = value; }); const sig57SubKey = CrComLib.subscribeState('s', '57', function (value) { self.dmxfb[54]['background-color'] = value; }); const sig58SubKey = CrComLib.subscribeState('s', '58', function (value) { self.dmxfb[55]['background-color'] = value; }); const sig59SubKey = CrComLib.subscribeState('s', '59', function (value) { self.dmxfb[56]['background-color'] = value; }); const sig60SubKey = CrComLib.subscribeState('s', '60', function (value) { self.dmxfb[57]['background-color'] = value; }); const sig61SubKey = CrComLib.subscribeState('s', '61', function (value) { self.dmxfb[58]['background-color'] = value; }); const sig62SubKey = CrComLib.subscribeState('s', '62', function (value) { self.dmxfb[59]['background-color'] = value; }); const sig63SubKey = CrComLib.subscribeState('s', '63', function (value) { self.dmxfb[60]['background-color'] = value; }); const sig64SubKey = CrComLib.subscribeState('s', '64', function (value) { self.dmxfb[61]['background-color'] = value; }); const sig65SubKey = CrComLib.subscribeState('s', '65', function (value) { self.dmxfb[62]['background-color'] = value; }); const sig66SubKey = CrComLib.subscribeState('s', '66', function (value) { self.dmxfb[63]['background-color'] = value; }); const sig67SubKey = CrComLib.subscribeState('s', '67', function (value) { self.dmxfb[64]['background-color'] = value; }); const sig68SubKey = CrComLib.subscribeState('s', '68', function (value) { self.dmxfb[65]['background-color'] = value; }); const sig69SubKey = CrComLib.subscribeState('s', '69', function (value) { self.dmxfb[66]['background-color'] = value; }); const sig70SubKey = CrComLib.subscribeState('s', '70', function (value) { self.dmxfb[67]['background-color'] = value; }); const sig71SubKey = CrComLib.subscribeState('s', '71', function (value) { self.dmxfb[68]['background-color'] = value; }); const sig72SubKey = CrComLib.subscribeState('s', '72', function (value) { self.dmxfb[69]['background-color'] = value; }); const sig73SubKey = CrComLib.subscribeState('s', '73', function (value) { self.dmxfb[70]['background-color'] = value; }); const sig74SubKey = CrComLib.subscribeState('s', '74', function (value) { self.dmxfb[71]['background-color'] = value; }); const sig75SubKey = CrComLib.subscribeState('s', '75', function (value) { self.dmxfb[72]['background-color'] = value; }); const sig76SubKey = CrComLib.subscribeState('s', '76', function (value) { self.dmxfb[73]['background-color'] = value; }); const sig77SubKey = CrComLib.subscribeState('s', '77', function (value) { self.dmxfb[74]['background-color'] = value; }); const sig78SubKey = CrComLib.subscribeState('s', '78', function (value) { self.dmxfb[75]['background-color'] = value; }); const sig79SubKey = CrComLib.subscribeState('s', '79', function (value) { self.dmxfb[76]['background-color'] = value; }); const sig80SubKey = CrComLib.subscribeState('s', '80', function (value) { self.dmxfb[77]['background-color'] = value; }); const sig81SubKey = CrComLib.subscribeState('s', '81', function (value) { self.dmxfb[78]['background-color'] = value; }); const sig82SubKey = CrComLib.subscribeState('s', '82', function (value) { self.dmxfb[79]['background-color'] = value; }); const sig83SubKey = CrComLib.subscribeState('s', '83', function (value) { self.dmxfb[80]['background-color'] = value; }); const sig84SubKey = CrComLib.subscribeState('s', '84', function (value) { self.dmxfb[81]['background-color'] = value; }); const sig85SubKey = CrComLib.subscribeState('s', '85', function (value) { self.dmxfb[82]['background-color'] = value; }); const sig86SubKey = CrComLib.subscribeState('s', '86', function (value) { self.dmxfb[83]['background-color'] = value; }); const sig87SubKey = CrComLib.subscribeState('s', '87', function (value) { self.dmxfb[84]['background-color'] = value; }); const sig88SubKey = CrComLib.subscribeState('s', '88', function (value) { self.dmxfb[85]['background-color'] = value; }); const sig89SubKey = CrComLib.subscribeState('s', '89', function (value) { self.dmxfb[86]['background-color'] = value; }); const sig90SubKey = CrComLib.subscribeState('s', '90', function (value) { self.dmxfb[87]['background-color'] = value; }); const sig91SubKey = CrComLib.subscribeState('s', '91', function (value) { self.dmxfb[88]['background-color'] = value; }); const sig92SubKey = CrComLib.subscribeState('s', '92', function (value) { self.dmxfb[89]['background-color'] = value; }); const sig93SubKey = CrComLib.subscribeState('s', '93', function (value) { self.dmxfb[90]['background-color'] = value; }); const sig94SubKey = CrComLib.subscribeState('s', '94', function (value) { self.dmxfb[91]['background-color'] = value; }); const sig95SubKey = CrComLib.subscribeState('s', '95', function (value) { self.dmxfb[92]['background-color'] = value; }); const sig96SubKey = CrComLib.subscribeState('s', '96', function (value) { self.dmxfb[93]['background-color'] = value; }); const sig97SubKey = CrComLib.subscribeState('s', '97', function (value) { self.dmxfb[94]['background-color'] = value; }); const sig98SubKey = CrComLib.subscribeState('s', '98', function (value) { self.dmxfb[95]['background-color'] = value; }); const sig99SubKey = CrComLib.subscribeState('s', '99', function (value) { self.dmxfb[96]['background-color'] = value; }); const sig100SubKey = CrComLib.subscribeState('s', '100', function (value) { self.dmxfb[97]['background-color'] = value; }); const sig101SubKey = CrComLib.subscribeState('s', '101', function (value) { self.dmxfb[98]['background-color'] = value; }); const sig102SubKey = CrComLib.subscribeState('s', '102', function (value) { self.dmxfb[99]['background-color'] = value; }); const sig103SubKey = CrComLib.subscribeState('s', '103', function (value) { self.dmxfb[100]['background-color'] = value; }); const sig104SubKey = CrComLib.subscribeState('s', '104', function (value) { self.dmxfb[101]['background-color'] = value; }); const sig105SubKey = CrComLib.subscribeState('s', '105', function (value) { self.dmxfb[102]['background-color'] = value; }); const sig106SubKey = CrComLib.subscribeState('s', '106', function (value) { self.dmxfb[103]['background-color'] = value; }); const sig107SubKey = CrComLib.subscribeState('s', '107', function (value) { self.dmxfb[104]['background-color'] = value; }); const sig108SubKey = CrComLib.subscribeState('s', '108', function (value) { self.dmxfb[105]['background-color'] = value; }); const sig109SubKey = CrComLib.subscribeState('s', '109', function (value) { self.dmxfb[106]['background-color'] = value; }); const sig110SubKey = CrComLib.subscribeState('s', '110', function (value) { self.dmxfb[107]['background-color'] = value; }); const sig111SubKey = CrComLib.subscribeState('s', '111', function (value) { self.dmxfb[108]['background-color'] = value; }); const sig112SubKey = CrComLib.subscribeState('s', '112', function (value) { self.dmxfb[109]['background-color'] = value; }); const sig113SubKey = CrComLib.subscribeState('s', '113', function (value) { self.dmxfb[110]['background-color'] = value; }); const sig114SubKey = CrComLib.subscribeState('s', '114', function (value) { self.dmxfb[111]['background-color'] = value; }); const sig115SubKey = CrComLib.subscribeState('s', '115', function (value) { self.dmxfb[112]['background-color'] = value; }); const sig116SubKey = CrComLib.subscribeState('s', '116', function (value) { self.dmxfb[113]['background-color'] = value; }); const sig117SubKey = CrComLib.subscribeState('s', '117', function (value) { self.dmxfb[114]['background-color'] = value; }); const sig118SubKey = CrComLib.subscribeState('s', '118', function (value) { self.dmxfb[115]['background-color'] = value; }); const sig119SubKey = CrComLib.subscribeState('s', '119', function (value) { self.dmxfb[116]['background-color'] = value; }); const sig120SubKey = CrComLib.subscribeState('s', '120', function (value) { self.dmxfb[117]['background-color'] = value; }); const sig121SubKey = CrComLib.subscribeState('s', '121', function (value) { self.dmxfb[118]['background-color'] = value; }); const sig122SubKey = CrComLib.subscribeState('s', '122', function (value) { self.dmxfb[119]['background-color'] = value; });


    ////////timeout for refreshing CrCom subscribeState
    setInterval(function () { }, 1000);




  }




  ////////////DMX Mat dialog pop up

  DMXcall(id: number) {
    const dialogRef = this.dialog.open(DmxpopComponent, {
      width: '80vw',
      data: id,
    });
    let temp: number;
    id = id - 1;
    temp = id * 10 + 3;
    let temp2: string;
    temp2 = temp.toString();
    CrComLib.publishEvent('b', temp2, true);
    CrComLib.publishEvent('b', temp2, false);


  }


  /////////////// Area Mat dialog pop up


  Areapop() {
    const dialogRef = this.dialog.open(AreapopComponent, {
    });
  }

  Scenepop() {
    const dialogRef = this.dialog.open(ScenepopComponent, {

    });
  }

  Scenesave() {
    const dialogRef = this.dialog.open(ConfirmationComponent, {

    });
  }
}