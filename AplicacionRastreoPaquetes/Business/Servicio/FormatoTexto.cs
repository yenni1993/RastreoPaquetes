using AplicacionRastreoPaquetes.Business.Interface;
using System;
using System.Globalization;
using System.Text;

namespace AplicacionRastreoPaquetes.Business.Servicio
{
    public class FormatoTexto : IFormatoTexto
    {
        public string AplicarFormato(string _cTexto)
        {
            string cTextoNormalizado = _cTexto.Normalize(NormalizationForm.FormD);
            StringBuilder cTextoBuilder = new StringBuilder();

            for (int i = 0; i < cTextoNormalizado.Length; i++)
            {
                Char c = cTextoNormalizado[i];
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    cTextoBuilder.Append(c);
            }

            return cTextoBuilder.ToString();
        }
    }
}
