import { TestBed } from '@angular/core/testing';

import { TimeDelayService } from './time-delay.service';

describe('TimeDelayService', () => {
  let service: TimeDelayService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TimeDelayService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
