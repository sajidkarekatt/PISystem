import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { UserData } from '../model/signInData';
import { Router } from '@angular/router';

@Component({
  selector: 'app-user-entry',
  templateUrl: './user-entry.component.html',
  styleUrls: ['./user-entry.component.css']
})
export class UserEntryComponent implements OnInit {  

  constructor(private http: HttpClient, private router: Router) {
  }

  ngOnInit(): void {
  }

  onSubmit(eForm: NgForm) {
    var user = new UserData(eForm.value.pw,
                            eForm.value.name,
                            eForm.value.id,
                            eForm.value.age,
                            eForm.value.gender,
                            eForm.value.address,
                            eForm.value.phone,
      eForm.value.eaddress);
    //console.log(user);
    let url = 'https://localhost:7137/api/User';
    this.http.put(url, user).subscribe(result => {
      console.log(result);
      this.router.navigate(['user']);
    },
      error => console.error(error));
  }
}

