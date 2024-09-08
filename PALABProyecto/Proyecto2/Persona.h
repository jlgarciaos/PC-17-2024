// Persona.h
#ifndef PERSONA_H
#define PERSONA_H

#include <string>
using namespace std;

class Persona {
private:
    string nombre;
    string id;

public:
    Persona(string nombre, string id) : nombre(nombre), id(id) {}

    // Getters y Setters
    string getNombre() const { return nombre; }
    void setNombre(const string& nombre) { this->nombre = nombre; }

    string getId() const { return id; }
    void setId(const string& id) { this->id = id; }

    // Mostrar información de la persona
    void mostrarInfo() const {
        cout << "Nombre: " << nombre << "\nID: " << id << endl;
    }
};

#endif // PERSONA_H
