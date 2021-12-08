import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RamptimeComponent } from './ramptime.component';

describe('RamptimeComponent', () => {
  let component: RamptimeComponent;
  let fixture: ComponentFixture<RamptimeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RamptimeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RamptimeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
