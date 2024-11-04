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
            return this.view.GetCurrentInstance();

        } catch (Exception ex) {
            this.application.HandleException(ex);
            return null;
        }
    }

    public List<Medecin> Search(string filter) {
        return this.dao.Search(filter);
    }

    public Medecin Create(Medecin nouveauMedecin) {
        try {
            return this.dao.Create(nouveauMedecin);
        } catch (Exception ex) {
            throw new Exception("Failed to create new [Medecin].", ex);
        }
    }

    public Medecin? GetById(int id) {
        return this.dao.GetById(id);
    }

    public Medecin Update(Medecin medecin) {
        try {
            return this.dao.Update(medecin);
        } catch (Exception ex) {
            throw new Exception("Failed to update [Medecin] instance.", ex);
        }
    }

    public void Delete(Medecin medecin, bool softDeletes = true) {
        try {
            this.dao.Delete(medecin, softDeletes);
        } catch (Exception ex) {
            throw new Exception("Failed to delete [Medecin] instance.", ex);
        }
    }

}
