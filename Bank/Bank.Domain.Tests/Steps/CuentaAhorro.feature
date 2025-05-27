Feature: Como cliente quiero realizar depositos y retiros para modificar mi saldo de cuenta

Scenario: Cliente deposita en su cuenta un monto y es correcto
	Given la nueva cuenta numero 12345
	When deposito 10
	Then el saldo nuevo deberia ser 10

Scenario: Cliente retira en su cuenta un monto y es correcto
	Given la nueva cuenta numero 12345
    And con saldo 10
	When retiro 10
	Then el saldo nuevo deberia ser 0

Scenario: Cliente retira en su cuenta un monto negativo y es incorrecto
	Given la nueva cuenta numero 12345
    And con saldo 10
	When retiro -10
	Then deberia ser error
Scenario: Cancelar una cuenta activa
    Given la nueva cuenta numero 12345
    When cancelo la cuenta
    Then la cuenta deberia estar cancelada

Scenario: Cancelar cuenta y luego intentar depositar (verificación futura opcional)
    Given la nueva cuenta numero 67890
    When cancelo la cuenta
    Then la cuenta deberia estar cancelada