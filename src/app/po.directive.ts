import { Directive, HostListener, ViewChild } from '@angular/core';
import { SgateService } from './service/sgate.service';
import { Lotto } from './model/Lotti';
import { LottoModalComponent } from './lotto-modal/lotto-modal.component';
import { Observable } from 'rxjs';

@Directive({
  selector: '[confirm]'
})

export class PoDirective {
  lottoname$:Observable<string>;
  x = "che cavolo dici";
  lotto: Lotto = {
    Desc: "lotto1cacd",
    DataCarico: new Date("22/02/2019"),
    Dim: 333,
    Esito: "KO**/**",
    Status: 55,
    LotId: 987
  }

  @HostListener('click', ['$event'])

  keyevent(btn) {
    if (btn.currentTarget.id == "caricalotti")
      this.openModal();
    else if (btn == "btnlocalid")
      console.log("localid");
    // return window.confirm('Are you sure you want to do this?');
    //  return this.service.modaltestemitter();
  }

  constructor(private service: SgateService) { }

  public openModal() {
    this.service.confirm("Finestra di caricamento lotto", "Salvo buon fine", "Beccate sto Lotto ", "lascia stà")
  }

}