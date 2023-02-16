import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import Parent from 'src/Models/Parent';

@Injectable({
  providedIn: 'root'
})
export class ParentService {

  constructor(public http: HttpClient) { }
  baseRouteParent = environment.baseRoute + "Parent"
  currentUser = new BehaviorSubject<string>(null);

   addParent(parent: Parent):Observable<Parent>{
    return this.http.post<Parent>(`${this.baseRouteParent}`, parent)
  }
  
  //treat the storage
  saveInStorage(user) {
    localStorage.setItem("currentUser", JSON.stringify(user));
  }
  getFromStorageUser() {
    let u = localStorage.getItem("currentUser");
    if (!u)
      return null;
    return JSON.parse(u);
  }
  removeFromStorageUser() {
    localStorage.removeItem("currentUser");
  }
}
