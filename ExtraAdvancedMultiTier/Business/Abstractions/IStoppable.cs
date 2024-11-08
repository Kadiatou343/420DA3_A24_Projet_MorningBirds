using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAdvancedMultiTier.Business.Abstractions;
public interface IStoppable {

    public delegate void StoppableEventHandler(IStoppable stoppable);
    public event StoppableEventHandler? Stopping;
    public event StoppableEventHandler? Stopped;

    public void Stop();

    public bool IsStopped();
}
