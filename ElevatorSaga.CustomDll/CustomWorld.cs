using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElevatorSaga.Core;
using ElevatorSaga.Core.Classes;
using ElevatorSaga.Core.Interfaces;

namespace ElevatorSaga.CustomDll
{
    public class CustomWorld : IWorld
    {
        private List<Floor> Floors;
        private List<Elevator> Elevators;

        public string Author { get { return "Tamás Szabó"; } }

        public string AuthorEmail { get { return "gmail@szabto.com"; } }

        public void Initialize()
        {
        }

        public void WorldGenerated(List<Floor> floors, List<Elevator> elevators)
        {
            Floors = floors;
            Elevators = elevators;
        }

        public void Update(int frame, World world)
        {
        }
    }
}
