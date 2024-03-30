using SeminarioLenguajeDotnet.Clases;
using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica4;

internal class Practica4Ejercicio10(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Completar la clase Cuenta para que el siguiente código produzca la salida indicada:\n\n" +
        "Código:\n"                                                                               +
        "Cuenta cuenta = new Cuenta();\n"                                                         +
        "cuenta.Imprimir();\n"                                                                    +
        "cuenta = new Cuenta(30222111);\n"                                                        +
        "cuenta.Imprimir();\n"                                                                    +
        "cuenta = new Cuenta(\"José Perez\");\n"                                                  +
        "cuenta.Imprimir();\n"                                                                    +
        "cuenta = new Cuenta(\"Maria Diaz\", 20287544);\n"                                        +
        "cuenta.Imprimir();\n"                                                                    +
        "cuenta.Depositar(200);\n"                                                                +
        "cuenta.Imprimir();\n"                                                                    +
        "cuenta.Extraer(150);\n"                                                                  +
        "cuenta.Imprimir();\n"                                                                    +
        "cuenta.Extraer(1500);\n\n"                                                               +
        "Salida:\n"                                                                               +
        "Nombre: No especificado, DNI: No especificado, Monto: 0\n"                               +
        "Nombre: No especificado, DNI: 30222111, Monto: 0\n"                                      +
        "Nombre: José Perez, DNI: No especificado, Monto: 0\n"                                    +
        "Nombre: Maria Diaz, DNI: 20287544, Monto: 0\n"                                           +
        "Nombre: Maria Diaz, DNI: 20287544, Monto: 200\n"                                         +
        "Nombre: Maria Diaz, DNI: 20287544, Monto: 50\n"                                          +
        "Operación cancelada, monto insuficiente";

    protected override void Execute()
    {
        Cuenta cuenta = new();
        cuenta.Imprimir();
        cuenta = new Cuenta(30222111);
        cuenta.Imprimir();
        cuenta = new Cuenta("José Perez");
        cuenta.Imprimir();
        cuenta = new Cuenta("Maria Diaz", 20287544);
        cuenta.Imprimir();
        cuenta.Depositar(200);
        cuenta.Imprimir();
        cuenta.Extraer(150);
        cuenta.Imprimir();
        cuenta.Extraer(1500);
    }
}