namespace Logic;

//Write a function that takes an integer n, reverses the binary representation of that integer, and returns the new integer from the reversed binary.
public class ReversingBinary{
    public static int ReverseNumber(int num){
        string binary= Convert.ToString(num,2);
        char[] binaryArray= binary.ToCharArray();
        Array.Reverse(binaryArray);
        string binaryReversed= new string(binaryArray);

        return Convert.ToInt32(binaryReversed,2);
    }
}