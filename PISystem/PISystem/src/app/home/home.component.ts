import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Country,Summary } from '../model/covidData';
import { DataService } from '../service/data.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  url = 'https://api.covid19api.com/summary';
  countries: Array<Country> | undefined;
  summary: Summary;
  germany: Country;
  india: Country;
  america: Country;
  canada: Country;
  uk: Country;
  australia: Country;

  constructor(private http: HttpClient,private service :DataService) {
    this.summary = new Summary();
    this.india = new Country();
    this.germany = new Country();
    this.america = new Country();
    this.canada = new Country();
    this.uk = new Country();
    this.australia = new Country();
  }

  ngOnInit(): void {
    this.getAllData();
    //this.getCounty();
  }

  getAllData() {
    this.service.getData().subscribe(
      response => {              
        this.india = response.Countries[76];
        this.germany = response.Countries[63];
        this.canada = response.Countries[30];
        this.uk = response.Countries[183];
        this.america = response.Countries[184];
        this.australia = response.Countries[8];
      });
  }
}
