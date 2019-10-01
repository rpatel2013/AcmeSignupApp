import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { HttpClientModule } from "@angular/common/http";
import { MatSliderModule, MatStepperModule, MatFormFieldModule, MatInputModule, MatSelectModule } from '@angular/material';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from "./Components/Home/Home.component";
import { SignupComponent } from "./Components/Signup/Signup.component";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ApiService } from "./Services/api.service";


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    SignupComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    FormsModule, ReactiveFormsModule,
    HttpClientModule,
    MatSliderModule, MatStepperModule, MatFormFieldModule, MatInputModule, MatSelectModule
  ],
  providers: [
    ApiService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
