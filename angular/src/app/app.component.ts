import { HttpClient, HttpHeaders } from '@angular/common/http';
import { analyzeAndValidateNgModules, componentFactoryName } from '@angular/compiler';
import { Component, NgModule } from '@angular/core';
import { App } from './models/app';
import { AlertifyService } from './services/alertify.service';
import { FormGroup, FormControl, Validators, FormBuilder, NgForm } from '@angular/forms';
import { Value } from './models/value';
import { User } from './models/user';
import { Vade } from './models/vade';
import { MatSliderChange } from '@angular/material/slider';




@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})



export class AppComponent {

  title: 'angular';
  currentVal: "";
  taksitId: '';
  odemePlani: '';
  taksitTutari: '';
  deneme: '';
  kredi: any;
  myModel:0;
  bir:0;
  iki:0;
  



  getVal(val: any) {
    console.warn(val);
    this.currentVal = val;

  }
  onInputChange(event: MatSliderChange) {
    console.log("This is emitted as the thumb slides");
    console.log(event.value);
  }

  /* burayı tamamla row artısı
  array: any[
    for(int i =1; i <= taksitId ; i++){
    array.push(i);
    }
  ]
 */


  //onSubmit(data: any){
  //  console.warn(data);
  //}




  constructor(private httpClient: HttpClient) { }

  values: Value[]=[];
  user:User;
  vadeler:Vade[]=[];





  //get
  // get(){
  //this.httpClient.get<any>('https://localhost:44300/weatherforecast').subscribe(data =>

  // { console.log(data);

  // });

  // }

  //ngOnInit(){

  // AddUser(data: any) {

  //   const headers = new HttpHeaders()

  //     .append('Content-type', 'application/json')
  //     .append('Access-Control-Allow-Headers', 'Content-Type')
  //     .append('Access-Control-Allow-Headers', 'GET')
  //     .append('Access-Control-Allow-Origin', '*');


  //   this.httpClient.post<User>('https://localhost:44300/weatherforecast/useradd', data
  //     , { headers })
  //     .subscribe(data => {
  //       this.user = data;
  //       console.log(data);
  //     })


  // }

  onSubmit(data: any) {

    const headers = new HttpHeaders()

      .append('Content-type', 'application/json')
      .append('Access-Control-Allow-Headers', 'Content-Type')
      .append('Access-Control-Allow-Headers', 'GET')
      .append('Access-Control-Allow-Origin', '*');


    if (data.adi!=null) {
      this.httpClient.post<User>('https://localhost:44300/weatherforecast/useradd', data
      , { headers })
      .subscribe(data => {
        this.user = data;
        console.log(data);
      })
    }
    else{
      this.httpClient.post<Vade[]>('https://localhost:44300/weatherforecast/odemeplani?KrediTutari='+data.KrediTutari+'&KrediVadesi='+data.KrediVadesi
      , { headers })
      .subscribe(data => {
        this.vadeler = data;
        console.log(data);
      })
    }
    


  }

  // GetAllVade(){
  //   this.httpClient.get<Vade[]>('https://localhost:44300/weatherforecast/getallvade').subscribe(data=>{
  //     this.vadeler=data;
  //     console.log(data);
      
  //   })
  // }

  //}

  /*
  get(){
     return this.httpClient.get<Value[]>("https://localhost:44300/weatherforecast").subscribe(data=>{
     this.values=data;
    })
  
  }
  */


}






function post() {
  throw new Error('Function not implemented.');
}
//function private(private: any, httpClient: any, HttpClient: typeof HttpClient, private: any, formBuilder: any, FormBuilder: typeof FormBuilder) {
 // throw new Error('Function not implemented.');
//}
  //private alertifyService :AlertifyService;

  //kredihesapla:FormGroup;

  //createKrediForm(){
   // this.kredihesapla= this.formBuilder.group(
    //  {kredi_taksiti:["",Validators.required],
     //  kredi_vadesi:["",Validators.required]})

   // };

  //values:Value[]=[];

  //ngOnInit(){
   // this.gonder();


    // this.httpClient.post<any>('https://localhost:44300/weatherforecast', { title: 'Angular POST Request Example' }).subscribe(data => {

    //   console.log(data);
  //});


 // }

  //path:"https://localhost:44300/weatherforecast"
  //title = 'staj2';

  //gonder(){ 
  //let headers = new HttpHeaders();
  //headers=headers.append("Content-type","application/json")


  // console.log(this.httpClient.get(this.path) 

 // }








