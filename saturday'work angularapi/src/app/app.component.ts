import { AppService } from './app.service';
import { Product } from './Product';
import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'appapi';
  product:Product[]=[];
  Productsubscription:Subscription;
  constructor(private appService:AppService){

  }
  ngOnInit(){
    this.Productsubscription=this.appService.getProduct().subscribe(
      data=>this.product=data,
      error=>console.log(error),
      ()=>console.log('completed')
    );
  }
}
