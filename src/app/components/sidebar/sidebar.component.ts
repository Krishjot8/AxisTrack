import { Component } from '@angular/core';
import {ButtonModule} from 'primeng/button';

@Component({
    selector: 'app-sidebar',
    templateUrl: './sidebar.component.html',
    styleUrls: ['./sidebar.component.css'],
    standalone: true,
    imports:[

   ButtonModule


    ]
})
export class SidebarComponent {

showSidebar:boolean = true;
}
