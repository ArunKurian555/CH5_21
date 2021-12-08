import { Injectable } from '@angular/core';

declare var CrComLib: any;

@Injectable({
  providedIn: 'root'
})
export class ZonesService {

  constructor() { }
  activeZones = [1];
  value: string;

  get() {
    let self = this; //this statement binds the object that you want to self;

    let items = [];
    const sig22SubKey = CrComLib.subscribeState('s', '1', function (value) {
      self.value = value;
    });
    for (let i = 0; i < self.value.length; i++) {
      if (self.value[i] === "1") {
        items.push(i / 2 + 1);
      }
    }
    self.activeZones = items;
  }
}
