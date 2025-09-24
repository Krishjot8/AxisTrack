import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { SidebarComponent } from "./components/sidebar/sidebar.component";

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css'],
    standalone: true,
    imports: [RouterOutlet, SidebarComponent],
    template:`

 <router-outlet></router-outlet>
    `
})
export class AppComponent {
  title = 'AxisTrack-UI';
}
