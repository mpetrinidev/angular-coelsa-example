import { Component, OnInit, Inject } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-new-item',
  templateUrl: './new-item.component.html',
  styleUrls: ['./new-item.component.css']
})
export class NewItemComponent implements OnInit {
  model: ToDo = {
    id: 0,
    description: ''
  };
  baseUrl: string;

  constructor(
    private router: Router,
    @Inject('BASE_URL') baseUrl: string,
    private http: HttpClient
  ) {
    this.baseUrl = baseUrl;
  }

  ngOnInit() {}

  addToDo() {
    this.http
      .post(this.baseUrl + 'api/ToDo', this.model)
      .subscribe(res => this.goToMainPage());
  }

  goToMainPage() {
    this.router.navigate(['/']);
  }
}
