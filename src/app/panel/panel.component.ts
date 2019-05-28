import { Component, OnInit, Output, EventEmitter ,HostListener} from '@angular/core';
import { SgateService } from '../service/sgate.service';
import { Lotti } from '../model/Lotti';

@Component({
  selector: 'app-panel',
  templateUrl: './panel.component.html',
  styleUrls: ['./panel.component.css']
})

export class PanelComponent implements OnInit {

lotvisible=false;
regvisible=false;
lotti:Lotti[];

// @HostListener('document:keyup',['$event'])
// Keyevent(ev:KeyboardEvent){
//   var t=100;
// }

  constructor(private service:SgateService) {
   }

  ngOnInit() {
  }

  getLotti(event){
    this.lotvisible=true;
    this.regvisible=false;
    var name=event.target.innerHTML;
    this.service.setBilotti("bilottisi");
  }

  getRegister(){
    this.service.emitReg.emit(name);
  }

}
