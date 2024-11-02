using ExtraAdvancedMultiTier.Business.Services;
using ExtraAdvancedMultiTier.Presentation;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Project_Utilities.Enums;
using Project_Utilities.Exceptions;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public class EntityView<TEntity, TEntityKey> : Form, IEntityView<TEntity, TEntityKey>
    where TEntity : class, IEntity<TEntityKey>
    where TEntityKey : IEquatable<TEntityKey> {

    protected IServiceContainer Application { get; }

    protected TEntity? CurrentInstance { get; set; }

    protected ViewActionsEnum CurrentAction { get; set; }

    protected EntityView(IServiceContainer parent)
        : base() {
        this.Application = parent;
    }

    public TEntity? GetCurrentInstance() {
        return this.CurrentInstance;
    }

    public virtual DialogResult OpenFor(ViewActionsEnum action, TEntity? entity) {
        this.CurrentAction = action;
        this.LoadInstanceInControls(entity);
        this.UpdateControlsForAction();
        switch (this.CurrentAction) {
            case ViewActionsEnum.Creation:
                this.EnableEditableControls();
                break;
            case ViewActionsEnum.Visualization:
                if (entity is null) {
                    throw new ArgumentException($"Parameter [entity] cannot be null for view action [{this.CurrentAction}].");
                }
                this.DisableEditableControls();
                break;
            case ViewActionsEnum.Edition:
                if (entity is null) {
                    throw new ArgumentException($"Parameter [entity] cannot be null for view action [{this.CurrentAction}].");
                }
                this.EnableEditableControls();
                break;
            case ViewActionsEnum.Deletion:
                if (entity is null) {
                    throw new ArgumentException($"Parameter [entity] cannot be null for view action [{this.CurrentAction}].");
                }
                this.DisableEditableControls();
                break;
            default:
                throw new NotImplementedException($"View action [{this.CurrentAction}] is not implemented.");
        }
        return this.ShowDialog();
    }

    protected void CancelButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    protected void ActionButton_Click(object sender, EventArgs e) {
        try {
            this.ProcessAction();
            this.DialogResult = DialogResult.OK;

        } catch (Exception ex) {
            IExceptionHandler exHandler =
                this.Application as IExceptionHandler
                ?? new DefaultExceptionHandler();

            exHandler.HandleException(ex);
        }
    }

    protected virtual void LoadInstanceInControls(TEntity? entity) {
        throw new NotOverriddenException($"Method LoadInstanceInControls must be overridden in {this.GetType().ShortDisplayName}.");
    }

    protected virtual void UpdateControlsForAction() {
        throw new NotOverriddenException($"Method UpdateControlsForAction must be overridden in {this.GetType().ShortDisplayName}.");
    }

    protected virtual void EnableEditableControls() {
        throw new NotOverriddenException($"Method EnableEditableControls must be overridden in {this.GetType().ShortDisplayName}.");
    }

    protected virtual void DisableEditableControls() {
        throw new NotOverriddenException($"Method DisableEditableControls must be overridden in {this.GetType().ShortDisplayName}.");
    }

    protected virtual void ValidateControlsForAction() {
        throw new NotOverriddenException($"Method ValidateControlsForAction must be overridden in {this.GetType().ShortDisplayName}.");
    }

    protected virtual void ProcessAction() {
        throw new NotOverriddenException($"Method ProcessAction must be overridden in {this.GetType().ShortDisplayName}.");
    }
}
