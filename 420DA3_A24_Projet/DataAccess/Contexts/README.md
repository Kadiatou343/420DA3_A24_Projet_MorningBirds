
# Créez votre classe de contexte dans ce dossier.

### Pour utiliser le système avancé pour la classe de contexte:
- Faites hériter votre classe de contexte de AbstractDataContext.
#### Votre classe de contexte héritera automatiquement des méthodes suivantes:
	- GetDbSet<TEntity>() : DbSet<TEntity> (retourne le DbSet de l'entité spécifiée par TEntity)