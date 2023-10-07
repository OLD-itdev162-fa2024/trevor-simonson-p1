import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit{
  title = 'client';
  nasaPotds: any;

  constructor(private http: HttpClient){

  }

  ngOnInit(): void {
    this.http.get('http://localhost:5175/nasapotd/getall').subscribe(
      response => {this.nasaPotds = response},
      error => { console.log(error) }
    )

  }
}

