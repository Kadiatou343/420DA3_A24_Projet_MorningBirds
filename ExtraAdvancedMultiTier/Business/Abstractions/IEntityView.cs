using Microsoft.EntityFrameworkCore.Infrastructure;
using Project_Utilities.Enums;
using Project_Utilities.Exceptions;
using System.Runtime.Serialization;

namespace ExtraAdvancedMultiTier.Business.Abstractions;

public interface IEntityView {
    public static ViewActionsEnum[] ActionsRequiringEntity = new ViewActionsEnum[] {
        ViewActionsEnum.Visualization,
        ViewActionsEnum.Edition,
        ViewActionsEnum.Deletion
    };
}

public interface IEntityView<TEntity, TEntityKey> : IEntityView
    where TEntity : class, IEntity<TEntityKey>
    where TEntityKey : notnull, IEquatable<TEntityKey> {

    protected abstract IServiceContainer ServiceContainer { get; }
    protected abstract IEntityService<TEntity, TEntityKey> EntityService { get; }
    protected abstract TEntity CurrentInstance { get; set; }
    protected abstract ViewActionsEnum CurrentAction { get; set; }

    public delegate DialogResult ViewEventHandler();
    public delegate TEntity CreationActionEventHandler();
    public delegate TEntity VisualizationActionEventHandler();
    public delegate TEntity ModificationActionEventHandler();
    public delegate TEntity DeletionActionEventHandler();
    public event ViewEventHandler ViewOpenEvent;
    public event CreationActionEventHandler CreationActionTriggeredEvent;
    public event VisualizationActionEventHandler VisualizationActionTriggeredEvent;
    public event ModificationActionEventHandler ModificationActionTriggeredEvent;
    public event DeletionActionEventHandler DeletionActionTriggeredEvent;


    public TEntity GetCurrentInstance();
    public void SetCurrentInstance(TEntity entity);
    public ViewActionsEnum GetCurrentAction();
    public void SetCurrentAction(ViewActionsEnum action);
    public IEntityService<TEntity, TEntityKey> GetEntityService();
    public DialogResult ShowDialog();

    private DialogResult OnViewOpen() {
        this.LoadInstanceInControls();
        this.UpdateControlsForAction();
        return this.ShowDialog();
    }

    private TEntity OnCreationActionTriggered() {
        this.ValidateControlsForAction();
        this.SetCurrentInstance((TEntity) FormatterServices.GetUninitializedObject(typeof(TEntity)));
        this.UpdateInstanceFromControls();
        return this.GetEntityService().Create(this.GetCurrentInstance());
    }

    private TEntity OnVisualizationActionTriggered() {
        return this.GetCurrentInstance();
    }

    private TEntity OnModificationActionTriggered() {
        this.ValidateControlsForAction();
        this.UpdateInstanceFromControls();
        return this.GetEntityService().Update(this.GetCurrentInstance());
    }

    private TEntity OnDeletionActionTriggered() {
        return this.GetEntityService().Delete(this.GetCurrentInstance());
    }


    public DialogResult OpenFor(ViewActionsEnum action, TEntity? entity);

    public void LoadInstanceInControls();

    public void UpdateInstanceFromControls();

    public void UpdateControlsForAction();

    public void EnableEditableControls();

    public void DisableEditableControls();

    public void ValidateControlsForAction();

}
