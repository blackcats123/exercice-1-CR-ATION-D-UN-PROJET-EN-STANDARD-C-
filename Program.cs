using System.Reflection;
using System.Security.Claims;

ifndef VEHICULE_H
#define VEHICULE_H

# include <string>

class Vehicule
{
    private:
    std::string marque;
    std::string modele;
    int vitesse;
    int annee;
    bool estDemarre;

    public:
    // Constructeur
    Vehicule(std::string marque = "", std::string modele = "", int annee = 2024);

    // Destructeur
    ~Vehicule();

    // Getters
    std::string getMarque() const;
    std::string getModele() const;
    int getVitesse() const;
    int getAnnee() const;
    bool getEstDemarre() const;

    // Setters
    void setMarque(const std::string& nouvelleMarque);
    void setModele(const std::string& nouveauModele);
    void setVitesse(int nouvelleVitesse);
    void setAnnee(int nouvelleAnnee);

    // Méthodes classiques
    void demarrer();
    void arreter();
    void accelerer(int increment);
    void ralentir(int decrement);
    void afficherInfos() const;
};

#endif

// Vehicule.cpp
#include "Vehicule.h"
#include <iostream>

Vehicule::Vehicule(std::string marque, std::string modele, int annee)
    : marque(marque), modele(modele), annee(annee), vitesse(0), estDemarre(false) {
    std::cout << "Construction d'un véhicule : " << marque << " " << modele << std::endl;
}

Vehicule::~Vehicule() {
    std::cout << "Destruction du véhicule : " << marque << " " << modele << std::endl;
}

// Implémentation des getters
std::string Vehicule::getMarque() const { return marque; }
std::string Vehicule::getModele() const { return modele; }
int Vehicule::getVitesse() const { return vitesse; }
int Vehicule::getAnnee() const { return annee; }
bool Vehicule::getEstDemarre() const { return estDemarre; }

// Implémentation des setters
void Vehicule::setMarque(const std::string& nouvelleMarque) { marque = nouvelleMarque; }
void Vehicule::setModele(const std::string& nouveauModele) { modele = nouveauModele; }
void Vehicule::setVitesse(int nouvelleVitesse) { vitesse = nouvelleVitesse; }
void Vehicule::setAnnee(int nouvelleAnnee) { annee = nouvelleAnnee; }

// Implémentation des méthodes classiques
void Vehicule::demarrer() {
    if (!estDemarre)
    {
        estDemarre = true;
        std::cout << "Le véhicule démarre" << std::endl;
    }
    else
    {
        std::cout << "Le véhicule est déjà démarré" << std::endl;
    }
}

void Vehicule::arreter() {
    if (estDemarre)
    {
        estDemarre = false;
        vitesse = 0;
        std::cout << "Le véhicule s'arrête" << std::endl;
    }
    else
    {
        std::cout << "Le véhicule est déjà arrêté" << std::endl;
    }
}

void Vehicule::accelerer(int increment) {
    if (estDemarre)
    {
        vitesse += increment;
        std::cout << "Vitesse actuelle : " << vitesse << " km/h" << std::endl;
    }
    else
    {
        std::cout << "Impossible d'accélérer, le véhicule est arrêté" << std::endl;
    }
}

void Vehicule::ralentir(int decrement) {
    if (estDemarre)
    {
        vitesse = std::max(0, vitesse - decrement);
        std::cout << "Vitesse actuelle : " << vitesse << " km/h" << std::endl;
    }
    else
    {
        std::cout << "Impossible de ralentir, le véhicule est arrêté" << std::endl;
    }
}

void Vehicule::afficherInfos() const {
    std::cout << "Véhicule : " << marque << " " << modele << " (" << annee << ")" << std::endl;
std::cout << "État : " << (estDemarre ? "démarré" : "arrêté") << std::endl;
std::cout << "Vitesse : " << vitesse << " km/h" << std::endl;
}

// Animal.h
#ifndef ANIMAL_H
#define ANIMAL_H

#include <string>

class Animal
{
    private:
    std::string nom;
    std::string espece;
    int age;
    bool aFaim;
    float poids;

    public:
    // Constructeur
    Animal(std::string nom = "", std::string espece = "", int age = 0, float poids = 0.0);

    // Destructeur
    ~Animal();

    // Getters
    std::string getNom() const;
    std::string getEspece() const;
    int getAge() const;
    bool getAFaim() const;
    float getPoids() const;

    // Setters
    void setNom(const std::string& nouveauNom);
    void setEspece(const std::string& nouvelleEspece);
    void setAge(int nouvelAge);
    void setPoids(float nouveauPoids);

    // Méthodes classiques
    void manger();
    void dormir();
    void jouer();
    void emettreSon();
    void afficherInfos() const;
};

#endif

// Animal.cpp
#include "Animal.h"
#include <iostream>

Animal::Animal(std::string nom, std::string espece, int age, float poids)
    : nom(nom), espece(espece), age(age), poids(poids), aFaim(true) {
    std::cout << "Création d'un animal : " << nom << " (" << espece << ")" << std::endl;
}

Animal::~Animal() {
    std::cout << "Destruction de l'animal : " << nom << std::endl;
}

// Implémentation des getters
std::string Animal::getNom() const { return nom; }
std::string Animal::getEspece() const { return espece; }
int Animal::getAge() const { return age; }
bool Animal::getAFaim() const { return aFaim; }
float Animal::getPoids() const { return poids; }

// Implémentation des setters
void Animal::setNom(const std::string& nouveauNom) { nom = nouveauNom; }
void Animal::setEspece(const std::string& nouvelleEspece) { espece = nouvelleEspece; }
void Animal::setAge(int nouvelAge) { age = nouvelAge; }
void Animal::setPoids(float nouveauPoids) { poids = nouveauPoids; }

// Implémentation des méthodes classiques
void Animal::manger() {
    if (aFaim)
    {
        std::cout << nom << " mange avec appétit" << std::endl;
        aFaim = false;
    }
    else
    {
        std::cout << nom << " n'a pas faim" << std::endl;
    }
}

void Animal::dormir() {
    std::cout << nom << " s'endort..." << std::endl;
    aFaim = true;
}

void Animal::jouer() {
    std::cout << nom << " joue joyeusement" << std::endl;
}

void Animal::emettreSon() {
    std::cout << nom << " fait un son caractéristique de son espèce" << std::endl;
}

void Animal::afficherInfos() const {
    std::cout << "Animal : " << nom << " (" << espece << ")" << std::endl;
std::cout << "Âge : " << age << " ans" << std::endl;
std::cout << "Poids : " << poids << " kg" << std::endl;
std::cout << "État : " << (aFaim ? "a faim" : "n'a pas faim") << std::endl;
}

// Personnage.h
#ifndef PERSONNAGE_H
#define PERSONNAGE_H

#include <string>

class Personnage
{
    private:
    std::string nom;
    std::string classe;
    int niveau;
    int pointsDeVie;
    int force;

    public:
    // Constructeur
    Personnage(std::string nom = "", std::string classe = "", int niveau = 1);

    // Destructeur
    ~Personnage();

    // Getters
    std::string getNom() const;
    std::string getClasse() const;
    int getNiveau() const;
    int getPointsDeVie() const;
    int getForce() const;

    // Setters
    void setNom(const std::string& nouveauNom);
    void setClasse(const std::string& nouvelleClasse);
    void setNiveau(int nouveauNiveau);
    void setPointsDeVie(int nouveauxPoints);
    void setForce(int nouvelleForce);

    // Méthodes classiques
    void attaquer();
    void prendreDegats(int degats);
    void gagnerNiveau();
    void seReposer();
    void afficherInfos() const;
};

#endif

// Personnage.cpp
#include "Personnage.h"
#include <iostream>

Personnage::Personnage(std::string nom, std::string classe, int niveau)
    : nom(nom), classe(classe), niveau(niveau), pointsDeVie(100), force(10) {
    std::cout << "Création du personnage : " << nom << " le " << classe << std::endl;
}

Personnage::~Personnage() {
    std::cout << "Destruction du personnage : " << nom << std::endl;
}

// Implémentation des getters
std::string Personnage::getNom() const { return nom; }
std::string Personnage::getClasse() const { return classe; }
int Personnage::getNiveau() const { return niveau; }
int Personnage::getPointsDeVie() const { return pointsDeVie; }
int Personnage::getForce() const { return force; }

// Implémentation des setters
void Personnage::setNom(const std::string& nouveauNom) { nom = nouveauNom; }
void Personnage::setClasse(const std::string& nouvelleClasse) { classe = nouvelleClasse; }
void Personnage::setNiveau(int nouveauNiveau) { niveau = nouveauNiveau; }
void Personnage::setPointsDeVie(int nouveauxPoints) { pointsDeVie = nouveauxPoints; }
void Personnage::setForce(int nouvelleForce) { force = nouvelleForce; }

// Implémentation des méthodes classiques
void Personnage::attaquer() {
    std::cout << nom << " lance une attaque avec " << force << " points de dégâts!" << std::endl;
}

void Personnage::prendreDegats(int degats) {
    pointsDeVie = std::max(0, pointsDeVie - degats);
    std::cout << nom << " perd " << degats << " points de vie! PV restants : " << pointsDeVie << std::endl;
}

void Personnage::gagnerNiveau() {
    niveau++;
    force += 5;
    pointsDeVie += 20;
    std::cout << nom << " passe au niveau " << niveau << "!" << std::endl;
}

void Personnage::seReposer() {
    pointsDeVie = std::min(100, pointsDeVie + 30);
    std::cout << nom << " se repose et récupère des PV. PV actuels : " << pointsDeVie << std::endl;
}

void Personnage::afficherInfos() const {
    std::cout << "Personnage : " << nom << " le " << classe << std::endl;
std::cout << "Niveau : " << niveau << std::endl;
std::cout << "Points de vie : " << pointsDeVie << std::endl;
std::cout << "Force : " << force << std::endl;
}

// main.cpp
#include "Vehicule.h"
#include "Animal.h"
#include "Personnage.h"
#include <iostream>

int main()
{
    // Création des instances
    Vehicule maVoiture("Renault", "Clio", 2023);
    Animal monChat("Felix", "Chat", 3, 4.5);
    Personnage monHeros("Arthur", "Guerrier", 1);

    std::cout << "\n=== Test du Véhicule ===" << std::endl;
    maVoiture.afficherInfos();
    maVoiture.demarrer();
    maVoiture.accelerer(50);
    maVoiture.ralentir(20);
    maVoiture.arreter();

    std::cout << "\n=== Test de l'Animal ===" << std::endl;
    monChat.afficherInfos();
    monChat.manger();
    monChat.jouer();
    monChat.dormir();

    std::cout << "\n=== Test du Personnage ===" << std::endl;
    monHeros.afficherInfos();
    monHeros.attaquer();
    monHeros.prendreDegats(25);
    monHeros.seReposer();
    monHeros.gagnerNiveau();
    monHeros.afficherInfos();

    return 0;
}










