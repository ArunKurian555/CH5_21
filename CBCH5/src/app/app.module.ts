import {getVersion, getBuildDate} from "@crestron/ch5-webxpanel"; 
import WebXPanel, {WebXPanelConfigParams, isActive, WebXPanelEvents} from "@crestron/ch5-webxpanel"; 
import { BrowserModule } from '@angular/platform-browser';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA, APP_INITIALIZER } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { AppComponent } from './app.component';
import { APP_BASE_HREF } from '@angular/common';
import { ScenesComponent } from './scenes/scenes.component';
import { ChRouteService } from 'src/service/ch-route.service';
import { UtilitiesComponent } from './utilities/utilities.component';
import { ConfigService } from 'src/service/config.service';
import { View3Component } from './view3/view3.component';
import { ScrollingModule } from '@angular/cdk/scrolling';
import { MatGridListModule } from '@angular/material/grid-list';
import { ColorSketchModule } from 'ngx-color/sketch';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { View4Component } from './view4/view4.component';
import { View5Component } from './view5/view5.component';
import { DmxpopComponent } from './dmxpop/dmxpop.component';
import { NoopAnimationsModule } from '@angular/platform-browser/animations' 
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { ColorChromeModule } from 'ngx-color/chrome';
import { MatSliderModule } from '@angular/material/slider';
import { AreapopComponent } from './areapop/areapop.component'; // <color-chrome></color-chrome>
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import {MatButtonToggleModule} from '@angular/material/button-toggle';
import { EditnameComponent } from './editname/editname.component';
import { EditorpageComponent } from './editorpage/editorpage.component';
import { RamptimeComponent } from './ramptime/ramptime.component';
import { ScenepopComponent } from './scenepop/scenepop.component';
import { ConfirmationComponent } from './confirmation/confirmation.component';
import { SettimeComponent } from './settime/settime.component';
import { NgxMaterialTimepickerModule } from 'ngx-material-timepicker';
import { View6Component } from './view6/view6.component';
import { DragDropModule } from '@angular/cdk/drag-drop';
import { UserIdleModule } from 'angular-user-idle';
import { View7Component } from './view7/view7.component';
import { FpzonecontrolComponent } from './fpzonecontrol/fpzonecontrol.component';
import { ZumfhComponent } from './zumfh/zumfh.component';
import { View8Component } from './view8/view8.component';
import { View9Component } from './view9/view9.component';
import { TimeDelayService } from "./time-delay.service";
import {MatSnackBarModule} from '@angular/material/snack-bar';

const configuration: Partial<WebXPanelConfigParams> = { 
   // host: '', // defaults to window.location.host
    ipId: '0x03' // string representing a hex value. Might contain "0x" or not. Defaults to "0x03"
   // roomId: 'virtual_control_room_id', // defaults to empty string
}; 

console.log(`WebXPanel version: ${getVersion()}`); 
console.log(`WebXPanel build date: ${getBuildDate()}`); 


const webXPanelFactory = () => () => {
    if (isActive) { 
      WebXPanel.initialize(configuration); 
    } 
} 
 
WebXPanel.addEventListener(WebXPanelEvents.LICENSE_WS, ({detail}) => { 
  const { 
    resourceAvailable, 
    controlSystemSupportsLicense, 
    licenseApplied, 
    licenseHasExpiry, 
    licenseDaysRemaining, 
    trialPeriod, 
    trialPeriodDaysRemaining, 
  } = detail; 
  console.log(detail);
  
  // other callback code 
}); 

WebXPanel.addEventListener(WebXPanelEvents.CONNECT_CIP, ({detail}) => { 
    const {url, ipId, roomId} = detail; 
    console.log(`Connected to ${url}, ${parseInt(ipId, 16)}, ${roomId}`); 
  }); 

@NgModule({
  declarations: [AppComponent, ScenesComponent, UtilitiesComponent, View3Component, View4Component, View5Component, DmxpopComponent, AreapopComponent, EditnameComponent, EditorpageComponent, RamptimeComponent, ScenepopComponent, ConfirmationComponent, SettimeComponent, View6Component, View7Component, FpzonecontrolComponent, ZumfhComponent, View8Component, View9Component],
  imports: [BrowserModule, MatSnackBarModule, FontAwesomeModule, ScrollingModule, ColorSketchModule, NoopAnimationsModule, BrowserAnimationsModule, MatDialogModule, ColorChromeModule, MatSliderModule, FormsModule, MatGridListModule, MatSlideToggleModule, MatButtonModule, MatButtonToggleModule,NgxMaterialTimepickerModule, DragDropModule, UserIdleModule.forRoot({ idle: 100, timeout: 10, ping: 120 })],
  providers: [
    { provide: APP_BASE_HREF, useValue: './' },
    { provide: APP_INITIALIZER, useFactory: webXPanelFactory, multi: true },
    ChRouteService,
    ConfigService,
    TimeDelayService
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  bootstrap: [AppComponent],
})
export class AppModule { }
