import { HomeComponent } from "./home.component"
import { TestBed } from "@angular/core/testing"
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { FormsModule, ReactiveFormsModule } from "@angular/forms"
import { MatInputModule } from "@angular/material/input";
import { MatFormFieldModule } from "@angular/material/form-field";
import { MatButtonModule } from "@angular/material/button";
import { MatSidenavModule } from "@angular/material/sidenav";
import { MatCardModule } from "@angular/material/card";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { By } from "protractor";

describe('HomeComponent', () => {

  beforeEach(() => TestBed.configureTestingModule({
    imports: [HttpClientTestingModule,
      FormsModule,
      ReactiveFormsModule,
      MatFormFieldModule,
      MatInputModule,
      MatButtonModule,
      MatSidenavModule,
      MatCardModule,
      BrowserAnimationsModule,
    ],
    declarations: [HomeComponent]
  }));

  it('all elements should be properly defined', () => {
    const fixture = TestBed.createComponent(HomeComponent);

    expect(document.getElementsByClassName('result-line')).toBeTruthy();
    expect(document.getElementsByName('minsAbove6')).toBeTruthy();
    expect(document.getElementsByName('milesBelow6')).toBeTruthy();
    expect(document.getElementsByName('date')).toBeTruthy();
    expect(document.getElementsByName('starttime')).toBeTruthy();
    expect(document.getElementById('submitButton')).toBeTruthy();
    expect(document.getElementById('clearButton')).toBeTruthy();
  });

});
