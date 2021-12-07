import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PiuserComponent } from './piuser.component';

describe('PiuserComponent', () => {
  let component: PiuserComponent;
  let fixture: ComponentFixture<PiuserComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PiuserComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PiuserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
