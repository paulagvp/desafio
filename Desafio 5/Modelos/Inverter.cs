namespace Desafio5.Models
{
    public class Inverter{
        public string InverterTexto(string texto){
            string invertida = "";

            for (int i = texto.Length - 1; i >= 0; i--){
                invertida += texto[i];
            }
            return invertida;
        }
    }
}
