using IRCalculator.XUnit.Driver;
using System;
using System.Globalization;
using Xbehave;
using Xunit;

namespace IRCalculator.XUnit
{
    public class IrCalculatorFeature
    {
        private readonly IRCalculatorDriver _driver;

        public IrCalculatorFeature()
        {
            _driver = new IRCalculatorDriver();
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }

        [Scenario]
        [Example(680, 680)]
        [Example(6357.66, 5478.66)]
        [Example(3152.38, 3034.31)]
        [Example(16837.66, 13076.66)]
        public void CalcularIR(double salario, int salarioExperado)
        {
            $"Dado um novo cálculo de IR"
                 .x(() => { _driver.NewCalc(); });
     
            $"E preencho a propriedade salário com o valor {salario}"
                .x(() => { _driver.AdicionarSalario(salario); });

            "Quando executo o cálculo do IR"
                .x(() => { _driver.CalcularIR(); });

            $"Então o salário liquido deverá ser {salarioExperado}"
                .x(() => { _driver.ChecarSalario(salarioExperado); });

        }
    }
}
