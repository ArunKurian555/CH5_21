import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { View8Component } from './view8.component';

describe('View8Component', () => {
  let component: View8Component;
  let fixture: ComponentFixture<View8Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ View8Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(View8Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
