using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Principal
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public void AgregarCliente(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }

        public void CrearCuentaBancaria(CuentaBancaria cuenta)
        {
            context.CuentasBancarias.Add(cuenta);
            context.SaveChanges();
        }

        public void EmitirTarjetaCredito(TarjetaDeCredito tarjeta)
        {
            context.TarjetasDeCredito.Add(tarjeta);
            context.SaveChanges();
        }
        public void PausarTarjetaCredito(int tarjetaId)
        {
            var tarjeta = context.TarjetasDeCredito.Find(tarjetaId);
            if (tarjeta != null)
            {
                tarjeta.Estado = "Pausada";
                context.SaveChanges();
            }
        }
        public void RealizarDeposito(int cuentaId, double monto)
        {
            var cuenta = context.CuentasBancarias.Find(cuentaId);
            if (cuenta != null)
            {
                cuenta.Saldo += monto;
                context.SaveChanges();
            }
        }
        public void RealizarExtraccion(int cuentaId, double monto)
        {
            var cuenta = context.CuentasBancarias.Find(cuentaId);
            if (cuenta != null && cuenta.Saldo >= monto)
            {
                cuenta.Saldo -= monto;
                context.SaveChanges();
            }
        }
        public void RealizarTransferencia(int cuentaOrigenId, int cuentaDestinoId, double monto)
        {
            var cuentaOrigen = context.CuentasBancarias.Find(cuentaOrigenId);
            var cuentaDestino = context.CuentasBancarias.Find(cuentaDestinoId);

            if (cuentaOrigen != null && cuentaDestino != null && (cuentaOrigen.Saldo >= monto))
            {
                cuentaOrigen.Saldo -= monto;
                cuentaDestino.Saldo += monto;
                context.SaveChanges();
            }
        }
        public bool PagarTarjetaCredito(int tarjetaId, double monto)
        {
            var tarjeta = context.TarjetasDeCredito.Find(tarjetaId);
            if (tarjeta != null && tarjeta.Estado == "Activa")
            {
                if (monto <= tarjeta.MontoDeuda)
                {
                    tarjeta.MontoDeuda -= monto;
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            else { return false; }
        }
        public string GenerarResumenTarjeta(int tarjetaId)
        {
            var resumen = context.TarjetasDeCredito.Find(tarjetaId);
            if (resumen != null)
            {
                return "Numero Tarjeta: " + resumen.NumeroTarjeta + "\n" + "Estado: " + resumen.Estado + "\n" + "Saldo Disponible: " + resumen.SaldoDisponible + "\n" + "Monto Deuda: " + resumen.MontoDeuda;
            }
            else return "Error";
        }
        public List<TarjetaDeCredito> DevolverListaTarjeta()
        {
            return context.TarjetasDeCredito.ToList();
        }
        public List<Cliente> DevolverListaClientes()
        {
            return context.Clientes.ToList();
        }
        public List<CuentaBancaria> DevolverListaCuentaBancaria()
        {
            return context.CuentasBancarias.ToList();
        }

    }
}
        