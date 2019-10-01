import { Component } from "@angular/core";
import { SignupComponent } from "../Signup/Signup.component";

@Component({
    selector: 'acme-app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.scss'],
})

export class HomeComponent{
    date = new Date();
}