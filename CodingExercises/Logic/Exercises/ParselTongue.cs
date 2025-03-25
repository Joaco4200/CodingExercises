namespace Logic;

public class ParselTongue{

    public bool IsParselTongue(string sentence){
        string[] splittedSentence= sentence.Split(" ");

        foreach(string word in splittedSentence){
            if(word.Contains("ss")){
                continue;
            }

            if(word.Contains("s")){
                return false;
            }

            return true;
        }

    }
}
