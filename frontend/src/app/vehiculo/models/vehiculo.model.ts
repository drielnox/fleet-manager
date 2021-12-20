export class Vehiculo
{
    identificador: number | undefined;
    marca!: string;
    modelo!: string;
    ruedas!: number;
    numeroChasis: number | undefined;
    kilometrosRecorridos: number;
    kilometroProximoMantenimiento: number | undefined;

    constructor() {
        this.kilometrosRecorridos = 0;
    }
}