using System;

namespace ConsoleApp1
{
    class Scenario
    {
        Equipment Equipment { get; }

        public Scenario(Equipment equipment)
        {
            Equipment = equipment;
        }

        internal void Calculate()
        {
            return;
            CalculateAccidentMasses();
            CalculateDamagingMasses();

            CalculateDamageZone();

            CalculateInjured();

            CalculateLoss();

            CalculateRisk();
        }

        private void CalculateRisk()
        {
            throw new NotImplementedException();
        }

        private void CalculateLoss()
        {
            throw new NotImplementedException();
        }

        private void CalculateInjured()
        {
            throw new NotImplementedException();
        }     

        private void CalculateDamageZone()
        {
            throw new NotImplementedException();
        }

        private void CalculateDamagingMasses()
        {
            throw new NotImplementedException();
        }

        private void CalculateAccidentMasses()
        {
            throw new NotImplementedException();
        }
    }
}