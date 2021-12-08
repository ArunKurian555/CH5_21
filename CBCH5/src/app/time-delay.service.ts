import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TimeDelayService {
  active: number;
  constructor() { }
}
