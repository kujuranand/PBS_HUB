import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  loginForm!:FormGroup;
  // title = 'Validation.Form';
  submitted = false;

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.loginForm = this.formBuilder.group({
      firstName:['', [Validators.required, Validators.minLength(3), Validators.maxLength(10)]],
      lastName:['', [Validators.required, Validators.minLength(3), Validators.maxLength(10)]],
      email:['', [Validators.required, Validators.email]],
      password:['', [Validators.required, Validators.minLength(8), Validators.maxLength(16)]],
      check_TnC:['', [Validators.required]],
    })
  }

  

  onSubmit() {
    this.submitted = true
    if (this.loginForm.invalid) {
      return
    }
    
    alert("Success")
  }
}
