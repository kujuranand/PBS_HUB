import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditPractitionerComponent } from './edit-practitioner.component';

describe('EditPractitionerComponent', () => {
  let component: EditPractitionerComponent;
  let fixture: ComponentFixture<EditPractitionerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditPractitionerComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditPractitionerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
