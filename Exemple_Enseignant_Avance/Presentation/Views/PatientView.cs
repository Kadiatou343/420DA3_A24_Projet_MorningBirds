using Exemple_Enseignant_Avance.Business.Domain;
using Exemple_Enseignant_Avance.Business.Services;
using ExtraAdvancedMultiTier.Business.Abstractions;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Project_Utilities.Enums;
using Project_Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemple_Enseignant_Avance.Presentation.Views;
public partial class PatientView : Form, IEntityView<Patient, int> {

    public IServiceContainer ServiceContainer { get; }
    public PatientService EntityService { get; }
    public Patient CurrentInstance { get; set; } = null!;
    public ViewActionsEnum CurrentAction { get; set; }

    IEntityService<Patient, int> IEntityView<Patient, int>.EntityService {
        get {
            return this.EntityService;
        }
    }

    public PatientView(IServiceContainer parent) {
        this.ServiceContainer = parent;
        this.EntityService = parent.GetService<PatientService>();
        this.InitializeComponent();
        this.ViewOpenEvent += this.OnViewOpen;
        this.CreationActionTriggeredEvent += this.OnCreationActionTriggered;
        this.VisualizationActionTriggeredEvent += this.OnVisualizationActionTriggered;
        this.ModificationActionTriggeredEvent += this.OnModificationActionTriggered;
        this.DeletionActionTriggeredEvent += this.OnDeletionActionTriggered;
    }

    public event IEntityView<Patient, int>.ViewEventHandler ViewOpenEvent;
    public event IEntityView<Patient, int>.CreationActionEventHandler CreationActionTriggeredEvent;
    public event IEntityView<Patient, int>.VisualizationActionEventHandler VisualizationActionTriggeredEvent;
    public event IEntityView<Patient, int>.ModificationActionEventHandler ModificationActionTriggeredEvent;
    public event IEntityView<Patient, int>.DeletionActionEventHandler DeletionActionTriggeredEvent;

    public Patient GetCurrentInstance() {
        return this.CurrentInstance;
    }

    public void SetCurrentInstance(Patient entity) {
        this.CurrentInstance = entity;
    }
    public ViewActionsEnum GetCurrentAction() {
        return this.CurrentAction;
    }

    public void SetCurrentAction(ViewActionsEnum view) {
        this.CurrentAction = view;
    }

    public DialogResult OpenFor(ViewActionsEnum action, Patient? entity) {
        this.CurrentAction = action;
        this.CurrentInstance = entity;
        return this.ViewOpenEvent?.Invoke() ?? throw new Exception("Event [ViewOpenEvent] has no attached handler.");
    }

    private DialogResult OnViewOpen() {
        this.LoadInstanceInControls();
        this.UpdateControlsForAction();
        return this.ShowDialog();
    }

    private Patient OnCreationActionTriggered() {
        this.ValidateControlsForAction();
        this.CurrentInstance = (Patient) FormatterServices.GetUninitializedObject(typeof(Patient));
        this.UpdateInstanceFromControls();
        return this.GetEntityService().Create(this.CurrentInstance);
    }

    private Patient OnVisualizationActionTriggered() {
        return this.CurrentInstance;
    }

    private Patient OnModificationActionTriggered() {
        this.ValidateControlsForAction();
        this.UpdateInstanceFromControls();
        return this.GetEntityService().Update(this.CurrentInstance);
    }

    private Patient OnDeletionActionTriggered() {
        return this.GetEntityService().Delete(this.CurrentInstance);
    }

    public void LoadInstanceInControls() {
        throw new NotImplementedException();
    }

    public void UpdateControlsForAction() {
        throw new NotImplementedException();
    }

    public virtual void EnableEditableControls() {
        throw new NotImplementedException();
    }

    public virtual void DisableEditableControls() {
        throw new NotImplementedException();
    }

    public virtual void ValidateControlsForAction() {
        throw new NotImplementedException();
    }

    public virtual void ProcessAction() {
        throw new NotImplementedException();
    }

    public IEntityService<Patient, int> GetEntityService() {
        throw new NotImplementedException();
    }

    public void UpdateInstanceFromControls() {
        throw new NotImplementedException();
    }
}
