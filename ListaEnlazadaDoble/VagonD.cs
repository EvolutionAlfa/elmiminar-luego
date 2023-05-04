using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazadaDoble {
    internal class VagonD {
        private string dato;
        public string Dato { get => dato; set => dato = value; }

        public VagonD Sig { get; set; }
        public VagonD Ant { get; set; }

        public VagonD() {
        }

        public VagonD(string dato) {
            Dato = dato;
            Sig = null;
            Ant = null;
        }
    }
}
