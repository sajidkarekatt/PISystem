export class SignInData {
  private _email: string;
  private _password: string;

  constructor(email:string,password:string) {
    this._email = email;
    this._password = password;
  }

  public getEmail(): string {
    return this._email;
  }

  public getPassword(): string {
    return this._password;
  }
}

export class UserData {
  constructor(public PW: string,
    public Name: string,
    public ID: string,
    public Age: number,
    public Gender: string,
    public Address: string,
    public Phone: string,
    public Email: string){}
}
