import { Component, OnInit, Input } from '@angular/core';
import { User } from '../model/Lotti';
import {NgForm} from '@angular/forms';
import { map, filter, catchError, mergeMap } from 'rxjs/operators';
import { range } from 'rxjs';

@Component({
  selector: 'app-lotto',
  templateUrl: './lotto.component.html',
  styleUrls: ['./lotto.component.css']
})

export class LottoComponent implements OnInit {
  _user:User=null;
  @Input() set userlotto(request:User){
    this._user=request;
  };

  get superpippo(){
    return this._user;
  }
 
 constructor() { }

  ngOnInit() { }

  testRXJS(lotto){
    range(1,10).pipe(filter(x=>x%2==1),
    map(x=>x*x)).subscribe(x=>console.log(x));
  }

}
