using System;
using System.Collections.Generic;
using System.Text;

namespace Sorteio.Entities
{
    class Participante
    {
        public int ParticipanteID { get; set; }
        public string Nome { get; set; }

        public Participante(int participanteID, string nome)
        {
            ParticipanteID = participanteID;
            Nome = nome;
        }

        public override string ToString()
        {
            return ParticipanteID + " - " + Nome;
        }
    }
}
