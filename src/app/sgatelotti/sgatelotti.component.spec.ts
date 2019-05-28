import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SgatelottiComponent } from './sgatelotti.component';

describe('SgatelottiComponent', () => {
  let component: SgatelottiComponent;
  let fixture: ComponentFixture<SgatelottiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SgatelottiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SgatelottiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
