import { product } from './../product';
import { ChangeDetectionStrategy, Component, Input, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-listproductwithasync',
  templateUrl: './listproductwithasync.component.html',
  styleUrls: ['./listproductwithasync.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ListProductWithAsyncComponent implements OnInit {
  @Input() myproducts$: Observable<product[]>;
  constructor() { }

  ngOnInit(): void {
  }
}
