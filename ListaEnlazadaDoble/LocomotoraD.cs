using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazadaDoble
{
    internal class LocomotoraD
    {
        private VagonD primero;
        private VagonD ultimo;

        public LocomotoraD()
        {
            primero = null;
            ultimo = null;
        }

        public void AgregarInicio(String pasajero)
        {
            if (primero == null)
            {
                VagonD nuevo = new VagonD(pasajero);
                primero = nuevo;
                ultimo = nuevo;
            }
            else if (primero.Sig == null)
            {
                VagonD nuevo = new VagonD(pasajero);

                VagonD priVag = primero;
                nuevo.Sig = priVag;
                priVag.Ant = nuevo;

                primero = nuevo;
            }
            else
            {
                VagonD nuevo = new VagonD(pasajero);

                VagonD priVag = primero;
                nuevo.Sig = priVag;
                priVag.Ant = nuevo;

                primero = nuevo;
            }
        }

        public void AgregarInicio2(String pasajero)
        {
            VagonD nuevo = new VagonD(pasajero);
            if (primero == null)
            {
                ultimo = nuevo;
            }
            else
            {
                VagonD priVag = primero;
                nuevo.Sig = priVag;
                priVag.Ant = nuevo;
            }
            primero = nuevo;
        }

        public void AgregarFinal(String pasajero)
        {
            if (primero == null)
            {
                VagonD nuevo = new VagonD(pasajero);
                primero = nuevo;
                ultimo = nuevo;
            }
            else if (primero.Sig == null)
            {
                VagonD nuevo = new VagonD(pasajero);

                VagonD priVag = primero;
                priVag.Sig = nuevo;
                nuevo.Ant = priVag;
                ultimo = nuevo;
            }
            else
            {
                VagonD nuevo = new VagonD(pasajero);

                VagonD ultVag = ultimo;
                ultVag.Sig = nuevo;
                nuevo.Ant = ultVag;
                ultimo = nuevo;
            }
        }

        public String Imprimir()
        {
            String tren = "";
            VagonD tmp = primero;
            while (tmp != null)
            {
                tren += tmp.Dato + ", ";
                tmp = tmp.Sig;
            }
            return tren;
        }
        public int Contar()
        {
            int cont = 0;
            VagonD tmp = primero;
            while (tmp != null)
            {
                cont++;
                tmp = tmp.Sig;
            }
            return cont;
        }

        public string Get(int pos)
        {
            int indice = -1;
            VagonD tmp = primero;

            while (tmp != null)
            {
                indice++;
                if (indice == pos)
                {
                    return tmp.Dato;
                }
                return "";

            }

        }

    }
}