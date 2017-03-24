using System;

namespace AbstractFactoryDP001
{
	class MainClass
	{
		public static Personagem CriarPersonagem()
		{
			PersonagemFactory criadorPersonagem = new PersonagemOgroFactory ();
			Personagem personagem = criadorPersonagem.ConstruirPersonagem ();
			Equipamento equipamentoPersonagem = criadorPersonagem.ConstruirEquipamento ();
			personagem.EquipamentoPrincipal = equipamentoPersonagem;

			return personagem;
		}

		public static void Main (string[] args)
		{
			Personagem personagem = CriarPersonagem ();

			Console.WriteLine ("Você construiu um " + personagem.Descricao + " com o equipamento " + personagem.EquipamentoPrincipal.Descricao + " em mãos");
			Console.ReadKey ();
		}
	}
}
