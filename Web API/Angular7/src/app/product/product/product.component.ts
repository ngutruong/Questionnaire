import { Component, OnInit } from '@angular/core';
import { ProductService } from 'src/app/shared/product.service';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  constructor(private service : ProductService, private toastr : ToastrService) {
  }

  ngOnInit() {
  	this.resetForm();
  }

  resetForm(form? : NgForm){
  	if(form!=null){
		form.resetForm();
  	}
	this.service.formData = {
		ID : null,
		ProductName : '',
		Quantity : 0
	}
  }

  onSubmit(form : NgForm){
  	if(form.value.ID == null)
  		this.insertRecord(form);
  	else
  		this.updateRecord(form);
  }

  insertRecord(form : NgForm){
  	this.service.postProduct(form.value).subscribe(res => {
  		this.toastr.success('Product added successfully', 'Product Added');
  		this.resetForm(form);
  		this.service.refreshList();
  	});
  }

  updateRecord(form : NgForm){
  	this.service.putProduct(form.value).subscribe(res => {
  		this.toastr.warning('Product updated successfully', 'Product Updated');
  		this.resetForm(form);
  		this.service.refreshList();
  	});
  }
}
