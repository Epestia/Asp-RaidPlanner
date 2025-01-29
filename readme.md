### Commandes Entity Framework Core dans Visual Studio

#### **1. Ajouter une migration**
```powershell
Add-Migration NomDeLaMigration
```
Crée une nouvelle migration basée sur les modifications du modèle.

---

#### **2. Appliquer les migrations à la base de données**
```powershell
Update-Database
```
Met à jour la base de données avec la dernière migration.

---

#### **3. Revenir à une migration spécifique**
```powershell
Update-Database -Migration NomDeLaMigration
```
Ramène la base de données à un état spécifique.

---

#### **4. Supprimer la dernière migration**
```powershell
Remove-Migration
```
Supprime la dernière migration (tant qu’elle n’a pas été appliquée à la base de données).

---

#### **5. Lister toutes les migrations**
```powershell
Get-Migrations
```
Affiche la liste des migrations appliquées et disponibles.

---

#### **6. Générer un script SQL des migrations**
```powershell
Script-Migration -From NomMigrationDébut -To NomMigrationFin
```
Génère un script SQL des migrations entre deux migrations spécifiques.

---

### **Où exécuter ces commandes ?**
Ces commandes doivent être entrées dans la **Console du Gestionnaire de Packages** de Visual Studio.

**Accéder à la console :**  
**Affichage** → **Autres fenêtres** → **Console du Gestionnaire de packages**

