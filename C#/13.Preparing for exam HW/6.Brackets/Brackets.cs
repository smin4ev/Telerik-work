using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Brackets
{            //С помоща на видеото от workshop!!!
    class Brackets
    {
        static StringBuilder sb = new StringBuilder();
        static string tabulation;
        static int tabsCount = 0;
        static bool shouldPrintNewLine = false;
        static bool isFirstSymbol = true;

        static void Main()
        {
            int numberLines = int.Parse(Console.ReadLine());
            tabulation = Console.ReadLine();
            
            for (int i = 0; i < numberLines; i++)
            {
                string currentLine = Console.ReadLine().Trim(); ;
                HandleLine(currentLine);
            }
            Console.WriteLine(sb);
        }
        private static void HandleLine(string currentLine)
        {
            for (int i = 0; i < currentLine.Length; i++)
            {
                if (shouldPrintNewLine && char.IsWhiteSpace(currentLine[i]))
                {
                    continue;
                }
                if (shouldPrintNewLine)
                {
                    sb.AppendLine();
                    shouldPrintNewLine = false;
                    isFirstSymbol = true;
                }
                if (currentLine[i] == '{')
                {
                    if (!shouldPrintNewLine)
                    {
                        if (!isFirstSymbol)
                        {
                            if(sb.Length>0 && char.IsWhiteSpace(sb[sb.Length-1]))
                            {
                                sb.Remove(sb.Length - 1, 1);
                            }
                            sb.AppendLine();
                        }
                    }
                    AppendTabs();
                    sb.Append(currentLine[i]);
                    tabsCount++;
                    shouldPrintNewLine = true;
                }
                else if (currentLine[i] == '}')
                {
                    tabsCount--;
                    if (!shouldPrintNewLine)
                    {
                        if (!isFirstSymbol)
                        {
                            if (sb.Length > 0 && char.IsWhiteSpace(sb[sb.Length - 1]))
                            {
                                sb.Remove(sb.Length - 1, 1);
                            }
                            sb.AppendLine();
                        }
                    }
                    AppendTabs();
                    sb.Append(currentLine[i]);
                    shouldPrintNewLine = true;
                }
                else
                {
                    if (isFirstSymbol)
                    {
                        AppendTabs();
                    }
                    if (!(isFirstSymbol && char.IsWhiteSpace(currentLine[i])))
                    {
                        if (!(i < currentLine.Length - 1 && char.IsWhiteSpace(currentLine[i]) && char.IsWhiteSpace(currentLine[i + 1])))
                        {
                           
                            sb.Append(currentLine[i]);
                            
                        }
                    }
                    isFirstSymbol = false;
                }
            }
            shouldPrintNewLine = true;
            isFirstSymbol = true;
        }
        private static void AppendTabs()
        {
            for (int i = 0; i < tabsCount; i++)
            {
                sb.Append(tabulation);
            }
        }
        
    }
}
