namespace Logic;

public class TrackTheRobot
{
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
