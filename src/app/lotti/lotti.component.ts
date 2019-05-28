import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { User, Lotti, SgateRequest } from '../model/Lotti';
import { userInfo } from 'os';

@Component({
  selector: "[app-lotti]",
  templateUrl: './lotti.component.html',
  styleUrls: ['./lotti.component.css']
})

export class LottiComponent implements OnInit {
  _lotto: SgateRequest;
  reqsgate: SgateRequest;
 // @Output() onlottoshow = new EventEmitter<User>();

  @Input() set req(item: SgateRequest) {
    this.reqsgate = item;
  }

  constructor() { }

  ngOnInit() { }

  get request() {
    return this.reqsgate;
  }

}
