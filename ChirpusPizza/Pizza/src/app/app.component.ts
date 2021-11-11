import { Component } from '@angular/core';
import { MenuItem } from './menu-item';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Menu';

  ItemsOfMenu:MenuItem[] = [
    {
      name:"Spagetti",
      price:8,
      category:"pasta"
    },
    {
      name:"Alfredo",
      price:13,
      category:"pasta"
    },
    {
      name:"Burger",
      price:10,
      category:"American"
    },
    {
      name:"Tacos",
      price:6,
      category:"mexican"
    },
    {
      name:"Soup",
      price:5,
      category:"hobo"
    },
    {
      name:"Truffles",
      price:69,
      category:"expensive"
    }
  ];

  GetMenu():MenuItem[]{
    return this.ItemsOfMenu;
  }
}
