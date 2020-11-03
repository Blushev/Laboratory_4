using System;

namespace Laboratory_4
{
	class Program
	{
		static void Main(string[] args)
		{
			//1. СЧИТАЕМ ЗНАКИ ПРЕПИНАНИЯ!
			Console.Write("Введите любое предложение: ");
			string User_Text = Console.ReadLine();
			int CountChar = 0;
			for(int i = 0; i < User_Text.Length; i++)
            {
				if(User_Text[i] == '.' || User_Text[i] == ',' || User_Text[i] == '?' || User_Text[i] == '!' || User_Text[i] == ':'
				  || User_Text[i] == ';' || User_Text[i] == '-' || User_Text [i] == '"') 
					CountChar++;
            }
			Console.Write("Колличество знаков препинания: ");
			Console.WriteLine(CountChar);

			//2. ВЫВЕСТИ ОТДЕЛЬНЫЕ ПРЕДЛОЖЕНИЯ (СЛОВА)
			Console.WriteLine("Выводим отдельные слова: ");
			string[] words = User_Text.Split(new char[] { ' ' });

			foreach (string CountWord in words)
				Console.WriteLine(CountWord);
			
            //3. НАХОДИМ САМОЕ ДЛИННОЕ СЛОВО
			Console.Write("Самое длинное слово: ");
			string MaxWord = string.Empty;
			string[] _ = User_Text.Split(' ');
			for (int i = 0; i < _.Length; i++)
			{
				if (_[i].Length > MaxWord.Length)
					MaxWord = _[i];
			}
			Console.WriteLine(MaxWord);

			//4. ВЫВОДИМ ВТОРУЮ ПОЛОВИНУ НА ЭКРАН В СЛУЧАЕ ЧЁТНОСТИ
			int number_of_MaxWord = 0;
			for (int i = 0; i < MaxWord.Length; i++) 
				number_of_MaxWord++;
			if (number_of_MaxWord % 2 == 0)
			{
				Console.Write("Вводим вторую половину слова: ");
				Console.WriteLine(MaxWord.Substring(MaxWord.Length / 2));
			}

            //5. СТАВИМ * ПРИ НЕЧЁТНОМ КОЛ-ВЕ МАКСИМАЛЬНОГО СЛОВА
            else
            {
				int i = MaxWord.Length / 2;
				string Center_of_Word = MaxWord.Replace(MaxWord[i], '*');

				Console.WriteLine(Center_of_Word);
			}
			Console.ReadKey();
		}
	}
}
