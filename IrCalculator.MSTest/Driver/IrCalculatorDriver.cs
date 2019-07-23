using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;

namespace IRCalculator.MSTest.Driver
{
    public class IRCalculatorDriver
    {
        private Domain.IRCalculator _calculator;

        public void NewCalc()
        {
            _calculator = new Domain.IRCalculator();
        }

        public void AdicionarSalario(double salario)
        {
            _calculator._salario = salario;
        }

        public void CalcularIR()
        {            
            _calculator.CalculaSalario();
        }

        public void ChecarSalario(double salarioEsperado)
        {
            _calculator._salario.Should().BeApproximately(salarioEsperado,1);
        }
    }
}
