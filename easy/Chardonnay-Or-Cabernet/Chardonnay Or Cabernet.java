import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowWine(line);
        }
    }
    
    static void ShowWine(String line){
        int pos = line.indexOf("|");
        String phrase = line.substring(pos+1).trim();
        String[] wines = line.substring(0,pos).split(" ");
        String result = "";
        for(String wine : wines){
            int i = 0;
            String wineTemp = wine;
            while(i<phrase.length()){
                int tempos = wineTemp.indexOf(phrase.charAt(i));
                if (tempos>=0) wineTemp = wineTemp.substring(0,tempos) + wineTemp.substring(tempos+1);
                else break;
                i++;
            }
            if(wine.length() - phrase.length() == wineTemp.length()) result += wine + " ";
        }
        result = result.trim();
        System.out.println( result.length()>0 ? result : "False");
    }
}
