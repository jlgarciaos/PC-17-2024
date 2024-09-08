// Banco.h
#ifndef BANCO_H
#define BANCO_H

#include "Prestamo.h"
#include <vector>

class Banco {
private:
    std::vector<Prestamo*> prestamos;

public:
    ~Banco() {
        // Eliminar todos los préstamos y liberar memoria
        for (Prestamo* prestamo : prestamos) {
            delete prestamo;
        }
    }

    void agregarPrestamo(Prestamo* prestamo) {
        prestamos.push_back(prestamo);
    }

    void mostrarPrestamos() {
        for (Prestamo* prestamo : prestamos) {
            prestamo->mostrarInfo();
            std::cout << std::endl;
        }
    }

    // Getters y Setters
    std::vector<Prestamo*> getPrestamos() const { return prestamos; }
    void setPrestamos(const std::vector<Prestamo*>& prestamos) { this->prestamos = prestamos; }
};

#endif // BANCO_H
