import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatCardModule } from '@angular/material/card';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormComponent } from './form/form.component';
import { InstructionsComponent } from './instructions/instructions.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from "@angular/material/form-field";
import { MatSelectModule} from '@angular/material/select';
import { MatRadioModule } from '@angular/material/radio';;
import { FormsModule } from '@angular/forms';
import { MatIconModule } from "@angular/material/icon";
import { MatDividerModule } from '@angular/material/divider';
import { HttpClientModule } from '@angular/common/http';
import { NavBArComponent } from './nav-bar/nav-bar.component';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import { EndMessageComponent } from './end-message/end-message.component';
@NgModule({
  declarations: [
    AppComponent,
    FormComponent,
    InstructionsComponent,
    NavBArComponent,
    EndMessageComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,MatCardModule,MatDatepickerModule,
    BrowserAnimationsModule,MatFormFieldModule,MatDividerModule,MatNativeDateModule,
    MatInputModule,MatSelectModule,MatRadioModule,FormsModule,MatIconModule,HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
