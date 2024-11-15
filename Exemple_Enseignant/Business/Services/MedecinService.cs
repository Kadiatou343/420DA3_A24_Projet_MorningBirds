using _420DA3_A24_Exemple_Enseignant.Business.Domain;
using _420DA3_A24_Exemple_Enseignant.DataAccess.Contexts;
using _420DA3_A24_Exemple_Enseignant.DataAccess.Daos;
using _420DA3_A24_Exemple_Enseignant.Presentation.Views;
using Project_Utilities.Enums;

namespace _420DA3_A24_Exemple_Enseignant.Business.Services;
internal class MedecinService {
    private readonly ExempleApplication application;
    private readonly MedecinDAO dao;
    private readonly MedecinView view;

    public MedecinService(ExempleApplication app, ExempleDbContext context) {
        this.application = app;
        this.dao = new MedecinDAO(context);
        this.view = new MedecinView(app);
    }

    public Medecin? OpenViewFor(ViewActionsEnum viewAction, Medecin? medecin = null) {
        try {
            DialogResult result = this.view.OpenFor(viewAction, medecin);
            if (result == DialogResult.OK) {
                switch (viewAction) {
                    case ViewActionsEnum.Creation:
                    case ViewActionsEnum.Edition:
                        // open the view in visualization mode after edition and creation
                        // get the medecin from the view's current instance so we get the
                        // created one during creation (the parameter would be null here otherwise)
                        _ = this.OpenViewFor(ViewActionsEnum.Visualization, this.view.GetCurrentInstance());
                        break;
                    default:
                        break;
                }
            }
            // retourner l'instance courante du formulaire (créée, visualisée, modifiée ou supprimée)
            return this.view.GetCurrentInstance();

        } catch (Exception ex) {
            this.application.HandleException(ex);
            return null;
        }
    }

    public List<Medecin> Search(string filter) {
        try {
            return this.dao.Search(filter);
        } catch (Exception ex) {
            throw new Exception("Failed to search for [Medecin] instances.", ex);
        }
    }

    public Medecin Create(Medecin nouveauMedecin) {
        try {
            return this.dao.Create(nouveauMedecin);
        } catch (Exception ex) {
            throw new Exception("Failed to create new [Medecin].", ex);
        }
    }

    public Medecin? GetById(int id) {
        try {
            return this.dao.GetById(id);
        } catch (Exception ex) {
            throw new Exception($"Failed to obtain [Medecin] instance with id# {id}.", ex);
        }
    }

    public Medecin Update(Medecin medecin) {
        try {
            return this.dao.Update(medecin);
        } catch (Exception ex) {
            throw new Exception($"Failed to update [Medecin] instance with id# {medecin.Id}.", ex);
        }
    }

    public void Delete(Medecin medecin, bool softDeletes = true) {
        try {
            this.dao.Delete(medecin, softDeletes);
        } catch (Exception ex) {
            throw new Exception($"Failed to delete [Medecin] instance with id# {medecin.Id}.", ex);
        }
    }

}
