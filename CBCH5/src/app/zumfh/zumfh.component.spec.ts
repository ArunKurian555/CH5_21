import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ZumfhComponent } from './zumfh.component';

describe('ZumfhComponent', () => {
  let component: ZumfhComponent;
  let fixture: ComponentFixture<ZumfhComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ZumfhComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ZumfhComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
