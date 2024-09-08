// PrestamoPersonal.h
#ifndef PRESTAMOPERSONAL_H
#define PRESTAMOPERSONAL_H

#include "Prestamo.h"

class PrestamoPersonal : public Prestamo {
public:
    PrestamoPersonal(double monto, int plazo, Persona solicitante)
        : Prestamo(monto, 7.85, plazo, solicitante) {}

    double calcularInteres() override {
        // Fórmula de interés simple
        return (monto * tasaInteres * plazo) / 360;
    }

    void mostrarInfo() override {
        std::cout << "--- Préstamo Personal ---" << std::endl;
        Prestamo::mostrarInfo();
        std::cout << "Interés a pagar: " << calcularInteres() << std::endl;
    }

    // Getters y Setters
};

#endif // PRESTAMOPERSONAL_H
