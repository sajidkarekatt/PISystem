
export class Summary {
  Global: GlobalData;
  Countries: Array<Country> ;
  Date: Date;
  constructor() {
    this.Global = new GlobalData();
    this.Countries = new Array<Country>();
    this.Date = new Date();
  }
}

export class GlobalData {
  NewConfirmed: number;
  NewDeaths: number;
  NewRecovered: number;
  TotalConfirmed: number;
  TotalDeaths: number;
  TotalRecovered: number;
  constructor() {
    this.NewConfirmed = 0;
    this.NewDeaths = 0;
    this.NewRecovered = 0;
    this.TotalConfirmed = 0;
    this.TotalDeaths = 0;
    this.TotalRecovered = 0;
  }
}

export class Country extends GlobalData {
  Name: string;
  CountryCode: string;
  Date: Date;
  Slug: string;
  constructor() {
    super();
    this.Name = "";
    this.CountryCode = "";
    this.Date = new Date();
    this.Slug = "";
  }

}
