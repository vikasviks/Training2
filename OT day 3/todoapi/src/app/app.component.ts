import { Component } from '@angular/core';
import { Subscription } from 'rxjs';
import { AppService } from './app.service';
import { items } from './items';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'todoapi';
  product:items[]=[];
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
