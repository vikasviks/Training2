import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListWithMaterialComponent } from './list-with-material.component';

describe('ListWithMaterialComponent', () => {
  let component: ListWithMaterialComponent;
  let fixture: ComponentFixture<ListWithMaterialComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListWithMaterialComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ListWithMaterialComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
