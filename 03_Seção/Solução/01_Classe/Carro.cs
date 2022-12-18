using System.Drawing;
using System.Reflection.PortableExecutable;

namespace _01_Classe
{
    class Carro
    {
        string marca = "chefrole"; //Toda vez que eu me referir essa clsse ele já vem com essa "Pré definição", podendo alterar mais para frente.
        string modelo;
        string cor;
        bool luzesinternas; // Propriedades

        void abrir()// Metodos
        {
            luzesinternas = true;
        }
        void fechar()
        {
            luzesinternas = false;
        }

        string acenderfarol()
        {
            return "medio";
        }

    }
}
