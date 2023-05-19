using System;
using System.Data;

namespace SessionManager
{
    public class Session
    {
        //Atributos
        static Session _Instancia = null;
        static readonly Object _codelock = new Object();

        String _usuario;
        String _id_usuario;
        String _rol;
        String _id_rol;



        //Propiedades
        public static Session Instancia
        {
            get
            {
                if (_Instancia == null)
                {
                    lock (_codelock)
                    {
                        if (_Instancia == null)
                        {
                            _Instancia = new Session();
                        }
                    }
                }
                return _Instancia;
            }
        }

        public string usuario { get => _usuario; }
        public string id_usuario { get => _id_usuario; }
        public string rol { get => _rol; }
        public string id_rol { get => _id_rol; }


        //Metodos
        private Session()
        {


        }
        public Boolean IniciarSesion(String pUsuario, String pClave)
        {
            Boolean result = false;
            DataTable Resultado = new DataTable();
            try
            {
                Resultado = DataManager.DBConsultas.VALIDAR_USUARIO(pUsuario, pClave);
                if (Resultado.Rows.Count == 1)
                {
                    _id_usuario = Resultado.Rows[0]["id_usuario"].ToString();
                    _usuario = Resultado.Rows[0]["usuario"].ToString();
                    _id_rol = Resultado.Rows[0]["id_rol"].ToString();
                    _rol = Resultado.Rows[0]["rol"].ToString();
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }
    }
}
