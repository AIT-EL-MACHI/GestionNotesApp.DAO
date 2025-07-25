-- =============================================
-- Script de création de la base de données GestionNotesDB
-- =============================================

-- 1. Supprimer la base si elle existe (optionnel)
IF DB_ID('GestionNotesDB') IS NOT NULL
BEGIN
    DROP DATABASE GestionNotesDB;
END
GO

-- 2. Créer la base
CREATE DATABASE GestionNotesDB;
GO

-- 3. Utiliser la base
USE GestionNotesDB;
GO

-- 4. Créer la table Etudiant
CREATE TABLE Etudiant (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nom NVARCHAR(50) NOT NULL,
    Prenom NVARCHAR(50) NOT NULL
);
GO

-- 5. Créer la table Matiere
CREATE TABLE Matiere (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nom NVARCHAR(50) NOT NULL
);
GO

-- 6. Créer la table Note
CREATE TABLE Note (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    EtudiantId INT NOT NULL,
    MatiereId INT NOT NULL,
    Valeur FLOAT CHECK (Valeur >= 0 AND Valeur <= 20),
    FOREIGN KEY (EtudiantId) REFERENCES Etudiant(Id) ON DELETE CASCADE,
    FOREIGN KEY (MatiereId) REFERENCES Matiere(Id) ON DELETE CASCADE,
    CONSTRAINT UQ_Etudiant_Matiere UNIQUE (EtudiantId, MatiereId)
);
GO

-- 7. Insérer des matières de base
INSERT INTO Matiere (Nom) VALUES 
('Math'), 
('Physique'), 
('Informatique');
GO
