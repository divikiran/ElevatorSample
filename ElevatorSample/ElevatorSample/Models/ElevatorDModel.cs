using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElevatorSample.Controls;
using PubSub;

namespace ElevatorSample.Models
{
    public class ElevatorDModel : ElevatorModel
    {
        public ElevatorDModel()
        {
            FloorsToGo = new List<FloorsToGo>();
           /* this.Subscribe<FloorsToGo>(async (c) =>
            {
                FloorsToGo.Add(c);
                var a = FloorsToGo;
                foreach (var floorsToGo in a)
                {
                    await Elevate(floorsToGo).ContinueWith((d) =>
                    {
                        if (d.IsCompleted)
                        {
                            FloorsToGo.Remove(floorsToGo);
                        }
                    });

                    if (FloorsToGo.Count == 0)
                    {
                        break;
                    }
                }
            });*/
        }
    }
}
