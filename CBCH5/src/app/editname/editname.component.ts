import { Component, OnInit } from '@angular/core';


import { MatDialog } from '@angular/material/dialog';
import { EditorpageComponent } from '../editorpage/editorpage.component';
declare var CrComLib: any;
@Component({
  selector: 'app-editname',
  templateUrl: './editname.component.html',
  styleUrls: ['./editname.component.scss']
})
export class EditnameComponent implements OnInit {

  constructor(public dialog: MatDialog) {


  }

  activeZone = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120];
  activezonelabel = [];

  temp: number;
  value: string;
  numvalue: number;
  activeZones: number[];
  ngOnInit(): void {
    let self = this; //this statement binds the object that you want to self;

    /////////////// Active Zones
    const sig1SubKey = CrComLib.subscribeState('s', '1', function (value) {
      self.value = value;
      let items = [];
      for (let i = 0; i < self.value.length; i++) {
        if (self.value[i] === "1") {
          items.push(i + 1);
        }
      }
      self.activeZones = items;

    });



    ////////////////////////// Zone names

    for (let i = 0; i < 251; i++) {
      self.activezonelabel.push("NIL");
     }
     const Zone1SubKey = CrComLib.subscribeState('s', 'Zones.Zone1', function (value) { self.activezonelabel[1] = value; }); 
     const Zone2SubKey = CrComLib.subscribeState('s', 'Zones.Zone2', function (value) { self.activezonelabel[2] = value; }); 
     const Zone3SubKey = CrComLib.subscribeState('s', 'Zones.Zone3', function (value) { self.activezonelabel[3] = value; }); 
     const Zone4SubKey = CrComLib.subscribeState('s', 'Zones.Zone4', function (value) { self.activezonelabel[4] = value; }); 
     const Zone5SubKey = CrComLib.subscribeState('s', 'Zones.Zone5', function (value) { self.activezonelabel[5] = value; }); 
     const Zone6SubKey = CrComLib.subscribeState('s', 'Zones.Zone6', function (value) { self.activezonelabel[6] = value; }); 
     const Zone7SubKey = CrComLib.subscribeState('s', 'Zones.Zone7', function (value) { self.activezonelabel[7] = value; }); 
     const Zone8SubKey = CrComLib.subscribeState('s', 'Zones.Zone8', function (value) { self.activezonelabel[8] = value; }); 
     const Zone9SubKey = CrComLib.subscribeState('s', 'Zones.Zone9', function (value) { self.activezonelabel[9] = value; }); 
     const Zone10SubKey = CrComLib.subscribeState('s', 'Zones.Zone10', function (value) { self.activezonelabel[10] = value; }); 
     const Zone11SubKey = CrComLib.subscribeState('s', 'Zones.Zone11', function (value) { self.activezonelabel[11] = value; }); 
     const Zone12SubKey = CrComLib.subscribeState('s', 'Zones.Zone12', function (value) { self.activezonelabel[12] = value; }); 
     const Zone13SubKey = CrComLib.subscribeState('s', 'Zones.Zone13', function (value) { self.activezonelabel[13] = value; }); 
     const Zone14SubKey = CrComLib.subscribeState('s', 'Zones.Zone14', function (value) { self.activezonelabel[14] = value; }); 
     const Zone15SubKey = CrComLib.subscribeState('s', 'Zones.Zone15', function (value) { self.activezonelabel[15] = value; }); 
     const Zone16SubKey = CrComLib.subscribeState('s', 'Zones.Zone16', function (value) { self.activezonelabel[16] = value; }); 
     const Zone17SubKey = CrComLib.subscribeState('s', 'Zones.Zone17', function (value) { self.activezonelabel[17] = value; }); 
     const Zone18SubKey = CrComLib.subscribeState('s', 'Zones.Zone18', function (value) { self.activezonelabel[18] = value; }); 
     const Zone19SubKey = CrComLib.subscribeState('s', 'Zones.Zone19', function (value) { self.activezonelabel[19] = value; }); 
     const Zone20SubKey = CrComLib.subscribeState('s', 'Zones.Zone20', function (value) { self.activezonelabel[20] = value; }); 
     const Zone21SubKey = CrComLib.subscribeState('s', 'Zones.Zone21', function (value) { self.activezonelabel[21] = value; }); 
     const Zone22SubKey = CrComLib.subscribeState('s', 'Zones.Zone22', function (value) { self.activezonelabel[22] = value; }); 
     const Zone23SubKey = CrComLib.subscribeState('s', 'Zones.Zone23', function (value) { self.activezonelabel[23] = value; }); 
     const Zone24SubKey = CrComLib.subscribeState('s', 'Zones.Zone24', function (value) { self.activezonelabel[24] = value; }); 
     const Zone25SubKey = CrComLib.subscribeState('s', 'Zones.Zone25', function (value) { self.activezonelabel[25] = value; }); 
     const Zone26SubKey = CrComLib.subscribeState('s', 'Zones.Zone26', function (value) { self.activezonelabel[26] = value; }); 
     const Zone27SubKey = CrComLib.subscribeState('s', 'Zones.Zone27', function (value) { self.activezonelabel[27] = value; }); 
     const Zone28SubKey = CrComLib.subscribeState('s', 'Zones.Zone28', function (value) { self.activezonelabel[28] = value; }); 
     const Zone29SubKey = CrComLib.subscribeState('s', 'Zones.Zone29', function (value) { self.activezonelabel[29] = value; }); 
     const Zone30SubKey = CrComLib.subscribeState('s', 'Zones.Zone30', function (value) { self.activezonelabel[30] = value; }); 
     const Zone31SubKey = CrComLib.subscribeState('s', 'Zones.Zone31', function (value) { self.activezonelabel[31] = value; }); 
     const Zone32SubKey = CrComLib.subscribeState('s', 'Zones.Zone32', function (value) { self.activezonelabel[32] = value; }); 
     const Zone33SubKey = CrComLib.subscribeState('s', 'Zones.Zone33', function (value) { self.activezonelabel[33] = value; }); 
     const Zone34SubKey = CrComLib.subscribeState('s', 'Zones.Zone34', function (value) { self.activezonelabel[34] = value; }); 
     const Zone35SubKey = CrComLib.subscribeState('s', 'Zones.Zone35', function (value) { self.activezonelabel[35] = value; }); 
     const Zone36SubKey = CrComLib.subscribeState('s', 'Zones.Zone36', function (value) { self.activezonelabel[36] = value; }); 
     const Zone37SubKey = CrComLib.subscribeState('s', 'Zones.Zone37', function (value) { self.activezonelabel[37] = value; }); 
     const Zone38SubKey = CrComLib.subscribeState('s', 'Zones.Zone38', function (value) { self.activezonelabel[38] = value; }); 
     const Zone39SubKey = CrComLib.subscribeState('s', 'Zones.Zone39', function (value) { self.activezonelabel[39] = value; }); 
     const Zone40SubKey = CrComLib.subscribeState('s', 'Zones.Zone40', function (value) { self.activezonelabel[40] = value; }); 
     const Zone41SubKey = CrComLib.subscribeState('s', 'Zones.Zone41', function (value) { self.activezonelabel[41] = value; }); 
     const Zone42SubKey = CrComLib.subscribeState('s', 'Zones.Zone42', function (value) { self.activezonelabel[42] = value; }); 
     const Zone43SubKey = CrComLib.subscribeState('s', 'Zones.Zone43', function (value) { self.activezonelabel[43] = value; }); 
     const Zone44SubKey = CrComLib.subscribeState('s', 'Zones.Zone44', function (value) { self.activezonelabel[44] = value; }); 
     const Zone45SubKey = CrComLib.subscribeState('s', 'Zones.Zone45', function (value) { self.activezonelabel[45] = value; }); 
     const Zone46SubKey = CrComLib.subscribeState('s', 'Zones.Zone46', function (value) { self.activezonelabel[46] = value; }); 
     const Zone47SubKey = CrComLib.subscribeState('s', 'Zones.Zone47', function (value) { self.activezonelabel[47] = value; }); 
     const Zone48SubKey = CrComLib.subscribeState('s', 'Zones.Zone48', function (value) { self.activezonelabel[48] = value; }); 
     const Zone49SubKey = CrComLib.subscribeState('s', 'Zones.Zone49', function (value) { self.activezonelabel[49] = value; }); 
     const Zone50SubKey = CrComLib.subscribeState('s', 'Zones.Zone50', function (value) { self.activezonelabel[50] = value; }); 
     const Zone51SubKey = CrComLib.subscribeState('s', 'Zones.Zone51', function (value) { self.activezonelabel[51] = value; }); 
     const Zone52SubKey = CrComLib.subscribeState('s', 'Zones.Zone52', function (value) { self.activezonelabel[52] = value; }); 
     const Zone53SubKey = CrComLib.subscribeState('s', 'Zones.Zone53', function (value) { self.activezonelabel[53] = value; }); 
     const Zone54SubKey = CrComLib.subscribeState('s', 'Zones.Zone54', function (value) { self.activezonelabel[54] = value; }); 
     const Zone55SubKey = CrComLib.subscribeState('s', 'Zones.Zone55', function (value) { self.activezonelabel[55] = value; }); 
     const Zone56SubKey = CrComLib.subscribeState('s', 'Zones.Zone56', function (value) { self.activezonelabel[56] = value; }); 
     const Zone57SubKey = CrComLib.subscribeState('s', 'Zones.Zone57', function (value) { self.activezonelabel[57] = value; }); 
     const Zone58SubKey = CrComLib.subscribeState('s', 'Zones.Zone58', function (value) { self.activezonelabel[58] = value; }); 
     const Zone59SubKey = CrComLib.subscribeState('s', 'Zones.Zone59', function (value) { self.activezonelabel[59] = value; }); 
     const Zone60SubKey = CrComLib.subscribeState('s', 'Zones.Zone60', function (value) { self.activezonelabel[60] = value; }); 
     const Zone61SubKey = CrComLib.subscribeState('s', 'Zones.Zone61', function (value) { self.activezonelabel[61] = value; }); 
     const Zone62SubKey = CrComLib.subscribeState('s', 'Zones.Zone62', function (value) { self.activezonelabel[62] = value; }); 
     const Zone63SubKey = CrComLib.subscribeState('s', 'Zones.Zone63', function (value) { self.activezonelabel[63] = value; }); 
     const Zone64SubKey = CrComLib.subscribeState('s', 'Zones.Zone64', function (value) { self.activezonelabel[64] = value; }); 
     const Zone65SubKey = CrComLib.subscribeState('s', 'Zones.Zone65', function (value) { self.activezonelabel[65] = value; }); 
     const Zone66SubKey = CrComLib.subscribeState('s', 'Zones.Zone66', function (value) { self.activezonelabel[66] = value; }); 
     const Zone67SubKey = CrComLib.subscribeState('s', 'Zones.Zone67', function (value) { self.activezonelabel[67] = value; }); 
     const Zone68SubKey = CrComLib.subscribeState('s', 'Zones.Zone68', function (value) { self.activezonelabel[68] = value; }); 
     const Zone69SubKey = CrComLib.subscribeState('s', 'Zones.Zone69', function (value) { self.activezonelabel[69] = value; }); 
     const Zone70SubKey = CrComLib.subscribeState('s', 'Zones.Zone70', function (value) { self.activezonelabel[70] = value; }); 
     const Zone71SubKey = CrComLib.subscribeState('s', 'Zones.Zone71', function (value) { self.activezonelabel[71] = value; }); 
     const Zone72SubKey = CrComLib.subscribeState('s', 'Zones.Zone72', function (value) { self.activezonelabel[72] = value; }); 
     const Zone73SubKey = CrComLib.subscribeState('s', 'Zones.Zone73', function (value) { self.activezonelabel[73] = value; }); 
     const Zone74SubKey = CrComLib.subscribeState('s', 'Zones.Zone74', function (value) { self.activezonelabel[74] = value; }); 
     const Zone75SubKey = CrComLib.subscribeState('s', 'Zones.Zone75', function (value) { self.activezonelabel[75] = value; }); 
     const Zone76SubKey = CrComLib.subscribeState('s', 'Zones.Zone76', function (value) { self.activezonelabel[76] = value; }); 
     const Zone77SubKey = CrComLib.subscribeState('s', 'Zones.Zone77', function (value) { self.activezonelabel[77] = value; }); 
     const Zone78SubKey = CrComLib.subscribeState('s', 'Zones.Zone78', function (value) { self.activezonelabel[78] = value; }); 
     const Zone79SubKey = CrComLib.subscribeState('s', 'Zones.Zone79', function (value) { self.activezonelabel[79] = value; }); 
     const Zone80SubKey = CrComLib.subscribeState('s', 'Zones.Zone80', function (value) { self.activezonelabel[80] = value; }); 
     const Zone81SubKey = CrComLib.subscribeState('s', 'Zones.Zone81', function (value) { self.activezonelabel[81] = value; }); 
     const Zone82SubKey = CrComLib.subscribeState('s', 'Zones.Zone82', function (value) { self.activezonelabel[82] = value; }); 
     const Zone83SubKey = CrComLib.subscribeState('s', 'Zones.Zone83', function (value) { self.activezonelabel[83] = value; }); 
     const Zone84SubKey = CrComLib.subscribeState('s', 'Zones.Zone84', function (value) { self.activezonelabel[84] = value; }); 
     const Zone85SubKey = CrComLib.subscribeState('s', 'Zones.Zone85', function (value) { self.activezonelabel[85] = value; }); 
     const Zone86SubKey = CrComLib.subscribeState('s', 'Zones.Zone86', function (value) { self.activezonelabel[86] = value; }); 
     const Zone87SubKey = CrComLib.subscribeState('s', 'Zones.Zone87', function (value) { self.activezonelabel[87] = value; }); 
     const Zone88SubKey = CrComLib.subscribeState('s', 'Zones.Zone88', function (value) { self.activezonelabel[88] = value; }); 
     const Zone89SubKey = CrComLib.subscribeState('s', 'Zones.Zone89', function (value) { self.activezonelabel[89] = value; }); 
     const Zone90SubKey = CrComLib.subscribeState('s', 'Zones.Zone90', function (value) { self.activezonelabel[90] = value; }); 
     const Zone91SubKey = CrComLib.subscribeState('s', 'Zones.Zone91', function (value) { self.activezonelabel[91] = value; }); 
     const Zone92SubKey = CrComLib.subscribeState('s', 'Zones.Zone92', function (value) { self.activezonelabel[92] = value; }); 
     const Zone93SubKey = CrComLib.subscribeState('s', 'Zones.Zone93', function (value) { self.activezonelabel[93] = value; }); 
     const Zone94SubKey = CrComLib.subscribeState('s', 'Zones.Zone94', function (value) { self.activezonelabel[94] = value; }); 
     const Zone95SubKey = CrComLib.subscribeState('s', 'Zones.Zone95', function (value) { self.activezonelabel[95] = value; }); 
     const Zone96SubKey = CrComLib.subscribeState('s', 'Zones.Zone96', function (value) { self.activezonelabel[96] = value; }); 
     const Zone97SubKey = CrComLib.subscribeState('s', 'Zones.Zone97', function (value) { self.activezonelabel[97] = value; }); 
     const Zone98SubKey = CrComLib.subscribeState('s', 'Zones.Zone98', function (value) { self.activezonelabel[98] = value; }); 
     const Zone99SubKey = CrComLib.subscribeState('s', 'Zones.Zone99', function (value) { self.activezonelabel[99] = value; }); 
     const Zone100SubKey = CrComLib.subscribeState('s', 'Zones.Zone100', function (value) { self.activezonelabel[100] = value; }); 
     const Zone101SubKey = CrComLib.subscribeState('s', 'Zones.Zone101', function (value) { self.activezonelabel[101] = value; }); 
     const Zone102SubKey = CrComLib.subscribeState('s', 'Zones.Zone102', function (value) { self.activezonelabel[102] = value; }); 
     const Zone103SubKey = CrComLib.subscribeState('s', 'Zones.Zone103', function (value) { self.activezonelabel[103] = value; }); 
     const Zone104SubKey = CrComLib.subscribeState('s', 'Zones.Zone104', function (value) { self.activezonelabel[104] = value; }); 
     const Zone105SubKey = CrComLib.subscribeState('s', 'Zones.Zone105', function (value) { self.activezonelabel[105] = value; }); 
     const Zone106SubKey = CrComLib.subscribeState('s', 'Zones.Zone106', function (value) { self.activezonelabel[106] = value; }); 
     const Zone107SubKey = CrComLib.subscribeState('s', 'Zones.Zone107', function (value) { self.activezonelabel[107] = value; }); 
     const Zone108SubKey = CrComLib.subscribeState('s', 'Zones.Zone108', function (value) { self.activezonelabel[108] = value; }); 
     const Zone109SubKey = CrComLib.subscribeState('s', 'Zones.Zone109', function (value) { self.activezonelabel[109] = value; }); 
     const Zone110SubKey = CrComLib.subscribeState('s', 'Zones.Zone110', function (value) { self.activezonelabel[110] = value; }); 
     const Zone111SubKey = CrComLib.subscribeState('s', 'Zones.Zone111', function (value) { self.activezonelabel[111] = value; }); 
     const Zone112SubKey = CrComLib.subscribeState('s', 'Zones.Zone112', function (value) { self.activezonelabel[112] = value; }); 
     const Zone113SubKey = CrComLib.subscribeState('s', 'Zones.Zone113', function (value) { self.activezonelabel[113] = value; }); 
     const Zone114SubKey = CrComLib.subscribeState('s', 'Zones.Zone114', function (value) { self.activezonelabel[114] = value; }); 
     const Zone115SubKey = CrComLib.subscribeState('s', 'Zones.Zone115', function (value) { self.activezonelabel[115] = value; }); 
     const Zone116SubKey = CrComLib.subscribeState('s', 'Zones.Zone116', function (value) { self.activezonelabel[116] = value; }); 
     const Zone117SubKey = CrComLib.subscribeState('s', 'Zones.Zone117', function (value) { self.activezonelabel[117] = value; }); 
     const Zone118SubKey = CrComLib.subscribeState('s', 'Zones.Zone118', function (value) { self.activezonelabel[118] = value; }); 
     const Zone119SubKey = CrComLib.subscribeState('s', 'Zones.Zone119', function (value) { self.activezonelabel[119] = value; }); 
     const Zone120SubKey = CrComLib.subscribeState('s', 'Zones.Zone120', function (value) { self.activezonelabel[120] = value; }); 
     const Zone121SubKey = CrComLib.subscribeState('s', 'Zones.Zone121', function (value) { self.activezonelabel[121] = value; }); 
     const Zone122SubKey = CrComLib.subscribeState('s', 'Zones.Zone122', function (value) { self.activezonelabel[122] = value; }); 
     const Zone123SubKey = CrComLib.subscribeState('s', 'Zones.Zone123', function (value) { self.activezonelabel[123] = value; }); 
     const Zone124SubKey = CrComLib.subscribeState('s', 'Zones.Zone124', function (value) { self.activezonelabel[124] = value; }); 
     const Zone125SubKey = CrComLib.subscribeState('s', 'Zones.Zone125', function (value) { self.activezonelabel[125] = value; }); 
     const Zone126SubKey = CrComLib.subscribeState('s', 'Zones.Zone126', function (value) { self.activezonelabel[126] = value; }); 
     const Zone127SubKey = CrComLib.subscribeState('s', 'Zones.Zone127', function (value) { self.activezonelabel[127] = value; }); 
     const Zone128SubKey = CrComLib.subscribeState('s', 'Zones.Zone128', function (value) { self.activezonelabel[128] = value; }); 
     const Zone129SubKey = CrComLib.subscribeState('s', 'Zones.Zone129', function (value) { self.activezonelabel[129] = value; }); 
     const Zone130SubKey = CrComLib.subscribeState('s', 'Zones.Zone130', function (value) { self.activezonelabel[130] = value; }); 
     const Zone131SubKey = CrComLib.subscribeState('s', 'Zones.Zone131', function (value) { self.activezonelabel[131] = value; }); 
     const Zone132SubKey = CrComLib.subscribeState('s', 'Zones.Zone132', function (value) { self.activezonelabel[132] = value; }); 
     const Zone133SubKey = CrComLib.subscribeState('s', 'Zones.Zone133', function (value) { self.activezonelabel[133] = value; }); 
     const Zone134SubKey = CrComLib.subscribeState('s', 'Zones.Zone134', function (value) { self.activezonelabel[134] = value; }); 
     const Zone135SubKey = CrComLib.subscribeState('s', 'Zones.Zone135', function (value) { self.activezonelabel[135] = value; }); 
     const Zone136SubKey = CrComLib.subscribeState('s', 'Zones.Zone136', function (value) { self.activezonelabel[136] = value; }); 
     const Zone137SubKey = CrComLib.subscribeState('s', 'Zones.Zone137', function (value) { self.activezonelabel[137] = value; }); 
     const Zone138SubKey = CrComLib.subscribeState('s', 'Zones.Zone138', function (value) { self.activezonelabel[138] = value; }); 
     const Zone139SubKey = CrComLib.subscribeState('s', 'Zones.Zone139', function (value) { self.activezonelabel[139] = value; }); 
     const Zone140SubKey = CrComLib.subscribeState('s', 'Zones.Zone140', function (value) { self.activezonelabel[140] = value; }); 
     const Zone141SubKey = CrComLib.subscribeState('s', 'Zones.Zone141', function (value) { self.activezonelabel[141] = value; }); 
     const Zone142SubKey = CrComLib.subscribeState('s', 'Zones.Zone142', function (value) { self.activezonelabel[142] = value; }); 
     const Zone143SubKey = CrComLib.subscribeState('s', 'Zones.Zone143', function (value) { self.activezonelabel[143] = value; }); 
     const Zone144SubKey = CrComLib.subscribeState('s', 'Zones.Zone144', function (value) { self.activezonelabel[144] = value; }); 
     const Zone145SubKey = CrComLib.subscribeState('s', 'Zones.Zone145', function (value) { self.activezonelabel[145] = value; }); 
     const Zone146SubKey = CrComLib.subscribeState('s', 'Zones.Zone146', function (value) { self.activezonelabel[146] = value; }); 
     const Zone147SubKey = CrComLib.subscribeState('s', 'Zones.Zone147', function (value) { self.activezonelabel[147] = value; }); 
     const Zone148SubKey = CrComLib.subscribeState('s', 'Zones.Zone148', function (value) { self.activezonelabel[148] = value; }); 
     const Zone149SubKey = CrComLib.subscribeState('s', 'Zones.Zone149', function (value) { self.activezonelabel[149] = value; }); 
     const Zone150SubKey = CrComLib.subscribeState('s', 'Zones.Zone150', function (value) { self.activezonelabel[150] = value; }); 
     const Zone151SubKey = CrComLib.subscribeState('s', 'Zones.Zone151', function (value) { self.activezonelabel[151] = value; }); 
     const Zone152SubKey = CrComLib.subscribeState('s', 'Zones.Zone152', function (value) { self.activezonelabel[152] = value; }); 
     const Zone153SubKey = CrComLib.subscribeState('s', 'Zones.Zone153', function (value) { self.activezonelabel[153] = value; }); 
     const Zone154SubKey = CrComLib.subscribeState('s', 'Zones.Zone154', function (value) { self.activezonelabel[154] = value; }); 
     const Zone155SubKey = CrComLib.subscribeState('s', 'Zones.Zone155', function (value) { self.activezonelabel[155] = value; }); 
     const Zone156SubKey = CrComLib.subscribeState('s', 'Zones.Zone156', function (value) { self.activezonelabel[156] = value; }); 
     const Zone157SubKey = CrComLib.subscribeState('s', 'Zones.Zone157', function (value) { self.activezonelabel[157] = value; }); 
     const Zone158SubKey = CrComLib.subscribeState('s', 'Zones.Zone158', function (value) { self.activezonelabel[158] = value; }); 
     const Zone159SubKey = CrComLib.subscribeState('s', 'Zones.Zone159', function (value) { self.activezonelabel[159] = value; }); 
     const Zone160SubKey = CrComLib.subscribeState('s', 'Zones.Zone160', function (value) { self.activezonelabel[160] = value; }); 
     const Zone161SubKey = CrComLib.subscribeState('s', 'Zones.Zone161', function (value) { self.activezonelabel[161] = value; }); 
     const Zone162SubKey = CrComLib.subscribeState('s', 'Zones.Zone162', function (value) { self.activezonelabel[162] = value; }); 
     const Zone163SubKey = CrComLib.subscribeState('s', 'Zones.Zone163', function (value) { self.activezonelabel[163] = value; }); 
     const Zone164SubKey = CrComLib.subscribeState('s', 'Zones.Zone164', function (value) { self.activezonelabel[164] = value; }); 
     const Zone165SubKey = CrComLib.subscribeState('s', 'Zones.Zone165', function (value) { self.activezonelabel[165] = value; }); 
     const Zone166SubKey = CrComLib.subscribeState('s', 'Zones.Zone166', function (value) { self.activezonelabel[166] = value; }); 
     const Zone167SubKey = CrComLib.subscribeState('s', 'Zones.Zone167', function (value) { self.activezonelabel[167] = value; }); 
     const Zone168SubKey = CrComLib.subscribeState('s', 'Zones.Zone168', function (value) { self.activezonelabel[168] = value; }); 
     const Zone169SubKey = CrComLib.subscribeState('s', 'Zones.Zone169', function (value) { self.activezonelabel[169] = value; }); 
     const Zone170SubKey = CrComLib.subscribeState('s', 'Zones.Zone170', function (value) { self.activezonelabel[170] = value; }); 
     const Zone171SubKey = CrComLib.subscribeState('s', 'Zones.Zone171', function (value) { self.activezonelabel[171] = value; }); 
     const Zone172SubKey = CrComLib.subscribeState('s', 'Zones.Zone172', function (value) { self.activezonelabel[172] = value; }); 
     const Zone173SubKey = CrComLib.subscribeState('s', 'Zones.Zone173', function (value) { self.activezonelabel[173] = value; }); 
     const Zone174SubKey = CrComLib.subscribeState('s', 'Zones.Zone174', function (value) { self.activezonelabel[174] = value; }); 
     const Zone175SubKey = CrComLib.subscribeState('s', 'Zones.Zone175', function (value) { self.activezonelabel[175] = value; }); 
     const Zone176SubKey = CrComLib.subscribeState('s', 'Zones.Zone176', function (value) { self.activezonelabel[176] = value; }); 
     const Zone177SubKey = CrComLib.subscribeState('s', 'Zones.Zone177', function (value) { self.activezonelabel[177] = value; }); 
     const Zone178SubKey = CrComLib.subscribeState('s', 'Zones.Zone178', function (value) { self.activezonelabel[178] = value; }); 
     const Zone179SubKey = CrComLib.subscribeState('s', 'Zones.Zone179', function (value) { self.activezonelabel[179] = value; }); 
     const Zone180SubKey = CrComLib.subscribeState('s', 'Zones.Zone180', function (value) { self.activezonelabel[180] = value; }); 
     const Zone181SubKey = CrComLib.subscribeState('s', 'Zones.Zone181', function (value) { self.activezonelabel[181] = value; }); 
     const Zone182SubKey = CrComLib.subscribeState('s', 'Zones.Zone182', function (value) { self.activezonelabel[182] = value; }); 
     const Zone183SubKey = CrComLib.subscribeState('s', 'Zones.Zone183', function (value) { self.activezonelabel[183] = value; }); 
     const Zone184SubKey = CrComLib.subscribeState('s', 'Zones.Zone184', function (value) { self.activezonelabel[184] = value; }); 
     const Zone185SubKey = CrComLib.subscribeState('s', 'Zones.Zone185', function (value) { self.activezonelabel[185] = value; }); 
     const Zone186SubKey = CrComLib.subscribeState('s', 'Zones.Zone186', function (value) { self.activezonelabel[186] = value; }); 
     const Zone187SubKey = CrComLib.subscribeState('s', 'Zones.Zone187', function (value) { self.activezonelabel[187] = value; }); 
     const Zone188SubKey = CrComLib.subscribeState('s', 'Zones.Zone188', function (value) { self.activezonelabel[188] = value; }); 
     const Zone189SubKey = CrComLib.subscribeState('s', 'Zones.Zone189', function (value) { self.activezonelabel[189] = value; }); 
     const Zone190SubKey = CrComLib.subscribeState('s', 'Zones.Zone190', function (value) { self.activezonelabel[190] = value; }); 
     const Zone191SubKey = CrComLib.subscribeState('s', 'Zones.Zone191', function (value) { self.activezonelabel[191] = value; }); 
     const Zone192SubKey = CrComLib.subscribeState('s', 'Zones.Zone192', function (value) { self.activezonelabel[192] = value; }); 
     const Zone193SubKey = CrComLib.subscribeState('s', 'Zones.Zone193', function (value) { self.activezonelabel[193] = value; }); 
     const Zone194SubKey = CrComLib.subscribeState('s', 'Zones.Zone194', function (value) { self.activezonelabel[194] = value; }); 
     const Zone195SubKey = CrComLib.subscribeState('s', 'Zones.Zone195', function (value) { self.activezonelabel[195] = value; }); 
     const Zone196SubKey = CrComLib.subscribeState('s', 'Zones.Zone196', function (value) { self.activezonelabel[196] = value; }); 
     const Zone197SubKey = CrComLib.subscribeState('s', 'Zones.Zone197', function (value) { self.activezonelabel[197] = value; }); 
     const Zone198SubKey = CrComLib.subscribeState('s', 'Zones.Zone198', function (value) { self.activezonelabel[198] = value; }); 
     const Zone199SubKey = CrComLib.subscribeState('s', 'Zones.Zone199', function (value) { self.activezonelabel[199] = value; }); 
     const Zone200SubKey = CrComLib.subscribeState('s', 'Zones.Zone200', function (value) { self.activezonelabel[200] = value; }); 
     const Zone201SubKey = CrComLib.subscribeState('s', 'Zones.Zone201', function (value) { self.activezonelabel[201] = value; }); 
     const Zone202SubKey = CrComLib.subscribeState('s', 'Zones.Zone202', function (value) { self.activezonelabel[202] = value; }); 
     const Zone203SubKey = CrComLib.subscribeState('s', 'Zones.Zone203', function (value) { self.activezonelabel[203] = value; }); 
     const Zone204SubKey = CrComLib.subscribeState('s', 'Zones.Zone204', function (value) { self.activezonelabel[204] = value; }); 
     const Zone205SubKey = CrComLib.subscribeState('s', 'Zones.Zone205', function (value) { self.activezonelabel[205] = value; }); 
     const Zone206SubKey = CrComLib.subscribeState('s', 'Zones.Zone206', function (value) { self.activezonelabel[206] = value; }); 
     const Zone207SubKey = CrComLib.subscribeState('s', 'Zones.Zone207', function (value) { self.activezonelabel[207] = value; }); 
     const Zone208SubKey = CrComLib.subscribeState('s', 'Zones.Zone208', function (value) { self.activezonelabel[208] = value; }); 
     const Zone209SubKey = CrComLib.subscribeState('s', 'Zones.Zone209', function (value) { self.activezonelabel[209] = value; }); 
     const Zone210SubKey = CrComLib.subscribeState('s', 'Zones.Zone210', function (value) { self.activezonelabel[210] = value; }); 
     const Zone211SubKey = CrComLib.subscribeState('s', 'Zones.Zone211', function (value) { self.activezonelabel[211] = value; }); 
     const Zone212SubKey = CrComLib.subscribeState('s', 'Zones.Zone212', function (value) { self.activezonelabel[212] = value; }); 
     const Zone213SubKey = CrComLib.subscribeState('s', 'Zones.Zone213', function (value) { self.activezonelabel[213] = value; }); 
     const Zone214SubKey = CrComLib.subscribeState('s', 'Zones.Zone214', function (value) { self.activezonelabel[214] = value; }); 
     const Zone215SubKey = CrComLib.subscribeState('s', 'Zones.Zone215', function (value) { self.activezonelabel[215] = value; }); 
     const Zone216SubKey = CrComLib.subscribeState('s', 'Zones.Zone216', function (value) { self.activezonelabel[216] = value; }); 
     const Zone217SubKey = CrComLib.subscribeState('s', 'Zones.Zone217', function (value) { self.activezonelabel[217] = value; }); 
     const Zone218SubKey = CrComLib.subscribeState('s', 'Zones.Zone218', function (value) { self.activezonelabel[218] = value; }); 
     const Zone219SubKey = CrComLib.subscribeState('s', 'Zones.Zone219', function (value) { self.activezonelabel[219] = value; }); 
     const Zone220SubKey = CrComLib.subscribeState('s', 'Zones.Zone220', function (value) { self.activezonelabel[220] = value; }); 
     const Zone221SubKey = CrComLib.subscribeState('s', 'Zones.Zone221', function (value) { self.activezonelabel[221] = value; }); 
     const Zone222SubKey = CrComLib.subscribeState('s', 'Zones.Zone222', function (value) { self.activezonelabel[222] = value; }); 
     const Zone223SubKey = CrComLib.subscribeState('s', 'Zones.Zone223', function (value) { self.activezonelabel[223] = value; }); 
     const Zone224SubKey = CrComLib.subscribeState('s', 'Zones.Zone224', function (value) { self.activezonelabel[224] = value; }); 
     const Zone225SubKey = CrComLib.subscribeState('s', 'Zones.Zone225', function (value) { self.activezonelabel[225] = value; }); 
     const Zone226SubKey = CrComLib.subscribeState('s', 'Zones.Zone226', function (value) { self.activezonelabel[226] = value; }); 
     const Zone227SubKey = CrComLib.subscribeState('s', 'Zones.Zone227', function (value) { self.activezonelabel[227] = value; }); 
     const Zone228SubKey = CrComLib.subscribeState('s', 'Zones.Zone228', function (value) { self.activezonelabel[228] = value; }); 
     const Zone229SubKey = CrComLib.subscribeState('s', 'Zones.Zone229', function (value) { self.activezonelabel[229] = value; }); 
     const Zone230SubKey = CrComLib.subscribeState('s', 'Zones.Zone230', function (value) { self.activezonelabel[230] = value; }); 
     const Zone231SubKey = CrComLib.subscribeState('s', 'Zones.Zone231', function (value) { self.activezonelabel[231] = value; }); 
     const Zone232SubKey = CrComLib.subscribeState('s', 'Zones.Zone232', function (value) { self.activezonelabel[232] = value; }); 
     const Zone233SubKey = CrComLib.subscribeState('s', 'Zones.Zone233', function (value) { self.activezonelabel[233] = value; }); 
     const Zone234SubKey = CrComLib.subscribeState('s', 'Zones.Zone234', function (value) { self.activezonelabel[234] = value; }); 
     const Zone235SubKey = CrComLib.subscribeState('s', 'Zones.Zone235', function (value) { self.activezonelabel[235] = value; }); 
     const Zone236SubKey = CrComLib.subscribeState('s', 'Zones.Zone236', function (value) { self.activezonelabel[236] = value; }); 
     const Zone237SubKey = CrComLib.subscribeState('s', 'Zones.Zone237', function (value) { self.activezonelabel[237] = value; }); 
     const Zone238SubKey = CrComLib.subscribeState('s', 'Zones.Zone238', function (value) { self.activezonelabel[238] = value; }); 
     const Zone239SubKey = CrComLib.subscribeState('s', 'Zones.Zone239', function (value) { self.activezonelabel[239] = value; }); 
     const Zone240SubKey = CrComLib.subscribeState('s', 'Zones.Zone240', function (value) { self.activezonelabel[240] = value; }); 
     const Zone241SubKey = CrComLib.subscribeState('s', 'Zones.Zone241', function (value) { self.activezonelabel[241] = value; }); 
     const Zone242SubKey = CrComLib.subscribeState('s', 'Zones.Zone242', function (value) { self.activezonelabel[242] = value; }); 
     const Zone243SubKey = CrComLib.subscribeState('s', 'Zones.Zone243', function (value) { self.activezonelabel[243] = value; }); 
     const Zone244SubKey = CrComLib.subscribeState('s', 'Zones.Zone244', function (value) { self.activezonelabel[244] = value; }); 
     const Zone245SubKey = CrComLib.subscribeState('s', 'Zones.Zone245', function (value) { self.activezonelabel[245] = value; }); 
     const Zone246SubKey = CrComLib.subscribeState('s', 'Zones.Zone246', function (value) { self.activezonelabel[246] = value; }); 
     const Zone247SubKey = CrComLib.subscribeState('s', 'Zones.Zone247', function (value) { self.activezonelabel[247] = value; }); 
     const Zone248SubKey = CrComLib.subscribeState('s', 'Zones.Zone248', function (value) { self.activezonelabel[248] = value; }); 
     const Zone249SubKey = CrComLib.subscribeState('s', 'Zones.Zone249', function (value) { self.activezonelabel[249] = value; }); 
     const Zone250SubKey = CrComLib.subscribeState('s', 'Zones.Zone250', function (value) { self.activezonelabel[250] = value; }); 
  


  }


  editname2(id: number) {
    const dialogRef = this.dialog.open(EditorpageComponent, {
    });
    let temp = id.toString();
    let temp2 = "Zonerename.Zoneflag" + temp;
    CrComLib.publishEvent('b', temp2, true);
    CrComLib.publishEvent('b', temp2, false);
  }



  editname1() {
    const dialogRef = this.dialog.open(EditorpageComponent, {
    });
  }

}
