import { TestBed } from '@angular/core/testing';

import { ProappapiService } from './proappapi.service';

describe('ProappapiService', () => {
  let service: ProappapiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ProappapiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
