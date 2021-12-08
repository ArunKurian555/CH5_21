import { Component, OnInit } from '@angular/core';

declare var CrComLib: any;
@Component({
  selector: 'app-editorpage',
  templateUrl: './editorpage.component.html',
  styleUrls: ['./editorpage.component.scss']
})
export class EditorpageComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }




  tick() {
    CrComLib.publishEvent('b', "3068", true);
    CrComLib.publishEvent('b', "3068", false);


  }

}
