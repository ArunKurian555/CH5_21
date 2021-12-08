import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AreapopComponent } from './areapop.component';

describe('AreapopComponent', () => {
  let component: AreapopComponent;
  let fixture: ComponentFixture<AreapopComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AreapopComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AreapopComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
