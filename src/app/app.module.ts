import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {SidebarComponent } from './components/sidebar/sidebar.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { SidebarModule } from 'primeng/sidebar';
import { ButtonModule } from 'primeng/button';
@NgModule({
  declarations: [AppComponent, DashboardComponent, SidebarComponent],
  imports: [BrowserModule, AppRoutingModule, SidebarModule, ButtonModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
