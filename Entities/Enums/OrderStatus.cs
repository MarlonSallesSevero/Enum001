using System;

namespace EnumeracaotEx001.Entities.Enums
{
    enum OrderStatus : int
    {
        PagamentoPendente = 0,
        Processando = 1,
        Enviado = 2,
        Entregue = 3
    }
}