using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Presentation;
using Project_Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class LoginService {

    private WsysApplication parentApp;
    private readonly LoginWindow loginWindow;
    private readonly RoleSelectionWindow roleSelectionWindow;

    public User? LoggedInUser { get; private set; }
    public Role? UserLoggedInRole { get; private set; }
    public bool IsLoggedIn { get; private set; }

    public LoginService(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.loginWindow = new LoginWindow(parentApp);
        this.roleSelectionWindow = new RoleSelectionWindow(parentApp);
        this.IsLoggedIn = false;


    }


    public bool RequireLoggedInUser() {

        if(this.IsLoggedIn && this.LoggedInUser is User && this.UserLoggedInRole is Role) {
            return true;
        } else {
            DialogResult result = this.OpenLogInWindow();
            if (result == DialogResult.OK) {
                return true;
            } else {
                return false;
            }
        }

    }

    public void TryLogIn(string username, string password) {
        User? user = this.parentApp.UserService.GetByUsername(username) ?? throw new UserNotFoundException($"L'utilisateur [{username}] n'existe pas.");

        if(!this.parentApp.PasswordService.ValidatePassword(password, user.PasswordHash)) {
            throw new InvalidPasswordException("Le mot de passe est invalide.");
        }

        Role roleSelectionne;
        if(user.Roles.Count > 1) {
            roleSelectionne = this.roleSelectionWindow.OpenRoleSelectionWindowForUser(user);
        }else if (user.Roles.Count == 1) {
            roleSelectionne = user.Roles[0];
        } else {
            throw new Exception("Impossible de poursuivre la connexion");
        }

        this.LoggedInUser = user;
        this.UserLoggedInRole = roleSelectionne;
        this.IsLoggedIn = true;

    }

    public void Logout() {
        this.LoggedInUser = null;
        this.UserLoggedInRole = null;
        this.IsLoggedIn = false;
    }

    private DialogResult OpenLogInWindow() {
        return this.loginWindow.ShowDialog();
    }

    private Role OpenRoleSelectionWindow() {
        
    }



}
