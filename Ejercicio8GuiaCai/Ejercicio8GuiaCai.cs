using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8GuiaCai
{
    internal class Ejercicio8GuiaCai
    {
        /*
         

47. Se le ha solicitado codificar un simulador de atención al cliente para una obra social que opera con 3 cajas. El sistema se ha diseñado como una aplicación de consola que recibe del usuario los siguientes comandos:

a. “afiliado: [nombre]” – (Ej.: “afiliado:Perez”) le indica al sistema que el afiliado [nombre] se ha presentado en mesa de entradas (asuma que cada afiliado tiene un nombre único). Si hay una caja libre pasará directamente, si no quedará en espera.

b. “caja: [n]” – (Ej.:”caja:1”) le indica al sistema que la caja n (1, 2 o 3) está libre. Debe asignársele un cliente según el orden de presentación en mesa de entrada.

c. “fin” – Finaliza la ejecución.

Cualquier otro ingreso se considerará un error del operador, indicándose con un mensaje.

Luego de procesar cada comando el sistema mostrará:

a. La lista de afiliados en espera, según orden de atención.

b. El estado de cada caja (“libre” o el nombre del afiliado que está siendo atendido).

48. Se le ha solicitado codificar un sistema de seguimiento para el depósito de una empresa de logística. El sistema se ha diseñado como una aplicación de consola que recibe del usuario los siguientes comandos:

a. “Lote [código]” – (Ej.: “Lote ABC334”) – Indica que producción ha ingresado al depósito el lote cuyo código se indica. Los códigos de lote constan de 3 letras seguidas por 3 números.

b. “Camión [patente] Despacho [cantidad]” – (Ej.: “Camión ABCDEF Despacho 10”) Indica que ha arribado un camión identificado por [patente] (6 letras) que requiere ser cargado con [cantidad] de despachos.

Los camiones son atendidos por orden de llegada, y puestos en espera hasta que pueda completarse la carga. Los lotes son que llegan de producción son apilados, de manera tal que el último ingresado en producción será el primero en ser despachado.

Luego de procesar cada comando el sistema indicará:

a. Si se ha asignado un lote a un camión, la patente y el código de lote.

b. Si se ha completado un envío, la patente del camión despachado y la patente del próximo camión a despachar, de haber uno.

c. La cantidad de camiones en espera.

d. La cantidad de lotes en depósito.
         
         
         */

        public void ej47()
        {
            /* 47. Se le ha solicitado codificar un simulador de atención al cliente
             * para una obra social que opera con 3 cajas. El sistema se ha diseñado 
             * como una aplicación de consola que recibe del usuario los siguientes comandos:
             * a. “afiliado: [nombre]” – (Ej.: “afiliado:Perez”) 
             * le indica al sistema que el afiliado [nombre] se ha presentado 
             * en mesa de entradas (asuma que cada afiliado tiene un nombre único). 
             * Si hay una caja libre pasará directamente, si no quedará en espera.
             * b. “caja: [n]” – (Ej.:”caja:1”) le indica al sistema que la caja n (1, 2 o 3) está libre. 
             * Debe asignársele un cliente según el orden de presentación en mesa de entrada.
             * c. “fin” – Finaliza la ejecución.
             * Cualquier otro ingreso se considerará un error del operador, indicándose con un mensaje.
             * Luego de procesar cada comando el sistema mostrará:
             * a. La lista de afiliados en espera, según orden de atención.
             * b. El estado de cada caja (“libre” o el nombre del afiliado que está siendo atendido).*/
            Queue<string> cajas = new Queue<string>();

        }
    }
}
