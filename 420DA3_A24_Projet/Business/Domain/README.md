
# Créez vos classes-entités dans ce dossier.

### Pour utiliser le système avancé pour les entités:
- Faites hériter vos classes-entités de AbstractEntity\<TKey> en spécifiant le type de la clé primaire de votre entité (TKey).
#### Vos classes entités hériteront automatiquement des propriétés suivantes:
	- Id : TKey (la clé primaire de l'entité)
	- DateCreated : DateTime (la date de création de l'entité)
	- DateModified : DateTime? (la date de dernière modification de l'entité)
	- DateDeleted : DateTime? (la date de suppression de l'entité)
	- RowVersion : byte[] (la version de la ligne de l'entité)
#### Et des méthodes suivantes:
	- GetId() : TKey (retourne la clé primaire de l'entité)
	- GetDateCreated() : DateTime (retourne la date de création de l'entité)
	- GetDateModified() : DateTime? (retourne la date de dernière modification de l'entité)
	- GetDateDeleted() : DateTime? (retourne la date de suppression de l'entité)
	- SetDateModified(DateTime date) : void (met à jour la date de dernière modification de l'entité)
	- SetDateDeleted(DateTime? date) : void (met à jour la date de suppression de l'entité)
	- IsDeleted() : bool (retourne vrai si l'entité est supprimée, faux sinon)
#### EXEMPLE:
```csharp

public class VotreEntite : AbstractEntity<int> {

	// Insérez les propriétés de données spécifiques à votre entité ici.

	// NOTE: les propriétés 'Id', 'DateCreated', 'DateModified', 'DateDeleted' et 'RowVersion' 
	// sont déjà définies dans AbstractEntity<TKey> et votre entité en héritera.

	// Insérez les propriétés de navigation spécifiques à votre entité ici.

	// Insérez votre/vos constructeurs ici

	// Insérez les méthodes spécifiques à votre entité ici.
}
```