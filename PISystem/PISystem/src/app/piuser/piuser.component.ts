import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';


@Component({
  selector: 'app-piuser',
  templateUrl: './piuser.component.html',
  styleUrls: ['./piuser.component.css']
})
export class PiuserComponent implements OnInit {
  public piusers?: User[];
  private url: string = "https://localhost:7137/api/User";

  constructor(private http: HttpClient,private router:Router) { }

  ngOnInit(): void {
    this.getUsers();
  }

  getUsers() {
    this.http.get<User[]>(this.url).subscribe(result => {
      this.piusers = result;
    },
      error => console.error(error));
  }
  
  deleteUser(user:User) {  
    this.http.delete(this.url + '/' + user.id).subscribe(
      response => {
        console.log(response);
        this.getUsers();
    },
      error => {
        console.log(error);
      });
  }

  showUserEntry() {
    this.router.navigate(['user-entry']);
  }

}

interface User {
  pw: string
  name: string,
  id: string,
  age: number,
  gender: string,
  address: string,
  phone: string
}

