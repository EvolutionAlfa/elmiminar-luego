using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazadaSimple {
    internal class Vagon {
        private string dato;
        public string Dato { get => dato; set => dato = value; }

        public Vagon Sig { get; set;}

        public Vagon() {
        }

        public Vagon(string dato) {
            Dato = dato;
            Sig = null;
        }
    }
}
