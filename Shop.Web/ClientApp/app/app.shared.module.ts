import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule, XHRBackend } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { routing } from './app.routing';
import { ConfigService } from './shared/utils/config.service';
import { AuthenticateXHRBackend } from './authenticate-xhr.backend';
import { BrowserModule } from '@angular/platform-browser';
import { AccountModule } from './account/account.module';
import { DashboardModule } from './dashboard/dashboard.module';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent              
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        BrowserModule,
        AccountModule,
        DashboardModule, 
        routing,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },            
            { path: '**', redirectTo: 'home' }
        ])
    ],
    providers: [ConfigService, {
        provide: XHRBackend,
        useClass: AuthenticateXHRBackend
    }],
    bootstrap: [AppComponent]
})
export class AppModuleShared {
}
