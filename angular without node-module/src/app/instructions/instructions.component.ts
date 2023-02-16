import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { FormComponent } from '../form/form.component';
import { ParentService } from '../Services/parent.service';
@Component({
  selector: 'app-instructions',
  templateUrl: './instructions.component.html',
  styleUrls: ['./instructions.component.scss']
})
export class InstructionsComponent implements OnInit {
  userName = null;
  sub: Subscription;
  form: FormComponent
  parentService:ParentService
  constructor(pwrentSer:ParentService) { this.parentService=pwrentSer}

  ngOnDestroy(): void {
    this.sub.unsubscribe();

  }
  ngOnInit(): void {  
    this.sub = this.parentService.currentUser.subscribe(succ => {
      this.userName = succ;
    })

  }


}
