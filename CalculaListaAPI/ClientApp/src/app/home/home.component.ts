import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  numeros: numero;
  listaNumeros: Array<number> = [];
  numeroModel: number;
  erro = false;
  sucess = false;

  constructor(
    private http: HttpClient, 
    @Inject('BASE_URL') private baseUrl: string
    ){ 

  }

  onClickAdicionar(numero: number){
    if (numero) {
      if(this.numeros)
        this.numeros = undefined;
      this.listaNumeros.push(numero);
      this.numeroModel = undefined;
    } 
    document.getElementById("numeroModel").focus();
  }

  onClickCalcular(){
    if(this.listaNumeros.length > 0){
      this.http.post<numero>(this.baseUrl + 'api/CalculaLista/', this.listaNumeros).subscribe(result => {
      this.numeros = result;
      this.listaNumeros = [];
      }, error => {
        this.erro = true;
        setTimeout(() => {  this.erro = false; }, 5000);
      });
    }
  }

}

interface numero{
  somaTotalLista: number;
  somaParesLista: number;
  mediaLista: number;
  maiorNumeroLista: number;
  menorNumeroLista: number;
}
