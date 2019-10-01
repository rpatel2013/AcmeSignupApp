import { Component, OnInit } from "@angular/core";
import {FormBuilder, FormGroup, Validators, FormArray, FormControl} from '@angular/forms';
import { ApiService } from "../../Services/api.service";

@Component({
    selector: 'acme-signup-form',
    templateUrl: './Signup.component.html',
    styleUrls: ['./Signup.component.scss']
})

export class SignupComponent implements OnInit {
    
  ActivityFormGroup: FormGroup;
  ActivityForm: FormGroup;
  Activities;
    constructor(private apiService: ApiService) {}
  
    ngOnInit() {      
      
      this.ActivityFormGroup = new FormGroup({

          activityId: new FormControl(null, Validators.required),

          FirstName: new FormControl(null, Validators.compose([
            Validators.required,
            Validators.pattern('[\\w\\-\\s\\/]+')
          ])),
          LastName: new FormControl(null, Validators.compose([
            Validators.required,
            Validators.pattern('[\\w\\-\\s\\/]+')
          ])),
          Email: new FormControl(null, Validators.compose([
            Validators.required,
            Validators.email
          ])),
          Phone: new FormControl(null, Validators.compose([
            Validators.required,
            Validators.pattern('^\\d{3}-\\d{3}-\\d{4}$')
          ])),
          Comment: new FormControl(null, Validators.maxLength(500)),
        });

      this.apiService.getActivities().subscribe(Response => {
        this.Activities = Response;
      })
    
    }

    onSubmit(SignupForm){
      console.log(SignupForm);
      this.apiService.RegisterNewUser(SignupForm).subscribe();
    }

  }