using System;
using System.Collections.Generic;
using System.Text;

namespace IRCalculator.Domain
{
    public class IRCalculator
    {
       
        const double _aliquotaZero = 1903.98;
        const double _aliquotaSeteMeio = 2826.65;
        const double _aliquotaQuinze = 3751.05;
        const double _aliquotaVinteDoisMeio = 4664.68;
        const double _aliquotaVinteSeteMeio = 4664.68;

        const double _aliquotaZeroPorcentagem = 0.0;
        const double _aliquotaSeteMeioPorcentagem = 7.5;
        const double _aliquotaQuinzePorcentagem = 15.0;
        const double _aliquotaVinteDoisMeioPorcentagem = 22.5;
        const double _aliquotaVinteSeteMeioPorcentagem = 27.5;

        double x, y, z, w = 0;
        public double _salario;

        public IRCalculator()
        {

        }
        public IRCalculator(double salario)
        {
            this._salario = salario;
        }

        public double CalculaSalario()
        {
      
            switch (this._salario)
            {
                case double n when (n <= _aliquotaZero): 
                    n = _salario - ((_aliquotaZeroPorcentagem /100) * _salario);

                    Console.WriteLine($"Meu salário {_salario} é abaixo de {_aliquotaZero} " +
                        $"portanto meu salário total é: {n}");

                    this._salario = n;
                    return this._salario;

                case double n when (n > _aliquotaZero && n <= _aliquotaSeteMeio):
                    n = _salario - ((_aliquotaSeteMeioPorcentagem / 100) * (_salario - _aliquotaZero));

                    Console.WriteLine($"Meu salário {_salario} é acima de {_aliquotaZero} " +
                         $"e abaixo de {_aliquotaSeteMeio} " +
                         $"portanto meu salário total é: {n}");

                    this._salario = n;
                    return this._salario;

                case double n when (n > _aliquotaSeteMeio && n <= _aliquotaQuinze):
                    x = ((_aliquotaQuinzePorcentagem / 100) * (_salario - _aliquotaSeteMeio));
                    y = ((_aliquotaSeteMeioPorcentagem / 100) * (_aliquotaSeteMeio - _aliquotaZero));
                    n = _salario - (x + y);

                    Console.WriteLine($"Meu salário {_salario} é acima de {_aliquotaSeteMeio} " +
                         $"e abaixo de {_aliquotaQuinze} " +
                         $"portanto meu salário total é: {n}");

                    this._salario = n;
                    return this._salario;

                case double n when (n > _aliquotaQuinze && n <= _aliquotaVinteDoisMeio):
                    x = ((_aliquotaVinteDoisMeioPorcentagem / 100) * (_salario - _aliquotaQuinze));
                    y = ((_aliquotaSeteMeioPorcentagem / 100) * (_aliquotaSeteMeio - _aliquotaZero));
                    z = ((_aliquotaQuinzePorcentagem / 100) * (_aliquotaQuinze - _aliquotaSeteMeio));
                    n = _salario - (x + y + z);

                    Console.WriteLine($"Meu salário {_salario} é acima de {_aliquotaQuinze} " +
                         $"e abaixo de {_aliquotaVinteDoisMeio} " +
                         $"portanto meu salário total é: {n}");

                    this._salario = n;
                    return this._salario;

                case double n when (n > _aliquotaVinteSeteMeio):

                    x = ((_aliquotaVinteSeteMeioPorcentagem / 100) * (_salario - _aliquotaVinteDoisMeio));
                    y = ((_aliquotaSeteMeioPorcentagem / 100) * (_aliquotaSeteMeio - _aliquotaZero));
                    z = ((_aliquotaQuinzePorcentagem / 100) * (_aliquotaQuinze - _aliquotaSeteMeio));
                    w = ((_aliquotaVinteDoisMeioPorcentagem / 100) * (_aliquotaVinteDoisMeio - _aliquotaQuinze));
                    n = _salario - (x + y +z + w);

                    Console.WriteLine($"Meu salário {_salario} é acima de {_aliquotaVinteSeteMeio} " +
                         $"portanto meu salário total é: {n}");

                    this._salario = n;
                    return this._salario;

                default:
                    return this._salario;
            }
        }
    }
}
