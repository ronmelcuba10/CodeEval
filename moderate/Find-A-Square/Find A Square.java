import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowSquared(line);
        }
    }
    
    static void ShowSquared(String line){
        String[] pointsStr = line.split("\\s+");
        int[][] points = new int[4][2];
        for(int i=0;i<4;i++){
            int pos1 = pointsStr[i].indexOf("(");
            int pos2 = pointsStr[i].indexOf(",");
            int pos3 = pointsStr[i].indexOf(")");
            points[i][0] = Integer.valueOf(pointsStr[i].substring(1,pos2));
            points[i][1] = Integer.valueOf(pointsStr[i].substring(pos2+1,pos3));
        }
        System.out.println(Squared(points));
    }
    
    public static boolean Squared(int[][] p){
        float d01 = distance(p[0][0],p[0][1],p[1][0],p[1][1]);
        float d02 = distance(p[0][0],p[0][1],p[2][0],p[2][1]);
        float d03 = distance(p[0][0],p[0][1],p[3][0],p[3][1]);
        float d12 = distance(p[1][0],p[1][1],p[2][0],p[2][1]);
        float d13 = distance(p[1][0],p[1][1],p[3][0],p[3][1]);
        float d23 = distance(p[2][0],p[2][1],p[3][0],p[3][1]);
        if(d01!=0 && d01==d12 && d12==d23 && d23==d03 && d02==d13)return true;
        if(d01!=0 && d02==d23 && d23==d13 && d13==d01 && d03==d12)return true;
        if(d01!=0 && d03==d13 && d13==d12 && d12==d02 && d01==d23)return true;
        return false;
    }
    
    public static float distance(int x1, int y1, int x2, int y2){
        return (float)Math.sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2));
    }
}
