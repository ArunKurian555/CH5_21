import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FpzonecontrolComponent } from './fpzonecontrol.component';

describe('FpzonecontrolComponent', () => {
  let component: FpzonecontrolComponent;
  let fixture: ComponentFixture<FpzonecontrolComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FpzonecontrolComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FpzonecontrolComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
