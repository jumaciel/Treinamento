using HtmlAgilityPack;
using PetitChef.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento.Controller
{/// <summary>
/// Classe para controller Petit Chef - Receita
/// </summary>
    class Tarefa1
    {
        public static Receita CriarNovaReceita(HtmlNode linha)
        {
            Receita receita = new Receita();

            Receita.GetTitulo(receita, linha);
            Receita.GetContemGluten(receita, linha);
            Receita.GetAvaliacaoVotos(receita, linha);
            Receita.GetIngredientes(receita, linha);
            Receita.GetUrl(receita, linha);
            Receita.GetPropriedades(receita, linha);
            Receita.GetAmeis(receita, linha);
            Receita.GetComentarios(receita, linha);

            return receita;
        }

        public static void AddReceitaNaLista()
        {

            HtmlNodeCollection nodes = SetNodes(Robo.GetHtmlNode(),"//div[@class ='i-right']");
            
            foreach (var node in nodes)
            {
                if (IsReceita(node))
                {
                    Receita novaReceita = CriarNovaReceita(node);
                    listaReceitas.Add(novaReceita);
                }
            }
        }

        private static HtmlNodeCollection SetNodes(HtmlNode nodes, string v)
        {
            var linhas = nodes.SelectNodes(v);
            return linhas;
        }
    }
}
