import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-medicine',
  templateUrl: './medicine.component.html',
  styleUrls: ['./medicine.component.css']
})
export class MedicineComponent implements OnInit {

  public medicines?: Medicine[];
  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getMedicine();
  }

  getMedicine() {
    this.http.get<Medicine[]>('https://localhost:7137/api/Medicine').subscribe(result => {
      this.medicines = result;
    },
      error => console.error(error));
  }
}

interface Medicine {
  id: string,
  name: string,
  dosage: string,
  type: string,
  uses: string,
  seffects: string,
  comment: string
}
