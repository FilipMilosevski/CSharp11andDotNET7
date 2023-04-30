using Packt.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared;

public class CdPlayer : IPlayable
{
    public void Pause()
    {
        WriteLine("CD is paused");
    }

    public void Play()
    {
        WriteLine("CD is playing");
    }
}
