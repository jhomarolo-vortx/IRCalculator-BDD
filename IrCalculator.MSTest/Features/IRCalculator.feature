#language:pt-br

Funcionalidade: Cálculo do valor do IR
	Enquanto contribuinte	
	Eu gostaria de calcular o IR
	Para saber quanto vou pagar de imposto

Cenário: Salário de 680 reais fica isento
	Dado um novo cálculo de IR
	E preencho a propriedade salário com o valor 680
	Quando executo o cálculo do IR
	Então o salário liquido deverá ser 680

Cenário: Salário de 6357 reais não fica isento
	Dado um novo cálculo de IR
	E preencho a propriedade salário com o valor 6357,66
	Quando executo o cálculo do IR
	Então o salário liquido deverá ser 5478,66

Cenário: Salário de 3152 reais não fica isento
	Dado um novo cálculo de IR
	E preencho a propriedade salário com o valor 3152,38
	Quando executo o cálculo do IR
	Então o salário liquido deverá ser 3034,31

Cenário: Salário de 16837 reais não fica isento
	Dado um novo cálculo de IR
	E preencho a propriedade salário com o valor 16837,66
	Quando executo o cálculo do IR
	Então o salário liquido deverá ser 13076,66