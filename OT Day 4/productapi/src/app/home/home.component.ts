import { product } from './../product';
import { ProappapiService } from './../proappapi.service';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  
  products$: Observable<product[]>
  constructor(private myservice: ProappapiService) { 
    this.products$ = new Observable<product[]>();
  }
  ngOnInit(): void {
   this.products$ = this.myservice.getProducts(); 
  }
}
