// PrestamoHipotecario.h
#ifndef PRESTAMOHIPOTECARIO_H
#define PRESTAMOHIPOTECARIO_H

#include "Prestamo.h"

class PrestamoHipotecario : public Prestamo {
private:
    double euribor;

public:
    PrestamoHipotecario(double monto, int plazo, Persona solicitante, double euribor)
        : Prestamo(monto, 6.0 + 1.26, plazo, solicitante), euribor(euribor) {}

    double calcularInteres() override {
        // Fórmula de interés compuesto para hipotecas
        return monto * (euribor + (tasaInteres / 100)) / 12;
    }

    void mostrarInfo() override {
        std::cout << "--- Préstamo Hipotecario ---" << std::endl;
        Prestamo::mostrarInfo();
        std::cout << "Euribor: " << euribor << "%\n";
        std::cout << "Interés a pagar: " << calcularInteres() << std::endl;
    }

    // Getters y Setters
    double getEuribor() const { return euribor; }
    void setEuribor(double euribor) { this->euribor = euribor; }
};

#endif // PRESTAMOHIPOTECARIO_H
