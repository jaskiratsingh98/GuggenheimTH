import { HomeComponent } from "./home.component"
import { TestBed } from "@angular/core/testing"
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { FormsModule, ReactiveFormsModule } from "@angular/forms"

describe('HomeComponent', () => {

  beforeEach(() => TestBed.configureTestingModule({
    imports: [HttpClientTestingModule,
      FormsModule,
      ReactiveFormsModule
    ],
    declarations: [HomeComponent]
  }));

  it('component title should be "test"', () => {
    const fixture = TestBed.createComponent(HomeComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.title).toEqual('Test');
  });

});
