﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Cliente
    {
        String _IdCliente;
        String _Identificacion;
        String _Nombre;
        String _Credito;
        String _Estado;
        String _IdDireccion;

        public string IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public string Identificacion { get => _Identificacion; set => _Identificacion = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Credito { get => _Credito; set => _Credito = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string IdDireccion { get => _IdDireccion; set => _IdDireccion = value; }

        //CRUD
        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"exec AgregarClientes '" + _Identificacion + "', '" + _Nombre + "', " + _Credito + ", " + _Estado + ", " + _IdDireccion + ";";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasInsertadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"exec ModificarClientes " + _IdCliente + ", '" + _Identificacion + "', '" + _Nombre + "', " + _Credito + ", " + _Estado + ", " + _IdDireccion + ";";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasInsertadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasEliminadas = 0;
            try
            {
                Sentencia = @"exec EliminarClientes " + _IdCliente + ";";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasEliminadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasEliminadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
    }
}
