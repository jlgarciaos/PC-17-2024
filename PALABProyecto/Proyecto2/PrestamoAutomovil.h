// PrestamoAutomovil.h
#ifndef PRESTAMOAUTOMOVIL_H
#define PRESTAMOAUTOMOVIL_H

#include "Prestamo.h"
#include <cmath>

class PrestamoAutomovil : public Prestamo {
public:
    PrestamoAutomovil(double monto, int plazo, Persona solicitante)
        : Prestamo(monto, 9.75, plazo, solicitante) {}

    double calcularInteres() override {
        // Fórmula de interés para automóviles
        double iMensual = tasaInteres / 100 / 12;
        return (monto * iMensual) / (1 - std::pow(1 + iMensual, -plazo));
    }

    void mostrarInfo() override {
        std::cout << "--- Préstamo de Automóvil ---" << std::endl;
        Prestamo::mostrarInfo();
        std::cout << "Cuota mensual a pagar: " << calcularInteres() << std::endl;
    }

    // Getters y Setters
};

#endif // PRESTAMOAUTOMOVIL_H
