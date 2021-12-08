import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ScenepopComponent } from './scenepop.component';

describe('ScenepopComponent', () => {
  let component: ScenepopComponent;
  let fixture: ComponentFixture<ScenepopComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ScenepopComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ScenepopComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
