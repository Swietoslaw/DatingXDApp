import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/_models/user';
import { AdminService } from 'src/app/_services/admin.service';

@Component({
  selector: 'app-user-managmest',
  templateUrl: './user-managmest.component.html',
  styleUrls: ['./user-managmest.component.css']
})
export class UserManagmestComponent implements OnInit {
  users: Partial<User[]>;

  constructor(private adminService: AdminService) { }

  ngOnInit(): void {
    this.getUsersWithRoles()
  }

  getUsersWithRoles() {
    this.adminService.getUsersWithRoles().subscribe( users =>{
      this.users = users;
    })
  }

}
