using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Business.Services;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business;

/// <summary>
/// Classe représentant le point de depart de l'application
/// </summary>
internal class WsysApplication {
    /// <summary>
    /// Le contexte qui est fourni aux services
    /// </summary>
    private WsysDbContext context;

    private AdminMainMenu adminMainMenu;
    private OffEmployeeMainMenu offEmployeeMainMenu;
    private WhEmployeeMainMenu whEmployeeMainMenu;

    /// <summary>
    /// Le service Utilisateur
    /// </summary>
    public UserService UserService { get; private set; }

    /// <summary>
    /// Le service Rôle
    /// </summary>
    public RoleService RoleService { get; private set; }

    /// <summary>
    /// Le service de mot de passe 
    /// </summary>
    public PasswordService PasswordService { get; private set; }

    public LoginService LoginService { get; private set; }

    /// <summary>
    /// Constructeur
    /// </summary>
    public WsysApplication() {
        context = new WsysDbContext();
        this.UserService = new UserService(this, context);
        this.RoleService = new RoleService(this, context);
        this.PasswordService = PasswordService.GetInstance();
        this.LoginService = new LoginService(this);
        this.adminMainMenu = new AdminMainMenu(this);
        this.offEmployeeMainMenu = new OffEmployeeMainMenu(this);
        this.whEmployeeMainMenu = new WhEmployeeMainMenu(this);
    }

    public void Start() {
        Application.Run();// Cette ligne est a tester par le prof 

        while (this.LoginService.RequireLoggedInUser()) {
            if (this.LoginService.UserLoggedInRole?.Id == Role.ADMIN_ROLE_ID) {
                _ = this.adminMainMenu.ShowDialog();
            } else if (this.LoginService.UserLoggedInRole?.Id == Role.OFFICE_EMPLOYEE_ROLE_ID) {
                _ = this.offEmployeeMainMenu.ShowDialog();
            } else if (this.LoginService.UserLoggedInRole?.Id == Role.WH_EMPLOYEE_ROLE_ID) {
                _ = this.whEmployeeMainMenu.ShowDialog();
            } else {
                throw new Exception("Impossible de demarrer l'application : Role non implémenté!");
            }
        }
    }
}
