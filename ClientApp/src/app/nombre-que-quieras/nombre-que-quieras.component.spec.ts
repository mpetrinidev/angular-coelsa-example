import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NombreQueQuierasComponent } from './nombre-que-quieras.component';

describe('NombreQueQuierasComponent', () => {
  let component: NombreQueQuierasComponent;
  let fixture: ComponentFixture<NombreQueQuierasComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NombreQueQuierasComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NombreQueQuierasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
