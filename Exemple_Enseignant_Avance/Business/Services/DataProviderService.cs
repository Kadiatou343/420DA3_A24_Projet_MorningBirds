using Exemple_Enseignant_Avance.Business.Abstractions;
using Exemple_Enseignant_Avance.DataAccess;
using Exemple_Enseignant_Avance.DataAccess.DataProviders;
using ExtraAdvancedMultiTier.Business.Abstractions;
using ExtraAdvancedMultiTier.Business.Domain;
using ExtraAdvancedMultiTier.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_Enseignant_Avance.Business.Services;

/// <summary>
/// Classe de services avancée pour les fournisseurs de données.
/// Permet de récupérer un fournisseur de données en fonction de la configuration de l'application.
/// </summary>
/// <remarks>
/// Hérite de la classe abstraite <see cref="AbstractService"/> permettant l'enregistrement de ce service dans un conteneur de services (<see cref="IServiceContainer"/>).
/// </remarks>
public class DataProviderService : AbstractService {

    private readonly IDataProvider dataProvider;

    /// <summary>
    /// Constructeur de DataProviderService.
    /// Reçoit un conteneur de services parent et les configuration de l'application. Ces configurations sont utilisées pour
    /// déterminer quel fournisseur de données doit être utilisé et instancier celui-ci.
    /// </summary>
    /// <param name="parent">Le conteneur de service parent.</param>
    /// <param name="configurations">Les configurations de l'application.</param>
    public DataProviderService(IServiceContainer parent, AppConfigurations configurations) : base(parent) { 
        this.dataProvider = DataProviderFactory.GetDataProvider(configurations);
    }

    /// <summary>
    /// Getter pour le fournisseur de données.
    /// </summary>
    /// <returns>Le fournisseur de données.</returns>
    public IDataProvider GetDataProvider() {
        return this.dataProvider;
    }

}
