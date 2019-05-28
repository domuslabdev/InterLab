import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LottiComponent } from './lotti.component';

describe('LottiComponent', () => {
  let component: LottiComponent;
  let fixture: ComponentFixture<LottiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LottiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LottiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
