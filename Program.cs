using System;

namespace Akinator
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Escolha e memorize um dos dez animais a seguir: \n");

            String[] animais = {"Cavalo", "Cachorro", "Gato", "Tubarao", "Baleia", "Golfinho", "Abelha",
            "Borboleta", "Pinguin", "Pardal"};

            foreach (var value in animais)
            {
                System.Console.WriteLine(value);
            }

            Console.Write("Responda 1 para Sim e 2 para Não! \n" + "O seu animal é um mamifero? ");
            int resposta = int.Parse(Console.ReadLine());

            if (resposta == 1)
            {
                var lista1 = animais.ToList(); lista1.Remove("Abelha"); animais = lista1.ToArray();
                var lista2 = animais.ToList(); lista1.Remove("Borboleta"); animais = lista1.ToArray();
                var lista3 = animais.ToList(); lista1.Remove("Pinguin"); animais = lista1.ToArray();
                var lista4 = animais.ToList(); lista1.Remove("Pardal"); animais = lista1.ToArray();
                
                Console.Write("O seu animal vive no mar? ");
                int resposta1 = int.Parse(Console.ReadLine());

                if (resposta1 == 1)
                {
                    var lista5 = animais.ToList(); lista1.Remove("Cavalo"); animais = lista1.ToArray();
                    var lista6 = animais.ToList(); lista1.Remove("Cachorro"); animais = lista1.ToArray();
                    var lista7 = animais.ToList(); lista1.Remove("Gato"); animais = lista1.ToArray();

                Console.Write("O seu animal é conhecido por ser dócil com humanos? ");
                int resposta2 = int.Parse(Console.ReadLine());

                if (resposta2 == 1)
                {
                    var lista8 = animais.ToList(); lista1.Remove("Tubarao"); animais = lista1.ToArray();
                    var lista9 = animais.ToList(); lista1.Remove("Baleia"); animais = lista1.ToArray();

                    foreach (var value in animais)
                    {
                        System.Console.WriteLine("O seu animal é: " + value);
                    }
                }
                else if (resposta2 == 2)
                {
                    var lista8 = animais.ToList(); lista1.Remove("Golfinho"); animais = lista1.ToArray();

                    Console.Write("O seu animal é cosiderado o maior animal do mundo? ");
                    int resposta3 = int.Parse(Console.ReadLine());

                    if (resposta3 == 1)
                    {
                        var listabaleia = animais.ToList(); lista1.Remove("Tubarao"); animais = lista1.ToArray();

                        foreach (var value in animais)
                        {
                            System.Console.WriteLine("O seu animal é: " + value);
                        }
                    }
                    else if (resposta3 == 2)
                    {
                        var listatutu = animais.ToList(); lista1.Remove("Baleia"); animais = lista1.ToArray();

                        foreach (var value in animais)
                        {
                            System.Console.WriteLine("O seu animal é: " + value);
                        }
                }
                else
                {
                    Console.WriteLine("Sua resposta não foi 1 e nem 2. Reinicie o programa.");
                }
                }
                else if (resposta1 == 2)
                {
                    var lista8 = animais.ToList(); lista1.Remove("Tubarao"); animais = lista1.ToArray();
                    var lista9 = animais.ToList(); lista1.Remove("Golfinho"); animais = lista1.ToArray();
                    var lista10 = animais.ToList(); lista1.Remove("Baleia"); animais = lista1.ToArray();

                    foreach (var value in animais)
                    {
                        System.Console.WriteLine(value);
                    }
                }
                else
                {
                    Console.WriteLine("Sua resposta não foi 1 e nem 2. Reinicie o programa.");
                }
            }

            else if (resposta == 2)
            {
                var listaca = animais.ToList(); lista1.Remove("Cavalo"); animais = lista1.ToArray();
                var listadog = animais.ToList(); lista1.Remove("Cachorro"); animais = lista1.ToArray();
                var listacat = animais.ToList(); lista1.Remove("Gato"); animais = lista1.ToArray();
                var listatututu = animais.ToList(); lista1.Remove("Tubarao"); animais = lista1.ToArray();
                var listabaleia = animais.ToList(); lista1.Remove("Baleia"); animais = lista1.ToArray();
                var listagolf = animais.ToList(); lista1.Remove("Golfinho"); animais = lista1.ToArray();

                foreach (var value in animais)
                {
                    System.Console.WriteLine(value);
                }
            }
            else
            {
                Console.WriteLine("Sua resposta não foi 1 e nem 2. Reinicie o programa.");
            }

        }
    }
}
}
