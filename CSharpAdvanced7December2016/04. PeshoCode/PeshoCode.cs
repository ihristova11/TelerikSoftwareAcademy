namespace _04.PeshoCode
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class PeshoCode
    {
        //1. read the input
        //2. find the sentence of the word
        //3. see if it's ? or .
        //4. get the substring
        //5. ToUpper()
        //6. print the output

        static void Main()
        {
            //reading the input
            var word = Console.ReadLine();
            var lines = int.Parse(Console.ReadLine());
            var builder = new StringBuilder();

            //appending sentences in builder (text) 
            var text = Enumerable.Range(0, lines)
                .Select(x => builder.Append(Console.ReadLine()))
                .Last()
                .ToString();

            //getting the start position of the searched word
            var startPos = text.IndexOf(word);

            //getting the position of '.' and '?'
            var dotPos = text.IndexOf('.', startPos);
            var questionPos = text.IndexOf('?', startPos);

            //find the ending of the sentence, '.' or '?' by using the index 
            //and getting the index of it
            var end = Math.Min(dotPos == -1 ? int.MaxValue : dotPos, questionPos == -1 ? int.MaxValue : questionPos);

            //substring of the sentence containing the searched word 
            string substring = null;
            if(text[end] == '.')
            {
                var start = Math.Max(text.LastIndexOf('.', startPos), text.LastIndexOf('?', startPos)) + 1;
                substring = text.Substring(start, startPos - start);
            }
            else
            {
                var start = text.IndexOfAny(" .?".ToCharArray(), startPos);
                substring = text.Substring(start, end - start);
            }
            //print output
            Console.WriteLine(substring.Where(x => x != ' ').Sum(x => char.ToUpper(x)));           
        }
    }
}
