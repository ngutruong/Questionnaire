import { Component, OnInit } from '@angular/core';
import { ProductService } from 'src/app/shared/product.service';
import { Product } from 'src/app/shared/product.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {

  constructor(private service : ProductService, private toastr : ToastrService) { }

  ngOnInit() {
  	this.service.refreshList();
  }

  populateForm(prod : Product){
  	this.service.formData = Object.assign({}, prod);
  }

  onDelete(id : number){
  	if(confirm('Are you sure you want to delete this record?')){
  		this.service.deleteProduct(id).subscribe(res =>{
  			this.service.refreshList();
  			this.toastr.info('Product deleted successfully', 'Product Deleted');
  		});
  	}
  }

}
