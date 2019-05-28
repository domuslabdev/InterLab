import { TestBed } from '@angular/core/testing';

import { SgateService } from './sgate.service';

describe('SgateService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SgateService = TestBed.get(SgateService);
    expect(service).toBeTruthy();
  });
});
