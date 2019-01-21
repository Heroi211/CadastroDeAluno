using System;
using System.Collections.Generic;
namespace CadastroDeAlunosConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*O instrutor Joaquim possui três cursos A, B e C, e deseja saber seu número total de alunos.
            Seu programa deve ler os alunos dos cursos A, B e C do instrutor Joaquim, depois mostrar a quantidade total e alunos
            dele, conforme exemplo.
            Veja o exemplo (os valores que devem ser digitados pelo usuário estão destacados em vermelho):*/

            HashSet<int> cursosJoaquimA = new HashSet<int>();
            HashSet<int> cursosJoaquimB = new HashSet<int>();
            HashSet<int> cursosJoaquimC = new HashSet<int>();

            Console.WriteLine("-----------------------------------CURSOS JOAQUIM------------------------------------------");
            Console.Write("O curso A possui quantos alunos? ");

            int cursoA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A");
            for (int i = 0; i < cursoA; i++)
            {
                int curso = int.Parse(Console.ReadLine());
                cursosJoaquimA.Add(curso);
            }

            Console.Write("O curso B possui quantos alunos? ");
            int cursoB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B");
            for (int i = 0; i < cursoB; i++)
            {
                int curso = int.Parse(Console.ReadLine());
                cursosJoaquimB.Add(curso);
            }

            Console.Write("O curso C possui quantos alunos? ");
            int cursoC = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C");
            for (int i = 0; i < cursoC; i++)
            {
                int curso = int.Parse(Console.ReadLine());
                cursosJoaquimC.Add(curso);
            }

            HashSet<int> todosALunos = new HashSet<int>();
            todosALunos.UnionWith(cursosJoaquimA);
            todosALunos.UnionWith(cursosJoaquimB);
            todosALunos.UnionWith(cursosJoaquimC);

            Console.WriteLine("Total de alunos: " + todosALunos.Count);
            Console.WriteLine();

        }
    }
}
