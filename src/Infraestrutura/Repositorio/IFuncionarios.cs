﻿using Dominio.Modelo;

namespace Infraestrutura.Repositorio
{
    public interface IFuncionarios
    {
        public List<Funcionario> ObterTodos();
        public void Criar(Funcionario novoFuncionario);
        public Funcionario ObterPorId(int id);
        public void Remover(int id);
        public Funcionario Atualizar(Funcionario funcionario);
        public Funcionario ObterPorCpf(string cpf);

    }
}
