using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SondaIT.SuperSisAmigos.DomainModel.Models;

namespace SondaIT.SuperSisAmigos.Repository.Repositories
{
    // sealed : SELA NOSSA CLASSE, HERDAMOS A BaseRepository E INJETAMOS A CLASSE MODELO
    // DESSA FORMA ESTAMOS UTILIZANDO O REPOSITORIO GENERICO, FORMA SENIOR DE REUTILIZAR CODIGO
    public sealed class LoginRepository:Abstracts.BaseRepository<LoginModel>
    {
        // AQUI FIZEMOS O MISTICO O FALADO O TEMIDO POLIMORFISMO
        // PARA SE CARACTERIZAR O POLIMORFISMO TEMOS QUE TRABALHAR COM HERANÇA DE CLASSES
        // A CLASSE BASE OU SUPER CLASSE OU CLASSE PAI É HERDADA PELAS CLASSESS
        // DERIVADAS(CLASSES FILHAS), OS METODOS NA CLASSE PAI TEM QUE ESTAR COM 
        // A PALAVRA RESERVADA virtual, PARA QUE NA CLASSE FILHA QUANDO DIGITARMOS
        // override O METODO ESTEJA DISPONIVEL PARA SER SOBREESCRITO
        public override void Add(LoginModel entity)
        {
            
            // SE DEIXARMOS A PALAVRA base NA IMPLEMENTAÇÃO, MANTEMOS O COMPORTAMENTO 
            // DA CLASSE BASE
            base.Add(entity);
        }
        // COMO NÃO TEMOS UM METODO ESPECIFICO DE LOGIN, IREMOS CRIAR O MESMO
        // AQUI NO REPOSITORY

        public List<LoginModel> Autentication(LoginModel entity)
        {
            // CRIAMOS UMA VARIAVEL CHAMADA QUERY QUE RECEBERA O RETORNO DOS
            // DADOS VINO DO BANCO, TULIZAMOS O METODO GetAll DO BASE REPOSITORY
            // E PASSAMOS A EXPRESSÃO LAMBDA PARA ELE
            // Equals = MELHOR FORMA DE SE COMPARAR COM EXATIDÃO UMA STRING
            var query = GetAll(c => c.USUARIO.Equals(entity.USUARIO)
                                && c.SENHA.Equals(entity.SENHA)).ToList();

            return query;
        } 

    }
}
