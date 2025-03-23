namespace Logic;

//Joseph is in the middle of packing for a vacation. He's having a bit of trouble finding all of his socks, though.

Write a function that returns the number of sock pairs he has. A sock pair consists of two of the same letter, such as "AA". The socks are represented as an unordered sequence.
public class SockPairs{
    public static int PairsCounter(string socks){

        if(socks == null){
            return 0;
        }
        Dictionary<char,int> pairCounter = new Dictionary<char,int>();
        foreach(char sock in socks){
            if(pairCounter.ContainsKey(sock)){
                pairCounter[sock]++;    
            }
            else{
                pairCounter[sock]= 1;
            }
        }
        int totalPairs=0;
        foreach(var pair in pairCounter.Values){
            totalPairs += pair/2;
        }
        return totalPairs;
    } 
}