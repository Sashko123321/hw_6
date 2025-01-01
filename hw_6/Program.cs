namespace hw_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Enter:");
            string input = Console.ReadLine();

            string[] sentences = input.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < sentences.Length; i++)
            {
                string sentence = sentences[i].Trim();

                if (sentence.Length > 0)
                {
                    sentences[i] = sentence.Substring(0, 1).ToUpper() + sentence.Substring(1).ToLower();
                }
            }

            string result = string.Join(". ", sentences);

            result = result.Trim().EndsWith(".") ? result : result + ".";

            Console.WriteLine("Result:");
            Console.WriteLine(result);

            //2
            //Console.WriteLine("Enter text:");
            //string input = Console.ReadLine();

            //Console.WriteLine("Enter word:");
            //string forbiddenWord = Console.ReadLine();

            //string replacement = new string('*', forbiddenWord.Length);

            //string result = input;
            //int index = result.IndexOf(forbiddenWord);

            //while (index != -1)
            //{
            //    result = result.Substring(0, index) + replacement + result.Substring(index + forbiddenWord.Length);
            //    index = result.IndexOf(forbiddenWord, index + replacement.Length);
            //}

            //Console.WriteLine("Result:");
            //Console.WriteLine(result);

        }
    }
}
