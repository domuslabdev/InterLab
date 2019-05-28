import { Component, OnInit, EventEmitter } from '@angular/core';
import { NgbModal, NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { SgateRequest } from '../model/Lotti';

@Component({
  selector: 'app-sgatereqs',
  templateUrl: './sgatereqs.component.html',
  styleUrls: ['./sgatereqs.component.css']
})

export class SgatereqsComponent implements OnInit {
  reqs : Array<SgateRequest>;
  public reqs$:EventEmitter<Array<SgateRequest>>=new EventEmitter();
  
  constructor(private modalservice: NgbModal, private modalactive: NgbActiveModal) { }

  ngOnInit() { }

  decline(event) {
    this.modalactive.close(false)
  }

  accept(event) {
   this.reqs$.emit(this.reqs);
    this.modalactive.close(true);
  }

  dismiss() {
    this.modalactive.dismiss();
  }

}
