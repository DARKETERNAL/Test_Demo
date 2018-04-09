using System;

namespace Fundamentos_Demo
{
    class CalculadorDevueltas
    {
        int CalcularMonedas(int valorDevuelta, int denominacion)
        {
            int resultado = 0;

            if (valorDevuelta > 0)
            {
                resultado = valorDevuelta / denominacion;
            }

            return resultado;
        }

        public void CalcularDevuelta(int dineroTotal, int precioProducto)
        {
            int devuelta = 0;

            int monedas500 = 0;
            int monedas200 = 0;
            int monedas100 = 0;
            int monedas50 = 0;
            int monedas20 = 0;
            int monedas10 = 0;

            if (dineroTotal >= precioProducto)
            {
                devuelta = dineroTotal - precioProducto;
                int devueltaTotal = devuelta;

                if (devuelta == 0)
                {
                    Console.WriteLine("No hay devuelta");

                }
                else
                {
                    monedas500 = CalcularMonedas(devuelta, 500);
                    devuelta = devuelta % 500;
                    monedas200 = CalcularMonedas(devuelta, 200);
                    devuelta = devuelta % 200;
                    monedas100 = CalcularMonedas(devuelta, 100);
                    devuelta = devuelta % 100;
                    monedas50 = CalcularMonedas(devuelta, 50);
                    devuelta = devuelta % 50;
                    monedas20 = CalcularMonedas(devuelta, 20);
                    devuelta = devuelta % 20;
                    monedas10 = CalcularMonedas(devuelta, 10);
                    devuelta = devuelta % 10;

                    //monedas500 = devuelta / 500;
                    //devuelta = devuelta % 500;

                    //if (devuelta > 0)
                    //{
                    //    monedas200 = devuelta / 200;
                    //    devuelta = devuelta % 200;

                    //    if (devuelta > 0)
                    //    {
                    //        monedas100 = devuelta / 100;
                    //        devuelta = devuelta % 100;

                    //        if (devuelta > 0)
                    //        {
                    //            monedas50 = devuelta / 50;
                    //            devuelta = devuelta % 50;

                    //            if (devuelta > 0)
                    //            {
                    //                monedas20 = devuelta / 20;
                    //                devuelta = devuelta % 20;

                    //                if (devuelta > 0)
                    //                {
                    //                    monedas10 = devuelta / 10;
                    //                    devuelta = devuelta % 10;

                    //                    if (devuelta > 0)
                    //                    {
                    //                        Console.WriteLine("No puedo devolver más");
                    //                    }
                    //                }
                    //            }
                    //        }
                    //    }
                    //}
                }
                Console.WriteLine(
                    string.Format("La devuelta {0} será entregada en {1} monedas de 500, {2} monedas de 200, {3} monedas de 100, {4} monedas de 50, {5} monedas de 20 y {6} monedas de 10",
                    devueltaTotal, monedas500, monedas200, monedas100, monedas50, monedas20, monedas10));
            }            
            else
            {
                Console.WriteLine("Hace falta dinero para completar el pedido");
            }
        }
    }
}
