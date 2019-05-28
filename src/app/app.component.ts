import { SgateService } from './service/sgate.service';
import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { NgbModal,ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import { SgatelottiComponent } from './sgatelotti/sgatelotti.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit {
  bilotti="bilottisi";
  visible:boolean=true;
  
  @ViewChild(SgatelottiComponent) bilottichild;

  constructor(private service:SgateService){
   this.service.bilottiDisplay.subscribe((t)=>{this.bilotti=t});
  }
  
  ngOnInit(){
   this.service.bilottiDisplay.subscribe((t)=>{this.visible=true});
   this.service.emitReg.subscribe((t)=>{
     this.visible=false;
    });
     this.bilottichild.getLotti();
   }
   
}
