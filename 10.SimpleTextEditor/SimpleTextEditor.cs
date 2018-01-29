using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SimpleTextEditor
{
    static void Main()
    {
        var operations = int.Parse(Console.ReadLine());
        var undoCommand = new string[2];
        var textSequence = new Stack<char>();

        for (int i = 0; i < operations; i++)
        {
            var command = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

            switch (command[0])
            {
                case "1":
                    var stringToAppend = command[1].ToCharArray();
                    

                    undoCommand = command.ToArray();
                    break;
                case "2":
                    var charactersToRemove = int.Parse(command[1]);


                    undoCommand = command.ToArray();
                    break;
                case "3":



                    break;


            }




        }




    }
}