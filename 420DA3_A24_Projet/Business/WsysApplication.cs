using _420DA3_A24_Projet.Business.Services;
using _420DA3_A24_Projet.DataAccess.Contexts;
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

    /// <summary>
    /// Le service Utilisateur
    /// </summary>
    public UserService UserService { get; private set; }

    /// <summary>
    /// Le service Rôle
    /// </summary>
    public RoleService RoleService { get; private set; }

    /// <summary>
    /// Constructeur
    /// </summary>
    public WsysApplication() {
        context = new WsysDbContext();
        this.UserService = new UserService(this, context);
        this.RoleService = new RoleService(this, context);
    }
}
