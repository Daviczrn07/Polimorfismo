using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    internal class NotificacaoPush : INotificacao
    {
        public void Enviar()
        {
            Console.WriteLine("ENVIANDO NOTIFICAÇÃO PUSH PARA O APP...");
        }
    }
}
