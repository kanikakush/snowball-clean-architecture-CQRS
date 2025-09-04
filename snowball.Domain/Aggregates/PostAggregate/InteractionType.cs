using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snowball.Domain.Aggregates.PostAggregate
{
    public enum InteractionType
    {
        Like,
        Share,
        Love,
        Haha,
        Wow,
        Sad,
        Angry
    }
}
