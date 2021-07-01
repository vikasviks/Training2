import { product } from './product';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { environment } from 'src/environments/environment';
import { tap, catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ProappapiService {

  constructor(private http:HttpClient) { }
  private myerrorhandler(err: any){
    console.log(err);
    return throwError(err);
  }
  getProducts(): Observable<product[]>{
    const apiurl = environment.apibaseurl + 'Products';
    const headers = {'content-type':'application/json'};
    return this.http.get<product[]>(apiurl,{'headers':headers}).pipe(
      //tap(data=>console.log(data)),
      catchError(
        //error => {return throwError(error);}
        error => this.myerrorhandler(error)
      )
    );
  }
  postProduct(product: product): Observable<product> {
    Object.defineProperty(product, 'id',{'enumerable':false}); // so that id won't go to api
    const apiurl = environment.apibaseurl + 'Products';
    const headers = {'accept':'application/json','content-type':'application/json'};
    return this.http.post<product>(apiurl, product, {'headers':headers}).pipe(
      catchError( error => this.myerrorhandler(error) )
    );
  }
  putProduct(product: product): Observable<product> {
    const apiurl = environment.apibaseurl + 'Products/'+ product.Id;
    const headers = {'accept':'application/json','content-type':'application/json'};
    return this.http.put<product>(apiurl, product,{'headers':headers}).pipe(
      catchError( error => this.myerrorhandler(error) )
    );
  }
  deleteProduct(product: product): Observable<product>{
    const apiurl = environment.apibaseurl + 'Products/'+ product.Id;
    const headers = {'accept':'application/json','content-type':'application/json'};
    return this.http.delete<product>(apiurl,{'headers':headers}).pipe(
      catchError( error => this.myerrorhandler(error) )
    ); 
  }
}