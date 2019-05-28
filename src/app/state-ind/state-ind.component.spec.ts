import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { StateIndComponent } from './state-ind.component';

describe('StateIndComponent', () => {
  let component: StateIndComponent;
  let fixture: ComponentFixture<StateIndComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ StateIndComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StateIndComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
