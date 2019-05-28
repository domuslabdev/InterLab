import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { SgateService } from '../service/sgate.service';
import { User, Lotti, SgateRequest } from '../model/Lotti';
import { NgbModal,ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-richieste',
  templateUrl: './richieste.component.html',
  styleUrls: ['./richieste.component.css']
})

export class RichiesteComponent implements OnInit {
  closeResult: string;
  @ViewChild("content") el:ElementRef;
  text="ecco";
  num:string;
  user:string="ciao chicco";
  biuser:Array<SgateRequest>;

  constructor(private modalService: NgbModal,private service:SgateService) {}

  open(content) {
    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'}).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }

  ngOnInit(){
     this.service.messageSource.subscribe((t)=>{this.getModal(t)});
//    this.service.number$.subscribe((x)=>{console.log(x)});
 // this.service.users$.subscribe(x=>this.getModal(x));
  }

  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return `with: ${reason}`;
    }
  }

  getModal(lotid) {
   // this.service.getSgateReqs(lotid).subscribe((x)=>{this.biuser=x})
    this.modalService.open(this.el,{ windowClass: 'my-class'});
  }

}