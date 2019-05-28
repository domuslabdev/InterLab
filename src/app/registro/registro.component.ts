import { Component, OnInit } from '@angular/core';
import { Registro } from '../model/Lotti';
import { SgateService } from '../service/sgate.service';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.css']
})

export class RegistroComponent implements OnInit {
  registro:Array<Registro>;

  constructor(private service:SgateService) { 
    this.service.getCapReg().subscribe((x)=>{this.registro=x}); 
  }

  ngOnInit() {
//    this.service.getCapReg().subscribe((x)=>{this.registro=x}); 
  }

}