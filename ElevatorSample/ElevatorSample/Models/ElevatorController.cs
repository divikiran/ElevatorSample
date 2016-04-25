using System.Collections.Generic;
using ElevatorSample.Controls;
using PubSub;

namespace ElevatorSample.Models
{
    public class ElevatorController : BaseModel
    {
        public List<FloorsToGo> FloorsToGo { get; set; }
        public int CurrentFloor { get; set; } = 1;


        public ElevatorAModel ElevatorA { get; set; }
        public ElevatorBModel ElevatorB { get; set; }
        public ElevatorCModel ElevatorC { get; set; }
        public ElevatorDModel ElevatorD { get; set; }

        public ElevatorController()
        {
            FloorsToGo = new List<FloorsToGo>();
            this.Subscribe<FloorsToGo>(async (c) =>
            {
                FloorsToGo.Add(c);
                foreach (var floorsToGo in FloorsToGo)
                {
                    await ElevatorA.Elevate(floorsToGo);

                    //await Elevate(floorsToGo).ContinueWith((cc) =>
                    //{
                    //    if (!cc.IsCompleted) return;
                    //    FloorsToGo.Remove(floorsToGo);
                    //    if (FloorsToGo.Count == 0)
                    //    {
                    //        CurrentFloor = Convert.ToInt32(floorsToGo.FloorSelected);
                    //    }
                    //});
                }
            });
        }
    }
}
