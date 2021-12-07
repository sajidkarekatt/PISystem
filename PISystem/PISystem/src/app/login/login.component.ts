import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { SignInData } from '../model/signInData';
import { AuthenticationService } from '../service/authentication/authentication.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {
  isInvalid = false;
  isCredsInvalid = false;

  constructor(private authenthicationService: AuthenticationService, private router:Router) { }

  ngOnInit(): void {
  }


  onSubmit(signInForm: NgForm) {
    if (!signInForm.valid) {
      this.isInvalid = true;
      this.isCredsInvalid = false;
      return;
    }
    this.checkCreds(signInForm);
  }

  private checkCreds(signInForm: NgForm) {
    const signIndata = new SignInData(signInForm.value.emailid, signInForm.value.password);    
    
    if (!this.authenthicationService.authenticateCredentials(signIndata)) {
      this.isInvalid = false;
      this.isCredsInvalid = true;     
    }
  }
}
