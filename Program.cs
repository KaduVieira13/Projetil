using System;

namespace Projetil
{
              class Program
              {
                            static void Main(string[] args)
                            {
                                          const double g = 9.80665;

                                          double anguloEmGraus;
                                          double velocidade;
                                          double anguloEmRadianos;
                                          double alcance;
                                          double altura;

                                          Console.WriteLine("--- Projetil---");

                                          Console.Write("entre com a velocidade, em m/s..:");
                                          velocidade = Convert.ToDouble(Console.ReadLine());

                                          Console.Write("entre com o angulo, em graus..:");
                                          anguloEmGraus = Convert.ToDouble(Console.ReadLine());

                                          anguloEmRadianos = anguloEmGraus * (Math.PI / 180);

                                          alcance = Math.Pow(velocidade, 2) * Math.Sin(2 * anguloEmRadianos) / g;
                                          Console.WriteLine($"Alcance é igual: {alcance:N2} m ");

                                          altura = Math.Pow((velocidade * Math.Sin(anguloEmRadianos)), 2) / (2 * g);
                                          Console.WriteLine($"Altura é igual: {altura:N2}");



                            }
              }
}
