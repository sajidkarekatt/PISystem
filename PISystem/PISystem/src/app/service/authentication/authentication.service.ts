import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { SignInData } from '../../model/signInData';


@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {
  isAuthenticated = false;
  private baseURL: string = 'https://localhost:7137/api/User/';
  private users: User[];
  private isLoaded = false;

  constructor(private router: Router, private http: HttpClient) {
    this.users = [];
  }

  authenticateCredentials(signInData: SignInData): boolean {
      this.authenticate(signInData);    
      return this.isAuthenticated;
  }

  async authenticate(signInData: SignInData): Promise<boolean> {   
    await this.checkCredentials(signInData).then(() => this.isLoaded = true);
    if (this.isLoaded) {
      if (this.users.length > 0) {
        this.isAuthenticated = true;
        this.router.navigate(['home']);
        return true;
      }
      this.isAuthenticated = false;
      return false;
    }
    this.isAuthenticated =false;
    return false;
  }

  checkCredentials(signIndata: SignInData) {
    let promise = new Promise<void>((resolve, reject) => {
      let url = this.baseURL + signIndata.getEmail() + '/' + signIndata.getPassword();
      this.http.get<User[]>(url)
        .toPromise()
        .then(
          result => {
            this.users = result!;
            resolve();
          },
          message => {
            reject();
          }
        )
    });
    return promise;
  }

  logOut() {
    this.isAuthenticated = false;
    this.router.navigate(['']);
  }
}

interface User {
  pw:string,
  name: string,
  id: string,
  age: number,
  gender: string,
  address: string,
  phone: string,
  email:string
}
