import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { HttpClient} from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Product } from './Product';
import {tap, catchError} from 'rxjs/operators';
 
@Injectable({
  providedIn: 'root'
})
export class AppService {
 
  constructor(private http: HttpClient) {
 
   }
 
   getProduct() : Observable<Product[]>{
     const apiurl = environment.apibaseurl + '/products';
     const headers = {'content-type': 'application/json'};
 
     return this.http.get<Product[]>(apiurl,{'headers': headers}).pipe(
       tap(data=>{console.log(data)}),
       catchError(error =>{
         return throwError(error);
       })
     );
   }
}