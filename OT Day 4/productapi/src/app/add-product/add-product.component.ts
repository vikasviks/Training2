import { product } from './../product';
import { ProappapiService } from './../proappapi.service';
import { stringify } from '@angular/compiler/src/util';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent implements OnInit {
  addform: FormGroup;
  constructor(private fb: FormBuilder, private myservice:ProappapiService) {
    this.addform = this.fb.group({
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
    let product:product = {...this.addform.value};
    product.Id = ''; // dummy id to add
    this.myservice.postProduct(product).subscribe();
  }
}
