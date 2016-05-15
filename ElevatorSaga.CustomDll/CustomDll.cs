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
    public class CustomDll : IWorld
    {
        private List<Floor> Floors;
        private List<Elevator> Elevators;

        public string Author { get { return "Tamás Szabó"; } }

        public string AuthorEmail { get { return "gmail@szabto.com"; } }

        public void Initialize()
        {
        }

        public void WorldGenerated(List<Floor> f, List<Elevator> e)
        {
            Floors = f;
            Elevators = e;
        }

        public void Update(int frame, World world)
        {
        }
    }
}
