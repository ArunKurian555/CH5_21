import { TestBed } from '@angular/core/testing';

import { ChRouteService } from './ch-route.service';

describe('ChRouteService', () => {
  let service: ChRouteService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ChRouteService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
