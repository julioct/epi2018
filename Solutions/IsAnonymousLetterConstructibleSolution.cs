using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class IsAnonymousLetterConstructibleSolution
    {
        public static bool IsLetterConstructibleFromMagazine(string letterText, string magazineText){
            var characters = new Dictionary<char, int>();

            foreach(var c in letterText){
                characters[c] = characters.ContainsKey(c) ? characters[c]++ : 1;
            }

            foreach(var c in magazineText){
                if (characters.ContainsKey(c)){
                    characters[c]--;

                    if (characters[c] == 0){
                        characters.Remove(c);

                        if (characters.Count == 0){
                            break;
                        }
                    }
                }
            }

            return characters.Count == 0;
        }
    }    
}
