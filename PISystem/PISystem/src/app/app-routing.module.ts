import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthGuard } from './auth.guard';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { MedicineComponent } from './medicine/medicine.component';
import { PatientComponent } from './patient/patient.component';
import { PiuserComponent } from './piuser/piuser.component';
import { UserEntryComponent } from './user-entry/user-entry.component';

const routes: Routes = [
  {path:'user-entry',component:UserEntryComponent,canActivate:[AuthGuard]},
  {path:'user',component:PiuserComponent,canActivate:[AuthGuard]},
  {path:'medicine',component:MedicineComponent,canActivate:[AuthGuard]},
  {path:'patient',component:PatientComponent,canActivate:[AuthGuard]},
  {path:'home',component:HomeComponent,canActivate : [AuthGuard]},
  {path:'',component:LoginComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
