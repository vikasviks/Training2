import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AppService } from '../app.service';
import { IProduct } from '../IProduct';

@Component({
  selector: 'app-delete-product',
  templateUrl: './delete-product.component.html',
  styleUrls: ['./delete-product.component.css']
})
export class DeleteProductComponent implements OnInit {

  products$: Observable<IProduct[]>;
  selectidControl: FormControl = new FormControl(0);
  showProductDetails: boolean = false;
  deleteform: FormGroup;

  constructor(private fb: FormBuilder, private myservice: AppService, private router: Router) {
    this.products$ = new Observable<IProduct[]>();

    this.deleteform = this.fb.group({
      title: ['', Validators.required],
      price: [, [Validators.required, Validators.min(0)]],
      quantity: [, [Validators.required, Validators.min(0)]],
      color: ['', Validators.required],
      expirydate: ['', Validators.required],
      instock: [true, Validators.required]
    });
  }

  ngOnInit(): void {
    this.products$ = this.myservice.getProducts();
  }

  showDetails() {
    if (this.selectidControl.value != '0') {
      this.showProductDetails = true;
      this.myservice.getProduct(this.selectidControl.value).subscribe(
        data => {
          this.deleteform.get('title').setValue(data.title);
          this.deleteform.get('price').setValue(data.price);
          this.deleteform.get('quantity').setValue(data.quantity);
          this.deleteform.get('color').setValue(data.color);
          this.deleteform.get('expirydate').setValue(data.expiryDate);
          this.deleteform.get('instock').setValue(data.inStock);
        }
      );
    }
    else {
      this.showProductDetails = false;
    }
  }

  delete() {
    this.myservice.deleteProduct((this.selectidControl.value)).subscribe();
    this.router.navigate(['/home']);
  }
}