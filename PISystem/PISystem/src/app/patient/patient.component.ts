import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-patient',
  templateUrl: './patient.component.html',
  styleUrls: ['./patient.component.css']
})
export class PatientComponent implements OnInit {


  public patients?: Patient[];

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getPatients();
  }

  getPatients() {
    this.http.get<Patient[]>('https://localhost:7137/api/Patient').subscribe(result => {
      this.patients = result;
    },
      error => console.error(error));
  }
}

interface Patient {
  pw: string
  name: string,
  id: string,
  age: number,
  gender: string,
  address: string,
  phone: string
  status: string
}
