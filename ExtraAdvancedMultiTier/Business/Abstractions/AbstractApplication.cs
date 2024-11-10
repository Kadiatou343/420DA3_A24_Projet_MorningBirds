using ExtraAdvancedMultiTier.Business.Domain;
using ExtraAdvancedMultiTier.Business.Services;
using ExtraAdvancedMultiTier.Presentation;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public abstract class AbstractApplication : AbstractServiceContainer, IApplication {
    public readonly AppConfigurations Configurations;
    public readonly List<string> CliArguments;

    protected AbstractApplication(string[]? args = null) : base() { 
        this.Configurations = AppConfigurationsService.GetConfigs();
        this.CliArguments = args?.ToList() ?? new List<string>();
    }

    public AppConfigurations GetAppConfigurations() {
        return this.Configurations;
    }
}
