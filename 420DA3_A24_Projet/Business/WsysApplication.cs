using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Business.Services;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation;
using System;
using System.Collections;
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

    /// <summary>
    /// Le service d'authentification
    /// </summary>
    public LoginService LoginService { get; private set; }

    /// <summary>
    /// Le service de Client
    /// </summary> 
    public ClientService ClientService { get; private set; }

    /// <summary>
    /// Le service d'addresse
    /// </summary> 
    public AdresseService AdresseService { get; private set; }

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
        this.ClientService = new ClientService(this, context);
        this.AdresseService = new AdresseService(this, context);
    }

    /// <summary>
    /// Demarrer le système en fonction du rôle de l'utilisateur connecté
    /// </summary>
    /// <exception cref="Exception">Au cas où il n'y aucun rôle pour l'utilisateur essayant de se connectter</exception>
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

    /// <summary>
    /// Obtenir les droits d'auteur
    /// </summary>
    /// <returns></returns>
    public string GetCopyright() {
        return $"(c) {DateTime.Now.Year} Morning Birds - All Rights reserved";
    }

    /// <summary>
    /// Méthode de recupération des exceptions 
    /// </summary>
    /// <param name="e">L'exception fourni</param>
    public void HandleException(Exception e) {
        string? stack = e.StackTrace;

        StringBuilder messageBuilder = new StringBuilder();

        Console.Error.WriteLine(e.Message);

        _ = messageBuilder.Append(e.Message);

        while (e.InnerException != null) {
            e = e.InnerException;
            Console.Error.WriteLine(e.Message);
            _ = messageBuilder.Append(Environment.NewLine + "Causé par : " + e.Message);
        }


        Console.Error.WriteLine("Stack trace : ");
        Console.Error.WriteLine(stack);

        _ = MessageBox.Show(messageBuilder.ToString(), "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);

    }

}
