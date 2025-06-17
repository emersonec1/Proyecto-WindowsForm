using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GymProject
{
    class Helper
    {
        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;                
        }
        public bool ValidarEmail(string email)
        {
            //regex o expresión regular con el formato del correo
            string formato = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            //comparamos el email con el formato, por medio de regex
            if (Regex.IsMatch(email, formato))
                //si hay coincidencia entrega true sino false
                if (Regex.Replace(email, formato, string.Empty).Length == 0)
                    return true;
            return false;
        }
        //formatear run
        public string FormatearRun(string rut)
        {
            int cont = 0;
            string format;
            if (rut.Length == 0)
            {
                return "";
            }
            else
            {
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                format = "-" + rut.Substring(rut.Length - 1);
                for (int i = rut.Length - 2; i >= 0; i--)
                {
                    format = rut.Substring(i, 1) + format;
                    cont++;
                    if (cont == 3 && i != 0)
                    {
                        format = "." + format;
                        cont = 0;
                    }
                }
                return format;
            }
        }
        //validar run
        public bool ValidarRun(string rut)
        {
            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                if (dv == (char)(s != 0 ? s + 47 : 75))
                    validacion = true;
            }
            catch (Exception)
            {
            }
            return validacion;
        }
    }
}
