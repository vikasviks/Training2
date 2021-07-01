import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListProductWithSubscribeComponent } from './listproductwithsubscribe.component';

describe('ListproductwithsubscribeComponent', () => {
  let component: ListProductWithSubscribeComponent;
  let fixture: ComponentFixture<ListProductWithSubscribeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListProductWithSubscribeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ListProductWithSubscribeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
