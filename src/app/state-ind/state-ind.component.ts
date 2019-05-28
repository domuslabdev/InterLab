import { Component, OnInit } from '@angular/core';
import { NgbModal, ModalDismissReasons, NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-state-ind',
  templateUrl: './state-ind.component.html',
  styleUrls: ['./state-ind.component.css']
})
export class StateIndComponent  {
  closeResult: string;

  constructor(private modalService: NgbModal,private modalactive:NgbActiveModal) {}

//  public  open(content) {
//     this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'}).result.then((result) => {
//       this.closeResult = `Closed with: ${result}`;
//     }, (reason) => {
//       this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
//     });
//   }

//   private getDismissReason(reason: any): string {
//     if (reason === ModalDismissReasons.ESC) {
//       return 'by pressing ESC';
//     } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
//       return 'by clicking on a backdrop';
//     } else {
//       return  `with: ${reason}`;
//     }
//   }

  public decline(){
    this.modalactive.close(false);
  }

  public dismiss(){
    this.modalactive.dismiss(false);
  }

  public accept(){
    this.modalactive.close(true);
  }

}