using _420DA3_A24_Exemple_Enseignant.Business.Domain;
using _420DA3_A24_Exemple_Enseignant.DataAccess.Contexts;
using _420DA3_A24_Exemple_Enseignant.DataAccess.Daos;
using _420DA3_A24_Exemple_Enseignant.Presentation.Views;
using Project_Utilities.Enums;

namespace _420DA3_A24_Exemple_Enseignant.Business.Services;
internal class PatientService {
    private readonly ExempleApplication application;
    private readonly PatientDAO dao;
    private readonly PatientView view;

    public PatientService(ExempleApplication app, ExempleDbContext context) {
        this.application = app;
        this.dao = new PatientDAO(context);
        this.view = new PatientView(app);
    }

    public Patient? OpenViewFor(ViewActionsEnum viewAction, Patient? patient = null) {
        try {
            DialogResult result = this.view.OpenFor(viewAction, patient);
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

    public List<Patient> Search(string filter) {
        return this.dao.Search(filter);
    }

    public Patient Create(Patient patient) {
        try {
            return this.dao.Create(patient);
        } catch (Exception ex) {
            throw new Exception("Failed to create new [Patient].", ex);
        }
    }

    public Patient? GetById(int id) {
        return this.dao.GetById(id);
    }

    public Patient Update(Patient patient) {
        try {
            return this.dao.Update(patient);
        } catch (Exception ex) {
            throw new Exception("Failed to update [Patient] instance.", ex);
        }
    }

    public void Delete(Patient patient, bool softDeletes = true) {
        try {
            this.dao.Delete(patient, softDeletes);
        } catch (Exception ex) {
            throw new Exception("Failed to delete [Patient] instance.", ex);
        }
    }

}
