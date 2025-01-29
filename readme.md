
## Commandes Entity Framework Core dans Visual Studio

## 1. Ajouter une migration
```powershell
Add-Migration NomDeLaMigration
```
Crée une nouvelle migration basée sur les modifications du modèle.

---

## 2. Appliquer les migrations à la base de données
```powershell
Update-Database
```
Met à jour la base de données avec la dernière migration.

---

## 3. Revenir à une migration spécifique
```powershell
Update-Database -Migration NomDeLaMigration
```
Ramène la base de données à un état spécifique.

---

## 4. Supprimer la dernière migration
```powershell
Remove-Migration
```
Supprime la dernière migration (tant qu’elle n’a pas été appliquée à la base de données).

---

## 5. Lister toutes les migrations
```powershell
Get-Migrations
```
Affiche la liste des migrations appliquées et disponibles.

---

## 6. Générer un script SQL des migrations
```powershell
Script-Migration -From NomMigrationDébut -To NomMigrationFin
```
Génère un script SQL des migrations entre deux migrations spécifiques.

---

## Où exécuter ces commandes ?
Ces commandes doivent être entrées dans la **Console du Gestionnaire de Packages** de Visual Studio.

**Accéder à la console :**  
**Affichage** → **Autres fenêtres** → **Console du Gestionnaire de packages**

---

# Composants d'une application MVC avec .NET

## 1. **Controllers**
Les contrôleurs gèrent les requêtes HTTP et renvoient des réponses. Ils contiennent la logique métier et dirigent les données entre le modèle et la vue.

## 2. **Entities**
Les entités représentent les objets du domaine et sont généralement mappées aux tables de la base de données via Entity Framework Core.

## 3. **Models**
Les modèles définissent la structure des données utilisées par l'application et peuvent inclure des validations et des annotations.

## 4. **Services**
Les services contiennent la logique métier et permettent de séparer la logique de l'application des contrôleurs pour une meilleure organisation.

## 5. **Views**
Les vues sont les interfaces utilisateur, généralement des fichiers Razor (`.cshtml`), qui affichent les données envoyées par le contrôleur.

---

# Configuration d'Entity Framework Core

## 1. **Configuration du contexte de base de données**
La classe `DbContext` est utilisée pour interagir avec la base de données. Elle doit être configurée dans `Startup.cs` ou `Program.cs`.

## 2. **Configuration du fichier `appsettings.json`**
Le fichier `appsettings.json` contient la chaîne de connexion à la base de données.

## 3. **Configuration des entités**
Les entités peuvent être configurées via Fluent API dans la méthode `OnModelCreating` du `DbContext`.

## 4. **Injection de dépendances**
Le `DbContext` doit être enregistré dans le conteneur de services dans `Program.cs` avec `services.AddDbContext<T>()`.

