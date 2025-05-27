namespace Bank.Domain
{
    /// <summary>
    /// Representa un cliente del banco.
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Identificador único del cliente.
        /// </summary>
        public int IdCliente { get; private set; }

        /// <summary>
        /// Nombre completo del cliente.
        /// </summary>
        public string NombreCliente { get; private set; }

        /// <summary>
        /// Crea una nueva instancia de cliente con el nombre especificado.
        /// </summary>
        /// <param name="_nombre">Nombre del cliente.</param>
        /// <returns>Instancia de <see cref="Cliente"/>.</returns>
        public static Cliente Registrar(string _nombre)
        {
            return new Cliente()
            {
                NombreCliente = _nombre
            };
        }
    }
}

