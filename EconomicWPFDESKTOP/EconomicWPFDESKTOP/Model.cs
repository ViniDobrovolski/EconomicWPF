using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Linq;
using E_conomic.Class;
using EconomicWPFDESKTOP.Class;

namespace E_conomic
{
    public class Model
    {
        #region Operações com o Usuário
        public void SetUsuario(DbUsuarios u)
        {
            Context db = new Context();

            db.usuario.Add(u);
            db.SaveChanges();
        }

        public usuarioLogin LoginUsuario(string email, string senha)
        {
            Context db = new Context();

            var result = (from a in db.usuario
                          where (a.email == email && a.senha == senha)
                          select new usuarioLogin
                          {
                              id = a.id,
                              email = a.email,
                              senha = a.senha

                          }).FirstOrDefault();
            return result;
        }

        public void EditUsuario(DbUsuarios u)
        {
            Context db = new Context();
            DbUsuarios e = db.usuario.FirstOrDefault(p => p.id == u.id);
            e.nomecompleto = u.nomecompleto;
            e.email = u.email;
            e.senha = u.senha;
            e.telefone = u.telefone;
            e.rendamensal = u.rendamensal;

            db.SaveChanges();
        }

        public void DeletarUsuario(int id)
        {
            Context db = new Context();
            DbUsuarios u = db.usuario.FirstOrDefault(p => p.id == id);
            db.usuario.Remove(u);
            db.SaveChanges();
        }

        public dtoUsuario GetUsuarioId(int id)
        {
            Context db = new Context();
            var result = (from a in db.usuario
                          where a.id == id
                          select new dtoUsuario
                          {
                              id = a.id,
                              nomecompleto = a.nomecompleto,
                              email = a.email,
                              senha = a.senha,
                              telefone = a.telefone,
                              rendamensal = a.rendamensal

                          }).FirstOrDefault();

            var result1 = db.usuario.Where(p => p.id == id).FirstOrDefault();

            return result;
        }

        public decimal GetUsuarioRenda(int idusuario)
        {

            Context db = new Context();
            var result = (from a in db.usuario
                          where a.id == idusuario
                          select new dtoUsuario
                          {
                              rendamensal = a.rendamensal

                          }).FirstOrDefault();


            return result.rendamensal;  
        }

        public decimal resultadoSoma;
        public decimal resultadoSomaAno;

        public decimal GetSomaGastosMensais(int idusuario, int mes)
        {
           
            Context db = new Context();
            List<dtoGasto> result = (from a in db.gasto
                                     where a.usuarioid == idusuario &&
                                     a.datagasto.Month == mes
                                     select new dtoGasto
                                     {

                                        
                                         valor = a.valor
                                         
                                     }).ToList();


            foreach (dtoGasto dtoUsuario in result)
            {
                resultadoSoma += dtoUsuario.valor;
            }

            return resultadoSoma;
            
    }
        public decimal GetSomaGastosAnuais(int idusuario, int ano)
        {

            Context db = new Context();
            List<dtoGasto> result = (from a in db.gasto
                                     where a.usuarioid == idusuario &&
                                     a.datagasto.Year == ano
                                     select new dtoGasto
                                     {


                                         valor = a.valor

                                     }).ToList();


            foreach (dtoGasto dtoUsuario in result)
            {
                resultadoSomaAno += dtoUsuario.valor;
            }

            return resultadoSomaAno;

        }
        #endregion

        #region Operações com o tipo de gasto
        public void SetTipoGasto(tipoGastos u)
        {
            Context db = new Context();

            db.tipogasto.Add(u);
            db.SaveChanges();
        }

        public void EditTipoGasto(tipoGastos u)
        {
            Context db = new Context();

            tipoGastos e = db.tipogasto.FirstOrDefault(p => p.id == u.id);
            e.nomegasto = u.nomegasto;

            db.SaveChanges();
        }

        public void DeletarTipoGasto(int id)
        {
            try
            {
                Context db = new Context();
                tipoGastos u = db.tipogasto.FirstOrDefault(p => p.id == id);
                db.tipogasto.Remove(u);
                db.SaveChanges();
            }
            

            catch(Exception ex)
            {
                
            }
        }

        public List<dtoTipo> ListTipoGastos()
        {
            Context db = new Context();
            List<dtoTipo> result = (from a in db.tipogasto
                                    select new dtoTipo
                                    {
                                        id = a.id,
                                        nomegasto = a.nomegasto
                                    }).ToList();

            return new List<dtoTipo>(result);
        }


        public tipoGastos GetTipoGasto(int id)
        {
            Context db = new Context();
            var result = (from a in db.tipogasto
                          where a.id == id
                          select new tipoGastos
                          {
                              id = a.id,
                              nomegasto = a.nomegasto
                          }).FirstOrDefault();

            var result1 = db.tipogasto.Where(p => p.id == id).FirstOrDefault();

            return result;
        }

        public decimal getTotalTipo(int tip)
        {
            Context db = new Context();
            var result = (from a in db.gasto
                          where a.tipoid == tip
                          select new dtoGraficoMenu
                          {
                              soma = a.valor,
                              
                          }).ToList();

            var somar = result.Sum(i => i.soma);


            return somar;
        }
        #endregion

        #region Operações com o novo gasto

        public void SetGasto(DbnovoGasto u)
        {
            Context db = new Context();

            db.gasto.Add(u);
            db.SaveChanges();
        }

        public void EditGasto(DbnovoGasto u)
        {
            Context db = new Context();
            DbnovoGasto e = db.gasto.FirstOrDefault(p => p.id == u.id);
            e.nome = u.nome;
            e.valor = u.valor;
            e.descricao = u.descricao;
            e.tipoid = u.tipoid;


            db.SaveChanges();
        }

        public void DeletarGasto(int id)
        {
            Context db = new Context();
            DbnovoGasto u = db.gasto.FirstOrDefault(p => p.id == id);
            db.gasto.Remove(u);
            db.SaveChanges();
        }
        public dtoGasto GetGasto(int id)
        {
            Context db = new Context();
            var result = (from a in db.gasto
                          where a.id == id
                          select new dtoGasto
                          {
                              id = a.id,
                              nome = a.nome,
                              usuarioid = a.usuarioid,
                              valor = a.valor,
                              descricao = a.descricao,
                              datagasto = a.datagasto

                          }).FirstOrDefault();

            

            return result;
        }


        #endregion

        #region Operações da comparação de gastos

        public List<dtoGastoComparar> comparartipoGastosMes(int idusuario, int ano, int mes) 
        {

        Context db = new Context();
        List<dtoGastoComparar> result = (from a in db.gasto
                                where a.usuarioid == idusuario &&
                                a.datagasto.Year == ano &&
                                a.datagasto.Month ==  mes
                                select new dtoGastoComparar
                                {
                                    id = a.id,
                                    nome = a.nome,
                                    valor = a.valor,
                                    datagasto = a.datagasto
                                }).ToList();

            return new List<dtoGastoComparar>(result);
        }

        public List<dtoGastoComparar> comparartipoGastosAno(int idusuario, int ano)
        {

            Context db = new Context();
            List<dtoGastoComparar> result = (from a in db.gasto
                                     where a.usuarioid == idusuario &&
                                     a.datagasto.Year == ano
                                     select new dtoGastoComparar
                                     {
                                         id = a.id,
                                         nome = a.nome,
                                         valor = a.valor,
                                         datagasto = a.datagasto
                                     }).ToList();

            return new List<dtoGastoComparar>(result);
        }

        public List<dtoGasto> gastosTotaisMes(int idusuario, int mes)
        {

            Context db = new Context();
            List<dtoGasto> result = (from a in db.gasto
                                     where a.usuarioid == idusuario &&
                                     a.datagasto.Month == mes
                                     select new dtoGasto
                                     {
                                         
                                         nome = a.nome,
                                         valor = a.valor,
                                         datagasto = a.datagasto
                                     }).ToList();

            return new List<dtoGasto>(result);
        }

        public List<dtoGasto> gastosTotaisAno(int idusuario, int ano)
        {

            Context db = new Context();
            List<dtoGasto> result = (from a in db.gasto
                                     where a.usuarioid == idusuario &&
                                     a.datagasto.Year == ano
                                     select new dtoGasto
                                     {
                                         
                                         nome = a.nome,
                                         valor = a.valor,
                                         datagasto = a.datagasto
                                     }).ToList();

            return new List<dtoGasto>(result);
        }

        #endregion
    }
}
