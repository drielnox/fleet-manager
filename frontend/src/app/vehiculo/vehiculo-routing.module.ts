import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AgregarModificarVehiculoComponent } from './pages/agregar-modificar-vehiculo/agregar-modificar-vehiculo.component';
import { BorrarVehiculoComponent } from './pages/borrar-vehiculo/borrar-vehiculo.component';
import { ListarVehiculosComponent } from './pages/listar-vehiculos/listar-vehiculos.component';

const routes: Routes = [
  { path: '', component: ListarVehiculosComponent },
  { path: 'agregar', component: AgregarModificarVehiculoComponent },
  { path: 'modificar/:id', component: AgregarModificarVehiculoComponent },
  { path: 'borrar/:id', component: BorrarVehiculoComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class VehiculoRoutingModule { }
