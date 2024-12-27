﻿namespace CarteiradeContatos
{
    public class EntityBase
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime? DataAtualizacao { get; set; }

        public void AtualizarDataAtualizacao()
        {
            DataAtualizacao = DateTime.Now;
        }
    }

}