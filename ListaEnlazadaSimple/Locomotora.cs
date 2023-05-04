using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazadaSimple {
    internal class Locomotora {
        private Vagon primero;

        public Locomotora() {
            primero = null;
        }

        public void AgregarInicio(String pasajero) {
            if (primero == null) {
                Vagon nuevo = new Vagon(pasajero);
                primero = nuevo;
            } else if ( primero.Sig == null) {
                Vagon nuevo = new Vagon(pasajero);

                Vagon priVag = primero;
                nuevo.Sig = priVag;

                primero = nuevo;
            } else {
                Vagon nuevo = new Vagon(pasajero);

                Vagon priVag = primero;
                nuevo.Sig = priVag;

                primero = nuevo;
            }
        }

        public void AgregarInicio2(String pasajero) {
            Vagon nuevo = new Vagon(pasajero);
            if (primero != null) {
                Vagon priVag = primero;
                nuevo.Sig = priVag;
            }
            primero = nuevo;
        }

        public void AgregarFinal(String pasajero) {
            if (primero == null) {
                Vagon nuevo = new Vagon(pasajero);
                primero = nuevo;
            } else if (primero.Sig == null) {
                Vagon nuevo = new Vagon(pasajero);

                Vagon priVag = primero;
                priVag.Sig = nuevo;

            } else {
                Vagon nuevo = new Vagon(pasajero);

                Vagon tmp = primero;
                while (tmp.Sig != null) {
                    tmp = tmp.Sig;
                }

                tmp.Sig = nuevo;
            }
        }

        public String Imprimir() {
            String tren = "";
            Vagon tmp = primero;
            while (tmp != null) {
                tren += tmp.Dato + ", ";
                tmp = tmp.Sig;
            }
            return tren;
        }
    }
}
