using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public interface IStartable {

    public delegate void StartableEventHandler(IStartable startable);
    public abstract event StartableEventHandler? Starting;
    public abstract event StartableEventHandler? Started;

    public void Start();

    public bool IsStarted();

}
