
# Créez vos classes DAO dans ce dossier.

### Pour utiliser le système avancé pour les DAOs:
- Faites hériter vos DAO de AbstractDao<TEntity, TEntityKey> en spécifiant le type d'entité géré par le DAO (TEntity) et le type de sa clé primaire (TEntityKey).
- Faites recevoir au constructeur du DAO un IDataContext comme paramètre.
- Appelez le constructeur de la classe parent avec le IDataContext reçu en paramètre.
#### Vos DAOs hériteront automatiquement des propriétés suivantes:
	- Context : IDataContext (le contexte de données utilisé par le DAO)
#### Vos DAOs hériteront automatiquement des méthodes suivantes:
	- GetAll(bool includeDeleted = false) : List<TEntity> (retourne la liste de toutes les entités de type TEntity, incluant optionellement celles supprimées)
	- GetById(TEntityKey id, bool includeDeleted = false) : TEntity? (retourne l'entité de type TEntity correspondant à la clé primaire spécifiée, incluant optionellement celles supprimées)
	- Create(TEntity entity, bool doSaveChanges = true) : TEntity (crée une nouvelle entité de type TEntity dans la base de données, avec possibilité de désactiver la sauvegarde automatique des changements)
	- Update(TEntity entity, bool doSaveChanges = true) : TEntity (met à jour une entité de type TEntity dans la base de données, avec possibilité de désactiver la sauvegarde automatique des changements)
	- Delete(TEntity entity, bool doSaveChanges = true, bool softDeletes = true) : TEntity (supprime une entité de type TEntity de la base de données, avec possibilité de désactiver la sauvegarde automatique des changements et les "soft deletes")
#### EXEMPLE:
```csharp
internal class VotreEntiteDAO : AbstractDao<VotreEntite, int> {

    public VotreEntiteDAO(IDataContext context) : base(context) { }


    /*
     * NOTE: Les méthodes CRUD de base sont déjà implémentées dans AbstractDao<T, TId>
     * et votre DAO en héritera. Ceci inclus:
     *      + GetAll()
     *      + GetById(TId id)
     *      + Create(TEntity entity)
     *      + Insert(TEntity entity)
     *      + Update(TEntity entity)
     *      + Delete(TEntity entity)
     */


     // Ajoutez ici des méthodes spécifiques à ce DAO si nécessaire.
     // Utilisez la propriété 'Context' pour accéder au contexte de données
     // et la méthode 'GetDbSet<TEntity>()' sur celle-ci pour accéder au DbSet<TEntity>
     // Dans le présent exemple, ça serait GetDbSet<VotreEntite>().

}
```