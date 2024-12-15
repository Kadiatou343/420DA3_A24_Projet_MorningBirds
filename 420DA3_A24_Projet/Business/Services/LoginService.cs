using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Presentation;
using Project_Utilities.Exceptions;

namespace _420DA3_A24_Projet.Business.Services;
/// <summary>
/// Classe représentant le service d'authentification des utilisateurs de l'application
/// </summary>
internal class LoginService {
    /// <summary>
    /// L'application elle-même
    /// </summary>
    private readonly WsysApplication parentApp;

    /// <summary>
    /// La vue de connexion au système
    /// </summary>
    private readonly LoginWindow loginWindow;

    /// <summary>
    /// La vue de selection de rôle
    /// </summary>
    private readonly RoleSelectionWindow roleSelectionWindow;

    /// <summary>
    /// L'utilisateur connecté
    /// </summary>
    public User? LoggedInUser { get; private set; }

    /// <summary>
    /// Le rôle de l'utilisateur ou le rôle selectionné par lui (au cas où il aurait plusieurs rôles)
    /// </summary>
    public Role? UserLoggedInRole { get; private set; }

    /// <summary>
    /// Verifier si un utilisateur est bien connecté
    /// </summary>
    public bool IsLoggedIn { get; private set; }

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="parentApp">L'application</param>
    public LoginService(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.loginWindow = new LoginWindow(parentApp);
        this.roleSelectionWindow = new RoleSelectionWindow(parentApp);
        this.IsLoggedIn = false;


    }

    /// <summary>
    /// Recquerir l'authentification d'un utilisation
    /// </summary>
    /// <returns></returns>
    public bool RequireLoggedInUser() {

        if (this.IsLoggedIn && this.LoggedInUser is User && this.UserLoggedInRole is Role) {
            return true;
        } else {
            DialogResult result = this.OpenLogInWindow();
            return result == DialogResult.OK;
        }

    }

    /// <summary>
    /// Essayer de procéder à l'authentification
    /// </summary>
    /// <param name="username">Le nom d'utilisateur lors de la connexion</param>
    /// <param name="password">Le mot de passe lors de la connexion</param>
    /// <exception cref="UserNotFoundException">Lorsqu'aucun uttilisateur n'est trouvé avec le nom d'utilisateur fourni</exception>
    /// <exception cref="InvalidPasswordException">Lorsque le mot de passe fourni est incorrect pour l'utilisateur en train de se connecter</exception>
    /// <exception cref="Exception">Si aucun rôle n'est detecté</exception>
    public void TryLogIn(string username, string password) {
        User? user = this.parentApp.UserService.GetByUsername(username) ?? throw new UserNotFoundException($"L'utilisateur [{username}] n'existe pas.");

        if (!this.parentApp.PasswordService.ValidatePassword(password, user.PasswordHash)) {
            throw new InvalidPasswordException("Le mot de passe est invalide.");
        }

        Role roleSelectionne = user.Roles.Count > 1
            ? this.roleSelectionWindow.OpenRoleSelectionWindowForUser(user)
            : user.Roles.Count == 1 ? user.Roles[0] : throw new Exception("Impossible de poursuivre la connexion");
        this.LoggedInUser = user;
        this.UserLoggedInRole = roleSelectionne;
        this.IsLoggedIn = true;

    }

    /// <summary>
    /// Deconnexion de l'utilisateur
    /// </summary>
    public void Logout() {
        this.LoggedInUser = null;
        this.UserLoggedInRole = null;
        this.IsLoggedIn = false;
    }

    /// <summary>
    /// Ouvrir la fenêtre de connexion
    /// </summary>
    /// <returns></returns>
    private DialogResult OpenLogInWindow() {
        return this.loginWindow.ShowDialog();
    }

}
