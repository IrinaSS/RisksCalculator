using System;

namespace ConsoleApp1
{
    class Scenario
    {
        internal void Calculate()
        {
            CalculateAccidentMasses();
            CalculateDamagingMasses();

            CalculateDamageZone();

            CalculateInjured();

            CalculateLoss();

            CalculateRisk();
        }
    }
}