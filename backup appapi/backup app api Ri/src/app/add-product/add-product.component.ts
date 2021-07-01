import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AppService } from '../app.service';
import { IProduct } from '../IProduct';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent implements OnInit {
  addform: FormGroup;
  constructor(private pvt: FormBuilder, private myservice:AppService, private router: Router) {
    this.addform = this.pvt.group({
      title: ['', Validators.required],
      price: [ [Validators.required,Validators.min(0)]],
      quantity: [ [Validators.required,Validators.min(0)]],
      color: ['', Validators.required],
      expirydate: ['', Validators.required],
      instock: [true, Validators.required]
    });
  }

  ngOnInit(): void {
    
  }

  submit() {
    let product:IProduct = {...this.addform.value};
    product.id = 0;
    this.myservice.postProduct(product).subscribe();
    this.router.navigate(['/home']);
  }
}
