﻿namespace Hardware_house.Infra.Entities
{
    public class Fornecedor
    {
        public int id { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string uf { get; set; }
        public string cidade { get; set; }
        public string cnpj { get; set; }
        public string nomeEmpresa { get; set; }
    }
}
