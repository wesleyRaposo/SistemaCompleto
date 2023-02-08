using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public static class Funcoes
    {
        public static String BooleanParaString(bool valor)
        {
            if(valor == true)
                return "S";
            else
                return "N";
        }

        public static bool ValidaEmail(String email)
        {
            if (email != "")
            {
                string modelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

                if (System.Text.RegularExpressions.Regex.IsMatch(email, modelo))
                    return true;
                else
                    return false;
            }
            else
            {
                //-Se não informar o email, não valida.
                return true;
            }
        }

        public static bool CharENumero(char key)
        {
            if (char.IsDigit(key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
