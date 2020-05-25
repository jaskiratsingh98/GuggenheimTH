import { Component} from '@angular/core';
//import { FormControl, FormGroup, FormBuilder } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { getBaseUrl } from '../../main';
//import { basename } from 'path';
//import { getBaseUrl } from '../../main';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  title = 'Test';
  result: string;

  onClickSubmit(data) {
    const formData = new FormData();
    formData.append('minsAbove6', data.minsAbove6);
    formData.append('milesBelow6', data.milesBelow6);
    formData.append('date', data.date);
    formData.append('starttime', data.starttime);
    this.http.post<any>('trip', formData).subscribe((data) => {
      this.result = data;
    });
    console.log(data);
  }

  constructor(private http: HttpClient) {
  }
}
