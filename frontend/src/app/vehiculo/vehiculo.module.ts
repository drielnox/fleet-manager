import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { VehiculoRoutingModule } from './vehiculo-routing.module';
import { ListarVehiculosComponent } from './pages/listar-vehiculos/listar-vehiculos.component';
import { AgregarModificarVehiculoComponent } from './pages/agregar-modificar-vehiculo/agregar-modificar-vehiculo.component';
import { BorrarVehiculoComponent } from './pages/borrar-vehiculo/borrar-vehiculo.component';


@NgModule({
  declarations: [
    ListarVehiculosComponent,
    AgregarModificarVehiculoComponent,
    BorrarVehiculoComponent
  ],
  imports: [
    CommonModule,
    VehiculoRoutingModule
  ]
})
export class VehiculoModule { }
