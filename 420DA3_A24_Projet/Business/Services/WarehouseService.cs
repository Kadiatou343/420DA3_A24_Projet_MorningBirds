using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class WarehouseService {

    private readonly WsysApplication parentApp;
    private readonly WarehouseDAO dao;
    private readonly WarehouseView view;

    public WarehouseService(WsysApplication parentApp, WsysDbContext context) {
        this.parentApp = parentApp;
        this.dao = new WarehouseDAO(context);
        this.view = new WarehouseView(parentApp);
    }
}
