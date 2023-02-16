import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BehaviorSubject } from 'rxjs';
import Child from 'src/Models/Child';
import Parent from 'src/Models/Parent';
import { ChildService } from '../Services/child.service';
import { ParentService } from '../Services/parent.service';
import * as XLSX from 'xlsx';
@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.scss']
})
export class FormComponent implements OnInit {

  constructor(childService: ChildService, p: ParentService, public action: Router) {
    this.childService = childService
    this.parentService = p
  }
  currentUser = new BehaviorSubject<{ name: string }>(null);

  childService: ChildService
  parentService: ParentService
  parent: Parent = new Parent(0, "", "", "", null, "", "", []);
  labelPosition: 'male' | 'female' = 'male';
  children: Child[] = []
  numChildren = 0;
  succes: boolean = true
  title = 'angular-app';
  fileName= 'ExcelSheet.xlsx';
  ngOnInit(): void {
    //שליפת נתונים קודמים אם ישנם
    let p: Parent
    p = this.parentService.getFromStorageUser()
    if (p != null) {
      this.parent = p
      this.children = p.children
    }
  }
  ngOnDestroy(): void {
    // שמירת הנתונים  
    this.parent.children = this.children
    this.parentService.saveInStorage(this.parent)
      //עדכון שם משתמש עבור קומפוננטה הוראות
      this.parentService.currentUser.next(this.parent.firstName + " " + this.parent.lastName);
  }

  addChildToParent() {
    this.children[this.numChildren] = new Child(0, "", "", null, 0)
    this.numChildren++
  }
  resetData() {
    this.parent.children = []
    this.parent.firstName = ""
    this.parent.lastName = ""
    this.parent.dateOfBirth = null
    this.parent.hmo = ""
    this.parent.idNumberParent = ""
    this.parent.maleOrFemale = ""
    this.children = []
    this.parentService.removeFromStorageUser()
    this.numChildren = 0;
    this.succes = true
  }


  submit() {
  
    //שליחת ההורה
    this.parent.children = this.children
    try {
      this.parentService.addParent(this.parent).subscribe(n => {
        this.parent.id = n.id
        console.log(this.parent.id);

      });
    } catch (error) {
      alert("שגיאה בשליחת הנתונים")
      this.succes = false
    }

    //שליחת הילדים
    this.children.forEach((child, index) => {
      this.children[index].idParent = 7
      try {
        this.childService.addChild(this.children[index]).subscribe(n => {
        });
      } catch (error) {
        alert("שגיאה בשליחת הנתונים")
        this.succes = false
      }
    })
    if (this.succes === true)
    {
     this.action.navigate(["end"])
    }
    this.resetData()
     
  }
  exportexcel(): void
  {
    let element = document.getElementById('excel-table');
    const ws: XLSX.WorkSheet =XLSX.utils.table_to_sheet(element);
 
    const wb: XLSX.WorkBook = XLSX.utils.book_new();
    XLSX.utils.book_append_sheet(wb, ws, 'Sheet1');
 
    XLSX.writeFile(wb, this.fileName);
 
  }

}

