using _420DA3_A24_Projet.Business.Services;
using _420DA3_A24_Projet.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business;
internal class WsysApplication {
    private WsysDbContext context;

    public UserService UserService { get; private set; }
    public RoleService RoleService { get; private set; }

    public WsysApplication() {
        context = new WsysDbContext();
        this.UserService = new UserService(this, context);
        this.RoleService = new RoleService(this, context);
    }
}
