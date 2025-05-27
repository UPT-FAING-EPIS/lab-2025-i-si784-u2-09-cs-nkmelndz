
namespace Bank.Domain
{
    /// <summary>
    /// Representa una cuenta de ahorro de un cliente.
    /// </summary>
    public class CuentaAhorro
    {
        /// <summary>
        /// Mensaje de error cuando el monto es menor o igual a cero.
        /// </summary>
        public const string ERROR_MONTO_MENOR_IGUAL_A_CERO = "El monto no puede ser menor o igual a 0";

        /// <summary>
        /// Identificador único de la cuenta.
        /// </summary>
        public int IdCuenta { get; private set; }

        /// <summary>
        /// Número único de la cuenta.
        /// </summary>
        public string NumeroCuenta { get; private set; }

        /// <summary>
        /// Cliente propietario de la cuenta.
        /// </summary>
        public virtual Cliente Propietario { get; private set; }

        /// <summary>
        /// Identificador del cliente propietario.
        /// </summary>
        public int IdPropietario { get; private set; }

        /// <summary>
        /// Tasa de interés anual aplicada a la cuenta.
        /// </summary>
        public decimal Tasa { get; private set; }

        /// <summary>
        /// Saldo actual de la cuenta.
        /// </summary>
        public decimal Saldo { get; private set; }

        /// <summary>
        /// Fecha de apertura de la cuenta.
        /// </summary>
        public DateTime FechaApertura { get; private set; }

        /// <summary>
        /// Indica si la cuenta está activa o cancelada.
        /// </summary>
        public bool Estado { get; private set; }

        /// <summary>
        /// Crea una nueva cuenta de ahorro para un cliente.
        /// </summary>
        /// <param name="_numeroCuenta">Número de cuenta.</param>
        /// <param name="_propietario">Cliente propietario.</param>
        /// <param name="_tasa">Tasa de interés.</param>
        /// <returns>Instancia de <see cref="CuentaAhorro"/>.</returns>
        public static CuentaAhorro Aperturar(string _numeroCuenta, Cliente _propietario, decimal _tasa)
        {
            return new CuentaAhorro()
            {
                NumeroCuenta = _numeroCuenta,
                Propietario = _propietario,
                IdPropietario = _propietario.IdCliente,
                Tasa = _tasa,
                Saldo = 0
            };
        }

        /// <summary>
        /// Deposita un monto a la cuenta.
        /// </summary>
        /// <param name="monto">Monto a depositar. Debe ser mayor que cero.</param>
        /// <exception cref="Exception">Si el monto es menor o igual a cero.</exception>
        public void Depositar(decimal monto)
        {
            if (monto <= 0)
                throw new Exception(ERROR_MONTO_MENOR_IGUAL_A_CERO);
            Saldo += monto;
        }

        /// <summary>
        /// Retira un monto de la cuenta.
        /// </summary>
        /// <param name="monto">Monto a retirar. Debe ser mayor que cero.</param>
        /// <exception cref="Exception">Si el monto es menor o igual a cero.</exception>
        public void Retirar(decimal monto)
        {
            if (monto <= 0)
                throw new Exception(ERROR_MONTO_MENOR_IGUAL_A_CERO);
            Saldo -= monto;
        }

        /// <summary>
        /// Cancela la cuenta, desactivando su estado.
        /// </summary>
        public void Cancelar()
        {
            Estado = false;
        }
    }
}