import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { View9Component } from './view9.component';

describe('View9Component', () => {
  let component: View9Component;
  let fixture: ComponentFixture<View9Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ View9Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(View9Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
