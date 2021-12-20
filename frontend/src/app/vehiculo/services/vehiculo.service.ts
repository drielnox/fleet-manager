import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Vehiculo } from '../models/vehiculo.model';

const _URL: string = 'http://localhost:53000/api/vehiculos';

@Injectable({
  providedIn: 'root'
})
export class VehiculoService {
  constructor(private _http: HttpClient) { }

  public getAll(): Observable<Array<Vehiculo>> {
    return this._http
      .get<Array<Vehiculo>>(_URL);
  }

  public getById(id: number): Observable<Vehiculo> {
    return this._http
      .get<Vehiculo>(`${_URL}/${id}`);
  }

  public create(vehiculo: Vehiculo): Observable<void> {
    return this._http
      .put<void>(
        _URL,
        vehiculo
      );
  }

  public update(vehiculo: Vehiculo): Observable<Vehiculo> {
    return this._http
      .post<Vehiculo>(
        `${_URL}/${vehiculo.identificador}`,
        vehiculo
      );
  }

  public delete(vehiculo: Vehiculo): Observable<void> {
    return this._http
      .delete<void>(
        `${_URL}/${vehiculo.identificador}`
      );
  }
}
