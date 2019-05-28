import { Injectable, OnInit, EventEmitter, Output, SimpleChanges } from '@angular/core';
import { Lotti, User, Registro, Lotto, SgateRequest, CapReq, Anagrafica } from '../model/Lotti';
import { HttpClient, HttpHeaders, HttpRequest } from '@angular/common/http';
import { Observable, BehaviorSubject, Subject, of } from 'rxjs';
import { observeOn } from 'rxjs/operators';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { LottoModalComponent } from '../lotto-modal/lotto-modal.component';
import { SgatereqsComponent } from '../sgatereqs/sgatereqs.component';
import { resolve } from 'dns';
import { reject } from 'q';
import { promise } from 'protractor';

const URLlotti = "http://localhost:8360/home/";
const URLapi = "http://localhost:8360/api/cap/Postdata";
const APIREG = "http://localhost:8360/home/getReg";

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})

export class SgateService {
  users: Array<User>;
  bilottiDisplay = new EventEmitter<string>();
  sgatereqs: Array<SgateRequest>;
  messageSource = new Subject<Array<User>>();
  caricalottiresponse: EventEmitter<string> = new EventEmitter<string>();
  modaltestopen = new EventEmitter<string>();
  //currentmessage=this.messageSource.asObservable();
  emilotti = new EventEmitter<any>();
  emitInsCapLotti = new EventEmitter<string>();
  emitReg = new EventEmitter<string>();
  modalpromise: Promise<any>;
  text = "OK";
  lot: Lotto;
  resultmodalpromise: string;
  reqs: Array<SgateRequest>;
  ana$ = new EventEmitter<string>();
  //  lottoname$=new Subject<string>();
  lottoname$ = new Subject();

  ngOnChanges(changes: SimpleChanges): void {
  }

  list: any;
  headers: any;

  constructor(private httpclient: HttpClient, private modalservice: NgbModal) {
  }

  setBilotti(text: string) {
    this.bilottiDisplay.emit(text);
  }

  getLotti(text: string): Observable<Array<Lotti>> {
    return this.httpclient.post<Array<Lotti>>(URLlotti + "/getLotti", { "text": text }, httpOptions);
  }

  getAnagrafica(text: string): Promise<Array<Anagrafica>> {
    return this.httpclient.post<Array<Anagrafica>>(URLlotti + "/getAnagrafica", { "text": text }, httpOptions).toPromise();
  }

  getSgateReqs(lotid: number): Promise<Array<SgateRequest>> {
    return this.httpclient.post<Array<SgateRequest>>(URLlotti + "/getSgateReqs", { "lotid": lotid }).toPromise();
  }

  // getSgateReqs(lotid: number) {
  //   return this.httpclient.post<Array<SgateRequest>>(URLlotti + "/getSgateReqs", { "lotid": lotid }, httpOptions);
  // }


  insertLotto(lot: string): Observable<string> {
    //  var lotto=JSON.stringify(lot);
    return this.httpclient.post<string>(URLlotti + "/InsertSgate", { "lottoname": lot }, httpOptions);
  }

  getUser(): Observable<Array<User>> {
    return this.httpclient.post<Array<User>>(APIREG, this.text);
  }

  getCapReg(): Observable<Array<Registro>> {
    return this.httpclient.post<Array<Registro>>(APIREG, this.text);
  }

  validateCaps(reqs: Array<CapReq>): Observable<string> {
    return this.httpclient.post<string>(URLlotti + "/ValidateReqs", { "reqs": reqs }, httpOptions);
  }

  setModal(lotid) {
    this.messageSource.next(lotid);
  }

  modaltestemitter() {
    this.modaltestopen.emit("ciao");
  }

  openSgateReqsModal(salva, dismiss, testo, data: Array<SgateRequest>): void {
    var res = this.modalservice.open(SgatereqsComponent);
    res.componentInstance.btnOkText = salva;
    res.componentInstance.btnKOText = dismiss;
    res.componentInstance.testo = testo;
    res.componentInstance.reqs = data;

    res.componentInstance.reqs$.subscribe((x) => { this.reqs = x });
    res.result.then((x) => { this.resultmodalpromise = x });

    //    return this.reqspromise();
    //     return res.result;
  }

  reqspromise(): Promise<Array<SgateRequest>> {
    return (new Promise((resolve, reject) => {
      if (this.resultmodalpromise)
        resolve(this.reqs)
      else
        reject("errore di comunicazione");
    }));
  }
  
  callAnaCOmponent() {
    // return (new Subject((observer)=>{
    //     observer.next("ciao");
    // }));

    return this.ana$.next("ciao");
  }

  //apertuta modale
  confirm(
    title: string,
    message: string,
    btnOkText: string = 'Vai Biondinoino',
    btnCancelText: string = 'Annulla') {

    const modalRef = this.modalservice.open(LottoModalComponent);
    modalRef.componentInstance.title = title;
    modalRef.componentInstance.message = message;
    modalRef.componentInstance.btnOkText = btnOkText;
    modalRef.componentInstance.btnCancelText = btnCancelText;

    modalRef.result
      .then((x) => {
        if (x != null && x != false)
          this.getLottoName(x);
        else if (!x)
          var t = 100;
        //location.href = "http://www.google.com";
      })
      .catch((x) => {
        //location.href = "http://www.google.com";
      });
  }

  get lottonameget() {
    return this.lottoname$;
  }

  getLottoName(lottoname: string): void {
    this.lottoname$.next(lottoname);
  }

}