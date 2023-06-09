﻿using Dominio;
using Dominio.Modelo;

namespace Infraestrutura.Repositorio
{
    internal class RepositorioFuncionario : IRepositorioFuncionario
    {
        public List<Funcionario> ObterTodos()
        {
            return SingletonFuncionarios.ObterInstancia();
        }

        public Funcionario ObterPorId(int id)
        {
            foreach (Funcionario funcionario in SingletonFuncionarios.ObterInstancia())
            {
                if (funcionario.Id == id)
                {
                    return funcionario;
                }
            }
            return null;
        }

        public void Criar(Funcionario novoFuncionario)
        {
            SingletonFuncionarios.ObterInstancia().Add(novoFuncionario);
            SingletonFuncionarios.AdicionarIDFuncionario(novoFuncionario);
        }

        public void Remover(int id)
        {
            var funcionarioARemover = ObterPorId(id);
            SingletonFuncionarios.ObterInstancia().Remove(funcionarioARemover);
        }

        public Funcionario Atualizar(Funcionario funcionarioASerAtualizado)
        {
            foreach (Funcionario funcionario in SingletonFuncionarios.ObterInstancia())
            {
                if (funcionario.Id == funcionarioASerAtualizado.Id)
                {
                    funcionario.Nome = funcionarioASerAtualizado.Nome;
                    funcionario.CPF = funcionarioASerAtualizado.CPF;
                    funcionario.Endereco = funcionarioASerAtualizado.Endereco;
                    funcionario.Telefone = funcionarioASerAtualizado.Telefone;
                    funcionario.DataNascimento = funcionarioASerAtualizado.DataNascimento;
                    funcionario.DataAdmissao = funcionarioASerAtualizado.DataAdmissao;
                }
            }
            return funcionarioASerAtualizado;
        }
        public Funcionario ObterPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }
    }
}
