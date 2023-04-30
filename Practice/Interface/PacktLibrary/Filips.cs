using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared;

public class Filips : IPlayable
{
    public void Pause()
    {
        WriteLine("Filip is pausing");
    }
    public void Play()
    {
        WriteLine("Filip is playing");
    }
}
