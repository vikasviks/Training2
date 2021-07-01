import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { throwError } from 'rxjs/internal/observable/throwError';
import { environment } from 'src/environments/environment';
import {tap, catchError} from 'rxjs/operators';
import { items } from "./items";
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AppService {

  constructor(private http: HttpClient) {
 
  }

  getProduct() : Observable<items[]>{
    const apiurl = environment.apibaseurl + '';
    const headers = {'content-type': 'application/json'};

    return this.http.get<items[]>(apiurl,{'headers': headers}).pipe(
      tap(data=>{console.log(data)}),
      catchError(error =>{
        return throwError(error);
      })
    );
  }
}
