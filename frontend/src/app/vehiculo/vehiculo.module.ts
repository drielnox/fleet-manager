import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { VehiculoRoutingModule } from './vehiculo-routing.module';
import { VehiculoComponent } from './pages/vehiculo.component';


@NgModule({
  declarations: [
    VehiculoComponent
  ],
  imports: [
    CommonModule,
    VehiculoRoutingModule
  ]
})
export class VehiculoModule { }
