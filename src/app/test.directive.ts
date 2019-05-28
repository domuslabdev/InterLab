import { Directive, HostListener } from '@angular/core';

@Directive({
  selector: '[appTest]'
})
export class TestDirective {
  @HostListener('click', ['$event'])
 
  keyevent(btn) {
    if(btn.target.id=="btngoogleid")
      console.log("catturato evento");
    else if(btn=="btnlocalid")
      console.log("localid");        
    // return window.confirm('Are you sure you want to do this?');
 //  return this.service.modaltestemitter();
  }
  constructor() { }

  
}
