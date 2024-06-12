import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { LoginModel } from '../../models/LoginModel';
import { LoginService } from '../../service/LoginService';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss'
})
export class LoginComponent {

  loginForm!: FormGroup;

  constructor(
    private formBuilder:FormBuilder,
    private router: Router,
    private loginService: LoginService) {}
  
  ngOnInit(): void {
    this.loginForm = this.formBuilder.group({
      login: ["", [Validators.required]],
      senha: ["", [Validators.required]]
    });
  }

  submitLogin()
  {
	var dadosLogin = this.loginForm.getRawValue() as LoginModel;

	this.loginService.loginUsuario(dadosLogin)
	.subscribe(
		token => {
			console.log(token);
		},
		erro => console.log(erro)
	);
  }

}
