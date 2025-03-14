namespace Logic;

// You have to get a new driver's license. You show up at the office at the same time as four other people. The office says they will see everyone in alphabetical order and it takes 20 minutes for them to process each new license. All of the agents are available now, and they can each see one customer at a time. How long will it take for you to walk out with your new license?
// Your input will be a string of your name me, an integer of the number of available agents, and a string of the other four names separated by spaces others.
// Return the number of minutes it will take to get your license.

public class DriverLicense{
    public static int License(string me, int agents, string others){
        int timePerAgent= 20;
        string[] othersSplitted= others.Split(' ');
        
        foreach(string name in othersSplitted){
            if(name[0] < me[0]){
                timePerAgent*= 2;
            }
            else{
                break;
            }
        }
        return timePerAgent;
    }
}