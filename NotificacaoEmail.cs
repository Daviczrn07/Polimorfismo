using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    internal class NotificacaoEmail : INotificacao
    {
        public void Enviar()
        {
            Console.WriteLine("ENVIANDO NOTIFICAÇÃO POR EMAIL...");
        }

        public void Enviar(string anexo)
        {
            Console.WriteLine($"ENVIANDO EMAIL COM ANEXO: {anexo}");
        }
    }
}
