import { HttpClient } from "@angular/common/http";
import { environment } from "../env/environment";
import { LoginModel } from "../models/LoginModel";

const { Injectable } = require("@angular/core");

@Injectable({
	providedIn: "root"
})

export class LoginService{

	private readonly baseUrl = environment.apiUrl;

	constructor(private httpClient: HttpClient){}

	loginUsuario(login: LoginModel)
	{
		return this.httpClient.post<any>(this.baseUrl+"/login", login);
	}
	
}