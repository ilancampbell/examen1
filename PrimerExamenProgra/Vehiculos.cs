using PrimerExamenProgra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PrimerExamenProgra
{
    internal class Vehiculos
    
    {
        string[] codigos = { "873", "798", "385", "168", "670" };
        string[] marcas = { "Jeep", "Honda", "Porsche", "Nissan", "Toyota" };
        int[] precio = { 5000, 1500, 9000, 2000, 2500 };
        string[] modelos = { "Cherokee", "Civic", "911 GT", "GTR", "Hilux" };
    }
}

interface Agregar
{
    void AgregarVehiculo();
}
interface Modificar
{
    void ModificarVehiculo();
}
interface ConsultarVehiculo
{
    void ConsultarVehiculo();
}