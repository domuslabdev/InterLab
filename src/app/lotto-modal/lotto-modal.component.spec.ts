import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LottoModalComponent } from './lotto-modal.component';

describe('LottoModalComponent', () => {
  let component: LottoModalComponent;
  let fixture: ComponentFixture<LottoModalComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LottoModalComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LottoModalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
