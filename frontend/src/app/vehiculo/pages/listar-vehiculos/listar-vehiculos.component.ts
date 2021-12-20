import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Vehiculo } from '../../models/vehiculo.model';
import { VehiculoService } from '../../services/vehiculo.service';

@Component({
  templateUrl: './listar-vehiculos.component.html',
  styleUrls: ['./listar-vehiculos.component.scss']
})
export class ListarVehiculosComponent implements OnInit {

  public vehiculos$: Observable<Array<Vehiculo>> | undefined;

  constructor(private vehiculoSvc: VehiculoService) { }

  ngOnInit(): void {
    this.vehiculos$ = this.vehiculoSvc.getAll();
  }
}
