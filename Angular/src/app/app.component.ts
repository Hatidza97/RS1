import {Component, OnInit} from '@angular/core';
import {MyConfig} from './MyConfig';
import {HttpClient} from "@angular/common/http";
import {ProizvodiPrikazVM} from "./ProizvodiPrikazVM";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'Angular';
  trazi:string="";
  ProizvodPrikaz:ProizvodiPrikazVM= {};

  constructor(private http:HttpClient) {
  }
  ngOnInit()
  {
    this.http.get<ProizvodiPrikazVM>('https://localhost:44307/Proizvod/IndexAngular')
      .subscribe((result)=>{this.ProizvodPrikaz.value=result.value;
      console.log(this.ProizvodPrikaz)});
  }
  onSearch(event:any):void{
    this.trazi=event.target.value;
  }
  getProizvodi(){
    if(this.trazi=="")
    {
      return this.ProizvodPrikaz.value;
    }
    else {
      return this.ProizvodPrikaz.value?.filter(x=>x.proizvod?.toLowerCase().startsWith(this.trazi.toLowerCase()));
    }
  }
}
