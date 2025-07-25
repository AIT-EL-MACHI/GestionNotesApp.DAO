L'application Gestion des Notes des Étudiants est un logiciel développé en C# avec Windows Forms, destiné à faciliter la gestion académique des étudiants au sein d’un établissement scolaire ou universitaire. Elle permet aux utilisateurs d'enregistrer des étudiants, de leur attribuer des notes par matière, et de consulter ou modifier leurs bulletins de manière simple et efficace.

Cette application repose sur une architecture claire et modulaire, utilisant le design pattern DAO (Data Access Object) pour interagir avec une base de données SQL Server, assurant une séparation propre entre la logique métier, l’interface graphique et l'accès aux données.

🎯 Objectifs principaux
Fournir une interface simple pour gérer une liste d'étudiants

Permettre l'ajout, la modification et la suppression des notes par matière

Visualiser instantanément le bulletin d’un étudiant sélectionné

Organiser les données via DataGridView pour un affichage lisible et structuré

Utiliser SQL Server comme système de gestion de base de données relationnelle

🧰 Fonctionnalités en détail
Étudiants

Ajouter un nouvel étudiant (Nom, Prénom)

Modifier ou supprimer un étudiant existant

Affichage automatique dans une DataGridView

Notes

Associer des notes à un étudiant pour une matière donnée

Modifier ou supprimer une note

Consultation en temps réel des notes dans une seconde DataGridView

Matières

Pré-remplies (Math, Physique, Informatique)

Affectées via une ComboBox

🧱 Technologies utilisées
Composant	Détail
Langage	C#
Interface	Windows Forms (.NET Framework)
Base de données	SQL Server
Architecture	DAO (Data Access Object)
