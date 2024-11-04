using ExtraAdvancedMultiTier.Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAdvancedMultiTier.Business.Abstractions;

public interface IApplication : IStartable, IStoppable {

    public AppConfigurations GetAppConfigurations();

}
