import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowPixels(line);
        }
    }
    
    static void ShowPixels(String line){
        String[] result = {"","","","","",""};
        for(int i=0;i<line.length();i++){
            if(Character.valueOf(line.charAt(i)).toString().matches("[0-9]")){
                for(int j=0;j<5;j++) result[j] += DigitalSegment(line.charAt(i),j);
                result[5] += "-----";
            }
        }
        for(String str : result)System.out.println(str);
    }
    
    static String DigitalSegment(char num, int index){
        switch(num){
            case '0':
                String[] digitSegment0 = new String[]{"-**--",
                                "*--*-",
                                "*--*-",
                                "*--*-",
                                "-**--"};
                return digitSegment0[index];
            case '1':
                String[] digitSegment1 = new String[]{"--*--",
                                "-**--",
                                "--*--",
                                "--*--",
                                "-***-"};
                return digitSegment1[index];
            case '2':
                String[] digitSegment2 = new String[]{"***--",
                                "---*-",
                                "-**--",
                                "*----",
                                "****-"};
                return digitSegment2[index];
            case '3':
                String[] digitSegment3 = new String[]{"***--",
                                "---*-",
                                "-**--",
                                "---*-",
                                "***--"};
                return digitSegment3[index];
            case '4':
                String[] digitSegment4 = new String[]{"-*---",
                                "*--*-",
                                "****-",
                                "---*-",
                                "---*-"};
                return digitSegment4[index];
            case '5':
                String[] digitSegment5 = new String[]{"****-",
                                "*----",
                                "***--",
                                "---*-",
                                "***--"};
                return digitSegment5[index];
            case '6':
                String[] digitSegment6 = new String[]{"-**--",
                                "*----",
                                "***--",
                                "*--*-",
                                "-**--"};
                return digitSegment6[index];
            case '7':
                String[] digitSegment7 = new String[]{"****-",
                                "---*-",
                                "--*--",
                                "-*---",
                                "-*---"};
                return digitSegment7[index];
            case '8':
                String[] digitSegment8 = new String[]{"-**--",
                                "*--*-",
                                "-**--",
                                "*--*-",
                                "-**--"};
                return digitSegment8[index];
            default :
                String[] digitSegment9 = new String[]{"-**--",
                                "*--*-",
                                "-***-",
                                "---*-",
                                "-**--"};
                return digitSegment9[index];
        }
    }
}
