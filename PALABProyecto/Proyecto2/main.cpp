#include <iostream>
#include "Banco.h"
#include "PrestamoPersonal.h"
#include "PrestamoHipotecario.h"
#include "PrestamoAutomovil.h"
#include <cstdlib>

using namespace std;

void limpiarPantalla() {
    #ifdef _WIN32
        system("cls");
    #else
        system("clear");
    #endif
}

void mostrarMenu() {
    cout << "---- Sistema de Gestion de Prestamos ----\n";
    cout << "1. Agregar nuevo prestamo personal\n";
    cout << "2. Agregar nuevo prestamo hipotecario\n";
    cout << "3. Agregar nuevo prestamo de automovil\n";
    cout << "4. Mostrar todos los prestamos\n";
    cout << "5. Salir\n";
    cout << "----------------------------------------\n";
    cout << "Seleccione una opcion: ";
}

int main() {
    Banco banco;
    int opcion;

    do {
        mostrarMenu();
        cin >> opcion;
        limpiarPantalla();

        switch (opcion) {
            case 1: {
                string nombre, id;
                double monto;
                int plazo;

                cout << "Ingrese el nombre del solicitante: ";
                cin >> nombre;
                cout << "Ingrese el ID del solicitante: ";
                cin >> id;
                cout << "Ingrese el monto del prestamo: ";
                cin >> monto;
                cout << "Ingrese el plazo en meses: ";
                cin >> plazo;

                Persona solicitante(nombre, id);
                Prestamo* prestamoPersonal = new PrestamoPersonal(monto, plazo, solicitante);
                banco.agregarPrestamo(prestamoPersonal);
                cout << "Prestamo personal agregado correctamente.\n";
                break;
            }
            case 2: {
                string nombre, id;
                double monto, euribor;
                int plazo;

                cout << "Ingrese el nombre del solicitante: ";
                cin >> nombre;
                cout << "Ingrese el ID del solicitante: ";
                cin >> id;
                cout << "Ingrese el monto del prestamo: ";
                cin >> monto;
                cout << "Ingrese el plazo en meses: ";
                cin >> plazo;
                cout << "Ingrese el Euribor actual: ";
                cin >> euribor;

                Persona solicitante(nombre, id);
                Prestamo* prestamoHipotecario = new PrestamoHipotecario(monto, plazo, solicitante, euribor);
                banco.agregarPrestamo(prestamoHipotecario);
                cout << "Prestamo hipotecario agregado correctamente.\n";
                break;
            }
            case 3: {
                string nombre, id;
                double monto;
                int plazo;

                cout << "Ingrese el nombre del solicitante: ";
                cin >> nombre;
                cout << "Ingrese el ID del solicitante: ";
                cin >> id;
                cout << "Ingrese el monto del prestamo: ";
                cin >> monto;
                cout << "Ingrese el plazo en meses: ";
                cin >> plazo;

                Persona solicitante(nombre, id);
                Prestamo* prestamoAutomovil = new PrestamoAutomovil(monto, plazo, solicitante);
                banco.agregarPrestamo(prestamoAutomovil);
                cout << "Prestamo de automovil agregado correctamente.\n";
                break;
            }
            case 4:
                banco.mostrarPrestamos();
                break;
            case 5:
                cout << "Saliendo del sistema...\n";
                break;
            default:
                cout << "Opcin no valida. Intente nuevamente.\n";
        }

        cout << "\nPresione Enter para continuar...";
        cin.ignore();
        cin.get();
        limpiarPantalla();

    } while (opcion != 5);

    return 0;
}
