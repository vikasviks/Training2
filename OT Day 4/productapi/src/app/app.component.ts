import { Component } from '@angular/core';
import { Subscription } from 'rxjs';
import { ProappapiService } from './proappapi.service';
import { product } from './product';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Productapi';
  product$:product[]=[];
  Productsubscription:Subscription;
  constructor(private Service:ProappapiService){

  }
  ngOnInit(){
    this.Productsubscription=this.Service.getProducts().subscribe(
      data=>this.product$=data,
      error=>console.log(error),
      ()=>console.log('completed')
    );
  }
}
