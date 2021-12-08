import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DmxpopComponent } from './dmxpop.component';

describe('DmxpopComponent', () => {
  let component: DmxpopComponent;
  let fixture: ComponentFixture<DmxpopComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DmxpopComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DmxpopComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
