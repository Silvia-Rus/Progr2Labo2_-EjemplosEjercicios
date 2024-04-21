using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boligrafo
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        ConsoleColor color;
        short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor getColor()
        {
            return this.color;
        }
        
        public short getTinta()
        {
            return this.tinta;  
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "";
            bool retorno = false;
            for (int i = 0; i < gasto; i++)
            {
                if (this.getTinta() > 0)
                {
                    dibujo += "*";
                    this.setTinta(-1);
                    Console.ForegroundColor = this.getColor();
                    retorno =  true;
                }
                else
                {
                    if (i > 0)
                    {
                        break;
                    }
                }
            }
            return retorno;
        }

        public void Recargar()
        {
            this.setTinta(cantidadTintaMaxima);
        }

        //SET TINTA POR ESCENARIOS
        private void setTinta(short tinta)
        {
            int validador = this.tinta + tinta;

            if(validador < cantidadTintaMaxima && validador > -1) //E1: La operación no sale de rango ni por arriba ni por abajo
            {
                this.tinta += tinta;
            }
            else if (validador >= cantidadTintaMaxima) //E2: La operación hacía que pusiéramos más del máximo de tina
            {
                this.tinta = cantidadTintaMaxima;
            }
            else //E3: La operación gasta toda la tinra
            {
                this.tinta = 0;
            }
        }

        //SET TINTA POR PROGRESO
        private void setTinta2(short tinta)
        {

            while(this.tinta > 0 && this.tinta < cantidadTintaMaxima)
            {
                this.tinta += tinta;
            }

        }


    }
}
