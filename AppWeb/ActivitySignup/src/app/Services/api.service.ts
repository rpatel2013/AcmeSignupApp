import { Injectable } from "@angular/core";
import { HttpClient, HttpResponse, HttpHeaders } from "@angular/common/http";
import { map } from "rxjs/operators";
import { SignupComponent } from '../Components/Signup/Signup.component';

@Injectable()
export class ApiService {

    baseURL = "http://localhost:58973/api/";

    constructor(private http: HttpClient){}

    getActivities(){
        return this.http.get<ActivityResponse>(this.baseURL + "Activity");

    }

    RegisterNewUser(SignupForm){
        let headers = new HttpHeaders({
            'Content-Type': 'application/json',
            });
        let options = { headers: headers };

        return this.http.post(this.baseURL+"Activitysignups", JSON.stringify(SignupForm), options);
    }

}

interface Activity {
    id: number;
    name: string;
    details: string;
    registrationEndDT: Date;
}

interface ActivityResponse {
    Activities: Activity[]
}