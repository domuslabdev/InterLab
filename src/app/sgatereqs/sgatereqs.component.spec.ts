import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SgatereqsComponent } from './sgatereqs.component';

describe('SgatereqsComponent', () => {
  let component: SgatereqsComponent;
  let fixture: ComponentFixture<SgatereqsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SgatereqsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SgatereqsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
