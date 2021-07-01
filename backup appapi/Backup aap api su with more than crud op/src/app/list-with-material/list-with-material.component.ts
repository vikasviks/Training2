import { AppService } from './../app.service';
import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { Product } from '../product';
import { Observable, Subscription } from 'rxjs';
import { Input } from '@angular/core';

@Component({
  selector: 'app-list-with-material',
  templateUrl: './list-with-material.component.html',
  styleUrls: ['./list-with-material.component.css']
})
export class ListWithMaterialComponent implements OnInit {
  @Input() myProduct$:Observable<Product[]>;
  products: Product[]=[];
  productssubscription: Subscription;
  showTable: boolean = true;
  
  constructor(private cd:ChangeDetectorRef){
    this.productssubscription= new Subscription()
    this.myProduct$= new Observable();
  }

 ngOnInit(){
    this.productssubscription=this.myProduct$.subscribe(
      data=>{
        this.products=data;
        this.cd.markForCheck();
        console.log(this.products);      }
    ),
    error=>{
      console.log(error);
    },
    ()=>console.log('In Material')

  }
  ngOnChanges(): void {
    this.productssubscription= this.myProduct$.subscribe(
      data=>{this.products= data,
      this.cd.markForCheck();
    },
      error=>{
        console.log(error);
      },

      ()=>console.log('In material')
      
    )
    
  }

   displayedColumns: string[] = ['id', 'title', 'price', 'quantity','color', 'expiryDate', 'inStock'];
   
   
   
}
