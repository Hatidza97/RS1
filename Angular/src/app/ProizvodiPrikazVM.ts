export class Proizvod{
 id?:number;
 proizvod?:string;
 cijena?:number;
 stanjeNaSkladistu?:number;
 kolicina?:number;
 opis?:string;
 slika?:any;
}

export class ProizvodiPrikazVM
{
  contentType?:any;
  serializerSettings?:any;
  statusCode?:any;
  value?:Proizvod[];
}
