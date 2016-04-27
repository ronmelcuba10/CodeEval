using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            ShowRGB(line);
        }
    }
    
    static void ShowRGB(string line){
        string result = "";
        int leng = line.Length;
        if(line.Contains("HSL")) result = GetHSL(line.Substring(4,leng-5));
        if(line.Contains("HSV")) result = GetHSV(line.Substring(4,leng-5));
        if(line.Contains("#")) result = GetHex(line);
        if(result.Length==0) result = GetCMYK(line.Substring(1,leng-2));
        Console.WriteLine("RGB("+result+")");
    }
        
    static string GetHSL(string HSL){
        string[] compStr = HSL.Split(',');
        float[] comp = new float[compStr.Length];
        for(int i=0;i<compStr.Length;i++)comp[i] = Convert.ToSingle(compStr[i]);
        float H = comp[0];
        float S = comp[1]/100;
        float L = comp[2]/100;
        float C = (1-Math.Abs(2*L-1))*S;
        float X = C*(1-Math.Abs((H/60)%2-1));
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
        double R = Math.Round((R1 + m)*255);
        double G = Math.Round((G1 + m)*255);
        double B = Math.Round((B1 + m)*255);
        return R + "," + G + "," + B;
    }
    
    static string GetHSV(string HSV){
        string[] compStr = HSV.Split(',');
        float[] comp = new float[compStr.Length];
        for(int i=0;i<compStr.Length;i++)comp[i] = Convert.ToSingle(compStr[i]);
        float H = comp[0];
        float S = comp[1]/100;
        float V = comp[2]/100;
        float C = V*S;
        float X = C*(1-Math.Abs((H/60)%2-1));
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
        double R = Math.Round((R1 + m)*255);
        double G = Math.Round((G1 + m)*255);
        double B = Math.Round((B1 + m)*255);
        return R + "," + G + "," + B;
    }
    
    static string GetHex(string Hex){
        string result=Convert.ToInt32(Hex.Substring(1,2),16).ToString() + "," +
                    Convert.ToInt32(Hex.Substring(3,2),16).ToString() + "," +
                    Convert.ToInt32(Hex.Substring(5),16).ToString();
        return result;
    }
    
    static string GetCMYK(string CMYK){
        string[] compStr = CMYK.Split(',');
        float[] comp = new float[compStr.Length];
        for(int i=0;i<compStr.Length;i++)comp[i] = Convert.ToSingle(compStr[i]);
        double R = Math.Round(255 * ((1-comp[0])*(1-comp[3])));
        double G = Math.Round(255*((1-comp[1])*(1-comp[3])));
        double B = Math.Round(255*(1-comp[2])*(1-comp[3]));
        return  R + "," + G + "," + B;
    }
}
