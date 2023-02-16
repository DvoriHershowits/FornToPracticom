import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import Child from 'src/Models/Child';

@Injectable({
  providedIn: 'root'
})
export class ChildService {

  constructor(public http: HttpClient) { }
  baseRouteChild = environment.baseRoute + "Child"
  addChild(child: Child): Observable<Child> {
    return this.http.post<Child>(`${this.baseRouteChild}`, child)
  }
}
