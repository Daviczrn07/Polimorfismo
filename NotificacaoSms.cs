using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    internal class NotificacaoSms : INotificacao
    {
        public void Enviar()
        {
            Console.WriteLine("ENVIANDO NOTIFICAÇÃO POR SMS...");
        }
    }
}
