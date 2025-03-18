namespace Logic;

public class SockPairs{
    public static int PairsCounter(string socks){
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