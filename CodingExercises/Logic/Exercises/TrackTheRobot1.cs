namespace Logic;

//A robot has been given a list of movement instructions. Each instruction is either left, right, up or down, followed by a distance to move. The robot starts at [0, 0]. You want to calculate where the robot will end up and return its final position as an array.
public class TrackTheRobot{
    public static int[] TrackRobot(string[] instructions){
        int x=0;
        int y=0;

        if(instructions==null){
            return new int[] {0,0};
        }

        foreach(var instruction in instructions){
            string[] parts=instruction.Split(' ');
            string direction=parts[0];
            int distance=int.Parse(parts[1]);
            if(direction== "right"){
                x+= distance;
            }
            else if(direction=="left"){
                x-= distance;
            }
            else if (direction=="up"){
                y+= distance;
            }
            else if(direction=="down"){
                y-= distance;
            }
        }
        
        return new int[]{x, y};
    }
}
