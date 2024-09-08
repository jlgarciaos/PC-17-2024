// Prestamo.h
#ifndef PRESTAMO_H
#define PRESTAMO_H

#include "Persona.h"
#include <iostream>

class Prestamo {
protected:
    double monto;
    double tasaInteres;
    int plazo; // en meses
    Persona solicitante;

public:
    Prestamo(double monto, double tasaInteres, int plazo, Persona solicitante)
        : monto(monto), tasaInteres(tasaInteres), plazo(plazo), solicitante(solicitante) {}

    virtual double calcularInteres() = 0; // Método virtual puro

    virtual void mostrarInfo() {
        solicitante.mostrarInfo();
        std::cout << "Monto: " << monto << "\nTasa de Interés: " << tasaInteres << "%\nPlazo: " << plazo << " meses" << std::endl;
    }

    virtual ~Prestamo() {}

    // Getters y Setters
    double getMonto() const { return monto; }
    void setMonto(double monto) { this->monto = monto; }

    double getTasaInteres() const { return tasaInteres; }
    void setTasaInteres(double tasaInteres) { this->tasaInteres = tasaInteres; }

    int getPlazo() const { return plazo; }
    void setPlazo(int plazo) { this->plazo = plazo; }

    Persona getSolicitante() const { return solicitante; }
    void setSolicitante(const Persona& solicitante) { this->solicitante = solicitante; }
};

#endif // PRESTAMO_H
