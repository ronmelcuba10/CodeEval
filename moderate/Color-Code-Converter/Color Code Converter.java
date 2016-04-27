import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowRGB(line);
        }
    }
    
    static void ShowRGB(String line){
        String result = "";
        int leng = line.length();
        if(line.contains("HSL")) result = GetHSL(line.substring(4,leng-1));
        if(line.contains("HSV")) result = GetHSV(line.substring(4,leng-1));
        if(line.contains("#")) result = GetHex(line);
        if(result.length()==0) result = GetCMYK(line.substring(1,leng-1));
        System.out.println("RGB("+result+")");
    }
        
    static String GetHSL(String HSL){
        String[] compStr = HSL.split(",");
        float[] comp = new float[compStr.length];
        for(int i=0;i<compStr.length;i++)comp[i] = Float.valueOf(compStr[i]);
        float H = comp[0];
        float S = comp[1]/100;
        float L = comp[2]/100;
        float C = (1-Math.abs(2*L-1))*S;
        float X = C*(1-Math.abs((H/60)%2-1));
        float m = L-C/2;
        float R1 = 0;
        float G1 = 0;
        float B1 = 0;
        if      (H<60) {R1 = C; G1 = X; B1 = 0;}
        else if (H<120){R1 = X; G1 = C; B1 = 0;}
        else if (H<180){R1 = 0; G1 = C; B1 = X;}
        else if (H<240){R1 = 0; G1 = X; B1 = C;}
        else if (H<300){R1 = X; G1 = 0; B1 = C;}
        else if (H<360){R1 = C; G1 = 0; B1 = X;}
        int R = Math.round((R1 + m)*255);
        int G = Math.round((G1 + m)*255);
        int B = Math.round((B1 + m)*255);
        return R + "," + G + "," + B;
    }
    
    static String GetHSV(String HSV){
        String[] compStr = HSV.split(",");
        float[] comp = new float[compStr.length];
        for(int i=0;i<compStr.length;i++)comp[i] = Float.valueOf(compStr[i]);
        float H = comp[0];
        float S = comp[1]/100;
        float V = comp[2]/100;
        float C = V*S;
        float X = C*(1-Math.abs((H/60)%2-1));
        float m = V-C;
        float R1 = 0;
        float G1 = 0;
        float B1 = 0;
        if      (H<60) {R1 = C; G1 = X; B1 = 0;}
        else if (H<120){R1 = X; G1 = C; B1 = 0;}
        else if (H<180){R1 = 0; G1 = C; B1 = X;}
        else if (H<240){R1 = 0; G1 = X; B1 = C;}
        else if (H<300){R1 = X; G1 = 0; B1 = C;}
        else if (H<360){R1 = C; G1 = 0; B1 = X;}
        int R = Math.round((R1 + m)*255);
        int G = Math.round((G1 + m)*255);
        int B = Math.round((B1 + m)*255);
        return R + "," + G + "," + B;
    }
    
    static String GetHex(String Hex){
        String result=Integer.valueOf(Hex.substring(1,3),16).toString() + "," +
                    Integer.valueOf(Hex.substring(3,5),16).toString() + "," +
                    Integer.valueOf(Hex.substring(5),16).toString();
        return result;
    }
    
    static String GetCMYK(String CMYK){
        String[] compStr = CMYK.split(",");
        float[] comp = new float[compStr.length];
        for(int i=0;i<compStr.length;i++)comp[i] = Float.valueOf(compStr[i]);
        int R = Math.round(255 * ((1-comp[0])*(1-comp[3])));
        int G = Math.round(255*((1-comp[1])*(1-comp[3])));
        int B = Math.round(255*(1-comp[2])*(1-comp[3]));
        return  R + "," + G + "," + B;
    }
}
