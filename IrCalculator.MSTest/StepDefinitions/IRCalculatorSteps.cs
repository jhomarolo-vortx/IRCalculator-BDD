using IRCalculator.MSTest.Driver;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace IRCalculator.MSTest.steps
{
    [Binding]
    public sealed class IRCalculatorSteps
    {
  
        private readonly ScenarioContext context;
        private readonly IRCalculatorDriver _driver;

        public IRCalculatorSteps(ScenarioContext injectedContext, IRCalculatorDriver driver)
        {
            context = injectedContext;
            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }

        [Given(@"um novo cálculo de IR")]
        public void GivenNovoCalculo()
        {
            _driver.NewCalc();
          
        }

        [Given(@"preencho a propriedade salário com o valor (.*)")]
        public void GivenAdicionoOSalario(string salario)
        {
            _driver.AdicionarSalario(Convert.ToDouble(salario));
           
        }

        [When(@"executo o cálculo do IR")]
        public void WhenExecutoCalculo()
        {
            _driver.CalcularIR();
          
        }

        [Then("o salário liquido deverá ser (.*)")]
        public void ThenTheResultShouldBe(string salarioEsperado)
        {
            _driver.ChecarSalario(Convert.ToDouble(salarioEsperado));
           
        }
    }
}
