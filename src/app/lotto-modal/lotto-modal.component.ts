import { Component, OnInit, ViewChild, Input, EventEmitter } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Content } from '@angular/compiler/src/render3/r3_ast';
import { SgateService } from '../service/sgate.service';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Lotto } from '../model/Lotti';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-lotto-modal',
  templateUrl: './lotto-modal.component.html',
  styleUrls: ['./lotto-modal.component.css']
})

export class LottoModalComponent {
  lottoname:string;

  constructor(private modalservice: NgbModal, private active: NgbActiveModal) {
  }

  public decline() {
    this.active.close(false);
  }

  public accept() {
    this.active.close(this.lottoname);
  }

  public dismiss() {
    this.active.dismiss();
  }

}
