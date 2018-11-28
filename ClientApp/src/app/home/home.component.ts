import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit {
  model: ToDo;
  list: ToDo[];
  baseUrl: string;

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private router: Router
  ) {
    this.baseUrl = baseUrl;
  }

  ngOnInit(): void {
    this.getToDoItems();
  }

  getToDoItems() {
    return this.http
      .get<ToDo[]>(this.baseUrl + 'api/ToDo')
      .subscribe(res => (this.list = res));
  }

  goToCreatePage() {
    this.router.navigate(['/create']);
  }
}
