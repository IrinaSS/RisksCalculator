using System;

namespace ConsoleApp1
{
    class Scenario
    {
        public Equipment Equipment { get; }

        public Scenario(Equipment equipment)
        {
            Equipment = equipment;
        }

        internal void Calculate()
        {
            CalculateAccidentMasses();
            CalculateDamagingMasses();

            CalculateDamageZone();

            CalculateInjured();

            CalculateLoss();

            CalculateRisk();
        }

        private void CalculateRisk()
        {
        }

        private void CalculateLoss()
        {
        }

        private void CalculateInjured()
        {
        }     

        private void CalculateDamageZone()
        {
        }

        private void CalculateDamagingMasses()
        {
        }

        private void CalculateAccidentMasses()
        {
        }
    }
}