
# Créez vos classes de services (métier) dans ce dossier.

### Pour utiliser le système avancé pour les services de gestion d'entité:
- Faites hériter vos services de gestion d'entité de AbstractEntityService<TEntity, TEntityKey> en spécifiant le type d'entité géré par le service (TEntity) et le type de sa clé primaire (TEntityKey).
- Redéfinissez (override) la propriété 'Dao' pour qu'elle soit du bon type de DAO (celui-ci doit hériter de AbstractDao<TEntity, TEntityKey>).
- Redéfinissez (override) la propriété 'View' pour qu'elle soit du bon type de fenêtre de gestion d'entité (celle-ci doit hériter de Form et de IEntityView<TEntity, TEntityKey>).
- Faites recevoir au constructeur du service de gestion d'entité un IServiceContainer comme paramètre.
- Faites recevoir au constructeur du service de gestion d'entité un IDataContext comme paramètre.
- Appelez le constructeur de la classe parent avec le IServiceContainer reçu en paramètre.
#### Vos services de gestion d'entité hériteront automatiquement des méthodes suivantes:
	- OpenViewFor(ViewActionsEnum action, TEntity? entity)
	- GetAll(bool includeDeleted = false) : List<TEntity> (retourne la liste de toutes les entités de type TEntity, incluant optionellement celles supprimées)
	- GetById(TEntityKey id, bool includeDeleted = false) : TEntity? (retourne l'entité de type TEntity correspondant à la clé primaire spécifiée, incluant optionellement celles supprimées)
	- Create(TEntity entity, bool doSaveChanges = true) : TEntity (crée une nouvelle entité de type TEntity dans la base de données, avec possibilité de désactiver la sauvegarde automatique des changements)
	- Update(TEntity entity, bool doSaveChanges = true) : TEntity (met à jour une entité de type TEntity dans la base de données, avec possibilité de désactiver la sauvegarde automatique des changements)
	- Delete(TEntity entity, bool doSaveChanges = true, bool softDeletes = true) : TEntity (supprime une entité de type TEntity de la base de données, avec possibilité de désactiver la sauvegarde automatique des changements et les "soft deletes")
#### EXEMPLE:
```csharp
public class VotreEntiteService : AbstractEntityService<VotreEntite, int> {

    public override VotreEntiteDAO Dao { get; }
    public override VotreEntiteView View { get; }

    public VotreEntiteService(IServiceContainer parent, IDataContext context) : base(parent) {
        this.Dao = new VotreEntiteDao(context);
        this.View = new MedecinView(parent);
    }


    /*
     * NOTE: Les méthodes suivantes sont automatiquement héritées de AbstractEntityService<TEntity, TEntityKey>:
     * - OpenViewFor(ViewActionsEnum, TEntity?)
     * - GetAll(bool)
     * - GetById(int, bool)
     * - Create(TEntity, bool)
     * - Update(TEntity, bool)
     * - Delete(TEntity, bool, bool)
     */


    // Ajoutez ici vos méthodes spécifiques à votre service de gestion d'entité.

}
```

### Pour utiliser le système avancé pour les services généraux (pas de gestion d'entité):
- Faites hériter vos services généraux de AbstractService.
- Faites recevoir au constructeur du service de gestion d'entité un IServiceContainer comme paramètre.
- Appelez le constructeur de la classe parent avec le IServiceContainer reçu en paramètre.
#### EXEMPLE:
```csharp
public class VotreServiceGeneral : AbstractService {

    public VotreServiceGeneral(IServiceContainer parent) : base(parent) { }


    // Ajoutez ici vos méthodes spécifiques à votre service général.

}
```