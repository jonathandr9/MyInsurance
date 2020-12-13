﻿using System.Collections.Generic;

namespace HinovaProvaAdapter.Clients
{
    public class ListaOficina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string DescricaoCurta { get; set; }
        public string Endereco { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Foto { get; set; }
        public int AvaliacaoUsuario { get; set; }
        public int CodigoAssociacao { get; set; }
        public string Email { get; set; }
        public string Telefone1 { get; set; }
        public object Telefone2 { get; set; }
        public bool Ativo { get; set; }
    }

    public class RetornoErro
    {
        public object retornoErro { get; set; }
    }

    public class ConsultarOficinasGetResult
    {
        public List<ListaOficina> ListaOficinas { get; set; }
        public RetornoErro RetornoErro { get; set; }
        public object Token { get; set; }
    }


}
