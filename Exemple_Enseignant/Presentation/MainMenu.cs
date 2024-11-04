using _420DA3_A24_Exemple_Enseignant.Business;
using _420DA3_A24_Exemple_Enseignant.Business.Domain;
using Project_Utilities.Enums;

namespace _420DA3_A24_Exemple_Enseignant.Presentation;
internal partial class MainMenu : Form {
    private ExempleApplication app;

    public MainMenu(ExempleApplication app) {
        this.app = app;
        this.InitializeComponent();
    }

    #region Gestion des médecins

    private void MedecinSearchBox_TextChanged(object sender, EventArgs e) {
        List<Medecin> results = this.app.MedecinService.Search(this.medecinSearchBox.Text);
        this.medecinSearchResultsListBox.Items.Clear();
        int? selectedMedecinId = (this.medecinSearchResultsListBox.SelectedItem as Medecin)?.Id;
        this.medecinSearchResultsListBox.SelectedItem = null;
        foreach (Medecin medecin in results) {
            _ = this.medecinSearchResultsListBox.Items.Add(medecin);
            if (selectedMedecinId is not null && medecin.Id == selectedMedecinId) {
                this.medecinSearchResultsListBox.SelectedItem = medecin;
            }
        }
    }

    private void MedecinSearchResultsListBox_SelectedIndexChanged(object sender, EventArgs e) {
        Medecin? medecin = this.medecinSearchResultsListBox.SelectedItem as Medecin;
        if (medecin is not null) {
            this.EnableMedecinActionButtons();
        } else {
            this.DisableMedecinActionButtons();
        }
    }

    private void EnableMedecinActionButtons() {
        this.btnMedecinModifier.Enabled = true;
        this.btnMedecinSupprimer.Enabled = true;
        this.btnMedecinViewDetails.Enabled = true;
    }

    private void DisableMedecinActionButtons() {
        this.btnMedecinModifier.Enabled = false;
        this.btnMedecinSupprimer.Enabled = false;
        this.btnMedecinViewDetails.Enabled = false;
    }

    private void BtnCreateMedecin_Click(object sender, EventArgs e) {
        _ = this.app.MedecinService.OpenViewFor(ViewActionsEnum.Creation);
    }

    private void BtnMedecinViewDetails_Click(object sender, EventArgs e) {
        Medecin? medecin = this.medecinSearchResultsListBox.SelectedItem as Medecin;
        if (medecin is not null) {
            _ = this.app.MedecinService.OpenViewFor(ViewActionsEnum.Visualization, medecin);
        }
    }

    private void BtnMedecinModifier_Click(object sender, EventArgs e) {
        Medecin? medecin = this.medecinSearchResultsListBox.SelectedItem as Medecin;
        if (medecin is not null) {
            _ = this.app.MedecinService.OpenViewFor(ViewActionsEnum.Edition, medecin);
        }
    }

    private void BtnMedecinSupprimer_Click(object sender, EventArgs e) {
        Medecin? medecin = this.medecinSearchResultsListBox.SelectedItem as Medecin;
        if (medecin is not null) {
            _ = this.app.MedecinService.OpenViewFor(ViewActionsEnum.Deletion, medecin);
        }
    }

    #endregion


    #region Gestion des patients

    private void PatientSearchBox_TextChanged(object sender, EventArgs e) {
        List<Patient> results = this.app.PatientService.Search(this.patientSearchBox.Text);
        this.patientSearchResultsListBox.Items.Clear();
        int? selectedPatientId = (this.patientSearchResultsListBox.SelectedItem as Patient)?.Id;
        this.patientSearchResultsListBox.SelectedItem = null;
        foreach (Patient patient in results) {
            _ = this.patientSearchResultsListBox.Items.Add(patient);
            if (selectedPatientId is not null && patient.Id == selectedPatientId) {
                this.patientSearchResultsListBox.SelectedItem = patient;
            }
        }
    }

    private void PatientSearchResultsListBox_SelectedIndexChanged(object sender, EventArgs e) {
        Patient? patient = this.patientSearchResultsListBox.SelectedItem as Patient;
        if (patient is not null) {
            this.EnablePatientActionButtons();
        } else {
            this.DisablePatientActionButtons();
        }
    }

    private void EnablePatientActionButtons() {
        this.btnPatientViewDetails.Enabled = true;
        this.btnPatientModifier.Enabled = true;
        this.btnPatientSupprimer.Enabled = true;
    }

    private void DisablePatientActionButtons() {
        this.btnPatientViewDetails.Enabled = false;
        this.btnPatientModifier.Enabled = false;
        this.btnPatientSupprimer.Enabled = false;
    }

    private void BtnCreatePatient_Click(object sender, EventArgs e) {
        _ = this.app.PatientService.OpenViewFor(ViewActionsEnum.Creation);
    }

    private void BtnPatientViewDetails_Click(object sender, EventArgs e) {
        Patient? patient = this.patientSearchResultsListBox.SelectedItem as Patient;
        if (patient is not null) {
            _ = this.app.PatientService.OpenViewFor(ViewActionsEnum.Visualization, patient);
        }
    }

    private void BtnPatientModifier_Click(object sender, EventArgs e) {
        Patient? patient = this.patientSearchResultsListBox.SelectedItem as Patient;
        if (patient is not null) {
            _ = this.app.PatientService.OpenViewFor(ViewActionsEnum.Edition, patient);
        }
    }

    private void BtnPatientSupprimer_Click(object sender, EventArgs e) {
        Patient? patient = this.patientSearchResultsListBox.SelectedItem as Patient;
        if (patient is not null) {
            _ = this.app.PatientService.OpenViewFor(ViewActionsEnum.Deletion, patient);
        }
    }

    #endregion

}
