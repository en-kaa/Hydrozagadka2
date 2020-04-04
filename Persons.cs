using System;

namespace Hydrozagadka2 {
    
    

    public class Persons : Characters , IDialogues {
        // TODO Inconsistent naming - public fields shall be PascalCase
        public bool isUsed;
        public string dialogues;

        public string GetSentence(){
            throw new NotImplementedException();
        }

        public string GetAnswer(){
            throw new NotImplementedException();
        }

    }
}
