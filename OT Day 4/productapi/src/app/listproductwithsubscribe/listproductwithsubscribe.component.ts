import { product } from './../product';
import { ChangeDetectionStrategy, ChangeDetectorRef, Component, Input, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-listproductwithsubscribe',
  templateUrl: './listproductwithsubscribe.component.html',
  styleUrls: ['./listproductwithsubscribe.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ListProductWithSubscribeComponent implements OnInit {
  @Input() myproducts$:Observable<product[]>;
  myproducts: product[];
  constructor(private cd:ChangeDetectorRef) {
      this.myproducts = [];    
   }

  ngOnInit(): void {
    this.myproducts$.subscribe(
      data=> {
        this.myproducts = data
        this.cd.markForCheck();
        }
    );
  }

}