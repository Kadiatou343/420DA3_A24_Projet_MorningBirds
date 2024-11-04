using _420DA3_A24_Exemple_Enseignant.Business.Domain;
using _420DA3_A24_Exemple_Enseignant.DataAccess.Contexts;
using _420DA3_A24_Exemple_Enseignant.DataAccess.Daos;
using _420DA3_A24_Exemple_Enseignant.Presentation.Views;
using Project_Utilities.Enums;

namespace _420DA3_A24_Exemple_Enseignant.Business.Services;
internal class RendezVousService {
    private readonly ExempleApplication application;
    private readonly RendezVousDAO dao;
    private readonly RendezVousView view;

    public RendezVousService(ExempleApplication app, ExempleDbContext context) {
        this.application = app;
        this.dao = new RendezVousDAO(context);
        this.view = new RendezVousView(app);
    }

    public RendezVous? OpenViewFor(ViewActionsEnum viewAction, RendezVous? rendezVous) {
        try {
            DialogResult result = this.view.OpenFor(viewAction, rendezVous);
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

}
